using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    static class MatrixOperation
    {
        public static Point Multiply(Point P, Double[][] Mt)
        {
            Double[] Mp = PointToMatrix(P);
            Double[] Res = new Double[Mp.Length];
            for (int i = 0; i < Mp.Length; i++)
            {
                for (int j = 0; j<Mp.Length;j++)
                {
                    Res[j] = 0;
                    for (int k = 0; k <= j; k++)
                    {
                        Res[j] += Mp[k] * Mt[j][k];
                    }
                }
            }
            return new Point((int)Res[0], (int)Res[1]);
        }

        public static Double[] PointToMatrix(Point P)
        {
            return new Double[] { P.X, P.Y, 1 };
        }
    }
}
