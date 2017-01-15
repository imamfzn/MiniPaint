using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.Coloring
{
    class BoundaryFill:IFill
    {
        private Color boundaryColor;
        private Color fillColor;
        
        public BoundaryFill(Color boundary, Color fill)
        {
            this.boundaryColor = boundary;
            this.fillColor = fill;
        }

        public void SetFillColor(Color fill)
        {
            this.fillColor = fill;
        }

        public void SetBoundaryColor(Color boundary)
        {
            this.boundaryColor = boundary;
        }

        public void Fill(Bitmap canvas, int x, int y)
        {
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));
            int count = 0;
            while (pixels.Count > 0)
            {
                Point p = pixels.Pop();
                if (p.X > 0 && p.X < canvas.Width && p.Y > 0 && p.Y < canvas.Height)
                {
                    Color current = canvas.GetPixel(p.X, p.Y);
                    if (!Color.Equals(current, fillColor) && !Color.Equals(current, boundaryColor))
                    {
                        canvas.SetPixel(p.X, p.Y, fillColor);
                        pixels.Push(new Point(p.X, p.Y + 1));
                        pixels.Push(new Point(p.X, p.Y - 1));
                        pixels.Push(new Point(p.X + 1, p.Y));
                        pixels.Push(new Point(p.X - 1, p.Y));
                    }
                }
            }
        }

    }
}
