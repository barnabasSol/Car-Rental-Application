namespace Car_Rental_App.RenterUserControl
{
    partial class Deactivate_Renter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deactivate_Renter));
            this.Backlbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.deactivatebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.eyebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.backbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.password = new Car_Rental_App.RenterUserControl.UnderLined_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Backlbl
            // 
            this.Backlbl.AutoSize = true;
            this.Backlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backlbl.Location = new System.Drawing.Point(27, 102);
            this.Backlbl.Name = "Backlbl";
            this.Backlbl.Size = new System.Drawing.Size(52, 21);
            this.Backlbl.TabIndex = 43;
            this.Backlbl.Text = "Back";
            this.Backlbl.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // deactivatebtn
            // 
            this.deactivatebtn.ActiveBorderThickness = 1;
            this.deactivatebtn.ActiveCornerRadius = 20;
            this.deactivatebtn.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.deactivatebtn.ActiveForecolor = System.Drawing.Color.White;
            this.deactivatebtn.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.deactivatebtn.BackColor = System.Drawing.SystemColors.Control;
            this.deactivatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deactivatebtn.BackgroundImage")));
            this.deactivatebtn.ButtonText = "Deactivate";
            this.deactivatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deactivatebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivatebtn.ForeColor = System.Drawing.Color.Black;
            this.deactivatebtn.IdleBorderThickness = 1;
            this.deactivatebtn.IdleCornerRadius = 20;
            this.deactivatebtn.IdleFillColor = System.Drawing.Color.White;
            this.deactivatebtn.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deactivatebtn.IdleLineColor = System.Drawing.Color.Black;
            this.deactivatebtn.Location = new System.Drawing.Point(278, 279);
            this.deactivatebtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.deactivatebtn.Name = "deactivatebtn";
            this.deactivatebtn.Size = new System.Drawing.Size(157, 43);
            this.deactivatebtn.TabIndex = 9;
            this.deactivatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deactivatebtn.Click += new System.EventHandler(this.deactivatebtn_Click);
            // 
            // eyebtn
            // 
            this.eyebtn.BackColor = System.Drawing.SystemColors.Control;
            this.eyebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyebtn.Image = global::Car_Rental_App.Properties.Resources.eye1;
            this.eyebtn.ImageActive = null;
            this.eyebtn.Location = new System.Drawing.Point(199, 196);
            this.eyebtn.Margin = new System.Windows.Forms.Padding(4);
            this.eyebtn.Name = "eyebtn";
            this.eyebtn.Size = new System.Drawing.Size(57, 41);
            this.eyebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyebtn.TabIndex = 8;
            this.eyebtn.TabStop = false;
            this.eyebtn.Visible = false;
            this.eyebtn.Zoom = 10;
            this.eyebtn.Click += new System.EventHandler(this.eyebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Control;
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.ImageActive = null;
            this.backbtn.Location = new System.Drawing.Point(0, 16);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(104, 82);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 4;
            this.backbtn.TabStop = false;
            this.backbtn.Zoom = 10;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            this.backbtn.MouseEnter += new System.EventHandler(this.backbtn_MouseEnter);
            this.backbtn.MouseLeave += new System.EventHandler(this.backbtn_MouseLeave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.BorderColor = System.Drawing.Color.Black;
            this.password.BorderSize = 2;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(278, 202);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(7);
            this.password.PasswordChar = false;
            this.password.Size = new System.Drawing.Size(427, 35);
            this.password.TabIndex = 44;
            this.password.Texts = "enter your password";
            this.password.UnderlinedStlye = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // Deactivate_Renter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.password);
            this.Controls.Add(this.Backlbl);
            this.Controls.Add(this.deactivatebtn);
            this.Controls.Add(this.eyebtn);
            this.Controls.Add(this.backbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Deactivate_Renter";
            this.Size = new System.Drawing.Size(1125, 418);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton backbtn;
        private Bunifu.Framework.UI.BunifuImageButton eyebtn;
        private Bunifu.Framework.UI.BunifuThinButton2 deactivatebtn;
        private System.Windows.Forms.Label Backlbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UnderLined_TextBox password;
    }
}
