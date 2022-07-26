﻿
namespace Car_Rental_App
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.welcomelbl = new System.Windows.Forms.Label();
            this.dhaalbl = new System.Windows.Forms.Label();
            this.create_here_lbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.little_car = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.login_idtxt = new System.Windows.Forms.TextBox();
            this.pswlbl = new System.Windows.Forms.Label();
            this.loginidlbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.ForeColor = System.Drawing.Color.Black;
            this.welcomelbl.Location = new System.Drawing.Point(467, 40);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(351, 36);
            this.welcomelbl.TabIndex = 1;
            this.welcomelbl.Text = "Welcome to Rent a Car";
            // 
            // dhaalbl
            // 
            this.dhaalbl.AutoSize = true;
            this.dhaalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhaalbl.ForeColor = System.Drawing.Color.Black;
            this.dhaalbl.Location = new System.Drawing.Point(526, 309);
            this.dhaalbl.Name = "dhaalbl";
            this.dhaalbl.Size = new System.Drawing.Size(133, 15);
            this.dhaalbl.TabIndex = 7;
            this.dhaalbl.Text = "don\'t have an account?";
            // 
            // create_here_lbl
            // 
            this.create_here_lbl.AutoSize = true;
            this.create_here_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_here_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_here_lbl.Location = new System.Drawing.Point(655, 309);
            this.create_here_lbl.Name = "create_here_lbl";
            this.create_here_lbl.Size = new System.Drawing.Size(69, 15);
            this.create_here_lbl.TabIndex = 9;
            this.create_here_lbl.Text = "create here";
            this.create_here_lbl.Click += new System.EventHandler(this.create_here_lbl_Click);
            this.create_here_lbl.MouseEnter += new System.EventHandler(this.create_here_lbl_MouseEnter);
            this.create_here_lbl.MouseLeave += new System.EventHandler(this.create_here_lbl_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // little_car
            // 
            this.little_car.Image = ((System.Drawing.Image)(resources.GetObject("little_car.Image")));
            this.little_car.Location = new System.Drawing.Point(752, 359);
            this.little_car.Name = "little_car";
            this.little_car.Size = new System.Drawing.Size(67, 67);
            this.little_car.TabIndex = 2;
            this.little_car.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(508, 227);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '●';
            this.password_txt.Size = new System.Drawing.Size(243, 20);
            this.password_txt.TabIndex = 6;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // login_idtxt
            // 
            this.login_idtxt.Location = new System.Drawing.Point(508, 151);
            this.login_idtxt.Margin = new System.Windows.Forms.Padding(4);
            this.login_idtxt.Name = "login_idtxt";
            this.login_idtxt.Size = new System.Drawing.Size(243, 20);
            this.login_idtxt.TabIndex = 5;
            // 
            // pswlbl
            // 
            this.pswlbl.AutoSize = true;
            this.pswlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswlbl.ForeColor = System.Drawing.Color.Black;
            this.pswlbl.Location = new System.Drawing.Point(508, 188);
            this.pswlbl.Name = "pswlbl";
            this.pswlbl.Size = new System.Drawing.Size(101, 29);
            this.pswlbl.TabIndex = 4;
            this.pswlbl.Text = "Password:";
            this.pswlbl.UseCompatibleTextRendering = true;
            // 
            // loginidlbl
            // 
            this.loginidlbl.AutoSize = true;
            this.loginidlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginidlbl.ForeColor = System.Drawing.Color.Black;
            this.loginidlbl.Location = new System.Drawing.Point(508, 116);
            this.loginidlbl.Name = "loginidlbl";
            this.loginidlbl.Size = new System.Drawing.Size(89, 29);
            this.loginidlbl.TabIndex = 3;
            this.loginidlbl.Text = "Login-ID:";
            this.loginidlbl.UseCompatibleTextRendering = true;
            // 
            // login_btn
            // 
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.Location = new System.Drawing.Point(578, 267);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(91, 23);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 438);
            this.Controls.Add(this.create_here_lbl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.dhaalbl);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.login_idtxt);
            this.Controls.Add(this.pswlbl);
            this.Controls.Add(this.loginidlbl);
            this.Controls.Add(this.little_car);
            this.Controls.Add(this.welcomelbl);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent a Car";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.PictureBox little_car;
        private System.Windows.Forms.Label dhaalbl;
        private System.Windows.Forms.Label create_here_lbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox login_idtxt;
        private System.Windows.Forms.Label pswlbl;
        private System.Windows.Forms.Label loginidlbl;
        private System.Windows.Forms.Button login_btn;
    }
}

