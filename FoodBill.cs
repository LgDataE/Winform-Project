using Guna.UI2.WinForms;
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
    public partial class FoodBill : UserControl
    {
        public FoodBill()
        {
            InitializeComponent();
            this.BackColor = ColorFromHex("#d3c5c2");
            btnDelete.FillColor = ColorFromHex("#d3c5c2");

            guna2HtmlLabel3.ForeColor = ColorFromHex("#59392e");
        }
        private Color ColorFromHex(string hexColor)
        {
            // Chuyển đổi màu hex thành đối tượng Color
            return ColorTranslator.FromHtml(hexColor);
        }
        public string nameText
        {
            get { return guna2HtmlLabel1.Text; }
            set { guna2HtmlLabel1.Text = value; }
        }

        public string dateText
        {
            get { return guna2HtmlLabel2.Text; }
            set { guna2HtmlLabel2.Text = value; }
        }

        public string priceText
        {
            get { return guna2HtmlLabel3.Text; }
            set { guna2HtmlLabel3.Text = value; }
        }


        public Guna2NumericUpDown numeric
        {
            get { return guna2NumericUpDown1; }
            set { guna2NumericUpDown1 = value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
