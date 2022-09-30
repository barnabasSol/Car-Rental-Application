
namespace Car_Rental_App.AdminUserControl
{
    partial class AddVehicleUCcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleUCcs));
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lptxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cnametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmodeltxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pphtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cartype_cbox = new System.Windows.Forms.ComboBox();
            this.cartypelbl = new System.Windows.Forms.Label();
            this.car_capacitylbl = new System.Windows.Forms.Label();
            this.ccapacity_cbox = new System.Windows.Forms.ComboBox();
            this.carcolorlbl = new System.Windows.Forms.Label();
            this.ccolor_cbox = new System.Windows.Forms.ComboBox();
            this.conditionlbl = new System.Windows.Forms.Label();
            this.car_condition_slider = new Bunifu.Framework.UI.BunifuSlider();
            this.car_rep_slider = new Bunifu.Framework.UI.BunifuSlider();
            this.car_rep = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.ccondition_valuelbl = new System.Windows.Forms.Label();
            this.repvaluelbl = new System.Windows.Forms.Label();
            this.undobtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.addbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undobtn)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(219, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(106, 21);
            this.title.TabIndex = 2;
            this.title.Text = "Add Vehicle";
            // 
            // lptxt
            // 
            this.lptxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lptxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lptxt.ForeColor = System.Drawing.Color.Gray;
            this.lptxt.HintForeColor = System.Drawing.Color.Empty;
            this.lptxt.HintText = "";
            this.lptxt.isPassword = false;
            this.lptxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lptxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.lptxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lptxt.LineThickness = 3;
            this.lptxt.Location = new System.Drawing.Point(120, 39);
            this.lptxt.Margin = new System.Windows.Forms.Padding(4);
            this.lptxt.Name = "lptxt";
            this.lptxt.Size = new System.Drawing.Size(320, 33);
            this.lptxt.TabIndex = 8;
            this.lptxt.Text = "enter license plate";
            this.lptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lptxt.Enter += new System.EventHandler(this.lptxt_Enter);
            this.lptxt.Leave += new System.EventHandler(this.lptxt_Leave);
            // 
            // cnametxt
            // 
            this.cnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cnametxt.ForeColor = System.Drawing.Color.Gray;
            this.cnametxt.HintForeColor = System.Drawing.Color.Empty;
            this.cnametxt.HintText = "";
            this.cnametxt.isPassword = false;
            this.cnametxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cnametxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.cnametxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cnametxt.LineThickness = 3;
            this.cnametxt.Location = new System.Drawing.Point(119, 93);
            this.cnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(320, 33);
            this.cnametxt.TabIndex = 8;
            this.cnametxt.Text = "enter car name";
            this.cnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cnametxt.Enter += new System.EventHandler(this.cnametxt_Enter);
            this.cnametxt.Leave += new System.EventHandler(this.cnametxt_Leave);
            // 
            // cmodeltxt
            // 
            this.cmodeltxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmodeltxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmodeltxt.ForeColor = System.Drawing.Color.Gray;
            this.cmodeltxt.HintForeColor = System.Drawing.Color.Empty;
            this.cmodeltxt.HintText = "";
            this.cmodeltxt.isPassword = false;
            this.cmodeltxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cmodeltxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.cmodeltxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cmodeltxt.LineThickness = 3;
            this.cmodeltxt.Location = new System.Drawing.Point(119, 266);
            this.cmodeltxt.Margin = new System.Windows.Forms.Padding(4);
            this.cmodeltxt.Name = "cmodeltxt";
            this.cmodeltxt.Size = new System.Drawing.Size(320, 33);
            this.cmodeltxt.TabIndex = 8;
            this.cmodeltxt.Text = "enter car model";
            this.cmodeltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmodeltxt.Enter += new System.EventHandler(this.cmodeltxt_Enter);
            this.cmodeltxt.Leave += new System.EventHandler(this.cmodeltxt_Leave);
            // 
            // pphtxt
            // 
            this.pphtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pphtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pphtxt.ForeColor = System.Drawing.Color.Gray;
            this.pphtxt.HintForeColor = System.Drawing.Color.Empty;
            this.pphtxt.HintText = "";
            this.pphtxt.isPassword = false;
            this.pphtxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pphtxt.LineIdleColor = System.Drawing.Color.DimGray;
            this.pphtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pphtxt.LineThickness = 3;
            this.pphtxt.Location = new System.Drawing.Point(119, 491);
            this.pphtxt.Margin = new System.Windows.Forms.Padding(4);
            this.pphtxt.Name = "pphtxt";
            this.pphtxt.Size = new System.Drawing.Size(320, 33);
            this.pphtxt.TabIndex = 8;
            this.pphtxt.Text = "price per hour";
            this.pphtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pphtxt.Enter += new System.EventHandler(this.pphtxt_Enter);
            this.pphtxt.Leave += new System.EventHandler(this.pphtxt_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cartype_cbox
            // 
            this.cartype_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cartype_cbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cartype_cbox.FormattingEnabled = true;
            this.cartype_cbox.Items.AddRange(new object[] {
            "coupe",
            "hatchback",
            "minivan",
            "sports car",
            "van",
            "supercar",
            "bus",
            "other"});
            this.cartype_cbox.Location = new System.Drawing.Point(119, 166);
            this.cartype_cbox.Name = "cartype_cbox";
            this.cartype_cbox.Size = new System.Drawing.Size(320, 21);
            this.cartype_cbox.TabIndex = 14;
            // 
            // cartypelbl
            // 
            this.cartypelbl.AutoSize = true;
            this.cartypelbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartypelbl.Location = new System.Drawing.Point(116, 142);
            this.cartypelbl.Name = "cartypelbl";
            this.cartypelbl.Size = new System.Drawing.Size(61, 17);
            this.cartypelbl.TabIndex = 15;
            this.cartypelbl.Text = "car type:";
            // 
            // car_capacitylbl
            // 
            this.car_capacitylbl.AutoSize = true;
            this.car_capacitylbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_capacitylbl.Location = new System.Drawing.Point(116, 206);
            this.car_capacitylbl.Name = "car_capacitylbl";
            this.car_capacitylbl.Size = new System.Drawing.Size(88, 17);
            this.car_capacitylbl.TabIndex = 17;
            this.car_capacitylbl.Text = "car capacity:";
            // 
            // ccapacity_cbox
            // 
            this.ccapacity_cbox.FormattingEnabled = true;
            this.ccapacity_cbox.Items.AddRange(new object[] {
            "2 seats",
            "4 seats",
            "8 seats",
            "12 seats",
            "24 seats"});
            this.ccapacity_cbox.Location = new System.Drawing.Point(119, 230);
            this.ccapacity_cbox.Name = "ccapacity_cbox";
            this.ccapacity_cbox.Size = new System.Drawing.Size(320, 21);
            this.ccapacity_cbox.TabIndex = 16;
            // 
            // carcolorlbl
            // 
            this.carcolorlbl.AutoSize = true;
            this.carcolorlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carcolorlbl.Location = new System.Drawing.Point(116, 312);
            this.carcolorlbl.Name = "carcolorlbl";
            this.carcolorlbl.Size = new System.Drawing.Size(65, 17);
            this.carcolorlbl.TabIndex = 19;
            this.carcolorlbl.Text = "car color:";
            // 
            // ccolor_cbox
            // 
            this.ccolor_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccolor_cbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccolor_cbox.FormattingEnabled = true;
            this.ccolor_cbox.Items.AddRange(new object[] {
            "gray",
            "silver",
            "black",
            "red",
            "yellow",
            "orange",
            "other"});
            this.ccolor_cbox.Location = new System.Drawing.Point(119, 336);
            this.ccolor_cbox.Name = "ccolor_cbox";
            this.ccolor_cbox.Size = new System.Drawing.Size(320, 21);
            this.ccolor_cbox.TabIndex = 18;
            // 
            // conditionlbl
            // 
            this.conditionlbl.AutoSize = true;
            this.conditionlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionlbl.Location = new System.Drawing.Point(116, 373);
            this.conditionlbl.Name = "conditionlbl";
            this.conditionlbl.Size = new System.Drawing.Size(91, 17);
            this.conditionlbl.TabIndex = 19;
            this.conditionlbl.Text = "car condition:";
            // 
            // car_condition_slider
            // 
            this.car_condition_slider.BackColor = System.Drawing.Color.Transparent;
            this.car_condition_slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.car_condition_slider.BorderRadius = 0;
            this.car_condition_slider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.car_condition_slider.Location = new System.Drawing.Point(120, 393);
            this.car_condition_slider.MaximumValue = 10;
            this.car_condition_slider.Name = "car_condition_slider";
            this.car_condition_slider.Size = new System.Drawing.Size(320, 30);
            this.car_condition_slider.TabIndex = 20;
            this.car_condition_slider.Value = 0;
            this.car_condition_slider.ValueChanged += new System.EventHandler(this.car_condition_slider_ValueChanged);
            this.car_condition_slider.MouseHover += new System.EventHandler(this.car_condition_slider_MouseHover);
            // 
            // car_rep_slider
            // 
            this.car_rep_slider.BackColor = System.Drawing.Color.Transparent;
            this.car_rep_slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.car_rep_slider.BorderRadius = 0;
            this.car_rep_slider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.car_rep_slider.Location = new System.Drawing.Point(120, 451);
            this.car_rep_slider.MaximumValue = 10;
            this.car_rep_slider.Name = "car_rep_slider";
            this.car_rep_slider.Size = new System.Drawing.Size(320, 30);
            this.car_rep_slider.TabIndex = 20;
            this.car_rep_slider.Value = 0;
            this.car_rep_slider.ValueChanged += new System.EventHandler(this.car_Rep_slider_ValueChanged);
            // 
            // car_rep
            // 
            this.car_rep.AutoSize = true;
            this.car_rep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_rep.Location = new System.Drawing.Point(117, 426);
            this.car_rep.Name = "car_rep";
            this.car_rep.Size = new System.Drawing.Size(110, 17);
            this.car_rep.TabIndex = 19;
            this.car_rep.Text = "car minimum rep:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "hint:";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // ccondition_valuelbl
            // 
            this.ccondition_valuelbl.AutoSize = true;
            this.ccondition_valuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccondition_valuelbl.Location = new System.Drawing.Point(462, 396);
            this.ccondition_valuelbl.Name = "ccondition_valuelbl";
            this.ccondition_valuelbl.Size = new System.Drawing.Size(14, 15);
            this.ccondition_valuelbl.TabIndex = 21;
            this.ccondition_valuelbl.Text = "0";
            // 
            // repvaluelbl
            // 
            this.repvaluelbl.AutoSize = true;
            this.repvaluelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repvaluelbl.Location = new System.Drawing.Point(462, 454);
            this.repvaluelbl.Name = "repvaluelbl";
            this.repvaluelbl.Size = new System.Drawing.Size(14, 15);
            this.repvaluelbl.TabIndex = 21;
            this.repvaluelbl.Text = "0";
            // 
            // undobtn
            // 
            this.undobtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.undobtn.Image = global::Car_Rental_App.Properties.Resources.undo_circular_arrow;
            this.undobtn.ImageActive = null;
            this.undobtn.Location = new System.Drawing.Point(326, 539);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(34, 28);
            this.undobtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.undobtn.TabIndex = 13;
            this.undobtn.TabStop = false;
            this.undobtn.Visible = false;
            this.undobtn.Zoom = 10;
            this.undobtn.Click += new System.EventHandler(this.undobtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.ActiveBorderThickness = 1;
            this.addbtn.ActiveCornerRadius = 20;
            this.addbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addbtn.ActiveForecolor = System.Drawing.Color.White;
            this.addbtn.ActiveLineColor = System.Drawing.Color.White;
            this.addbtn.BackColor = System.Drawing.SystemColors.Control;
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.ButtonText = "Add";
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.IdleBorderThickness = 1;
            this.addbtn.IdleCornerRadius = 20;
            this.addbtn.IdleFillColor = System.Drawing.SystemColors.ControlLight;
            this.addbtn.IdleForecolor = System.Drawing.Color.Black;
            this.addbtn.IdleLineColor = System.Drawing.Color.Black;
            this.addbtn.Location = new System.Drawing.Point(177, 533);
            this.addbtn.Margin = new System.Windows.Forms.Padding(5);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(137, 40);
            this.addbtn.TabIndex = 12;
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // AddVehicleUCcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.repvaluelbl);
            this.Controls.Add(this.ccondition_valuelbl);
            this.Controls.Add(this.car_rep_slider);
            this.Controls.Add(this.car_condition_slider);
            this.Controls.Add(this.car_rep);
            this.Controls.Add(this.conditionlbl);
            this.Controls.Add(this.carcolorlbl);
            this.Controls.Add(this.ccolor_cbox);
            this.Controls.Add(this.car_capacitylbl);
            this.Controls.Add(this.ccapacity_cbox);
            this.Controls.Add(this.cartypelbl);
            this.Controls.Add(this.cartype_cbox);
            this.Controls.Add(this.undobtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.pphtxt);
            this.Controls.Add(this.cmodeltxt);
            this.Controls.Add(this.cnametxt);
            this.Controls.Add(this.lptxt);
            this.Controls.Add(this.title);
            this.Name = "AddVehicleUCcs";
            this.Size = new System.Drawing.Size(550, 578);
            this.Load += new System.EventHandler(this.AddVehicleUCcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undobtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lptxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnametxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmodeltxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pphtxt;
        private Bunifu.Framework.UI.BunifuThinButton2 addbtn;
        private Bunifu.Framework.UI.BunifuImageButton undobtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cartype_cbox;
        private System.Windows.Forms.Label cartypelbl;
        private System.Windows.Forms.Label carcolorlbl;
        private System.Windows.Forms.ComboBox ccolor_cbox;
        private System.Windows.Forms.Label car_capacitylbl;
        private System.Windows.Forms.ComboBox ccapacity_cbox;
        private Bunifu.Framework.UI.BunifuSlider car_condition_slider;
        private System.Windows.Forms.Label conditionlbl;
        private Bunifu.Framework.UI.BunifuSlider car_rep_slider;
        private System.Windows.Forms.Label car_rep;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label repvaluelbl;
        private System.Windows.Forms.Label ccondition_valuelbl;
    }
}
