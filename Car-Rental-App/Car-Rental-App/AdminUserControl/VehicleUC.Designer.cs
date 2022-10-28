
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
            this.vpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchvtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.addvehiclebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.flbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterbycbox = new System.Windows.Forms.ComboBox();
            this.srchimg = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addvehiclebtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srchimg)).BeginInit();
            this.SuspendLayout();
            // 
            // vpanel
            // 
            this.vpanel.AutoScroll = true;
            this.vpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vpanel.Location = new System.Drawing.Point(110, 60);
            this.vpanel.Name = "vpanel";
            this.vpanel.Size = new System.Drawing.Size(600, 336);
            this.vpanel.TabIndex = 16;
            this.vpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.vpanel_Paint);
            // 
            // searchvtxt
            // 
            this.searchvtxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.searchvtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchvtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.searchvtxt.BorderThickness = 3;
            this.searchvtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchvtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchvtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchvtxt.isPassword = false;
            this.searchvtxt.Location = new System.Drawing.Point(206, 9);
            this.searchvtxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchvtxt.Name = "searchvtxt";
            this.searchvtxt.Size = new System.Drawing.Size(370, 44);
            this.searchvtxt.TabIndex = 18;
            this.searchvtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchvtxt.Visible = false;
            this.searchvtxt.OnValueChanged += new System.EventHandler(this.searchvtxt_OnValueChanged_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.addvehiclebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 396);
            this.panel2.TabIndex = 13;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::Car_Rental_App.Properties.Resources.searchingcar;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(41, 73);
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
            this.addvehiclebtn.Location = new System.Drawing.Point(41, 248);
            this.addvehiclebtn.Margin = new System.Windows.Forms.Padding(2);
            this.addvehiclebtn.Name = "addvehiclebtn";
            this.addvehiclebtn.Size = new System.Drawing.Size(61, 63);
            this.addvehiclebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addvehiclebtn.TabIndex = 4;
            this.addvehiclebtn.TabStop = false;
            this.addvehiclebtn.Zoom = 10;
            this.addvehiclebtn.Click += new System.EventHandler(this.addvehiclebtn_Click);
            // 
            // flbl
            // 
            this.flbl.AutoSize = true;
            this.flbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flbl.Location = new System.Drawing.Point(36, 83);
            this.flbl.Name = "flbl";
            this.flbl.Size = new System.Drawing.Size(55, 17);
            this.flbl.TabIndex = 30;
            this.flbl.Text = "filter by:";
            this.flbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flbl);
            this.panel1.Controls.Add(this.filterbycbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(710, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 396);
            this.panel1.TabIndex = 12;
            // 
            // filterbycbox
            // 
            this.filterbycbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterbycbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterbycbox.FormattingEnabled = true;
            this.filterbycbox.Items.AddRange(new object[] {
            "unreturned",
            "verified",
            "unverified",
            "car condition (asc)",
            "car condition (desc)",
            "price (asc)",
            "price (desc)"});
            this.filterbycbox.Location = new System.Drawing.Point(5, 115);
            this.filterbycbox.Name = "filterbycbox";
            this.filterbycbox.Size = new System.Drawing.Size(126, 21);
            this.filterbycbox.TabIndex = 11;
            this.filterbycbox.Visible = false;
            this.filterbycbox.SelectedIndexChanged += new System.EventHandler(this.filterbycbox_SelectedIndexChanged);
            // 
            // srchimg
            // 
            this.srchimg.Image = global::Car_Rental_App.Properties.Resources.icons8_search_30;
            this.srchimg.Location = new System.Drawing.Point(585, 15);
            this.srchimg.Name = "srchimg";
            this.srchimg.Size = new System.Drawing.Size(40, 32);
            this.srchimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.srchimg.TabIndex = 19;
            this.srchimg.TabStop = false;
            this.srchimg.Visible = false;
            // 
            // VehicleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.srchimg);
            this.Controls.Add(this.searchvtxt);
            this.Controls.Add(this.vpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VehicleUC";
            this.Size = new System.Drawing.Size(844, 396);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addvehiclebtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srchimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vpanel;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchvtxt;
        private System.Windows.Forms.PictureBox srchimg;
        private Bunifu.Framework.UI.BunifuImageButton addvehiclebtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label flbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox filterbycbox;
    }
}
