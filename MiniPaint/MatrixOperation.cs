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
        public static Double[,] Multiply(Double[,] M1, Double[,] M2)
        {
            Double[,] Result = new Double[,] { {0,0,0 }, {0,0,0 }, {0,0,0 } };
            for (int i = 0; i < M1.GetLength(0); i++)
            {
                for (int j = 0; j < M2.GetLength(0); j++)
                {
                    for (int k = 0; k < M2.GetLength(0); k++)
                    {
                        Result[i, j] += M1[i, k] * M2[k, j];
                    }
                }
            }

            for (int i = 0; i < Result.GetLength(0); i++)
            {
                for (int j = 0; j < Result.GetLength(0); j++)
                {
                    Console.Write("{0} ", Result[i, j]);
                }
                Console.WriteLine();
            }

            return Result;
        }

        public static Point Multiply(Point P, Double[,] Mt)
        {
            Double[] Mp = PointToMatrix(new Point(P.X,-P.Y));
            Double[] Res = new Double[Mp.Length];

            for (int i = 0; i < Mp.Length; i++)
            {
                for (int j = 0; j<Mp.Length;j++)
                {
                    Res[j] = 0;
                    for (int k = 0; k < Mp.Length; k++)
                    {
                        Res[j] += Mt[j, k] * Mp[k];
                    }
                  
                }
            }            
            return new Point((int)Res[0], -(int)Res[1]);
        }

        public static Double[] PointToMatrix(Point P)
        {
            return new Double[] { P.X, P.Y, 1 };
        }
    }
}
