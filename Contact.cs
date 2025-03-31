using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            pbLocation.BackColor = ColorFromHex("#0f151a");
            pbPhone.BackColor = ColorFromHex("#0f151a");
            pbMail.BackColor = ColorFromHex("#0f151a");
            lbAddress.BackColor = ColorFromHex("#0f151a");
            lbTalk.BackColor = ColorFromHex("#0f151a");
            lbSupport.BackColor = ColorFromHex("#0f151a");
            label1.BackColor = ColorFromHex("#0f151a");
            label2.BackColor = ColorFromHex("#0f151a");
            label3.BackColor = ColorFromHex("#0f151a");

        }
        private Color ColorFromHex(string hexColor)
        {
            // Chuyển đổi màu hex thành đối tượng Color
            return ColorTranslator.FromHtml(hexColor);
        }

        private void lbTalk_Click(object sender, EventArgs e)
        {

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

        private void Contact_Load(object sender, EventArgs e)
        {

        }

        private void gunabtnSend_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có nhập đủ thông tin cả 5 textbox không
            if (string.IsNullOrEmpty(gunatxtName.Text) || string.IsNullOrEmpty(gunatxtEmail.Text) 
                || string.IsNullOrEmpty(gunatxtPhone.Text) || string.IsNullOrEmpty(gunatxtAddress.Text)
                || string.IsNullOrEmpty(gunatxtMessage.Text))
            {
                MessageBox.Show("Please fill all information.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Thank you for sending feedback to us!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset giá trị của các TextBox về chuỗi rỗng
                gunatxtName.Text = "";
                gunatxtEmail.Text = "";
                gunatxtPhone.Text = "";
                gunatxtAddress.Text = "";
                gunatxtMessage.Text = "";
            }
        }
    }
}
