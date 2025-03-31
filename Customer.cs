using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Functions : Form
    {
        private LogicProcessing logicProcessing = new LogicProcessing();
        private bool isDataChanged = false;
        public Functions()
        {
            InitializeComponent();
        }

        public DataGridView GetUserData()
        {
            return UserData;
        }


        private void Functions_Load(object sender, EventArgs e)
        {
            LoadUserData();
            txtUser.KeyPress += new KeyPressEventHandler(txtUser_KeyPress);

        }
        private void LoadUserData()
        {
            UserData.DataSource = logicProcessing.GetUserData();

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Nếu phím Enter được nhấn, thực hiện tìm kiếm
                PerformSearch();
            }
        }

        private void PerformSearch()
        {
            LogicProcessing logicProcessing = new LogicProcessing();

            // Lấy giá trị từ TextBox
            string searchValue = txtUser.Text.Trim();

            // Lấy giá trị được chọn từ ComboBox (Phone hoặc Username)
            string selectedOption = cbSelect.SelectedItem?.ToString();

            // Nếu giá trị tìm kiếm không rỗng và có lựa chọn, thực hiện tìm kiếm
            if (!string.IsNullOrEmpty(searchValue) && !string.IsNullOrEmpty(selectedOption))
            {
                DataTable dataTable;

                // Tùy thuộc vào lựa chọn, gọi phương thức tìm kiếm tương ứng trong BusinessLogicLayer
                if (selectedOption == "Phone")
                {
                    dataTable = logicProcessing.SearchUserByPhone(searchValue);
                }
                else if (selectedOption == "Username")
                {
                    dataTable = logicProcessing.SearchUserByUsername(searchValue);
                }
                else
                {
                    // Nếu không có lựa chọn nào, hiển thị toàn bộ dữ liệu
                    LoadUserData();
                    return;
                }

                // Hiển thị kết quả lên DataGridView
                UserData.DataSource = dataTable;
            }
            else
            {
                // Nếu giá trị tìm kiếm rỗng hoặc không có lựa chọn, hiển thị toàn bộ dữ liệu
                LoadUserData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string input = txtMoney.Text.Trim();
            // Kiểm tra xem người dùng đã nhập giá trị hay chưa
            if (!string.IsNullOrEmpty(input))
            {
                // Chuyển đổi giá trị nhập vào thành số nguyên
                if (long.TryParse(input, out long amount))
                {
                    // Lấy UserID của người dùng đang được chọn trong DataGridView
                    if (UserData.SelectedRows.Count > 0)
                    {
                        int selectedRowIndex = UserData.SelectedRows[0].Index;
                        int userID = Convert.ToInt32(UserData.Rows[selectedRowIndex].Cells["UserID"].Value);

                        // Thực hiện nạp tiền vào tài khoản
                        logicProcessing.AddMoneyToUser(userID, amount);

                        // Cập nhật lại dữ liệu trong DataGridView
                        LoadUserData();

                        // Hiển thị thông báo nạp tiền thành công
                        MessageBox.Show("Add money successfully!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            // Mở form mới để nhập thông tin User
            using (NewAccount newAccountForm = new NewAccount(this))
            {
                DialogResult result = newAccountForm.ShowDialog();

                // Kiểm tra xem người dùng đã thêm User thành công hay không
                if (result == DialogResult.OK)
                {
                    // Tải lại dữ liệu người dùng trong DataGridView
                    LoadUserData();
                }
            }
        }

        // Thêm phương thức để thêm User từ form con
        public void AddNewUser(string phone, string username, string password, string name, string money)
        {
            // Tạo đối tượng UserDTO với các thông tin từ form con
            UserDTO newUser = new UserDTO
            {
                Phone = phone,
                Username = username,
                Password = password,
                Name = name,
                Money = money,
                Timestamp = DateTime.Now,
                Status = "Offline"
            };

            // Gọi phương thức thêm User từ LogicProcessing
            logicProcessing.AddNewUser(newUser);
        }

        // Thêm phương thức để hiển thị thông báo
        public void ShowRegistrationSuccessMessage()
        {
            MessageBox.Show("Register successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            //Chuyển qua form Food
            Food foodForm = new Food();
            this.Hide();
            foodForm.ShowDialog();
            this.Close();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //Chuyển qua form Customer
            Functions customerForm = new Functions();
            this.Hide();
            customerForm.ShowDialog();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Chuyển qua form Dashboard
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.ShowDialog();
            this.Close();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            //Chuyển qua form Server
            Server serverForm = new Server();
            this.Hide();
            serverForm.ShowDialog();
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            //Chuyển qua form Contact
            Contact contactForm = new Contact();
            this.Hide();
            contactForm.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (UserData.SelectedRows.Count > 0)
            {
                // Lấy UserID của người dùng đang được chọn trong DataGridView
                int selectedRowIndex = UserData.SelectedRows[0].Index;
                int userID = Convert.ToInt32(UserData.Rows[selectedRowIndex].Cells["UserID"].Value);

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Do you want to delete this account?", "Deletion confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức xóa người dùng từ LogicProcessing
                    logicProcessing.DeleteUser(userID);

                    // Cập nhật lại dữ liệu trong DataGridView sau khi xóa
                    LoadUserData();
                }
            }
            else
            {
                MessageBox.Show("Please choose an account to delete!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Are you sure to logout now?", "Confirm logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                // Tạo đối tượng form Login
                Login loginForm = new Login();

                // Ẩn form hiện tại
                this.Hide();

                // Hiển thị form Login
                loginForm.ShowDialog();

                // Đóng form hiện tại sau khi form Login đóng
                this.Close();
            }
        }

        private void UserData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin chỉnh sửa
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            string columnName = UserData.Columns[colIndex].Name;
            string updatedValue = UserData.Rows[rowIndex].Cells[colIndex].Value.ToString();

            // Lấy UserID của người dùng đang được chỉnh sửa trong DataGridView
            int userID = Convert.ToInt32(UserData.Rows[rowIndex].Cells["UserID"].Value);

            // Cập nhật dữ liệu và kiểm tra kết quả
            isDataChanged = logicProcessing.UpdateUserData(userID, columnName, updatedValue);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isDataChanged)
            {
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isDataChanged = false;  // Đặt lại giá trị sau khi hiển thị thông báo
            }
            else
            {
                MessageBox.Show("No changes to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (UserData.SelectedRows.Count > 0)
            {
                int selectedRowIndex = UserData.SelectedRows[0].Index;
                int userID = Convert.ToInt32(UserData.Rows[selectedRowIndex].Cells["UserID"].Value);
                string status = UserData.Rows[selectedRowIndex].Cells["Status"].Value.ToString();

                if (status.Equals("Online", StringComparison.OrdinalIgnoreCase))
                {
                    DateTime registrationTime = Convert.ToDateTime(UserData.Rows[selectedRowIndex].Cells["Timestamp"].Value);
                    long amountToDeduct = logicProcessing.CalculateAmountToDeduct(registrationTime);

                    if (amountToDeduct <= Convert.ToInt64(UserData.Rows[selectedRowIndex].Cells["Money"].Value))
                    {
                        logicProcessing.PerformPayment(userID, amountToDeduct);
                        LoadUserData();

                        MessageBox.Show($"Payment successful! Amount deducted: {amountToDeduct}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insufficient balance. Please add money to your account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected user is not online. Payment can only be made for online users.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose a user to make a payment.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
