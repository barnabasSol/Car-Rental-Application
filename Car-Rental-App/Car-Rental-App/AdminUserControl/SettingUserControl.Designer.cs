
namespace Car_Rental_App.AdminUserControl
{
    partial class SettingUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingUserControl));
            this.logoutlbl = new System.Windows.Forms.Label();
            this.resetpswlbl = new System.Windows.Forms.Label();
            this.deactivatelbl = new System.Windows.Forms.Label();
            this.deactivatebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.resetpswbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.logoutbtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.deactivatebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetpswbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutlbl
            // 
            this.logoutlbl.AutoSize = true;
            this.logoutlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlbl.Location = new System.Drawing.Point(128, 198);
            this.logoutlbl.Name = "logoutlbl";
            this.logoutlbl.Size = new System.Drawing.Size(60, 17);
            this.logoutlbl.TabIndex = 1;
            this.logoutlbl.Text = "Log Out";
            this.logoutlbl.Visible = false;
            // 
            // resetpswlbl
            // 
            this.resetpswlbl.AutoSize = true;
            this.resetpswlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpswlbl.Location = new System.Drawing.Point(361, 198);
            this.resetpswlbl.Name = "resetpswlbl";
            this.resetpswlbl.Size = new System.Drawing.Size(107, 17);
            this.resetpswlbl.TabIndex = 2;
            this.resetpswlbl.Text = "Reset Password";
            this.resetpswlbl.Visible = false;
            // 
            // deactivatelbl
            // 
            this.deactivatelbl.AutoSize = true;
            this.deactivatelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivatelbl.Location = new System.Drawing.Point(609, 198);
            this.deactivatelbl.Name = "deactivatelbl";
            this.deactivatelbl.Size = new System.Drawing.Size(140, 17);
            this.deactivatelbl.TabIndex = 2;
            this.deactivatelbl.Text = "Deactivate Account";
            this.deactivatelbl.Visible = false;
            // 
            // deactivatebtn
            // 
            this.deactivatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.deactivatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deactivatebtn.Image = ((System.Drawing.Image)(resources.GetObject("deactivatebtn.Image")));
            this.deactivatebtn.ImageActive = null;
            this.deactivatebtn.Location = new System.Drawing.Point(640, 117);
            this.deactivatebtn.Name = "deactivatebtn";
            this.deactivatebtn.Size = new System.Drawing.Size(81, 78);
            this.deactivatebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deactivatebtn.TabIndex = 4;
            this.deactivatebtn.TabStop = false;
            this.deactivatebtn.Zoom = 10;
            this.deactivatebtn.MouseLeave += new System.EventHandler(this.deactivatebtn_MouseLeave);
            this.deactivatebtn.MouseHover += new System.EventHandler(this.deactivatebtn_MouseHover);
            // 
            // resetpswbtn
            // 
            this.resetpswbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.resetpswbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetpswbtn.Image = ((System.Drawing.Image)(resources.GetObject("resetpswbtn.Image")));
            this.resetpswbtn.ImageActive = null;
            this.resetpswbtn.Location = new System.Drawing.Point(375, 117);
            this.resetpswbtn.Name = "resetpswbtn";
            this.resetpswbtn.Size = new System.Drawing.Size(81, 78);
            this.resetpswbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resetpswbtn.TabIndex = 3;
            this.resetpswbtn.TabStop = false;
            this.resetpswbtn.Zoom = 10;
            this.resetpswbtn.Click += new System.EventHandler(this.resetpswbtn_Click);
            this.resetpswbtn.MouseLeave += new System.EventHandler(this.resetpswbtn_MouseLeave);
            this.resetpswbtn.MouseHover += new System.EventHandler(this.resetpswbtn_MouseHover);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.ImageActive = null;
            this.logoutbtn.Location = new System.Drawing.Point(122, 117);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(108, 96);
            this.logoutbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutbtn.TabIndex = 0;
            this.logoutbtn.TabStop = false;
            this.logoutbtn.Zoom = 10;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            this.logoutbtn.MouseLeave += new System.EventHandler(this.logoutbtn_MouseLeave);
            this.logoutbtn.MouseHover += new System.EventHandler(this.logoutbtn_MouseHover);
            // 
            // SettingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deactivatebtn);
            this.Controls.Add(this.resetpswbtn);
            this.Controls.Add(this.deactivatelbl);
            this.Controls.Add(this.resetpswlbl);
            this.Controls.Add(this.logoutlbl);
            this.Controls.Add(this.logoutbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingUserControl";
            this.Size = new System.Drawing.Size(1125, 418);
            this.Load += new System.EventHandler(this.SettingUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deactivatebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetpswbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton logoutbtn;
        private System.Windows.Forms.Label logoutlbl;
        private System.Windows.Forms.Label resetpswlbl;
        private System.Windows.Forms.Label deactivatelbl;
        private Bunifu.Framework.UI.BunifuImageButton resetpswbtn;
        private Bunifu.Framework.UI.BunifuImageButton deactivatebtn;
    }
}
