using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.Shape
{
    class Circle : IDraw, ITransformation
    {
        private Point center;
        private int r;

        public Circle(Point center, int r)
        {
            this.r = r;
            this.center = center;
        }

        public void Draw(Graphics g)
        {
            //int r = GetDistance(Start, End);
            int x = 0, y = r, p = 1 - r;
            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }

                DrawCircle(g, (new Point(center.X + x, center.Y + y)));
                DrawCircle(g, (new Point(center.X - x, center.Y + y)));
                DrawCircle(g, (new Point(center.X + x, center.Y - y)));
                DrawCircle(g, (new Point(center.X - x, center.Y - y)));
                DrawCircle(g, (new Point(center.X + y, center.Y + x)));
                DrawCircle(g, (new Point(center.X - y, center.Y + x)));
                DrawCircle(g, (new Point(center.X + y, center.Y - x)));
                DrawCircle(g, (new Point(center.X - y, center.Y - x)));
            }
        }

        private void DrawCircle(Graphics g, Point P)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(P, new Size(1, 1)));
        }

        public IDraw Transform(Double[,] Mt)
        {
            Point ct = MatrixOperation.Multiply(this.center, Mt);
            return new Circle(ct, r);
        }
    }
}
