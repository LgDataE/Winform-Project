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
    public partial class NewAccount : Form
    {
        private Functions parentForm;
        private LogicProcessing logicProcessing;

        public NewAccount(Functions func)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.logicProcessing = new LogicProcessing();
        }

        public NewAccount()
        {
            InitializeComponent();
        }

        public NewAccount(LogicProcessing logicProcessing)
        {
            InitializeComponent();
            this.logicProcessing = logicProcessing;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox
            string phone = txtNewPhone.Text.Trim();
            string username = txtNewUsername.Text.Trim();
            string password = txtNewPassWord.Text.Trim();
            string name = txtNewName.Text.Trim();
            string money = txtNewMoney.Text.Trim();

            // Kiểm tra xem số điện thoại hoặc tên người dùng đã nhập đã tồn tại trong dữ liệu hiện tại chưa
            bool isPhoneExists = logicProcessing.CheckIfPhoneExists(phone);
            bool isUsernameExists = logicProcessing.CheckIfUsernameExists(username);

            if (isPhoneExists || isUsernameExists)
            {
                MessageBox.Show("Phone or Username existed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Gọi phương thức thêm User từ parentForm
                Functions parentForm = new Functions(); // Khởi tạo đối tượng parentForm
                parentForm.AddNewUser(phone, username, password, name, money);

                parentForm.ShowRegistrationSuccessMessage();

                // Đóng form hiện tại
                this.DialogResult = DialogResult.OK;
            }
                
        }

    }
}
