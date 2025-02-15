﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomad.VegasScript.OtomadHelper.V4 {
	public class Windows10StyledContextMenuStripRenderer : ToolStripProfessionalRenderer {
		public Windows10StyledContextMenuStripRenderer() : base(new Windows10StyledContextMenuStripColorTable()) { }
		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e) {
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle r = new Rectangle(e.ArrowRectangle.Location, e.ArrowRectangle.Size);
			r.Inflate(-2, -6);
			e.Graphics.DrawLines(Pens.Black, new Point[] {
				new Point(r.Right - r.Height / 2, r.Top),
				new Point(r.Right, r.Top + r.Height / 2),
				new Point(r.Right - r.Height / 2, r.Top + r.Height)
			});
			/*e.Graphics.DrawLines(Pens.Black, new Point[] {
				new Point(r.Left, r.Top),
				new Point(r.Right, r.Top),
				new Point(r.Right, r.Bottom),
				new Point(r.Left, r.Bottom)
			});*/
		}

		protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e) {
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle r = new Rectangle(e.ImageRectangle.Location, e.ImageRectangle.Size);
			r.Inflate(-4, -6);
			e.Graphics.DrawLines(Pens.Black, new Point[] {
				new Point(r.Left, r.Bottom - r.Height / 2),
				new Point(r.Left + r.Width / 3, r.Bottom),
				new Point(r.Right, r.Top)
			});
		}
	}

	public class Windows10StyledContextMenuStripColorTable : ProfessionalColorTable {
		private static readonly Color MenuBarSelectedColor = Color.FromArgb(224, 224, 224);
		public override Color MenuItemBorder { get { return Color.WhiteSmoke; } }
		public override Color MenuItemSelected { get { return Color.WhiteSmoke; } }
		public override Color ToolStripDropDownBackground { get { return Color.White; } }
		public override Color ImageMarginGradientBegin { get { return Color.White; } }
		public override Color ImageMarginGradientMiddle { get { return Color.White; } }
		public override Color ImageMarginGradientEnd { get { return Color.White; } }
		public override Color MenuItemSelectedGradientBegin { get { return MenuBarSelectedColor; } }
		public override Color MenuItemSelectedGradientEnd { get { return MenuBarSelectedColor; } }
		public override Color MenuItemPressedGradientBegin { get { return Color.White; } }
		public override Color MenuItemPressedGradientEnd { get { return Color.White; } }
		public override Color MenuItemPressedGradientMiddle { get { return Color.White; } }
	}
}
