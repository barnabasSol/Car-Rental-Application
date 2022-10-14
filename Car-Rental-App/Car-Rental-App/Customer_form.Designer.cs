namespace Car_Rental_App
{
    partial class Customer_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.idlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fullnamelbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.little_car = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.settingbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.homebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_car)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.idlbl);
            this.panel1.Controls.Add(this.fullnamelbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.little_car);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 72);
            this.panel1.TabIndex = 8;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.idlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.idlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idlbl.Location = new System.Drawing.Point(68, 30);
            this.idlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(89, 18);
            this.idlbl.TabIndex = 5;
            this.idlbl.Text = "id goes here";
            // 
            // fullnamelbl
            // 
            this.fullnamelbl.AutoSize = true;
            this.fullnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fullnamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullnamelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fullnamelbl.Location = new System.Drawing.Point(69, 10);
            this.fullnamelbl.Name = "fullnamelbl";
            this.fullnamelbl.Size = new System.Drawing.Size(105, 16);
            this.fullnamelbl.TabIndex = 4;
            this.fullnamelbl.Text = "name goes here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Rental_App.Properties.Resources.administrator_2_48;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // little_car
            // 
            this.little_car.Cursor = System.Windows.Forms.Cursors.Hand;
            this.little_car.Image = ((System.Drawing.Image)(resources.GetObject("little_car.Image")));
            this.little_car.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.little_car.Location = new System.Drawing.Point(768, 4);
            this.little_car.Margin = new System.Windows.Forms.Padding(2);
            this.little_car.Name = "little_car";
            this.little_car.Size = new System.Drawing.Size(65, 68);
            this.little_car.TabIndex = 3;
            this.little_car.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customerbtn);
            this.panel2.Controls.Add(this.settingbtn);
            this.panel2.Controls.Add(this.homebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 52);
            this.panel2.TabIndex = 9;
            // 
            // customerbtn
            // 
            this.customerbtn.ActiveBorderThickness = 1;
            this.customerbtn.ActiveCornerRadius = 20;
            this.customerbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.customerbtn.ActiveForecolor = System.Drawing.Color.White;
            this.customerbtn.ActiveLineColor = System.Drawing.Color.White;
            this.customerbtn.BackColor = System.Drawing.SystemColors.Control;
            this.customerbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerbtn.BackgroundImage")));
            this.customerbtn.ButtonText = "Browse";
            this.customerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerbtn.ForeColor = System.Drawing.Color.Black;
            this.customerbtn.IdleBorderThickness = 1;
            this.customerbtn.IdleCornerRadius = 20;
            this.customerbtn.IdleFillColor = System.Drawing.SystemColors.Menu;
            this.customerbtn.IdleForecolor = System.Drawing.Color.Black;
            this.customerbtn.IdleLineColor = System.Drawing.SystemColors.Menu;
            this.customerbtn.Location = new System.Drawing.Point(350, 5);
            this.customerbtn.Margin = new System.Windows.Forms.Padding(5);
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.Size = new System.Drawing.Size(145, 42);
            this.customerbtn.TabIndex = 11;
            this.customerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerbtn.Click += new System.EventHandler(this.customerbtn_Click);
            // 
            // settingbtn
            // 
            this.settingbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.settingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingbtn.Image = ((System.Drawing.Image)(resources.GetObject("settingbtn.Image")));
            this.settingbtn.ImageActive = null;
            this.settingbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.settingbtn.Location = new System.Drawing.Point(701, 6);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(131, 41);
            this.settingbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingbtn.TabIndex = 9;
            this.settingbtn.TabStop = false;
            this.settingbtn.Zoom = 10;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.SystemColors.Menu;
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebtn.Image = ((System.Drawing.Image)(resources.GetObject("homebtn.Image")));
            this.homebtn.ImageActive = null;
            this.homebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.homebtn.Location = new System.Drawing.Point(12, 6);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(131, 41);
            this.homebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homebtn.TabIndex = 9;
            this.homebtn.TabStop = false;
            this.homebtn.Zoom = 10;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 124);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(844, 393);
            this.mainpanel.TabIndex = 10;
            // 
            // Customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 517);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Customer_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_car)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel idlbl;
        private Bunifu.Framework.UI.BunifuCustomLabel fullnamelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox little_car;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton settingbtn;
        private Bunifu.Framework.UI.BunifuImageButton homebtn;
        private System.Windows.Forms.Panel mainpanel;
        private Bunifu.Framework.UI.BunifuThinButton2 customerbtn;
    }
}