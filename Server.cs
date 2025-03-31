    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.SqlClient;
    using System.IO;
    using Guna.UI2.WinForms;

    namespace WindowsFormsApp1
    {
        public partial class Server : Form
        {
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            private PictureBox pic = new PictureBox();
            private Label Status = new Label();
            private Label ComputerID = new Label();
        
            //private Button button;
            public Server()
            {
                InitializeComponent();
                cn = new SqlConnection();
                cn.ConnectionString = "Server=(local)\\MAY_CHU; DataBase=QLMAYTINH; Integrated Security=true";
            }

            private void Client_Load(object sender, EventArgs e)
            {
                //CreateAreaButtons();
                GetData();
            }

            private void DisplayImage(string imagePath, string computerID, string status, string area)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(imagePath);
                    PictureBox pic = new PictureBox
                    {
                        Width = 150,
                        Height = 150,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        BackgroundImage = bitmap,
                        Tag = new ComputerInfo { ComputerID = computerID, Status = status, Area = area }
                    };

                    Label computerIDLabel = new Label
                    {
                        Text = computerID,
                        Width = 20,
                        BackColor = Color.FromArgb(255, 121, 121),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Label statusLabel = new StatusLabel
                    {
                        Text = status,
                        BackColor = Color.FromArgb(46, 134, 222),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.White,
                        Font = new Font("Verdana", 10),
                        Dock = DockStyle.Bottom
                    };

                    
                    // Thêm sự kiện Click cho PictureBox
                    pic.Click += (sender, e) => ShowComputerDetails((sender as PictureBox).Tag as ComputerInfo);


                    pic.Controls.Add(computerIDLabel);
                    pic.Controls.Add(statusLabel);
                    flowLayoutPanel2.Controls.Add(pic);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error displaying image: {ex.Message}");
                }
            }

            // Định nghĩa lớp ComputerInfo để lưu trữ thông tin chi tiết của máy tính
            public class ComputerInfo
            {
                public string ComputerID { get; set; }
                public string Status { get; set; }
                public string Area { get; set; }
            }

            private void GetData()
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "SELECT Computers.ComputerID, Computers.Status, Computers.Area, Images.ImagePath " +
                                      "FROM Computers " +
                                      "JOIN Images ON Computers.ComputerID = Images.ComputerID";
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string computerID = dr["ComputerID"].ToString();
                        string status = dr["Status"].ToString();
                        string area = dr["Area"].ToString();
                        string imagePath = dr["ImagePath"].ToString();

                        // Hiện hình ảnh trên PictureBox
                        DisplayImage(imagePath, computerID, status, area);

                        // Use the retrieved values as needed
                        Console.WriteLine($"ComputerID: {computerID}, Status: {status}, Area: {area}, ImagePath: {imagePath}");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (dr != null && !dr.IsClosed)
                    {
                        dr.Close();
                    }
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            }

            private void ShowComputerDetails(ComputerInfo computerInfo)
            {
                string userAccountInfo = (computerInfo.Status == "Using") ? GetUserName(computerInfo.ComputerID) : "None";

                // Hiển thị thông tin chi tiết
                string details = $"Number: {computerInfo.ComputerID}\nArea: {computerInfo.Area}\nStatus: {computerInfo.Status}\nAccount: {userAccountInfo}";

                MessageBox.Show(details, "Thông tin chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private string GetUserName(string computerID)
            {
                // Điều này là nơi bạn có thể truy vấn CSDL hoặc thực hiện logic để lấy tên tài khoản người sử dụng
                // Trong ví dụ này, tôi sẽ trả về một giá trị giả định.
                return "Account name";
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

        

            private void guna2TextBox2_TextChanged(object sender, EventArgs e)
            {
                string searchText = guna2TextBox2.Text.ToLower();

                foreach (PictureBox pb in flowLayoutPanel2.Controls)
                {
                    bool isVisible = false;

                    foreach (Label lbl in pb.Controls)
                    {
                        if (lbl.Text.ToLower().Contains(searchText))
                        {
                            isVisible = true;
                            break;
                        }
                    }

                    pb.Visible = isVisible;
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

    }

    public class StatusLabel : Label
        {
            public StatusLabel() { }
        }
}
