using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaint.Shape;

namespace MiniPaint.LineCreator
{
    class DDA : IDraw
    {
        private Line line;

        public DDA(Line line)
        {
            this.line = line;
        }

        public void Draw(Graphics g)
        {
            
            int dx = line.End.X - line.Start.X;
            int dy = line.End.Y - line.Start.Y;

            int step = Math.Max(Math.Abs(dx), Math.Abs(dy));
            double x_tambah = (double) dx / step;
            double y_tambah = (double) dy / step;

            double x = line.Start.X;
            double y = line.Start.Y;

            for (int i = 0; i < step; i++)
            {
                Point P = new Point((int)Math.Round(x), (int)Math.Round(y));
                g.FillRectangle(Brushes.Black, new Rectangle(P,new Size(1, 1)));
                x += x_tambah;
                y += y_tambah;
            }           
            
        }
    }
}
