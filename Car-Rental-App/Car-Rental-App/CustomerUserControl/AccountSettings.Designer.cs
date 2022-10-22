namespace Car_Rental_App.CustomerUserControl
{
    partial class AccountSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btndeactivate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnlogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtConfirmP = new System.Windows.Forms.TextBox();
            this.txtNewP = new System.Windows.Forms.TextBox();
            this.txtOldP = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 454);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.btndeactivate);
            this.splitContainer1.Panel2.Controls.Add(this.btnlogout);
            this.splitContainer1.Panel2.Controls.Add(this.txtConfirmP);
            this.splitContainer1.Panel2.Controls.Add(this.txtNewP);
            this.splitContainer1.Panel2.Controls.Add(this.txtOldP);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuFlatButton1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(721, 454);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // btndeactivate
            // 
            this.btndeactivate.Activecolor = System.Drawing.Color.White;
            this.btndeactivate.BackColor = System.Drawing.Color.White;
            this.btndeactivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndeactivate.BorderRadius = 0;
            this.btndeactivate.ButtonText = "Deactivate";
            this.btndeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeactivate.DisabledColor = System.Drawing.Color.Gray;
            this.btndeactivate.Iconcolor = System.Drawing.Color.Transparent;
            this.btndeactivate.Iconimage = global::Car_Rental_App.Properties.Resources.block;
            this.btndeactivate.Iconimage_right = null;
            this.btndeactivate.Iconimage_right_Selected = null;
            this.btndeactivate.Iconimage_Selected = null;
            this.btndeactivate.IconMarginLeft = 0;
            this.btndeactivate.IconMarginRight = 0;
            this.btndeactivate.IconRightVisible = true;
            this.btndeactivate.IconRightZoom = 0D;
            this.btndeactivate.IconVisible = true;
            this.btndeactivate.IconZoom = 90D;
            this.btndeactivate.IsTab = false;
            this.btndeactivate.Location = new System.Drawing.Point(382, 108);
            this.btndeactivate.Name = "btndeactivate";
            this.btndeactivate.Normalcolor = System.Drawing.Color.White;
            this.btndeactivate.OnHovercolor = System.Drawing.Color.White;
            this.btndeactivate.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btndeactivate.selected = false;
            this.btndeactivate.Size = new System.Drawing.Size(241, 43);
            this.btndeactivate.TabIndex = 11;
            this.btndeactivate.Text = "Deactivate";
            this.btndeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeactivate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btndeactivate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnlogout
            // 
            this.btnlogout.Activecolor = System.Drawing.Color.White;
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogout.BorderRadius = 0;
            this.btnlogout.ButtonText = "Logout";
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnlogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnlogout.Iconimage = global::Car_Rental_App.Properties.Resources.block;
            this.btnlogout.Iconimage_right = null;
            this.btnlogout.Iconimage_right_Selected = null;
            this.btnlogout.Iconimage_Selected = null;
            this.btnlogout.IconMarginLeft = 0;
            this.btnlogout.IconMarginRight = 0;
            this.btnlogout.IconRightVisible = true;
            this.btnlogout.IconRightZoom = 0D;
            this.btnlogout.IconVisible = true;
            this.btnlogout.IconZoom = 90D;
            this.btnlogout.IsTab = false;
            this.btnlogout.Location = new System.Drawing.Point(382, 27);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Normalcolor = System.Drawing.Color.White;
            this.btnlogout.OnHovercolor = System.Drawing.Color.White;
            this.btnlogout.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnlogout.selected = false;
            this.btnlogout.Size = new System.Drawing.Size(241, 43);
            this.btnlogout.TabIndex = 10;
            this.btnlogout.Text = "Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnlogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // txtConfirmP
            // 
            this.txtConfirmP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmP.Location = new System.Drawing.Point(23, 169);
            this.txtConfirmP.Name = "txtConfirmP";
            this.txtConfirmP.Size = new System.Drawing.Size(222, 23);
            this.txtConfirmP.TabIndex = 9;
            this.txtConfirmP.UseSystemPasswordChar = true;
            // 
            // txtNewP
            // 
            this.txtNewP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewP.Location = new System.Drawing.Point(23, 108);
            this.txtNewP.Name = "txtNewP";
            this.txtNewP.Size = new System.Drawing.Size(222, 23);
            this.txtNewP.TabIndex = 8;
            this.txtNewP.UseSystemPasswordChar = true;
            // 
            // txtOldP
            // 
            this.txtOldP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldP.Location = new System.Drawing.Point(23, 47);
            this.txtOldP.Name = "txtOldP";
            this.txtOldP.Size = new System.Drawing.Size(222, 23);
            this.txtOldP.TabIndex = 7;
            this.txtOldP.UseSystemPasswordChar = true;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Save Changes";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(23, 212);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(222, 45);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Save Changes";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Old Password:";
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AccountSettings";
            this.Size = new System.Drawing.Size(721, 454);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox txtConfirmP;
        private System.Windows.Forms.TextBox txtNewP;
        private System.Windows.Forms.TextBox txtOldP;
        private Bunifu.Framework.UI.BunifuFlatButton btnlogout;
        private Bunifu.Framework.UI.BunifuFlatButton btndeactivate;
    }
}
