﻿
namespace Car_Rental_App.AdminUserControl
{
    partial class VehicleListUC
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
            this.allcarspanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // allcarspanel
            // 
            this.allcarspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allcarspanel.Location = new System.Drawing.Point(0, 0);
            this.allcarspanel.Name = "allcarspanel";
            this.allcarspanel.Size = new System.Drawing.Size(550, 578);
            this.allcarspanel.TabIndex = 0;
            // 
            // VehicleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.allcarspanel);
            this.Name = "VehicleCard";
            this.Size = new System.Drawing.Size(550, 578);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel allcarspanel;
    }
}
