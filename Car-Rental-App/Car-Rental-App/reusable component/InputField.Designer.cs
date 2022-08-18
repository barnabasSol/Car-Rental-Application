
namespace Car_Rental_App.reusable_component
{
    partial class InputField
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
            this.textbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.Window;
            this.textbox1.BorderColor = System.Drawing.Color.Linen;
            this.textbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox1.ForeColor = System.Drawing.Color.Silver;
            this.textbox1.Location = new System.Drawing.Point(0, 0);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(273, 20);
            this.textbox1.TabIndex = 0;
            this.textbox1.Text = "enter old password here";
            this.textbox1.Enter += new System.EventHandler(this.textbox1_Enter);
            this.textbox1.Leave += new System.EventHandler(this.textbox1_Leave);
            // 
            // InputField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textbox1);
            this.Name = "InputField";
            this.Size = new System.Drawing.Size(273, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox textbox1;
    }
}
