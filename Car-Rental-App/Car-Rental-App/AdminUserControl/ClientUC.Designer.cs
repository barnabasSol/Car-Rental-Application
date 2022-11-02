
namespace Car_Rental_App.AdminUserControl
{
    partial class ClientUC
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
            this.search_user_client_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchclienttxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.slow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_user_client_panel
            // 
            this.search_user_client_panel.AutoScroll = true;
            this.search_user_client_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.search_user_client_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.search_user_client_panel.Location = new System.Drawing.Point(396, 0);
            this.search_user_client_panel.Name = "search_user_client_panel";
            this.search_user_client_panel.Size = new System.Drawing.Size(463, 340);
            this.search_user_client_panel.TabIndex = 6;
            // 
            // searchclienttxt
            // 
            this.searchclienttxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.searchclienttxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchclienttxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(94)))), ((int)(((byte)(135)))));
            this.searchclienttxt.BorderThickness = 3;
            this.searchclienttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchclienttxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchclienttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchclienttxt.isPassword = false;
            this.searchclienttxt.Location = new System.Drawing.Point(6, 145);
            this.searchclienttxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchclienttxt.Name = "searchclienttxt";
            this.searchclienttxt.Size = new System.Drawing.Size(370, 44);
            this.searchclienttxt.TabIndex = 7;
            this.searchclienttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchclienttxt.OnValueChanged += new System.EventHandler(this.searchcustomer_OnValueChanged_1);
            this.searchclienttxt.Enter += new System.EventHandler(this.searchcustomer_Enter);
            // 
            // slow
            // 
            this.slow.Interval = 200;
            this.slow.Tick += new System.EventHandler(this.slow_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Rental_App.Properties.Resources.user_search;
            this.pictureBox1.Location = new System.Drawing.Point(171, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Customer",
            "Renter"});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "customer",
            "renter"});
            this.comboBox1.Location = new System.Drawing.Point(78, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClientUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchclienttxt);
            this.Controls.Add(this.search_user_client_panel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientUC";
            this.Size = new System.Drawing.Size(859, 340);
            this.Load += new System.EventHandler(this.ClientUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel search_user_client_panel;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchclienttxt;
        private System.Windows.Forms.Timer slow;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
