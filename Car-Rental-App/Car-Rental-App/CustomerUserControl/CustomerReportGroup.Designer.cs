namespace Car_Rental_App.CustomerUserControl
{
    partial class CustomerReportGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReportGroup));
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.btnRate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(4, 20);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(52, 17);
            this.lblBranch.TabIndex = 0;
            this.lblBranch.Text = "label1";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lblTimeLeft.Location = new System.Drawing.Point(4, 46);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(46, 17);
            this.lblTimeLeft.TabIndex = 1;
            this.lblTimeLeft.Text = "label2";
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuRating1.Location = new System.Drawing.Point(392, 26);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(187, 27);
            this.bunifuRating1.TabIndex = 2;
            this.bunifuRating1.Value = 0;
            // 
            // btnRate
            // 
            this.btnRate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRate.BorderRadius = 0;
            this.btnRate.ButtonText = "Rate";
            this.btnRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRate.DisabledColor = System.Drawing.Color.Gray;
            this.btnRate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRate.Iconimage")));
            this.btnRate.Iconimage_right = null;
            this.btnRate.Iconimage_right_Selected = null;
            this.btnRate.Iconimage_Selected = null;
            this.btnRate.IconMarginLeft = 0;
            this.btnRate.IconMarginRight = 0;
            this.btnRate.IconRightVisible = true;
            this.btnRate.IconRightZoom = 0D;
            this.btnRate.IconVisible = true;
            this.btnRate.IconZoom = 90D;
            this.btnRate.IsTab = false;
            this.btnRate.Location = new System.Drawing.Point(604, 20);
            this.btnRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRate.Name = "btnRate";
            this.btnRate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnRate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnRate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRate.selected = false;
            this.btnRate.Size = new System.Drawing.Size(103, 40);
            this.btnRate.TabIndex = 3;
            this.btnRate.Text = "Rate";
            this.btnRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRate.Textcolor = System.Drawing.Color.White;
            this.btnRate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click_1);
            // 
            // CustomerReportGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblBranch);
            this.Name = "CustomerReportGroup";
            this.Size = new System.Drawing.Size(711, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblTimeLeft;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRate;
    }
}
