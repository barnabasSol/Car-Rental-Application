namespace Car_Rental_App.AdminUserControl
{
    partial class HomeUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.auditdatagridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterbylbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.searchtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filteroldestlbl = new Bunifu.Framework.UI.BunifuThinButton2();
            this.filterlatestlbl = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.auditdatagridview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // auditdatagridview
            // 
            this.auditdatagridview.AllowUserToAddRows = false;
            this.auditdatagridview.AllowUserToDeleteRows = false;
            this.auditdatagridview.AllowUserToResizeColumns = false;
            this.auditdatagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.auditdatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.auditdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.auditdatagridview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.auditdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.auditdatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.auditdatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.auditdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auditdatagridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.auditdatagridview.DoubleBuffered = true;
            this.auditdatagridview.EnableHeadersVisualStyles = false;
            this.auditdatagridview.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.auditdatagridview.HeaderForeColor = System.Drawing.Color.White;
            this.auditdatagridview.Location = new System.Drawing.Point(0, 0);
            this.auditdatagridview.Name = "auditdatagridview";
            this.auditdatagridview.ReadOnly = true;
            this.auditdatagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.auditdatagridview.RowHeadersVisible = false;
            this.auditdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.auditdatagridview.Size = new System.Drawing.Size(844, 194);
            this.auditdatagridview.TabIndex = 0;
            this.auditdatagridview.SelectionChanged += new System.EventHandler(this.auditdatagridview_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.auditdatagridview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 194);
            this.panel1.TabIndex = 1;
            // 
            // filterbylbl
            // 
            this.filterbylbl.AutoSize = true;
            this.filterbylbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterbylbl.Location = new System.Drawing.Point(520, 116);
            this.filterbylbl.Name = "filterbylbl";
            this.filterbylbl.Size = new System.Drawing.Size(58, 17);
            this.filterbylbl.TabIndex = 2;
            this.filterbylbl.Text = "filter by:";
            // 
            // searchtxt
            // 
            this.searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchtxt.HintForeColor = System.Drawing.Color.Empty;
            this.searchtxt.HintText = "";
            this.searchtxt.isPassword = false;
            this.searchtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.searchtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchtxt.LineThickness = 3;
            this.searchtxt.Location = new System.Drawing.Point(61, 103);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(379, 33);
            this.searchtxt.TabIndex = 4;
            this.searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchtxt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Rental_App.Properties.Resources.icons8_search_30;
            this.pictureBox1.Location = new System.Drawing.Point(32, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // filteroldestlbl
            // 
            this.filteroldestlbl.ActiveBorderThickness = 1;
            this.filteroldestlbl.ActiveCornerRadius = 20;
            this.filteroldestlbl.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.filteroldestlbl.ActiveForecolor = System.Drawing.Color.White;
            this.filteroldestlbl.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.filteroldestlbl.BackColor = System.Drawing.SystemColors.Control;
            this.filteroldestlbl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filteroldestlbl.BackgroundImage")));
            this.filteroldestlbl.ButtonText = "oldest";
            this.filteroldestlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filteroldestlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteroldestlbl.ForeColor = System.Drawing.Color.SeaGreen;
            this.filteroldestlbl.IdleBorderThickness = 1;
            this.filteroldestlbl.IdleCornerRadius = 20;
            this.filteroldestlbl.IdleFillColor = System.Drawing.Color.White;
            this.filteroldestlbl.IdleForecolor = System.Drawing.Color.Black;
            this.filteroldestlbl.IdleLineColor = System.Drawing.Color.Black;
            this.filteroldestlbl.Location = new System.Drawing.Point(708, 106);
            this.filteroldestlbl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filteroldestlbl.Name = "filteroldestlbl";
            this.filteroldestlbl.Size = new System.Drawing.Size(104, 37);
            this.filteroldestlbl.TabIndex = 3;
            this.filteroldestlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filteroldestlbl.Click += new System.EventHandler(this.filteroldestlbl_Click);
            // 
            // filterlatestlbl
            // 
            this.filterlatestlbl.ActiveBorderThickness = 1;
            this.filterlatestlbl.ActiveCornerRadius = 20;
            this.filterlatestlbl.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.filterlatestlbl.ActiveForecolor = System.Drawing.Color.White;
            this.filterlatestlbl.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.filterlatestlbl.BackColor = System.Drawing.SystemColors.Control;
            this.filterlatestlbl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filterlatestlbl.BackgroundImage")));
            this.filterlatestlbl.ButtonText = "latest";
            this.filterlatestlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterlatestlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterlatestlbl.ForeColor = System.Drawing.Color.SeaGreen;
            this.filterlatestlbl.IdleBorderThickness = 1;
            this.filterlatestlbl.IdleCornerRadius = 20;
            this.filterlatestlbl.IdleFillColor = System.Drawing.Color.White;
            this.filterlatestlbl.IdleForecolor = System.Drawing.Color.Black;
            this.filterlatestlbl.IdleLineColor = System.Drawing.Color.Black;
            this.filterlatestlbl.Location = new System.Drawing.Point(584, 106);
            this.filterlatestlbl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterlatestlbl.Name = "filterlatestlbl";
            this.filterlatestlbl.Size = new System.Drawing.Size(104, 37);
            this.filterlatestlbl.TabIndex = 3;
            this.filterlatestlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterlatestlbl.Click += new System.EventHandler(this.filterlatestlbl_Click);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.filteroldestlbl);
            this.Controls.Add(this.filterlatestlbl);
            this.Controls.Add(this.filterbylbl);
            this.Controls.Add(this.panel1);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(844, 340);
            this.Load += new System.EventHandler(this.HomeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auditdatagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid auditdatagridview;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel filterbylbl;
        private Bunifu.Framework.UI.BunifuThinButton2 filterlatestlbl;
        private Bunifu.Framework.UI.BunifuThinButton2 filteroldestlbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
