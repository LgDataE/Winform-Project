using DashboardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class DashboardForm : Form
    {
        private Dashboard model;
        private Button currentButton;

        //Constructor
        public DashboardForm()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            SetDateMenuButtonsUI(btnLast7Days);
            model = new Dashboard();
            LoadData();
        }

        //Private methods
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lblNumberOfOrders.Text = model.NumOrders.ToString();
                lblTotalRevenue.Text = "$" + model.TotalRevenue.ToString();
                lblTotalProfit.Text = "$" + model.TotalProfit.ToString();

                lblNumberOfCustomers.Text = model.NumCustomers.ToString();
                lblNumberOfRefills.Text = model.NumRefills.ToString();
                lblNumberOfProducts.Text = model.NumProducts.ToString();

                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();

                chartTopProducts.DataSource = model.TopProductsList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();

                UnderstockData.DataSource = model.UnderstockList;
                UnderstockData.Columns[0].HeaderText = "Item";
                UnderstockData.Columns[1].HeaderText = "Units";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void SetDateMenuButtonsUI(object button)
        {
            var btn = (Button)button;

            //Highlight button
            btn.BackColor = btnLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            //Unhighlight button
            if (currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn; //Set button hiện tại

            //Enable custom dates
            if(btn == btnCustom)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOk.Visible = true;
                lblStartDate.Cursor = Cursors.Hand;
                lblEndDate.Cursor = Cursors.Hand;
            }

            //Disable custom dates
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                btnOk.Visible = false;
                lblStartDate.Cursor = Cursors.Default;
                lblEndDate.Cursor = Cursors.Default;
            }

            /*dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;*/
        }

        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            if(currentButton == btnCustom)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustom)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
            lblEndDate.Text = dtpEndDate.Text;
            UnderstockData.Columns[1].Width = 50;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            //Chuyển qua form Food
            Food foodForm = new Food();
            this.Hide();
            foodForm.ShowDialog();
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
            //Chuyển qua form Customer
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.ShowDialog();
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
