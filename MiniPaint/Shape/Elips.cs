using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.Shape
{
    class Elips : IDraw,ITransformation
    {
        private Point center;
        private int rX, rY;

        public Elips(Point center, int rX, int rY)
        {
            this.center = center;
            this.rX = rX;
            this.rY = rY;
        }

        /*  bugs before : pada ukuran dengan besar tertentu bentukelips akan menjadi aneh, 
            dikarenakan tipe data untuk menyimpan nilai P tidak cukup dengan menggunakan int 32 bits
        */
        public void Draw(Graphics g)
        {
            long  Rx2 = rX * rX;
            long  Ry2 = rY * rY;

            int x = 0, y = rY;
            long P = (long)(Ry2 - (Rx2 * rY) + (0.25 * Rx2));

            while (Ry2 * x < Rx2 * y)
            {
                x++;
                if (P < 0)
                {
                    P += Ry2 * (2 * x + 1);
                }
                else
                {
                    y--;
                    P += 2 * (Ry2 * x - Rx2 * y) + Ry2;
                }

                DrawElips(g, (new Point(center.X + x, center.Y + y)));
                DrawElips(g, (new Point(center.X - x, center.Y + y)));
                DrawElips(g, (new Point(center.X + x, center.Y - y)));
                DrawElips(g, (new Point(center.X - x, center.Y - y)));


            }

            P = (int)(Ry2 * (x + 0.5) * (x + 0.5) + Rx2 * (y - 1) * (y - 1) - Rx2 * Ry2);
            while (y > 0)
            {
                y--;
                if (P > 0)
                {
                    P += Rx2 * (1 - 2 * y);

                }
                else
                {
                    x++;
                    P += 2 * (Ry2 * x - Rx2 * y) + Rx2;
                }

                DrawElips(g, (new Point(center.X + x, center.Y + y)));
                DrawElips(g, (new Point(center.X - x, center.Y + y)));
                DrawElips(g, (new Point(center.X + x, center.Y - y)));
                DrawElips(g, (new Point(center.X - x, center.Y - y)));
            }

            //add loss pixel
            DrawElips(g, (new Point(center.X, center.Y - rY)));
            DrawElips(g, (new Point(center.X, center.Y + rY)));
        }

        public void DrawElips(Graphics g, Point P)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(P, new Size(1, 1)));
        }

        public IDraw Transform(Double[,] Mt)
        {
            Point ct = MatrixOperation.Multiply(this.center, Mt);
            return new Elips(ct, rX, rY);
        }
    }
}
