namespace WindowsFormsApp1
{
    partial class FoodControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodControl));
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTick = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 24);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "15.000 VND";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnTick);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(150, 37);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btnTick
            // 
            this.btnTick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTick.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTick.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTick.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTick.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTick.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTick.FillColor = System.Drawing.Color.White;
            this.btnTick.FillColor2 = System.Drawing.Color.White;
            this.btnTick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTick.ForeColor = System.Drawing.Color.White;
            this.btnTick.Image = ((System.Drawing.Image)(resources.GetObject("btnTick.Image")));
            this.btnTick.ImageSize = new System.Drawing.Size(15, 15);
            this.btnTick.Location = new System.Drawing.Point(129, 0);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(21, 21);
            this.btnTick.TabIndex = 0;
            this.btnTick.Visible = false;
            // 
            // FoodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Name = "FoodControl";
            this.Click += new System.EventHandler(this.FoodControl_Click);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnTick;
    }
}
