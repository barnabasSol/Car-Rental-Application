
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
            this.verifybtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.saveeditbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.vstatuslbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.verifybtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // repvaluelbl
            // 
            this.repvaluelbl.AutoSize = true;
            this.repvaluelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repvaluelbl.Location = new System.Drawing.Point(197, 570);
            this.repvaluelbl.Name = "repvaluelbl";
            this.repvaluelbl.Size = new System.Drawing.Size(14, 15);
            this.repvaluelbl.TabIndex = 36;
            this.repvaluelbl.Text = "0";
            // 
            // cconditionlbl
            // 
            this.cconditionlbl.AutoSize = true;
            this.cconditionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cconditionlbl.Location = new System.Drawing.Point(177, 497);
            this.cconditionlbl.Name = "cconditionlbl";
            this.cconditionlbl.Size = new System.Drawing.Size(14, 15);
            this.cconditionlbl.TabIndex = 37;
            this.cconditionlbl.Text = "0";
            // 
            // car_rep_slider
            // 
            this.car_rep_slider.BackColor = System.Drawing.Color.Transparent;
            this.car_rep_slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.car_rep_slider.BorderRadius = 0;
            this.car_rep_slider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.car_rep_slider.Location = new System.Drawing.Point(91, 600);
            this.car_rep_slider.MaximumValue = 10;
            this.car_rep_slider.Name = "car_rep_slider";
            this.car_rep_slider.Size = new System.Drawing.Size(320, 30);
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
            this.car_condition_slider.Location = new System.Drawing.Point(90, 525);
            this.car_condition_slider.MaximumValue = 10;
            this.car_condition_slider.Name = "car_condition_slider";
            this.car_condition_slider.Size = new System.Drawing.Size(320, 30);
            this.car_condition_slider.TabIndex = 35;
            this.car_condition_slider.Value = 0;
            this.car_condition_slider.ValueChanged += new System.EventHandler(this.car_condition_slider_ValueChanged);
            // 
            // car_rep
            // 
            this.car_rep.AutoSize = true;
            this.car_rep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_rep.Location = new System.Drawing.Point(87, 569);
            this.car_rep.Name = "car_rep";
            this.car_rep.Size = new System.Drawing.Size(110, 17);
            this.car_rep.TabIndex = 31;
            this.car_rep.Text = "car minimum rep:";
            // 
            // conditionlbl
            // 
            this.conditionlbl.AutoSize = true;
            this.conditionlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionlbl.Location = new System.Drawing.Point(84, 497);
            this.conditionlbl.Name = "conditionlbl";
            this.conditionlbl.Size = new System.Drawing.Size(91, 17);
            this.conditionlbl.TabIndex = 32;
            this.conditionlbl.Text = "car condition:";
            // 
            // carcolorlbl
            // 
            this.carcolorlbl.AutoSize = true;
            this.carcolorlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carcolorlbl.Location = new System.Drawing.Point(84, 420);
            this.carcolorlbl.Name = "carcolorlbl";
            this.carcolorlbl.Size = new System.Drawing.Size(65, 17);
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
            this.ccolor_cbox.Location = new System.Drawing.Point(87, 456);
            this.ccolor_cbox.Name = "ccolor_cbox";
            this.ccolor_cbox.Size = new System.Drawing.Size(320, 21);
            this.ccolor_cbox.TabIndex = 30;
            // 
            // car_capacitylbl
            // 
            this.car_capacitylbl.AutoSize = true;
            this.car_capacitylbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_capacitylbl.Location = new System.Drawing.Point(87, 275);
            this.car_capacitylbl.Name = "car_capacitylbl";
            this.car_capacitylbl.Size = new System.Drawing.Size(88, 17);
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
            this.ccapacity_cbox.Location = new System.Drawing.Point(90, 306);
            this.ccapacity_cbox.Name = "ccapacity_cbox";
            this.ccapacity_cbox.Size = new System.Drawing.Size(320, 21);
            this.ccapacity_cbox.TabIndex = 28;
            // 
            // cartypelbl
            // 
            this.cartypelbl.AutoSize = true;
            this.cartypelbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartypelbl.Location = new System.Drawing.Point(88, 195);
            this.cartypelbl.Name = "cartypelbl";
            this.cartypelbl.Size = new System.Drawing.Size(61, 17);
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
            this.cartype_cbox.Location = new System.Drawing.Point(87, 229);
            this.cartype_cbox.Name = "cartype_cbox";
            this.cartype_cbox.Size = new System.Drawing.Size(320, 21);
            this.cartype_cbox.TabIndex = 26;
            // 
            // pphlbl
            // 
            this.pphlbl.AutoSize = true;
            this.pphlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pphlbl.Location = new System.Drawing.Point(88, 632);
            this.pphlbl.Name = "pphlbl";
            this.pphlbl.Size = new System.Drawing.Size(94, 17);
            this.pphlbl.TabIndex = 31;
            this.pphlbl.Text = "price per hour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "car model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "license plate no:";
            // 
            // cnamelbl
            // 
            this.cnamelbl.AutoSize = true;
            this.cnamelbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnamelbl.Location = new System.Drawing.Point(88, 121);
            this.cnamelbl.Name = "cnamelbl";
            this.cnamelbl.Size = new System.Drawing.Size(68, 17);
            this.cnamelbl.TabIndex = 40;
            this.cnamelbl.Text = "car name:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(196, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(101, 21);
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
            this.cmodeltxt.Location = new System.Drawing.Point(87, 372);
            this.cmodeltxt.Margin = new System.Windows.Forms.Padding(4);
            this.cmodeltxt.Name = "cmodeltxt";
            this.cmodeltxt.Size = new System.Drawing.Size(324, 33);
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
            this.lptxt.Location = new System.Drawing.Point(91, 66);
            this.lptxt.Margin = new System.Windows.Forms.Padding(4);
            this.lptxt.Name = "lptxt";
            this.lptxt.Size = new System.Drawing.Size(324, 33);
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
            this.cnametxt.Location = new System.Drawing.Point(91, 142);
            this.cnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(324, 33);
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
            this.pphtxt.Location = new System.Drawing.Point(87, 653);
            this.pphtxt.Margin = new System.Windows.Forms.Padding(4);
            this.pphtxt.Name = "pphtxt";
            this.pphtxt.Size = new System.Drawing.Size(324, 33);
            this.pphtxt.TabIndex = 42;
            this.pphtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // verifybtn
            // 
            this.verifybtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.verifybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifybtn.Image = global::Car_Rental_App.Properties.Resources.unverified1;
            this.verifybtn.ImageActive = null;
            this.verifybtn.Location = new System.Drawing.Point(461, 11);
            this.verifybtn.Margin = new System.Windows.Forms.Padding(2);
            this.verifybtn.Name = "verifybtn";
            this.verifybtn.Size = new System.Drawing.Size(50, 45);
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
            this.saveeditbtn.Location = new System.Drawing.Point(177, 695);
            this.saveeditbtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveeditbtn.Name = "saveeditbtn";
            this.saveeditbtn.Size = new System.Drawing.Size(148, 40);
            this.saveeditbtn.TabIndex = 38;
            this.saveeditbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveeditbtn.Click += new System.EventHandler(this.saveeditbtn_Click);
            // 
            // vstatuslbl
            // 
            this.vstatuslbl.AutoSize = true;
            this.vstatuslbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vstatuslbl.Location = new System.Drawing.Point(455, 57);
            this.vstatuslbl.Name = "vstatuslbl";
            this.vstatuslbl.Size = new System.Drawing.Size(54, 17);
            this.vstatuslbl.TabIndex = 46;
            this.vstatuslbl.Text = "verified";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // EditVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(534, 539);
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
            this.Name = "EditVehicleForm";
            this.Text = "EditVehicleForm";
            this.Load += new System.EventHandler(this.EditVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verifybtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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