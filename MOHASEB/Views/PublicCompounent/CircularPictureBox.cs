using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MOHASEB.Views.PublicCompounent
{
    public partial class CircularPictureBox : PictureBox
    {
        //Fields
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientangle = 50F;


        public CircularPictureBox()
        {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.Zoom;
        }

        #region Properties
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public Color BorderColor2
        {
            get
            {
                return borderColor2;
            }

            set
            {
                borderColor2 = value;
                Invalidate();
            }
        }

        public DashStyle BorderLineStyle
        {
            get
            {
                return borderLineStyle;
            }

            set
            {
                borderLineStyle = value;
                Invalidate();
            }
        }

        public DashCap BorderCapStyle
        {
            get
            {
                return borderCapStyle;
            }

            set
            {
                borderCapStyle = value;
                Invalidate();
            }
        }

        public float GradientAngle
        {
            get
            {
                return gradientangle;
            }

            set
            {
                gradientangle = value;
                Invalidate();
            }
        }
        #endregion


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            // Fields
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;

            var pathRegion = new GraphicsPath();
            var penBorder = new Pen(new LinearGradientBrush(rectBorder, BorderColor, BorderColor2, gradientangle), BorderSize);

            penBorder.DashStyle = borderLineStyle;
            penBorder.DashCap = borderCapStyle;
            pathRegion.AddEllipse(rectContourSmooth);

            Region = new Region(pathRegion);
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            // Drawing
            graph.DrawEllipse(new Pen(Parent.BackColor, smoothSize), rectContourSmooth);
            if (borderSize > 0)
                graph.DrawEllipse(penBorder, rectBorder);


        }
    }
}
