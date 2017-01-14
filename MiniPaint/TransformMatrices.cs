﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    class TransformMatrices
    {
        private Point center;

        public TransformMatrices(Point center)
        {
            this.center = center;
        }

        public Double[,] GetTranslation(Double dx, Double dy)
        {
            return new Double[,]
            {
                {1,0,dx},
                {0,1,dy},
                {0,0,1 }
            };
        }

        public Double[,] GetRotation(Double alpha)
        {
           return new Double[,]
           {
                {Math.Cos(alpha),- Math.Sin(alpha),0},
                {Math.Sin(alpha), Math.Cos(alpha),0},
                {0,0,1 }
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

        public Double[,] GetDilatation(Double k)
        {
           return new Double[,]
           {
                {k,0,0},
                {0, k,0},
                {0,0,1 }
           };
        }

    }
}