using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    class TransformMatrices
    {
        public Point center;

        public TransformMatrices(Point center)
        {
            this.center = center;
            this.center.Y = -center.Y;
        }

        public Double[,] GetTranslation(Double dx, Double dy)
        {
            return new Double[,]
            {
                {1,0,dx},
                {0,1,dy},
                {0,0,1}
            };
        }

        public Double[,] GetRotation(Double alpha)
        {
            Double cx = center.X + center.Y * Math.Sin(alpha) - center.X * Math.Cos(alpha);
            Double cy = center.Y - center.X * Math.Sin(alpha) - center.Y * Math.Cos(alpha);
            return new Double[,]
            {
                {Math.Cos(alpha),-Math.Sin(alpha),cx},
                {Math.Sin(alpha), Math.Cos(alpha),cy},
                {0,0,1 }
            };
        }

        public Double[,] GetReflection(Double m,Double c)
        {
            Double div = m * m + 1;
            Double[,] Mt1 = new Double[,]
            {
                {1,0,-center.X},
                {0,1,-center.Y},
                {0,0,1},
            };

            Console.WriteLine(c);
            Console.WriteLine(center.Y);

            Double[,] Mt2 = new Double[,]
            {
                {1,0,center.X},
                {0,1,center.Y},
                {0,0,1},
            };

            Double[,] Mr = new Double[,]
            {
                {(1-m*m)/div, 2*m/div,-2*c*m/div },
                {2*m/div,(m*m-1)/div,2*c/div  },
                {0,0,1 }
            };
            return MatrixOperation.Multiply(MatrixOperation.Multiply(Mt2, Mr), Mt1);
        }

        public Double[,] GetReflection(Double c)
        {
            return new Double[,]
            {
                {-1,0,2*(c+center.X)},
                {0,1,0},
                {0,0,1}
            };
        }

        public Double[,] GetDilatation(Double k)
        {
           return new Double[,]
           {
                {k,0,center.X*(1-k)},
                {0,k,center.Y*(1-k)},
                {0,0,1}
           };
        }

    }
}
