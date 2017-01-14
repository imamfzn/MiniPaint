using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MiniPaint.LineCreator;

namespace MiniPaint.Shape
{
    class Polygon : IDraw,ITransformation
    {
        private int n, r;
        private double degree;
        private Point center;
        private Point[] plot;
        public Polygon(Point center,int n, int r,double degree)
        {
            this.n = n;
            this.r = r;
            this.degree = degree;
            this.center = center;
            this.plot = this.GetPoints();
        }

        public Polygon(Point[] plot)
        {
            this.plot = plot;
            this.n = plot.Length;
        }

        private Point[] GetPoints()
        {
            double pi_n = Math.PI / n;
            
            List<Point> Points = new List<Point>();

            for (int i = 0; i < n ; i++)
            {
                double alpha = 2 * pi_n * i + degree;
                Points.Add(new Point(center.X + (int)(r * Math.Cos(alpha)), (int)(center.Y + r * Math.Sin(alpha))));
            }

            return Points.ToArray();
        }

        public void Draw(Graphics g)
        {
            for (int i = 0; i < plot.Length; i++)
            {
                //DDA(Plot[i], Plot[(i + 2) % N]);
                (new DDA(new Line(plot[i], plot[(i + 1) % n]))).Draw(g);
                Console.WriteLine(plot[i].ToString());

            }
        }

        public IDraw Transform(Double[,] Mt)
        {
            List<Point> Points = new List<Point>();
            foreach (Point p in plot)
            {
                Points.Add(MatrixOperation.Multiply(p, Mt));
                Console.WriteLine(p.ToString() + " -> " + MatrixOperation.Multiply(p, Mt).ToString());
            }
            return new Polygon(Points.ToArray());
        }
    }
}
