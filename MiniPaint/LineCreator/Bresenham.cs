using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaint.Shape;

namespace MiniPaint.LineCreator
{
    class Bresenham : IDraw
    {
        private Line line;
        public Bresenham(Line line)
        {
            this.line = line;
        }

        /* source from  https://rosettacode.org/wiki/Bitmap/Bresenham%27s_line_algorithm#C */
        public void Draw(Graphics g)
        {
            int dx = Math.Abs(line.Start.X - line.End.X);
            int inc_x = line.Start.X < line.End.X ? 1 : -1;

            int dy = Math.Abs(line.Start.Y - line.End.Y);
            int inc_y = line.Start.Y < line.End.Y ? 1 : -1;

            int err = (dx > dy ? dx : -dy) / 2;
            int p;

            int x = line.Start.X;
            int y = line.Start.Y;

            while (true)
            {
                g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                if (x == line.End.X && y == line.End.Y)
                    break;

                p = err;
                if (p > -dx)
                {
                    err -= dy;
                    x += inc_x;
                }
                if (p < dy)
                {
                    err += dx;
                    y += inc_y;
                }
            }
        }
    }
}
