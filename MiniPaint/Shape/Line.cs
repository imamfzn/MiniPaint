using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.Shape
{
    class Line
    {
        private Point start;
        private Point end;

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        public Point Start
        {
            get { return this.start; }
        }

        public Point End
        {
            get { return this.end; }
        }

        public int GetDeltaX()
        {
            return end.X - start.X;
        }

        public int GetDeltaY()
        {
            return end.Y - start.Y;
        }

        public double GetGradient()
        {
            int deltaX = GetDeltaX();

            //handle division by zero, vertical line
            if (deltaX == 0)
            {
                return double.PositiveInfinity;
            }

            return (double) GetDeltaY() / deltaX;
        }
    }
}
