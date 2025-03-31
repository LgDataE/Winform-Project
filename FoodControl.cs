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
    public partial class FoodControl : UserControl
    {
        private Guna2HtmlLabel guna2HtmlLabel1 = new Guna2HtmlLabel();
        public Image backgroundImage = Properties.Resources.banh_mi;
        public FoodControl()
        {
            InitializeComponent();

            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            guna2HtmlLabel1.Dock = DockStyle.Fill;

            this.BackColor = ColorFromHex("#b9c9c8");

            guna2HtmlLabel1.Font = new Font("Times New Roman", 16, FontStyle.Bold);

            guna2HtmlLabel1.Text = "Bánh mì";
            guna2Panel1.Controls.Add(guna2HtmlLabel1);



            this.Paint += backgroundImage_Paint;
        }

        private Color ColorFromHex(string hexColor)
        {
            // Chuyển đổi màu hex thành đối tượng Color
            return ColorTranslator.FromHtml(hexColor);
        }
        private void backgroundImage_Paint(object sender, PaintEventArgs e)
        {
            // Draw the image
            e.Graphics.DrawImage(backgroundImage, new Rectangle(27, 37, 100, 82));

        }

        public string nameText
        {
            get { return guna2HtmlLabel1.Text; }
            set { guna2HtmlLabel1.Text = value; }
        }

        public string priceText
        {
            get { return guna2HtmlLabel2.Text; }
            set { guna2HtmlLabel2.Text = value; }
        }

        public bool tick
        {
            get
            {
                if (btnTick.Visible == false) return false;
                else return true;
            }
            /*set { guna2HtmlLabel2.Text = value; }*/
        }
        public Guna2GradientButton tickButton
        {
            get { return btnTick; }
            set { btnTick = value; }
        }

        private void FoodControl_Click(object sender, EventArgs e)
        {
            if (btnTick.Visible == false)
            {
                btnTick.Visible = true;

            }
            else
            {
                btnTick.Visible = false;
            }
        }
    }
}
