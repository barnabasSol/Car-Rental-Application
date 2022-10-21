using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_App.RenterUserControl
{
    public partial class UnderLined_TextBox : UserControl
    {


        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStlye=false;
        public UnderLined_TextBox()
        {
            InitializeComponent();
        }

        public Color BorderColor {
            get { return borderColor; }

            set { borderColor = value; this.Invalidate(); }
        
        }
        public int BorderSize { 
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); } 
        
        }
        public bool UnderlinedStlye { 
        get { return underlinedStlye; }
            set { underlinedStlye = value; this.Invalidate(); }
        }

        public bool PasswordChar
        {

            get
            {
                return textBox1.UseSystemPasswordChar;
            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }

        public override Color BackColor
        {
            get { return base.BackColor;  }
            set { base.BackColor = value; textBox1.BackColor = value; }
        }
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; textBox1.ForeColor = value; }
        }
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value; textBox1.Font = value;


                if (this.DesignMode)
                    UpdateControlHeight();


            }
        }
        public string Texts
        {
            get { return textBox1.Text; }
            set
            {
                textBox1.Text = value;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph=e.Graphics;
            using(Pen penBorder=new Pen(BorderColor, borderSize))
            {

                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if(underlinedStlye)
                    graph.DrawLine(penBorder,0,this.Height-1,this.Width,this.Height-1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width-0.5F, this.Height-0.5F);

            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline=true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline=false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
}
