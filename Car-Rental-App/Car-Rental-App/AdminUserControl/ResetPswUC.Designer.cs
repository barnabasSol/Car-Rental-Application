
namespace Car_Rental_App.AdminUserControl
{
    partial class ResetPswUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPswUC));
            this.oldpswtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newpswtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cnfrmtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eyebtn2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.eyebtn3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.eyebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.backbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.resetbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // oldpswtxt
            // 
            this.oldpswtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldpswtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.oldpswtxt.ForeColor = System.Drawing.Color.Gray;
            this.oldpswtxt.HintForeColor = System.Drawing.Color.Empty;
            this.oldpswtxt.HintText = "";
            this.oldpswtxt.isPassword = false;
            this.oldpswtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.oldpswtxt.LineIdleColor = System.Drawing.Color.DarkGray;
            this.oldpswtxt.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.oldpswtxt.LineThickness = 3;
            this.oldpswtxt.Location = new System.Drawing.Point(281, 65);
            this.oldpswtxt.Margin = new System.Windows.Forms.Padding(4);
            this.oldpswtxt.Name = "oldpswtxt";
            this.oldpswtxt.Size = new System.Drawing.Size(320, 33);
            this.oldpswtxt.TabIndex = 3;
            this.oldpswtxt.Text = "enter old password here";
            this.oldpswtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.oldpswtxt.Enter += new System.EventHandler(this.oldpswtxt_Enter);
            this.oldpswtxt.Leave += new System.EventHandler(this.oldpswtxt_Leave);
            // 
            // newpswtxt
            // 
            this.newpswtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newpswtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newpswtxt.ForeColor = System.Drawing.Color.Gray;
            this.newpswtxt.HintForeColor = System.Drawing.Color.Empty;
            this.newpswtxt.HintText = "";
            this.newpswtxt.isPassword = false;
            this.newpswtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.newpswtxt.LineIdleColor = System.Drawing.Color.DarkGray;
            this.newpswtxt.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.newpswtxt.LineThickness = 3;
            this.newpswtxt.Location = new System.Drawing.Point(281, 132);
            this.newpswtxt.Margin = new System.Windows.Forms.Padding(4);
            this.newpswtxt.Name = "newpswtxt";
            this.newpswtxt.Size = new System.Drawing.Size(320, 33);
            this.newpswtxt.TabIndex = 3;
            this.newpswtxt.Text = "enter new password here";
            this.newpswtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newpswtxt.Enter += new System.EventHandler(this.newpswtxt_Enter);
            this.newpswtxt.Leave += new System.EventHandler(this.newpswtxt_Leave);
            // 
            // cnfrmtxt
            // 
            this.cnfrmtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnfrmtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cnfrmtxt.ForeColor = System.Drawing.Color.Gray;
            this.cnfrmtxt.HintForeColor = System.Drawing.Color.Empty;
            this.cnfrmtxt.HintText = "";
            this.cnfrmtxt.isPassword = false;
            this.cnfrmtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.cnfrmtxt.LineIdleColor = System.Drawing.Color.DarkGray;
            this.cnfrmtxt.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.cnfrmtxt.LineThickness = 3;
            this.cnfrmtxt.Location = new System.Drawing.Point(281, 202);
            this.cnfrmtxt.Margin = new System.Windows.Forms.Padding(4);
            this.cnfrmtxt.Name = "cnfrmtxt";
            this.cnfrmtxt.Size = new System.Drawing.Size(320, 33);
            this.cnfrmtxt.TabIndex = 3;
            this.cnfrmtxt.Text = "confirm password";
            this.cnfrmtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cnfrmtxt.OnValueChanged += new System.EventHandler(this.cnfrmtxt_OnValueChanged);
            this.cnfrmtxt.Enter += new System.EventHandler(this.cnfrmtxt_Enter);
            this.cnfrmtxt.Leave += new System.EventHandler(this.cnfrmtxt_Leave);
            // 
            // eyebtn2
            // 
            this.eyebtn2.BackColor = System.Drawing.SystemColors.Control;
            this.eyebtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyebtn2.Image = ((System.Drawing.Image)(resources.GetObject("eyebtn2.Image")));
            this.eyebtn2.ImageActive = null;
            this.eyebtn2.Location = new System.Drawing.Point(231, 132);
            this.eyebtn2.Name = "eyebtn2";
            this.eyebtn2.Size = new System.Drawing.Size(43, 33);
            this.eyebtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyebtn2.TabIndex = 4;
            this.eyebtn2.TabStop = false;
            this.eyebtn2.Visible = false;
            this.eyebtn2.Zoom = 10;
            this.eyebtn2.Click += new System.EventHandler(this.eyebtn2_Click);
            // 
            // eyebtn3
            // 
            this.eyebtn3.BackColor = System.Drawing.SystemColors.Control;
            this.eyebtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyebtn3.Image = ((System.Drawing.Image)(resources.GetObject("eyebtn3.Image")));
            this.eyebtn3.ImageActive = null;
            this.eyebtn3.Location = new System.Drawing.Point(231, 202);
            this.eyebtn3.Name = "eyebtn3";
            this.eyebtn3.Size = new System.Drawing.Size(43, 33);
            this.eyebtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyebtn3.TabIndex = 4;
            this.eyebtn3.TabStop = false;
            this.eyebtn3.Visible = false;
            this.eyebtn3.Zoom = 10;
            this.eyebtn3.Click += new System.EventHandler(this.eyebtn3_Click);
            // 
            // eyebtn
            // 
            this.eyebtn.BackColor = System.Drawing.SystemColors.Control;
            this.eyebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyebtn.Image = global::Car_Rental_App.Properties.Resources.eye1;
            this.eyebtn.ImageActive = null;
            this.eyebtn.Location = new System.Drawing.Point(231, 65);
            this.eyebtn.Name = "eyebtn";
            this.eyebtn.Size = new System.Drawing.Size(43, 33);
            this.eyebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyebtn.TabIndex = 4;
            this.eyebtn.TabStop = false;
            this.eyebtn.Visible = false;
            this.eyebtn.Zoom = 10;
            this.eyebtn.Click += new System.EventHandler(this.eyebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.ImageActive = null;
            this.backbtn.Location = new System.Drawing.Point(16, 16);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(78, 67);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 2;
            this.backbtn.TabStop = false;
            this.backbtn.Zoom = 10;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.ActiveBorderThickness = 1;
            this.resetbtn.ActiveCornerRadius = 20;
            this.resetbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.resetbtn.ActiveForecolor = System.Drawing.Color.White;
            this.resetbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.resetbtn.BackColor = System.Drawing.SystemColors.Control;
            this.resetbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetbtn.BackgroundImage")));
            this.resetbtn.ButtonText = "Reset";
            this.resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.resetbtn.IdleBorderThickness = 1;
            this.resetbtn.IdleCornerRadius = 20;
            this.resetbtn.IdleFillColor = System.Drawing.Color.White;
            this.resetbtn.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetbtn.IdleLineColor = System.Drawing.Color.Black;
            this.resetbtn.Location = new System.Drawing.Point(390, 258);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(5);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(118, 32);
            this.resetbtn.TabIndex = 1;
            this.resetbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ResetPswUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eyebtn2);
            this.Controls.Add(this.eyebtn3);
            this.Controls.Add(this.eyebtn);
            this.Controls.Add(this.cnfrmtxt);
            this.Controls.Add(this.newpswtxt);
            this.Controls.Add(this.oldpswtxt);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.resetbtn);
            this.Name = "ResetPswUC";
            this.Size = new System.Drawing.Size(844, 340);
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 resetbtn;
        private Bunifu.Framework.UI.BunifuImageButton backbtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox oldpswtxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newpswtxt;
        private Bunifu.Framework.UI.BunifuImageButton eyebtn;
        private Bunifu.Framework.UI.BunifuImageButton eyebtn3;
        private Bunifu.Framework.UI.BunifuImageButton eyebtn2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnfrmtxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
