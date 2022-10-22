namespace Car_Rental_App.CustomerUserControl
{
    partial class BrowseVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseVehicles));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchField = new Bunifu.Framework.UI.BunifuTextbox();
            this.pnlSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinalize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.pnlLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlSearch);
            this.pnlLeft.Controls.Add(this.panel3);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(3);
            this.pnlLeft.Size = new System.Drawing.Size(421, 418);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.AutoScroll = true;
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(3, 59);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.pnlSearch.Size = new System.Drawing.Size(415, 356);
            this.pnlSearch.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchField);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 56);
            this.panel3.TabIndex = 0;
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.SystemColors.Control;
            this.searchField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchField.BackgroundImage")));
            this.searchField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.searchField.Icon = ((System.Drawing.Image)(resources.GetObject("searchField.Icon")));
            this.searchField.Location = new System.Drawing.Point(48, 4);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(254, 46);
            this.searchField.TabIndex = 0;
            this.searchField.text = "";
            this.searchField.OnTextChange += new System.EventHandler(this.searchField_OnTextChange);
            // 
            // pnlSelected
            // 
            this.pnlSelected.AutoScroll = true;
            this.pnlSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelected.Location = new System.Drawing.Point(0, 59);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Padding = new System.Windows.Forms.Padding(3);
            this.pnlSelected.Size = new System.Drawing.Size(420, 359);
            this.pnlSelected.TabIndex = 1;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnFinalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalize.BorderRadius = 3;
            this.btnFinalize.ButtonText = "Finalize Purchase";
            this.btnFinalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalize.DisabledColor = System.Drawing.Color.Gray;
            this.btnFinalize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFinalize.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFinalize.Iconimage")));
            this.btnFinalize.Iconimage_right = null;
            this.btnFinalize.Iconimage_right_Selected = null;
            this.btnFinalize.Iconimage_Selected = null;
            this.btnFinalize.IconMarginLeft = 0;
            this.btnFinalize.IconMarginRight = 0;
            this.btnFinalize.IconRightVisible = true;
            this.btnFinalize.IconRightZoom = 0D;
            this.btnFinalize.IconVisible = true;
            this.btnFinalize.IconZoom = 90D;
            this.btnFinalize.IsTab = false;
            this.btnFinalize.Location = new System.Drawing.Point(268, 8);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnFinalize.OnHovercolor = System.Drawing.Color.Brown;
            this.btnFinalize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFinalize.selected = false;
            this.btnFinalize.Size = new System.Drawing.Size(132, 48);
            this.btnFinalize.TabIndex = 2;
            this.btnFinalize.Text = "Finalize Purchase";
            this.btnFinalize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalize.Textcolor = System.Drawing.Color.White;
            this.btnFinalize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlSelected);
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(424, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(420, 418);
            this.pnlRight.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.btnFinalize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Return Date";
            // 
            // datePicker
            // 
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(3, 30);
            this.datePicker.MinDate = new System.DateTime(2022, 10, 20, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(259, 23);
            this.datePicker.TabIndex = 3;
            // 
            // BrowseVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Name = "BrowseVehicles";
            this.Size = new System.Drawing.Size(844, 418);
            this.Load += new System.EventHandler(this.BrowseVehicles_Load);
            this.pnlLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel pnlSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlSelected;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinalize;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox searchField;
    }
}
