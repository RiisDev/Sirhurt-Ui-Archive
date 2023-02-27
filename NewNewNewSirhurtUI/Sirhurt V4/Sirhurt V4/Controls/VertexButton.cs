using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirhurt_V4.Controls
{
	public class UIControls
	{
		public class RoundButton : Button
		{
			private int radius = 25;
			public int Radius
			{
				get
				{
					return radius;
				}
				set
				{
					radius = value;
					Invalidate();
				}
			}

			public RoundButton()
			{
				Text = "";
				radius = 25;
				FlatStyle = FlatStyle.Flat;
				BackColor = Color.FromArgb(67, 125, 219);
				FlatAppearance.BorderSize = 0;
			}

			private GraphicsPath GRP(RectangleF r1, int r2)
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddArc(r1.X, r1.Y, r2, r2, 180f, 90f);
				graphicsPath.AddArc(r1.X + r1.Width - r2, r1.Y, r2, r2, 270f, 90f);
				graphicsPath.AddArc(r1.X + r1.Width - r2, r1.Y + r1.Height - r2, r2, r2, 0f, 90f);
				graphicsPath.AddArc(r1.X, r1.Y + r1.Height - r2, r2, r2, 90f, 90f);
				graphicsPath.CloseFigure();
				return graphicsPath;
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				base.OnPaint(e);
				RectangleF r = new RectangleF(0f, 0f, Width, Height);
				GraphicsPath path = GRP(r, radius);
				Region = new Region(path);
				using (Pen pen = new Pen(BackColor, 1.75f))
				{
					pen.Alignment = PenAlignment.Inset;
					e.Graphics.DrawPath(pen, path);
				}
			}

		}
	}
}
