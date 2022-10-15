
namespace Car_Rental_App
{
    partial class EditVehicleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVehicleForm));
            this.repvaluelbl = new System.Windows.Forms.Label();
            this.cconditionlbl = new System.Windows.Forms.Label();
            this.car_rep_slider = new Bunifu.Framework.UI.BunifuSlider();
            this.car_condition_slider = new Bunifu.Framework.UI.BunifuSlider();
            this.car_rep = new System.Windows.Forms.Label();
            this.conditionlbl = new System.Windows.Forms.Label();
            this.carcolorlbl = new System.Windows.Forms.Label();
            this.ccolor_cbox = new System.Windows.Forms.ComboBox();
            this.car_capacitylbl = new System.Windows.Forms.Label();
            this.ccapacity_cbox = new System.Windows.Forms.ComboBox();
            this.cartypelbl = new System.Windows.Forms.Label();
            this.cartype_cbox = new System.Windows.Forms.ComboBox();
            this.pphlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cnamelbl = new System.Windows.Forms.Label();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmodeltxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lptxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cnametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pphtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.vstatuslbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.verifybtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.saveeditbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verifybtn)).BeginInit();
            this.SuspendLayout();
            // 
            // repvaluelbl
            // 
            this.repvaluelbl.AutoSize = true;
            this.repvaluelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repvaluelbl.Location = new System.Drawing.Point(263, 702);
            this.repvaluelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repvaluelbl.Name = "repvaluelbl";
            this.repvaluelbl.Size = new System.Drawing.Size(16, 18);
            this.repvaluelbl.TabIndex = 36;
            this.repvaluelbl.Text = "0";
            // 
            // cconditionlbl
            // 
            this.cconditionlbl.AutoSize = true;
            this.cconditionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cconditionlbl.Location = new System.Drawing.Point(236, 612);
            this.cconditionlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cconditionlbl.Name = "cconditionlbl";
            this.cconditionlbl.Size = new System.Drawing.Size(16, 18);
            this.cconditionlbl.TabIndex = 37;
            this.cconditionlbl.Text = "0";
            // 
            // car_rep_slider
            // 
            this.car_rep_slider.BackColor = System.Drawing.Color.Transparent;
            this.car_rep_slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.car_rep_slider.BorderRadius = 0;
            this.car_rep_slider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.car_rep_slider.Location = new System.Drawing.Point(121, 738);
            this.car_rep_slider.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.car_rep_slider.MaximumValue = 10;
            this.car_rep_slider.Name = "car_rep_slider";
            this.car_rep_slider.Size = new System.Drawing.Size(427, 35);
            this.car_rep_slider.TabIndex = 34;
            this.car_rep_slider.Value = 0;
            this.car_rep_slider.ValueChanged += new System.EventHandler(this.car_rep_slider_ValueChanged);
            // 
            // car_condition_slider
            // 
            this.car_condition_slider.BackColor = System.Drawing.Color.Transparent;
            this.car_condition_slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.car_condition_slider.BorderRadius = 0;
            this.car_condition_slider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.car_condition_slider.Location = new System.Drawing.Point(120, 646);
            this.car_condition_slider.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.car_condition_slider.MaximumValue = 10;
            this.car_condition_slider.Name = "car_condition_slider";
            this.car_condition_slider.Size = new System.Drawing.Size(427, 35);
            this.car_condition_slider.TabIndex = 35;
            this.car_condition_slider.Value = 0;
            this.car_condition_slider.ValueChanged += new System.EventHandler(this.car_condition_slider_ValueChanged);
            // 
            // car_rep
            // 
            this.car_rep.AutoSize = true;
            this.car_rep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_rep.Location = new System.Drawing.Point(116, 700);
            this.car_rep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.car_rep.Name = "car_rep";
            this.car_rep.Size = new System.Drawing.Size(134, 20);
            this.car_rep.TabIndex = 31;
            this.car_rep.Text = "car minimum rep:";
            // 
            // conditionlbl
            // 
            this.conditionlbl.AutoSize = true;
            this.conditionlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionlbl.Location = new System.Drawing.Point(112, 612);
            this.conditionlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionlbl.Name = "conditionlbl";
            this.conditionlbl.Size = new System.Drawing.Size(111, 20);
            this.conditionlbl.TabIndex = 32;
            this.conditionlbl.Text = "car condition:";
            // 
            // carcolorlbl
            // 
            this.carcolorlbl.AutoSize = true;
            this.carcolorlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carcolorlbl.Location = new System.Drawing.Point(112, 517);
            this.carcolorlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carcolorlbl.Name = "carcolorlbl";
            this.carcolorlbl.Size = new System.Drawing.Size(80, 20);
            this.carcolorlbl.TabIndex = 33;
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
            this.ccolor_cbox.Location = new System.Drawing.Point(116, 561);
            this.ccolor_cbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ccolor_cbox.Name = "ccolor_cbox";
            this.ccolor_cbox.Size = new System.Drawing.Size(425, 24);
            this.ccolor_cbox.TabIndex = 30;
            // 
            // car_capacitylbl
            // 
            this.car_capacitylbl.AutoSize = true;
            this.car_capacitylbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_capacitylbl.Location = new System.Drawing.Point(116, 338);
            this.car_capacitylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.car_capacitylbl.Name = "car_capacitylbl";
            this.car_capacitylbl.Size = new System.Drawing.Size(108, 20);
            this.car_capacitylbl.TabIndex = 29;
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
            this.ccapacity_cbox.Location = new System.Drawing.Point(120, 377);
            this.ccapacity_cbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ccapacity_cbox.Name = "ccapacity_cbox";
            this.ccapacity_cbox.Size = new System.Drawing.Size(425, 24);
            this.ccapacity_cbox.TabIndex = 28;
            // 
            // cartypelbl
            // 
            this.cartypelbl.AutoSize = true;
            this.cartypelbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartypelbl.Location = new System.Drawing.Point(117, 240);
            this.cartypelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cartypelbl.Name = "cartypelbl";
            this.cartypelbl.Size = new System.Drawing.Size(75, 20);
            this.cartypelbl.TabIndex = 27;
            this.cartypelbl.Text = "car type:";
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
            this.cartype_cbox.Location = new System.Drawing.Point(116, 282);
            this.cartype_cbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cartype_cbox.Name = "cartype_cbox";
            this.cartype_cbox.Size = new System.Drawing.Size(425, 24);
            this.cartype_cbox.TabIndex = 26;
            // 
            // pphlbl
            // 
            this.pphlbl.AutoSize = true;
            this.pphlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pphlbl.Location = new System.Drawing.Point(117, 778);
            this.pphlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pphlbl.Name = "pphlbl";
            this.pphlbl.Size = new System.Drawing.Size(117, 20);
            this.pphlbl.TabIndex = 31;
            this.pphlbl.Text = "price per hour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "car model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "license plate no:";
            // 
            // cnamelbl
            // 
            this.cnamelbl.AutoSize = true;
            this.cnamelbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnamelbl.Location = new System.Drawing.Point(117, 149);
            this.cnamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cnamelbl.Name = "cnamelbl";
            this.cnamelbl.Size = new System.Drawing.Size(84, 20);
            this.cnamelbl.TabIndex = 40;
            this.cnamelbl.Text = "car name:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(261, 11);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 23);
            this.title.TabIndex = 41;
            this.title.Text = "Edit Vehicle";
            // 
            // cmodeltxt
            // 
            this.cmodeltxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmodeltxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmodeltxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmodeltxt.HintForeColor = System.Drawing.Color.Empty;
            this.cmodeltxt.HintText = "";
            this.cmodeltxt.isPassword = false;
            this.cmodeltxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cmodeltxt.LineIdleColor = System.Drawing.Color.Gray;
            this.cmodeltxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cmodeltxt.LineThickness = 3;
            this.cmodeltxt.Location = new System.Drawing.Point(116, 458);
            this.cmodeltxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmodeltxt.Name = "cmodeltxt";
            this.cmodeltxt.Size = new System.Drawing.Size(432, 41);
            this.cmodeltxt.TabIndex = 42;
            this.cmodeltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lptxt
            // 
            this.lptxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lptxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lptxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lptxt.HintForeColor = System.Drawing.Color.Empty;
            this.lptxt.HintText = "";
            this.lptxt.isPassword = false;
            this.lptxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lptxt.LineIdleColor = System.Drawing.Color.Gray;
            this.lptxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lptxt.LineThickness = 3;
            this.lptxt.Location = new System.Drawing.Point(121, 81);
            this.lptxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lptxt.Name = "lptxt";
            this.lptxt.Size = new System.Drawing.Size(432, 41);
            this.lptxt.TabIndex = 43;
            this.lptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cnametxt
            // 
            this.cnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cnametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnametxt.HintForeColor = System.Drawing.Color.Empty;
            this.cnametxt.HintText = "";
            this.cnametxt.isPassword = false;
            this.cnametxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cnametxt.LineIdleColor = System.Drawing.Color.Gray;
            this.cnametxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cnametxt.LineThickness = 3;
            this.cnametxt.Location = new System.Drawing.Point(121, 175);
            this.cnametxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(432, 41);
            this.cnametxt.TabIndex = 43;
            this.cnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pphtxt
            // 
            this.pphtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pphtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pphtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pphtxt.HintForeColor = System.Drawing.Color.Empty;
            this.pphtxt.HintText = "";
            this.pphtxt.isPassword = false;
            this.pphtxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pphtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.pphtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.pphtxt.LineThickness = 3;
            this.pphtxt.Location = new System.Drawing.Point(116, 804);
            this.pphtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pphtxt.Name = "pphtxt";
            this.pphtxt.Size = new System.Drawing.Size(432, 41);
            this.pphtxt.TabIndex = 42;
            this.pphtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // vstatuslbl
            // 
            this.vstatuslbl.AutoSize = true;
            this.vstatuslbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vstatuslbl.Location = new System.Drawing.Point(607, 70);
            this.vstatuslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vstatuslbl.Name = "vstatuslbl";
            this.vstatuslbl.Size = new System.Drawing.Size(65, 20);
            this.vstatuslbl.TabIndex = 46;
            this.vstatuslbl.Text = "verified";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // verifybtn
            // 
            this.verifybtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.verifybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifybtn.Image = global::Car_Rental_App.Properties.Resources.unverified1;
            this.verifybtn.ImageActive = null;
            this.verifybtn.Location = new System.Drawing.Point(615, 14);
            this.verifybtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifybtn.Name = "verifybtn";
            this.verifybtn.Size = new System.Drawing.Size(67, 55);
            this.verifybtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verifybtn.TabIndex = 45;
            this.verifybtn.TabStop = false;
            this.verifybtn.Zoom = 10;
            this.verifybtn.Click += new System.EventHandler(this.verifybtn_Click);
            // 
            // saveeditbtn
            // 
            this.saveeditbtn.ActiveBorderThickness = 1;
            this.saveeditbtn.ActiveCornerRadius = 20;
            this.saveeditbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.saveeditbtn.ActiveForecolor = System.Drawing.Color.White;
            this.saveeditbtn.ActiveLineColor = System.Drawing.Color.White;
            this.saveeditbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveeditbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveeditbtn.BackgroundImage")));
            this.saveeditbtn.ButtonText = "Save Changes";
            this.saveeditbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveeditbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveeditbtn.ForeColor = System.Drawing.Color.Black;
            this.saveeditbtn.IdleBorderThickness = 1;
            this.saveeditbtn.IdleCornerRadius = 20;
            this.saveeditbtn.IdleFillColor = System.Drawing.SystemColors.ControlLight;
            this.saveeditbtn.IdleForecolor = System.Drawing.Color.Black;
            this.saveeditbtn.IdleLineColor = System.Drawing.Color.Black;
            this.saveeditbtn.Location = new System.Drawing.Point(236, 855);
            this.saveeditbtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.saveeditbtn.Name = "saveeditbtn";
            this.saveeditbtn.Size = new System.Drawing.Size(197, 49);
            this.saveeditbtn.TabIndex = 38;
            this.saveeditbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveeditbtn.Click += new System.EventHandler(this.saveeditbtn_Click);
            // 
            // EditVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(712, 663);
            this.Controls.Add(this.vstatuslbl);
            this.Controls.Add(this.verifybtn);
            this.Controls.Add(this.cnametxt);
            this.Controls.Add(this.lptxt);
            this.Controls.Add(this.pphtxt);
            this.Controls.Add(this.cmodeltxt);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cnamelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveeditbtn);
            this.Controls.Add(this.repvaluelbl);
            this.Controls.Add(this.cconditionlbl);
            this.Controls.Add(this.car_rep_slider);
            this.Controls.Add(this.car_condition_slider);
            this.Controls.Add(this.pphlbl);
            this.Controls.Add(this.car_rep);
            this.Controls.Add(this.conditionlbl);
            this.Controls.Add(this.carcolorlbl);
            this.Controls.Add(this.ccolor_cbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.car_capacitylbl);
            this.Controls.Add(this.ccapacity_cbox);
            this.Controls.Add(this.cartypelbl);
            this.Controls.Add(this.cartype_cbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditVehicleForm";
            this.Text = "EditVehicleForm";
            this.Load += new System.EventHandler(this.EditVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verifybtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label repvaluelbl;
        private System.Windows.Forms.Label cconditionlbl;
        private Bunifu.Framework.UI.BunifuSlider car_rep_slider;
        private Bunifu.Framework.UI.BunifuSlider car_condition_slider;
        private System.Windows.Forms.Label car_rep;
        private System.Windows.Forms.Label conditionlbl;
        private System.Windows.Forms.Label carcolorlbl;
        private System.Windows.Forms.ComboBox ccolor_cbox;
        private System.Windows.Forms.Label car_capacitylbl;
        private System.Windows.Forms.ComboBox ccapacity_cbox;
        private System.Windows.Forms.Label cartypelbl;
        private System.Windows.Forms.ComboBox cartype_cbox;
        private Bunifu.Framework.UI.BunifuThinButton2 saveeditbtn;
        private System.Windows.Forms.Label pphlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cnamelbl;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmodeltxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lptxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnametxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pphtxt;
        private Bunifu.Framework.UI.BunifuImageButton verifybtn;
        private System.Windows.Forms.Label vstatuslbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}