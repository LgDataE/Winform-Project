using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Thiết lập ký tự password để ẩn thông tin mật khẩu
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập đơn giản
            if (txtUser.Text == "admin" && txtPassword.Text == "password")
            {
                // Đăng nhập thành công, chuyển đến form mới
                Functions mainForm = new Functions();
                this.Hide(); // Ẩn form đăng nhập
                mainForm.ShowDialog(); // Hiển thị form mới
                this.Close(); // Đóng form đăng nhập khi form mới được đóng
            }
            else
            {
                MessageBox.Show("Wrong Username or Password. Please try again!!!");
            }
        }
    }
}
