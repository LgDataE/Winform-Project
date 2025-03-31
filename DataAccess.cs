using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace WindowsFormsApp1
{
    public class DataAccess
    {
        private string connectionString = "Data Source=LAPTOP-82LFKPNT\\MAY_CHU;Initial Catalog=QLNGUOIDUNG;Integrated Security=True";
        public DataTable GetUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // Tìm kiếm theo SĐT
        public DataTable SearchUserByPhone(string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT UserID, Phone, Username, Password, Name, Money, Timestamp, Status FROM Users WHERE Phone LIKE '%{phone}%'", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // Tìm kiếm theo Tên tài khoản
        public DataTable SearchUserByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT UserID, Phone, Username, Password, Name, Money, Timestamp, Status FROM Users WHERE Username LIKE '%{username}%'", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // Thêm tiền vào tài khoản (Cập nhật lại số tiền tổng)
        public void AddMoneyToUser(int userID, long amount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Users SET Money = Money + {amount} WHERE UserID = {userID}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Kiểm tra số điện thoại đã tồn tại
        public bool CheckIfPhoneExists(string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Phone = @Phone";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Phone", phone);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Kiểm tra tên người dùng đã tồn tại
        public bool CheckIfUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Thêm người dùng mới
        public void AddNewUser(UserDTO user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (Phone, Username, Password, Name, Money, Timestamp, Status) " +
                               "VALUES (@Phone, @Username, @Password, @Name, @Money, @Timestamp, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Phone", user.Phone);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@Money", user.Money);
                    command.Parameters.AddWithValue("@Timestamp", user.Timestamp);
                    command.Parameters.AddWithValue("@Status", user.Status);

                    command.ExecuteNonQuery();
                }
            }

        }

        // Xóa tài khoản người dùng
        public void DeleteUser(int userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Users WHERE UserID = {userID}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Điều chỉnh tài khoản người dùng
        public bool UpdateUserData(int userID, string columnName, string updatedValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"UPDATE Users SET {columnName} = '{updatedValue}' WHERE UserID = {userID}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                // Trả về true nếu không có lỗi
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết (hiển thị thông báo lỗi, ghi log, vv.)
                Console.WriteLine($"Error updating data: {ex.Message}");
                return false;
            }
        }

        // Tính tiền tài khoản người dùng
        public void DeductMoneyFromUser(int userID, long amountToDeduct)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Bắt đầu giao dịch để đảm bảo tính nhất quán
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Lấy thông tin tiền hiện tại của người dùng
                        long currentMoney = 0;
                        string selectQuery = $"SELECT Money FROM Users WHERE UserID = {userID}";
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection, transaction))
                        {
                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    currentMoney = Convert.ToInt64(reader["Money"]);
                                }
                                else
                                {
                                    // Người dùng không tồn tại
                                    throw new InvalidOperationException("User not found");
                                }
                            }
                        }

                        // Kiểm tra xem có đủ tiền để trừ không
                        if (amountToDeduct <= currentMoney)
                        {
                            // Thực hiện trừ tiền
                            string updateQuery = $"UPDATE Users SET Money = Money - {amountToDeduct} WHERE UserID = {userID}";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                            {
                                updateCommand.ExecuteNonQuery();
                            }

                            // Commit giao dịch nếu không có lỗi
                            transaction.Commit();
                        }
                        else
                        {
                            // Không đủ tiền để trừ
                            throw new InvalidOperationException("Insufficient balance");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi, nếu có, và rollback giao dịch
                        Console.WriteLine($"Error deducting money: {ex.Message}");
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu không thể kết nối đến cơ sở dữ liệu
                Console.WriteLine($"Error connecting to the database: {ex.Message}");
            }
        }

        // Cập nhật trạng thái người dùng
        public void UpdateUserStatus(int userID, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Users SET Status = '{status}' WHERE UserID = {userID}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
