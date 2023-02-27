using System;
using System.Drawing;
using System.Windows.Forms;
using SirhurtV4ReCreate.Controls;

namespace SirhurtV4ReCreate.Classes
{
    public class ButtonX : Button
    {
        private Color color = Color.FromArgb(30, 30, 30);
        private bool isChanged = true;
        public Point p;
        public TabControlX Tab = new TabControlX();
        private string text = "_";
        private int textX = 6;
        private int textY = -20;

        public ButtonX()
        {
            Size = new Size(31, 24);
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            Text = "_";
            text = Text;
        }

        public string DisplayText
        {
            get => text;
            set
            {
                text = value;
                Invalidate();
            }
        }

        public Color BXBackColor
        {
            get => Tab.UnSelectedTabBackColour;
            set
            {
                Tab.UnSelectedTabBackColour = value;
                Invalidate();
            }
        }

        public Color MouseHoverColor
        {
            get => Tab.TabHoverColour;
            set
            {
                Tab.TabHoverColour = value;
                Invalidate();
            }
        }

        public Color MouseClickColor1
        {
            get => Tab.TabClickColour;
            set
            {
                Tab.TabClickColour = value;
                Invalidate();
            }
        }

        public bool ChangeColorMouseHC
        {
            get => isChanged;
            set
            {
                isChanged = value;
                Invalidate();
            }
        }


        public int TextLocation_X
        {
            get => textX;
            set
            {
                textX = value;
                Invalidate();
            }
        }

        public int TextLocation_Y
        {
            get => textY;
            set
            {
                textY = value;
                Invalidate();
            }
        }

        //method mouse enter
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        //method mouse leave
        protected override void OnMouseLeave(EventArgs e)
        {
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (isChanged) color = Tab.TabClickColour;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (isChanged) color = Tab.TabClickColour;
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            text = Text;
            base.Font = new Font("Microsoft Tai Le", 9, FontStyle.Regular);
            if (textX == 100 && textY == 25)
            {
                textX = Width / 3 + 10;
                textY = Height / 2 - 1;
            }

            p = new Point(textX, textY);
            pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), ClientRectangle);
            if (base.Text.Contains(" "))
                pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), ClientRectangle);
            else
                pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), ClientRectangle);
            pe.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), p);
        }
    }
}