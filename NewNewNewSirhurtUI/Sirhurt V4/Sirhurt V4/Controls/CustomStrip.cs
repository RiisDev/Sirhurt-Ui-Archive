using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ScintillaNET;
namespace SirhurtNewUI.MenuStripStuff
{
    public class BrowserMenuRenderer : ToolStripProfessionalRenderer
    {
        public BrowserMenuRenderer() : base(new BrowserColors())
        {
        }
    }

    public class BrowserColors : ProfessionalColorTable
    {
        private readonly Color BarColour = Color.FromArgb(40,40,40);
        private readonly Color Border = Color.FromArgb(158, 158, 158);

        private readonly Color DropDownBackColor = Color.FromArgb(39,39,39);
        private readonly Color MenuButtonPress = Color.FromArgb(39,39,39);
        private readonly Color MenuItemHover = Color.FromArgb(39, 39, 39);


        public override Color ToolStripDropDownBackground => DropDownBackColor; // DropDown items back colour


        public override Color ImageMarginGradientBegin => DropDownBackColor; // Image Location Back Colour

        public override Color ImageMarginGradientMiddle => DropDownBackColor; // Image Location Back Colour

        public override Color ImageMarginGradientEnd => DropDownBackColor; // Image Location Back Colour

        public override Color MenuBorder => Border; // Whole Drop Down Holder Border Colour

        public override Color MenuItemBorder { get; } = Color.FromArgb(59, 59, 59);
        // Hover Border

        public override Color MenuItemSelected { get; } = Color.FromArgb(9, 73, 110);
        // Menu Drop Down Hover Colour

        public override Color MenuStripGradientBegin => BarColour; // Main Bar

        public override Color MenuStripGradientEnd => BarColour; // Main Bar

        public override Color MenuItemSelectedGradientBegin => MenuItemHover; // Hover Behind Colour

        public override Color MenuItemSelectedGradientEnd => MenuItemHover; // Hover Behind Colour

        public override Color MenuItemPressedGradientBegin => MenuButtonPress; // Press back colour

        public override Color MenuItemPressedGradientEnd => MenuButtonPress; // Press back colour
    }

    public class CustomToolStripSeparator : ToolStripSeparator
    {
        public CustomToolStripSeparator()
        {
            Paint += CustomToolStripSeparator_Paint;
        }

        private void CustomToolStripSeparator_Paint(object sender, PaintEventArgs e)
        {
            var toolStripSeparator = (ToolStripSeparator) sender;
            var width = toolStripSeparator.Width;
            var height = toolStripSeparator.Height;
            var backColor = Color.FromArgb(92, 92, 93);
            e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0 + 3, width, height - 5);
            // Ty Rashedul.Rubel on stackoverflow
        }
    }

    public class CustomContextMenu : ContextMenuStrip
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            BackColor = Color.FromArgb(35, 35, 35);
        }
    }
}