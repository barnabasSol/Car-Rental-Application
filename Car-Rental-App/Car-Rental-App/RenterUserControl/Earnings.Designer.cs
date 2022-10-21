namespace Car_Rental_App.RenterUserControl
{
    partial class Earnings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Total_Amount_number = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EarningsDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.License_Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rental_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Vechicles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EarningsDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century", 20.2F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(111, 483);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(254, 40);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Total Amount :";
            // 
            // Total_Amount_number
            // 
            this.Total_Amount_number.AutoSize = true;
            this.Total_Amount_number.Font = new System.Drawing.Font("Century", 20.2F);
            this.Total_Amount_number.Location = new System.Drawing.Point(390, 483);
            this.Total_Amount_number.Name = "Total_Amount_number";
            this.Total_Amount_number.Size = new System.Drawing.Size(36, 40);
            this.Total_Amount_number.TabIndex = 4;
            this.Total_Amount_number.Text = "0";
            // 
            // EarningsDataGrid1
            // 
            this.EarningsDataGrid1.AllowUserToAddRows = false;
            this.EarningsDataGrid1.AllowUserToDeleteRows = false;
            this.EarningsDataGrid1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EarningsDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EarningsDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.EarningsDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EarningsDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EarningsDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EarningsDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EarningsDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.License_Plate,
            this.Car_Name,
            this.Branch,
            this.Customer_Name,
            this.Rental_Date,
            this.Total_Vechicles,
            this.Return_Date,
            this.Paid_Amount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EarningsDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.EarningsDataGrid1.DoubleBuffered = true;
            this.EarningsDataGrid1.EnableHeadersVisualStyles = false;
            this.EarningsDataGrid1.GridColor = System.Drawing.Color.White;
            this.EarningsDataGrid1.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.EarningsDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.EarningsDataGrid1.Location = new System.Drawing.Point(0, 3);
            this.EarningsDataGrid1.Name = "EarningsDataGrid1";
            this.EarningsDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EarningsDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EarningsDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EarningsDataGrid1.RowHeadersVisible = false;
            this.EarningsDataGrid1.RowHeadersWidth = 51;
            this.EarningsDataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EarningsDataGrid1.RowTemplate.Height = 24;
            this.EarningsDataGrid1.Size = new System.Drawing.Size(900, 477);
            this.EarningsDataGrid1.TabIndex = 6;
            // 
            // License_Plate
            // 
            this.License_Plate.HeaderText = "License Plate";
            this.License_Plate.MinimumWidth = 6;
            this.License_Plate.Name = "License_Plate";
            this.License_Plate.ReadOnly = true;
            this.License_Plate.Width = 80;
            // 
            // Car_Name
            // 
            this.Car_Name.HeaderText = "Car Name";
            this.Car_Name.MinimumWidth = 6;
            this.Car_Name.Name = "Car_Name";
            this.Car_Name.ReadOnly = true;
            this.Car_Name.Width = 80;
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Branch";
            this.Branch.MinimumWidth = 6;
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            this.Branch.Width = 80;
            // 
            // Customer_Name
            // 
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.MinimumWidth = 6;
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            this.Customer_Name.Width = 70;
            // 
            // Rental_Date
            // 
            this.Rental_Date.HeaderText = "Rental Date";
            this.Rental_Date.MinimumWidth = 6;
            this.Rental_Date.Name = "Rental_Date";
            this.Rental_Date.ReadOnly = true;
            this.Rental_Date.Width = 70;
            // 
            // Total_Vechicles
            // 
            this.Total_Vechicles.HeaderText = "Total Vechicles";
            this.Total_Vechicles.MinimumWidth = 6;
            this.Total_Vechicles.Name = "Total_Vechicles";
            this.Total_Vechicles.ReadOnly = true;
            this.Total_Vechicles.Width = 80;
            // 
            // Return_Date
            // 
            this.Return_Date.HeaderText = "Return Date";
            this.Return_Date.MinimumWidth = 6;
            this.Return_Date.Name = "Return_Date";
            this.Return_Date.ReadOnly = true;
            this.Return_Date.Width = 80;
            // 
            // Paid_Amount
            // 
            this.Paid_Amount.HeaderText = "Paid Amount";
            this.Paid_Amount.MinimumWidth = 6;
            this.Paid_Amount.Name = "Paid_Amount";
            this.Paid_Amount.ReadOnly = true;
            this.Paid_Amount.Width = 80;
            // 
            // Earnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EarningsDataGrid1);
            this.Controls.Add(this.Total_Amount_number);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "Earnings";
            this.Size = new System.Drawing.Size(900, 574);
            this.Load += new System.EventHandler(this.Earnings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EarningsDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Total_Amount_number;
        private Bunifu.Framework.UI.BunifuCustomDataGrid EarningsDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn License_Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rental_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Vechicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid_Amount;
    }
}
