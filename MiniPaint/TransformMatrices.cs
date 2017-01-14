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
        }

        public Double[,] GetTranslation(Double dx, Double dy)
        {
            return new Double[,]
            {
                {1,0,0},
                {0,1,0},
                {dx,dy,1}
            };
        }

        public Double[,] GetRotation(Double alpha)
        {
            Double cx = center.X + center.Y * Math.Sin(alpha) - center.X * Math.Cos(alpha);
            Double cy = center.Y - center.X * Math.Sin(alpha) - center.Y * Math.Cos(alpha);
            return new Double[,]
            {
                {Math.Cos(alpha),Math.Sin(alpha),0},
                {-Math.Sin(alpha), Math.Cos(alpha),0},
                {cx,cy,1 }
            };
        }

        public Double[,] GetReflection(Double m,Double c)
        {
            return new Double[,]
            {
                {0,0,0},
                {0,0,0},
                {0,0,1}
            };
        }

        public Double[,] GetReflection(Double c)
        {
            return new Double[,]
            {
                {-1,0,0},
                {0,1,0},
                {2*c+center.X,0,1}
            };
        }

        public Double[,] GetDilatation(Double k)
        {
           return new Double[,]
           {
                {k,0,0},
                {0,k,0},
                {center.X*(1-k),center.Y*(1-k),1}
           };
        }

    }
}
