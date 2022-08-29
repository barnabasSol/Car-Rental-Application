
namespace Car_Rental_App.AdminUserControl
{
    partial class AddVehicleUCcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleUCcs));
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lptxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cnametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ctypetxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.carcapacitytxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmodeltxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ccolortxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cconditiontxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pphtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.addbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(219, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(106, 21);
            this.title.TabIndex = 2;
            this.title.Text = "Add Vehicle";
            // 
            // lptxt
            // 
            this.lptxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lptxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lptxt.ForeColor = System.Drawing.Color.Gray;
            this.lptxt.HintForeColor = System.Drawing.Color.Empty;
            this.lptxt.HintText = "";
            this.lptxt.isPassword = false;
            this.lptxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.lptxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.lptxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.lptxt.LineThickness = 3;
            this.lptxt.Location = new System.Drawing.Point(102, 57);
            this.lptxt.Margin = new System.Windows.Forms.Padding(4);
            this.lptxt.Name = "lptxt";
            this.lptxt.Size = new System.Drawing.Size(320, 33);
            this.lptxt.TabIndex = 8;
            this.lptxt.Text = "enter license plate";
            this.lptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lptxt.Enter += new System.EventHandler(this.lptxt_Enter);
            this.lptxt.Leave += new System.EventHandler(this.lptxt_Leave);
            // 
            // cnametxt
            // 
            this.cnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cnametxt.ForeColor = System.Drawing.Color.Gray;
            this.cnametxt.HintForeColor = System.Drawing.Color.Empty;
            this.cnametxt.HintText = "";
            this.cnametxt.isPassword = false;
            this.cnametxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.cnametxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.cnametxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.cnametxt.LineThickness = 3;
            this.cnametxt.Location = new System.Drawing.Point(102, 107);
            this.cnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(320, 33);
            this.cnametxt.TabIndex = 8;
            this.cnametxt.Text = "enter car name";
            this.cnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cnametxt.Enter += new System.EventHandler(this.cnametxt_Enter);
            this.cnametxt.Leave += new System.EventHandler(this.cnametxt_Leave);
            // 
            // ctypetxt
            // 
            this.ctypetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctypetxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ctypetxt.ForeColor = System.Drawing.Color.Gray;
            this.ctypetxt.HintForeColor = System.Drawing.Color.Empty;
            this.ctypetxt.HintText = "";
            this.ctypetxt.isPassword = false;
            this.ctypetxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.ctypetxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.ctypetxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.ctypetxt.LineThickness = 3;
            this.ctypetxt.Location = new System.Drawing.Point(102, 161);
            this.ctypetxt.Margin = new System.Windows.Forms.Padding(4);
            this.ctypetxt.Name = "ctypetxt";
            this.ctypetxt.Size = new System.Drawing.Size(320, 33);
            this.ctypetxt.TabIndex = 8;
            this.ctypetxt.Text = "enter car type";
            this.ctypetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctypetxt.Enter += new System.EventHandler(this.ctypetxt_Enter);
            this.ctypetxt.Leave += new System.EventHandler(this.ctypetxt_Leave);
            // 
            // carcapacitytxt
            // 
            this.carcapacitytxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carcapacitytxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.carcapacitytxt.ForeColor = System.Drawing.Color.Gray;
            this.carcapacitytxt.HintForeColor = System.Drawing.Color.Empty;
            this.carcapacitytxt.HintText = "";
            this.carcapacitytxt.isPassword = false;
            this.carcapacitytxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.carcapacitytxt.LineIdleColor = System.Drawing.Color.DarkGray;
            this.carcapacitytxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.carcapacitytxt.LineThickness = 3;
            this.carcapacitytxt.Location = new System.Drawing.Point(102, 216);
            this.carcapacitytxt.Margin = new System.Windows.Forms.Padding(4);
            this.carcapacitytxt.Name = "carcapacitytxt";
            this.carcapacitytxt.Size = new System.Drawing.Size(320, 33);
            this.carcapacitytxt.TabIndex = 8;
            this.carcapacitytxt.Text = "enter car capacity";
            this.carcapacitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmodeltxt
            // 
            this.cmodeltxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmodeltxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmodeltxt.ForeColor = System.Drawing.Color.Gray;
            this.cmodeltxt.HintForeColor = System.Drawing.Color.Empty;
            this.cmodeltxt.HintText = "";
            this.cmodeltxt.isPassword = false;
            this.cmodeltxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.cmodeltxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.cmodeltxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.cmodeltxt.LineThickness = 3;
            this.cmodeltxt.Location = new System.Drawing.Point(102, 272);
            this.cmodeltxt.Margin = new System.Windows.Forms.Padding(4);
            this.cmodeltxt.Name = "cmodeltxt";
            this.cmodeltxt.Size = new System.Drawing.Size(320, 33);
            this.cmodeltxt.TabIndex = 8;
            this.cmodeltxt.Text = "enter car model";
            this.cmodeltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmodeltxt.Enter += new System.EventHandler(this.cmodeltxt_Enter);
            this.cmodeltxt.Leave += new System.EventHandler(this.cmodeltxt_Leave);
            // 
            // ccolortxt
            // 
            this.ccolortxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ccolortxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ccolortxt.ForeColor = System.Drawing.Color.Gray;
            this.ccolortxt.HintForeColor = System.Drawing.Color.Empty;
            this.ccolortxt.HintText = "";
            this.ccolortxt.isPassword = false;
            this.ccolortxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.ccolortxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.ccolortxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.ccolortxt.LineThickness = 3;
            this.ccolortxt.Location = new System.Drawing.Point(102, 329);
            this.ccolortxt.Margin = new System.Windows.Forms.Padding(4);
            this.ccolortxt.Name = "ccolortxt";
            this.ccolortxt.Size = new System.Drawing.Size(320, 33);
            this.ccolortxt.TabIndex = 8;
            this.ccolortxt.Text = "enter car color";
            this.ccolortxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ccolortxt.Enter += new System.EventHandler(this.ccolortxt_Enter);
            this.ccolortxt.Leave += new System.EventHandler(this.ccolortxt_Leave);
            // 
            // cconditiontxt
            // 
            this.cconditiontxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cconditiontxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cconditiontxt.ForeColor = System.Drawing.Color.Gray;
            this.cconditiontxt.HintForeColor = System.Drawing.Color.Empty;
            this.cconditiontxt.HintText = "";
            this.cconditiontxt.isPassword = false;
            this.cconditiontxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.cconditiontxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.cconditiontxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.cconditiontxt.LineThickness = 3;
            this.cconditiontxt.Location = new System.Drawing.Point(102, 383);
            this.cconditiontxt.Margin = new System.Windows.Forms.Padding(4);
            this.cconditiontxt.Name = "cconditiontxt";
            this.cconditiontxt.Size = new System.Drawing.Size(320, 33);
            this.cconditiontxt.TabIndex = 8;
            this.cconditiontxt.Text = "car condition";
            this.cconditiontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pphtxt
            // 
            this.pphtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pphtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pphtxt.ForeColor = System.Drawing.Color.Gray;
            this.pphtxt.HintForeColor = System.Drawing.Color.Empty;
            this.pphtxt.HintText = "";
            this.pphtxt.isPassword = false;
            this.pphtxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.pphtxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.pphtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.pphtxt.LineThickness = 3;
            this.pphtxt.Location = new System.Drawing.Point(102, 437);
            this.pphtxt.Margin = new System.Windows.Forms.Padding(4);
            this.pphtxt.Name = "pphtxt";
            this.pphtxt.Size = new System.Drawing.Size(320, 33);
            this.pphtxt.TabIndex = 8;
            this.pphtxt.Text = "price per hour";
            this.pphtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuImageButton1.Image = global::Car_Rental_App.Properties.Resources.undo_circular_arrow;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(322, 508);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(43, 41);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // addbtn
            // 
            this.addbtn.ActiveBorderThickness = 1;
            this.addbtn.ActiveCornerRadius = 20;
            this.addbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addbtn.ActiveForecolor = System.Drawing.Color.White;
            this.addbtn.ActiveLineColor = System.Drawing.Color.White;
            this.addbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.ButtonText = "Add";
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.IdleBorderThickness = 1;
            this.addbtn.IdleCornerRadius = 20;
            this.addbtn.IdleFillColor = System.Drawing.SystemColors.ControlLight;
            this.addbtn.IdleForecolor = System.Drawing.Color.Black;
            this.addbtn.IdleLineColor = System.Drawing.SystemColors.ControlLight;
            this.addbtn.Location = new System.Drawing.Point(165, 509);
            this.addbtn.Margin = new System.Windows.Forms.Padding(5);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(137, 40);
            this.addbtn.TabIndex = 12;
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // AddVehicleUCcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.pphtxt);
            this.Controls.Add(this.cconditiontxt);
            this.Controls.Add(this.ccolortxt);
            this.Controls.Add(this.cmodeltxt);
            this.Controls.Add(this.carcapacitytxt);
            this.Controls.Add(this.ctypetxt);
            this.Controls.Add(this.cnametxt);
            this.Controls.Add(this.lptxt);
            this.Controls.Add(this.title);
            this.Name = "AddVehicleUCcs";
            this.Size = new System.Drawing.Size(550, 578);
            this.Load += new System.EventHandler(this.AddVehicleUCcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lptxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnametxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ctypetxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox carcapacitytxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmodeltxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ccolortxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cconditiontxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pphtxt;
        private Bunifu.Framework.UI.BunifuThinButton2 addbtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
