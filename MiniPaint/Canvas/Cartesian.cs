using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace MiniPaint.Canvas
{
    class Cartesian : IDraw
    {
        private Point origin;
        private int size;

        public Cartesian(int x,int y, int size)
        {
            this.origin = new Point(x, y);
            this.size = size;
        }

        public Point ToCartesian(Point P)
        {
            int x = this.origin.X + P.X * this.size;
            int y = this.origin.Y - P.Y * this.size;
            return new Point(x, y);
        }
    }
}
