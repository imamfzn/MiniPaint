using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.Coloring
{
    class FloodFill : IFill
    {
        private Color oldColor;
        private Color fillColor;

        public FloodFill(Color old)
        {
            this.oldColor = old;
            this.fillColor = Color.Black; //default
        }

        public FloodFill(Color fillColor, Color oldColor)
        {
            this.oldColor = oldColor;
            this.fillColor = fillColor;
        }

        public void SetFillColor(Color fillColor)
        {
            this.fillColor = fillColor;
        }

        public void SetOldColor(Color old)
        {
            this.oldColor = old;
        }

        public void Fill(Bitmap canvas)
        {

        }

        public void Fill(Bitmap canvas, int x, int y)
        {
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point p = pixels.Pop();
                if (p.X > 0 && p.X < canvas.Width && p.Y > 0 && p.Y < canvas.Height)
                {
                    Color pColor = canvas.GetPixel(p.X, p.Y);
                    if (pColor == oldColor)
                    {
                        //Console.WriteLine("{0},{1}", p.X, p.Y);
                        canvas.SetPixel(p.X, p.Y, fillColor);
                        pixels.Push(new Point(p.X - 1, p.Y));
                        pixels.Push(new Point(p.X, p.Y - 1));
                        pixels.Push(new Point(p.X + 1, p.Y));
                        pixels.Push(new Point(p.X, p.Y + 1));
                    }
                }
            }
        }
    }
}
