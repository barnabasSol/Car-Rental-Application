namespace Car_Rental_App
{
    partial class Renter_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_Form));
            this.fullnamelbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.idlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Label();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.settingbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // fullnamelbl
            // 
            this.fullnamelbl.AutoSize = true;
            this.fullnamelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.fullnamelbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullnamelbl.Location = new System.Drawing.Point(80, 7);
            this.fullnamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullnamelbl.Name = "fullnamelbl";
            this.fullnamelbl.Size = new System.Drawing.Size(132, 23);
            this.fullnamelbl.TabIndex = 5;
            this.fullnamelbl.Text = "name goes here";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.idlbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.idlbl.Location = new System.Drawing.Point(80, 40);
            this.idlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(112, 24);
            this.idlbl.TabIndex = 6;
            this.idlbl.Text = "id goes here";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.idlbl);
            this.panel1.Controls.Add(this.fullnamelbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 562);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pictureBox1.Image = global::Car_Rental_App.Properties.Resources.administrator_2_48;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuImageButton4);
            this.panel2.Controls.Add(this.bunifuImageButton3);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.settingbtn);
            this.panel2.Location = new System.Drawing.Point(303, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 575);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 482);
            this.panel3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Setting";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Earnings";
            this.label1.Visible = false;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(58, 66);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 21);
            this.Add.TabIndex = 39;
            this.Add.Text = "Add a Car";
            this.Add.Visible = false;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(313, 6);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(113, 51);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 32;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.MouseEnter += new System.EventHandler(this.bunifuImageButton4_MouseEnter);
            this.bunifuImageButton4.MouseLeave += new System.EventHandler(this.bunifuImageButton4_MouseLeave);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(32, 4);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(126, 58);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 31;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            this.bunifuImageButton3.MouseEnter += new System.EventHandler(this.bunifuImageButton3_MouseEnter);
            this.bunifuImageButton3.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            // 
            // settingbtn
            // 
            this.settingbtn.BackColor = System.Drawing.Color.White;
            this.settingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingbtn.Image = ((System.Drawing.Image)(resources.GetObject("settingbtn.Image")));
            this.settingbtn.ImageActive = null;
            this.settingbtn.Location = new System.Drawing.Point(624, 6);
            this.settingbtn.Margin = new System.Windows.Forms.Padding(4);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(175, 50);
            this.settingbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingbtn.TabIndex = 10;
            this.settingbtn.TabStop = false;
            this.settingbtn.Zoom = 10;
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_Click_1);
            this.settingbtn.MouseEnter += new System.EventHandler(this.settingbtn_MouseEnter);
            this.settingbtn.MouseLeave += new System.EventHandler(this.settingbtn_MouseLeave);
            // 
            // Renter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Renter_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renter_Form";
            this.Load += new System.EventHandler(this.Renter_Form_Load);
            this.MouseEnter += new System.EventHandler(this.Renter_Form_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel fullnamelbl;
        private Bunifu.Framework.UI.BunifuCustomLabel idlbl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton settingbtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Add;
    }
}