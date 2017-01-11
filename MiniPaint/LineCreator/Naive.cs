using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MiniPaint.Shape;


namespace MiniPaint.LineCreator
{
    class Naive : IDraw
    {
        private Line line;

        public Naive(Line line)
        {
            this.line = line;
        }

        public void Draw(Graphics g)
        {
            
            int dx = line.GetDeltaX();
            int dy = line.GetDeltaY();
            double m = line.GetGradient();
            double c = line.Start.Y - m * line.Start.X;


            if (Math.Abs(dx) > Math.Abs(dy))
            {
                
                int inc = (dx > 0 ? 1 : -1);
                int x = line.Start.X;
           
                while (x != line.End.X + inc)
                {
                    int y = (int)(m * x + c);
                    g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                    x += inc;
                }
            }

            else
            {
                int inc = (dy > 0 ? 1 : -1);
                int x = line.Start.X, y = line.Start.Y;
                while (y != line.End.Y + inc)
                {
                    if (dx != 0)
                    {
                        x = (int)((y - c) / m);
                    }
                    g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                    y += inc;
                } 
                
            }
        }


    }
}
