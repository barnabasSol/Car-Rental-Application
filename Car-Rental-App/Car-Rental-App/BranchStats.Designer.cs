
namespace Car_Rental_App
{
    partial class BranchStats
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
            this.bstatspanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.branchsrchtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bstatspanel
            // 
            this.bstatspanel.AutoScroll = true;
            this.bstatspanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bstatspanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bstatspanel.Location = new System.Drawing.Point(0, 69);
            this.bstatspanel.Name = "bstatspanel";
            this.bstatspanel.Size = new System.Drawing.Size(607, 259);
            this.bstatspanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Rental_App.Properties.Resources.icons8_search_30;
            this.pictureBox1.Location = new System.Drawing.Point(92, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // branchsrchtxt
            // 
            this.branchsrchtxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.branchsrchtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.branchsrchtxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.branchsrchtxt.BorderThickness = 3;
            this.branchsrchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.branchsrchtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.branchsrchtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.branchsrchtxt.isPassword = false;
            this.branchsrchtxt.Location = new System.Drawing.Point(125, 17);
            this.branchsrchtxt.Margin = new System.Windows.Forms.Padding(4);
            this.branchsrchtxt.Name = "branchsrchtxt";
            this.branchsrchtxt.Size = new System.Drawing.Size(370, 44);
            this.branchsrchtxt.TabIndex = 8;
            this.branchsrchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.branchsrchtxt.OnValueChanged += new System.EventHandler(this.branchsrchtxt_OnValueChanged_1);
            // 
            // BranchStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(607, 328);
            this.Controls.Add(this.branchsrchtxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bstatspanel);
            this.Name = "BranchStats";
            this.Text = "BranchStats";
            this.Load += new System.EventHandler(this.BranchStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bstatspanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox branchsrchtxt;
    }
}