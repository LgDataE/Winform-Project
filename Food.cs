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
    public partial class Food : Form
    {
        DateTime currentTime = DateTime.Now;
        public Food()
        {
            InitializeComponent();

            FoodControl foodControl1 = new FoodControl();
            foodControl1.nameText = "Bánh mì";
            foodControl1.priceText = "15.000 VND";
            foodControl1.backgroundImage = Properties.Resources.banh_mi;
            flowLayoutPanel1.Controls.Add(foodControl1);

            FoodControl foodControl2 = new FoodControl();
            foodControl2.nameText = "Cơm sườn";
            foodControl2.priceText = "35.000 VND";
            foodControl2.backgroundImage = Properties.Resources.com_suon;
            flowLayoutPanel1.Controls.Add(foodControl2);

            FoodControl foodControl3 = new FoodControl();
            foodControl3.nameText = "Cơm gà";
            foodControl3.priceText = "34.000 VND";
            foodControl3.backgroundImage = Properties.Resources.com_ga_xoi_mo;
            flowLayoutPanel1.Controls.Add(foodControl3);

            FoodControl foodControl4 = new FoodControl();
            foodControl4.nameText = "Cơm chiên";
            foodControl4.priceText = "32.000 VND";
            foodControl4.backgroundImage = Properties.Resources.com_chien_duong_chau;
            flowLayoutPanel1.Controls.Add(foodControl4);

            FoodControl foodControl5 = new FoodControl();
            foodControl5.nameText = "Mì trứng";
            foodControl5.priceText = "15.500 VND";
            foodControl5.backgroundImage = Properties.Resources.mi_trung;
            flowLayoutPanel1.Controls.Add(foodControl5);

            FoodControl foodControl6 = new FoodControl();
            foodControl6.nameText = "Mì xào trứng";
            foodControl6.priceText = "18.000 VND";
            foodControl6.backgroundImage = Properties.Resources.mi_xao_trung;
            flowLayoutPanel1.Controls.Add(foodControl6);

            FoodControl foodControl7 = new FoodControl();
            foodControl7.nameText = "Mì xào bò";
            foodControl7.priceText = "23.000 VND";
            foodControl7.backgroundImage = Properties.Resources.mi_xao_bo;
            flowLayoutPanel1.Controls.Add(foodControl7);

            FoodControl foodControl8 = new FoodControl();
            foodControl8.nameText = "Nui xào bò";
            foodControl8.priceText = "25.000 VND";
            foodControl8.backgroundImage = Properties.Resources.nui_xao_bo;
            flowLayoutPanel1.Controls.Add(foodControl8);

            FoodControl foodControl9 = new FoodControl();
            foodControl9.nameText = "Nui xào trứng";
            foodControl9.priceText = "20.000 VND";
            foodControl9.backgroundImage = Properties.Resources.nui_xao_trung;
            flowLayoutPanel1.Controls.Add(foodControl9);

            FoodControl foodControl10 = new FoodControl();
            foodControl10.nameText = "Cà phê sữa";
            foodControl10.priceText = "12.000 VND";
            foodControl10.backgroundImage = Properties.Resources.cafe_sua;
            flowLayoutPanel1.Controls.Add(foodControl10);

            FoodControl foodControl11 = new FoodControl();
            foodControl11.nameText = "Cà phê đen";
            foodControl11.priceText = "10.000 VND";
            foodControl11.backgroundImage = Properties.Resources.ca_phe_den;
            flowLayoutPanel1.Controls.Add(foodControl11);

            FoodControl foodControl12 = new FoodControl();
            foodControl12.nameText = "Bạc xỉu";
            foodControl12.priceText = "13.000 VND";
            foodControl12.backgroundImage = Properties.Resources.bac_xiu;
            flowLayoutPanel1.Controls.Add(foodControl12);

            FoodControl foodControl13 = new FoodControl();
            foodControl13.nameText = "Coca Cola";
            foodControl13.priceText = "8.000 VND";
            foodControl13.backgroundImage = Properties.Resources.coca;
            flowLayoutPanel1.Controls.Add(foodControl13);

            FoodControl foodControl14 = new FoodControl();
            foodControl14.nameText = "Pepsi";
            foodControl14.priceText = "8.000 VND";
            foodControl14.backgroundImage = Properties.Resources.pepsi;
            flowLayoutPanel1.Controls.Add(foodControl14);

            FoodControl foodControl15 = new FoodControl();
            foodControl15.nameText = "7Up";
            foodControl15.priceText = "8.000 VND";
            foodControl15.backgroundImage = Properties.Resources._7up;
            flowLayoutPanel1.Controls.Add(foodControl15);

            FoodControl foodControl16 = new FoodControl();
            foodControl16.nameText = "Fanta";
            foodControl16.priceText = "8.000 VND";
            foodControl16.backgroundImage = Properties.Resources.fanta;
            flowLayoutPanel1.Controls.Add(foodControl16);

            FoodControl foodControl17 = new FoodControl();
            foodControl17.nameText = "Sting";
            foodControl17.priceText = "8.000 VND";
            foodControl17.backgroundImage = Properties.Resources.sting;
            flowLayoutPanel1.Controls.Add(foodControl17);

            FoodControl foodControl18 = new FoodControl();
            foodControl18.nameText = "Rồng đỏ";
            foodControl18.priceText = "10.000 VND";
            foodControl18.backgroundImage = Properties.Resources.rong_do;
            flowLayoutPanel1.Controls.Add(foodControl18);

            FoodControl foodControl19 = new FoodControl();
            foodControl19.nameText = "C2";
            foodControl19.priceText = "8.000 VND";
            foodControl19.backgroundImage = Properties.Resources.c2;
            flowLayoutPanel1.Controls.Add(foodControl19);

            FoodControl foodControl20 = new FoodControl();
            foodControl20.nameText = "Ô long";
            foodControl20.priceText = "8.000 VND";
            foodControl20.backgroundImage = Properties.Resources.olong;
            flowLayoutPanel1.Controls.Add(foodControl20);

            foreach (FoodControl fc in flowLayoutPanel1.Controls)
            {
                fc.Click += (sender, e) => FoodControl_Click(fc);
            }

            flowLayoutPanel2.ControlAdded += (sender, e) => FoodBill_Added();
        }

        private void FoodBill_Added()
        {
            foreach (FoodBill fb in flowLayoutPanel2.Controls)
            {
                flowLayoutPanel2.ControlRemoved += (sender, e) => FoodBill_Removed(fb);
            }
        }
        private void FoodBill_Removed(FoodBill fb)
        {
            foreach (FoodControl fc in flowLayoutPanel1.Controls)
            {
                if (fb.nameText == fc.nameText)
                {
                    fc.tickButton.Visible = false;
                }
            }
        }
        private void FoodControl_Click(FoodControl fc)
        {
            if (fc.tick == true)
            {
                FoodBill nfb = new FoodBill();
                flowLayoutPanel2.Controls.Add(nfb);
                nfb.nameText = fc.nameText;
                nfb.priceText = fc.priceText;
                nfb.dateText = currentTime.ToString("HH:mm");
            }
            else
            {

                if (flowLayoutPanel2.Controls.Count > 0)
                {
                    foreach (FoodBill fb in flowLayoutPanel2.Controls)
                    {
                        if (fb.nameText == fc.nameText)
                        {
                            flowLayoutPanel2.Controls.Remove(fb);
                        }
                    }
                }
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (FoodBill fb in flowLayoutPanel2.Controls)
            {
                string strPrice = fb.priceText.Substring(0, fb.priceText.Length - 4);
                decimal dbPrice = decimal.Parse(strPrice);

                total += dbPrice * fb.numeric.Value;
            }

            txtTotal.Text = total.ToString() + " VND";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox1.Text.ToLower();

            foreach (FoodControl fc in flowLayoutPanel1.Controls)
            {
                if (fc.nameText.ToLower().Contains(searchText))
                {
                    fc.Visible = true;
                }
                else
                {
                    fc.Visible = false;
                }
            }
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

        private void btnFood_Click(object sender, EventArgs e)
        {
            //Chuyển qua form Contact
            Food foodForm = new Food();
            this.Hide();
            foodForm.ShowDialog();
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

    }
}
