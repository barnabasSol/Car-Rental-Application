
namespace Car_Rental_App.AdminUserControl
{
    partial class CustomerUC
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
            this.customer_search_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchcustomer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.slow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_search_panel
            // 
            this.customer_search_panel.AutoScroll = true;
            this.customer_search_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customer_search_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.customer_search_panel.Location = new System.Drawing.Point(391, 0);
            this.customer_search_panel.Name = "customer_search_panel";
            this.customer_search_panel.Size = new System.Drawing.Size(453, 340);
            this.customer_search_panel.TabIndex = 6;
            // 
            // searchcustomer
            // 
            this.searchcustomer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.searchcustomer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchcustomer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.searchcustomer.BorderThickness = 3;
            this.searchcustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchcustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchcustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchcustomer.isPassword = false;
            this.searchcustomer.Location = new System.Drawing.Point(10, 143);
            this.searchcustomer.Margin = new System.Windows.Forms.Padding(4);
            this.searchcustomer.Name = "searchcustomer";
            this.searchcustomer.Size = new System.Drawing.Size(370, 44);
            this.searchcustomer.TabIndex = 7;
            this.searchcustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchcustomer.OnValueChanged += new System.EventHandler(this.searchcustomer_OnValueChanged_1);
            this.searchcustomer.Enter += new System.EventHandler(this.searchcustomer_Enter);
            // 
            // slow
            // 
            this.slow.Interval = 200;
            this.slow.Tick += new System.EventHandler(this.slow_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Rental_App.Properties.Resources.user_search;
            this.pictureBox1.Location = new System.Drawing.Point(160, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchcustomer);
            this.Controls.Add(this.customer_search_panel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(844, 340);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel customer_search_panel;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchcustomer;
        private System.Windows.Forms.Timer slow;
    }
}
