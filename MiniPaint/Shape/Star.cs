﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaint.LineCreator;

namespace MiniPaint.Shape
{
    class Star : IDraw
    {
        private int n, r;
        private double degree;
        private Point center;

        public Star(Point center, int n, int r, double degree)
        {
            this.n = n;
            this.r = r;
            this.degree = degree;
            this.center = center;
        }

        private Point[] GetPoints()
        {
            double pi_n = Math.PI / n;

            List<Point> Points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                double alpha = 2 * pi_n * i + degree;
                Points.Add(new Point(center.X + (int)(r * Math.Cos(alpha)), (int)(center.Y + r * Math.Sin(alpha))));
            }

            return Points.ToArray();
        }

        public void Draw(Graphics g)
        {
            Point[] plot = GetPoints();
            for (int i = 0; i < plot.Length; i++)
            {
                //DDA(Plot[i], Plot[(i + 2) % N]);
                (new DDA(new Line(plot[i], plot[(i + 2) % n]))).Draw(g);
            }
        }

    }
}
