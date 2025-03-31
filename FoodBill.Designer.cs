namespace WindowsFormsApp1
{
    partial class FoodBill
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bin;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.CustomImages.Image = global::WindowsFormsApp1.Properties.Resources.bin;
            this.btnDelete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.DarkGray;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 41);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(350, 20);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(69, 22);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "25.000 VND";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Teal;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(60, 35);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(41, 18);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "@22:00";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(60, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(58, 21);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Bánh mì";
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderColor = System.Drawing.Color.Black;
            this.guna2NumericUpDown1.BorderRadius = 5;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(270, 14);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(64, 36);
            this.guna2NumericUpDown1.TabIndex = 7;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.guna2NumericUpDown1.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // FoodBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.btnDelete);
            this.Name = "FoodBill";
            this.Size = new System.Drawing.Size(439, 64);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
    }
}
