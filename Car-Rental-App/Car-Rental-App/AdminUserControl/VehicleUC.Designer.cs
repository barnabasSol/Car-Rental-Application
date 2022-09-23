
namespace Car_Rental_App.AdminUserControl
{
    partial class VehicleUC
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
            this.vpanel = new System.Windows.Forms.Panel();
            this.searchv = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.srchimg = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.addvehiclebtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.srchimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addvehiclebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // vpanel
            // 
            this.vpanel.AutoScroll = true;
            this.vpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vpanel.Location = new System.Drawing.Point(127, 59);
            this.vpanel.Name = "vpanel";
            this.vpanel.Size = new System.Drawing.Size(611, 337);
            this.vpanel.TabIndex = 5;
            // 
            // searchv
            // 
            this.searchv.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.searchv.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchv.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.searchv.BorderThickness = 3;
            this.searchv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchv.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchv.isPassword = false;
            this.searchv.Location = new System.Drawing.Point(220, 8);
            this.searchv.Margin = new System.Windows.Forms.Padding(4);
            this.searchv.Name = "searchv";
            this.searchv.Size = new System.Drawing.Size(370, 44);
            this.searchv.TabIndex = 9;
            this.searchv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchv.Visible = false;
            this.searchv.OnValueChanged += new System.EventHandler(this.searchv_OnValueChanged);
            // 
            // srchimg
            // 
            this.srchimg.Image = global::Car_Rental_App.Properties.Resources.icons8_search_30;
            this.srchimg.Location = new System.Drawing.Point(593, 14);
            this.srchimg.Name = "srchimg";
            this.srchimg.Size = new System.Drawing.Size(40, 32);
            this.srchimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.srchimg.TabIndex = 10;
            this.srchimg.TabStop = false;
            this.srchimg.Visible = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::Car_Rental_App.Properties.Resources.searchingcar;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(43, 86);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(61, 63);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // addvehiclebtn
            // 
            this.addvehiclebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.addvehiclebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addvehiclebtn.Image = global::Car_Rental_App.Properties.Resources.addcar;
            this.addvehiclebtn.ImageActive = null;
            this.addvehiclebtn.Location = new System.Drawing.Point(43, 278);
            this.addvehiclebtn.Margin = new System.Windows.Forms.Padding(2);
            this.addvehiclebtn.Name = "addvehiclebtn";
            this.addvehiclebtn.Size = new System.Drawing.Size(61, 63);
            this.addvehiclebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addvehiclebtn.TabIndex = 4;
            this.addvehiclebtn.TabStop = false;
            this.addvehiclebtn.Zoom = 10;
            this.addvehiclebtn.Click += new System.EventHandler(this.addvehiclebtn_Click);
            // 
            // VehicleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.srchimg);
            this.Controls.Add(this.searchv);
            this.Controls.Add(this.vpanel);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.addvehiclebtn);
            this.Name = "VehicleUC";
            this.Size = new System.Drawing.Size(844, 396);
            ((System.ComponentModel.ISupportInitialize)(this.srchimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addvehiclebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton addvehiclebtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel vpanel;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchv;
        private System.Windows.Forms.PictureBox srchimg;
    }
}
