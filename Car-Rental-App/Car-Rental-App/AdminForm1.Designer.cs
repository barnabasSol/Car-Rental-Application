
namespace Car_Rental_App
{
    partial class AdminForm1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm1));
            this.idlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fullnamelbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.little_car = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vehiclebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.customerbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.settingbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.homebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_car)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).BeginInit();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // idlbl
            // 
            resources.ApplyResources(this.idlbl, "idlbl");
            this.idlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.idlbl.Name = "idlbl";
            // 
            // fullnamelbl
            // 
            resources.ApplyResources(this.fullnamelbl, "fullnamelbl");
            this.fullnamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullnamelbl.Name = "fullnamelbl";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.idlbl);
            this.panel1.Controls.Add(this.fullnamelbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.little_car);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Rental_App.Properties.Resources.administrator_2_48;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // little_car
            // 
            this.little_car.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.little_car, "little_car");
            this.little_car.Name = "little_car";
            this.little_car.TabStop = false;
            this.little_car.Click += new System.EventHandler(this.little_car_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vehiclebtn);
            this.panel2.Controls.Add(this.customerbtn);
            this.panel2.Controls.Add(this.settingbtn);
            this.panel2.Controls.Add(this.homebtn);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // vehiclebtn
            // 
            this.vehiclebtn.ActiveBorderThickness = 1;
            this.vehiclebtn.ActiveCornerRadius = 20;
            this.vehiclebtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.vehiclebtn.ActiveForecolor = System.Drawing.Color.White;
            this.vehiclebtn.ActiveLineColor = System.Drawing.SystemColors.Menu;
            this.vehiclebtn.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.vehiclebtn, "vehiclebtn");
            this.vehiclebtn.ButtonText = "Vehicle";
            this.vehiclebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehiclebtn.ForeColor = System.Drawing.Color.Black;
            this.vehiclebtn.IdleBorderThickness = 1;
            this.vehiclebtn.IdleCornerRadius = 20;
            this.vehiclebtn.IdleFillColor = System.Drawing.SystemColors.Menu;
            this.vehiclebtn.IdleForecolor = System.Drawing.Color.Black;
            this.vehiclebtn.IdleLineColor = System.Drawing.SystemColors.Menu;
            this.vehiclebtn.Name = "vehiclebtn";
            this.vehiclebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vehiclebtn.Click += new System.EventHandler(this.vehiclebtn_Click);
            // 
            // customerbtn
            // 
            this.customerbtn.ActiveBorderThickness = 1;
            this.customerbtn.ActiveCornerRadius = 20;
            this.customerbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.customerbtn.ActiveForecolor = System.Drawing.Color.White;
            this.customerbtn.ActiveLineColor = System.Drawing.Color.White;
            this.customerbtn.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.customerbtn, "customerbtn");
            this.customerbtn.ButtonText = "Customer";
            this.customerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerbtn.ForeColor = System.Drawing.Color.Black;
            this.customerbtn.IdleBorderThickness = 1;
            this.customerbtn.IdleCornerRadius = 20;
            this.customerbtn.IdleFillColor = System.Drawing.SystemColors.Menu;
            this.customerbtn.IdleForecolor = System.Drawing.Color.Black;
            this.customerbtn.IdleLineColor = System.Drawing.SystemColors.Menu;
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerbtn.Click += new System.EventHandler(this.customerbtn_Click);
            // 
            // settingbtn
            // 
            this.settingbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.settingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.settingbtn, "settingbtn");
            this.settingbtn.ImageActive = null;
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.TabStop = false;
            this.settingbtn.Zoom = 10;
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.SystemColors.Menu;
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.homebtn, "homebtn");
            this.homebtn.ImageActive = null;
            this.homebtn.Name = "homebtn";
            this.homebtn.TabStop = false;
            this.homebtn.Zoom = 10;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.mainpanel, "mainpanel");
            this.mainpanel.Name = "mainpanel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Car_Rental_App.Properties.Resources.administrator;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // AdminForm1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm1";
            this.Load += new System.EventHandler(this.AdminForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_car)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).EndInit();
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox little_car;
        private Bunifu.Framework.UI.BunifuCustomLabel idlbl;
        private Bunifu.Framework.UI.BunifuCustomLabel fullnamelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton homebtn;
        private Bunifu.Framework.UI.BunifuThinButton2 customerbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 vehiclebtn;
        private Bunifu.Framework.UI.BunifuImageButton settingbtn;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}