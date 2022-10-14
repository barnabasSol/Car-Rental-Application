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
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlSelected = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinalize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlSearch.Size = new System.Drawing.Size(415, 356);
            this.pnlSearch.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 56);
            this.panel3.TabIndex = 0;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(34, 16);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(336, 33);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // pnlSelected
            // 
            this.pnlSelected.AutoScroll = true;
            this.pnlSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelected.Location = new System.Drawing.Point(0, 59);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Padding = new System.Windows.Forms.Padding(3);
            this.pnlSelected.Size = new System.Drawing.Size(360, 359);
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
            this.btnFinalize.Location = new System.Drawing.Point(56, 5);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnFinalize.OnHovercolor = System.Drawing.Color.Brown;
            this.btnFinalize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFinalize.selected = false;
            this.btnFinalize.Size = new System.Drawing.Size(241, 48);
            this.btnFinalize.TabIndex = 2;
            this.btnFinalize.Text = "Finalize Purchase";
            this.btnFinalize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalize.Textcolor = System.Drawing.Color.White;
            this.btnFinalize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlSelected);
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(424, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(360, 418);
            this.pnlRight.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFinalize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 59);
            this.panel1.TabIndex = 0;
            // 
            // BrowseVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Name = "BrowseVehicles";
            this.Size = new System.Drawing.Size(784, 418);
            this.Load += new System.EventHandler(this.BrowseVehicles_Load);
            this.pnlLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.FlowLayoutPanel pnlSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlSelected;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinalize;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel1;
    }
}
