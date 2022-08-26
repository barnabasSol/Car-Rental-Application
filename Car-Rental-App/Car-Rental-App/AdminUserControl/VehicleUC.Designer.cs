
namespace Car_Rental_App.AdminUserControl
{
    partial class VehicleUC
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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.addvehiclebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.vpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addvehiclebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::Car_Rental_App.Properties.Resources.searchingcar;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(42, 64);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(61, 63);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // addvehiclebtn
            // 
            this.addvehiclebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.addvehiclebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addvehiclebtn.Image = global::Car_Rental_App.Properties.Resources.addcar;
            this.addvehiclebtn.ImageActive = null;
            this.addvehiclebtn.Location = new System.Drawing.Point(42, 203);
            this.addvehiclebtn.Margin = new System.Windows.Forms.Padding(2);
            this.addvehiclebtn.Name = "addvehiclebtn";
            this.addvehiclebtn.Size = new System.Drawing.Size(61, 63);
            this.addvehiclebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addvehiclebtn.TabIndex = 4;
            this.addvehiclebtn.TabStop = false;
            this.addvehiclebtn.Zoom = 10;
            this.addvehiclebtn.Click += new System.EventHandler(this.addvehiclebtn_Click);
            // 
            // vpanel
            // 
            this.vpanel.AutoScroll = true;
            this.vpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vpanel.Location = new System.Drawing.Point(120, 0);
            this.vpanel.Name = "vpanel";
            this.vpanel.Size = new System.Drawing.Size(611, 340);
            this.vpanel.TabIndex = 5;
            // 
            // VehicleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vpanel);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.addvehiclebtn);
            this.Name = "VehicleUC";
            this.Size = new System.Drawing.Size(844, 340);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addvehiclebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton addvehiclebtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel vpanel;
    }
}
