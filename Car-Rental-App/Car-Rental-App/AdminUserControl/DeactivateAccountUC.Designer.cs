
namespace Car_Rental_App.AdminUserControl
{
    partial class DeactivateAccountUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeactivateAccountUC));
            this.backbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.deactivatebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.eyebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.ImageActive = null;
            this.backbtn.Location = new System.Drawing.Point(27, 11);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(78, 67);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 3;
            this.backbtn.TabStop = false;
            this.backbtn.Zoom = 10;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // deactivatebtn
            // 
            this.deactivatebtn.ActiveBorderThickness = 1;
            this.deactivatebtn.ActiveCornerRadius = 20;
            this.deactivatebtn.ActiveFillColor = System.Drawing.Color.Red;
            this.deactivatebtn.ActiveForecolor = System.Drawing.Color.White;
            this.deactivatebtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.deactivatebtn.BackColor = System.Drawing.SystemColors.Control;
            this.deactivatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deactivatebtn.BackgroundImage")));
            this.deactivatebtn.ButtonText = "Deactivate";
            this.deactivatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deactivatebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivatebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.deactivatebtn.IdleBorderThickness = 1;
            this.deactivatebtn.IdleCornerRadius = 20;
            this.deactivatebtn.IdleFillColor = System.Drawing.Color.White;
            this.deactivatebtn.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deactivatebtn.IdleLineColor = System.Drawing.Color.Black;
            this.deactivatebtn.Location = new System.Drawing.Point(340, 193);
            this.deactivatebtn.Margin = new System.Windows.Forms.Padding(5);
            this.deactivatebtn.Name = "deactivatebtn";
            this.deactivatebtn.Size = new System.Drawing.Size(148, 41);
            this.deactivatebtn.TabIndex = 5;
            this.deactivatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deactivatebtn.Click += new System.EventHandler(this.deactivatebtn_Click);
            // 
            // eyebtn
            // 
            this.eyebtn.BackColor = System.Drawing.SystemColors.Control;
            this.eyebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyebtn.Image = global::Car_Rental_App.Properties.Resources.eye1;
            this.eyebtn.ImageActive = null;
            this.eyebtn.Location = new System.Drawing.Point(215, 125);
            this.eyebtn.Name = "eyebtn";
            this.eyebtn.Size = new System.Drawing.Size(43, 33);
            this.eyebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyebtn.TabIndex = 7;
            this.eyebtn.TabStop = false;
            this.eyebtn.Visible = false;
            this.eyebtn.Zoom = 10;
            this.eyebtn.Click += new System.EventHandler(this.eyebtn_Click);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(265, 125);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(320, 33);
            this.password.TabIndex = 6;
            this.password.Text = "enter your password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Enter += new System.EventHandler(this.password_Enter_1);
            this.password.Leave += new System.EventHandler(this.password_Leave_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeactivateAccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eyebtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.deactivatebtn);
            this.Controls.Add(this.backbtn);
            this.Name = "DeactivateAccountUC";
            this.Size = new System.Drawing.Size(844, 340);
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton backbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 deactivatebtn;
        private Bunifu.Framework.UI.BunifuImageButton eyebtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
