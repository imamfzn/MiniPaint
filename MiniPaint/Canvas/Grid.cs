using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.Canvas
{
    class Grid : IDraw
    {
        private int size;
        private int midX, midY, hPanel, wPanel;
        private Point origin;
        public Cartesian cart;
        
        public Grid(int size, int wPanel, int hPanel)
        {
            this.SetGrid(size, wPanel, hPanel);
            this.origin = new Point(wPanel, hPanel);
            this.cart = new Cartesian(wPanel, hPanel, size);
        }

        public void SetGrid(int size, int wPanel, int hPanel)
        {
            this.size = size;
            this.hPanel = hPanel;
            this.wPanel = wPanel;
            this.midX = (wPanel / size / 2) * size;
            this.midY = (hPanel / size / 2) * size;
            this.origin.X = wPanel;
            this.origin.Y = hPanel;
        }

        public void Draw(Graphics g)
        {
            Pen P = new Pen(Color.LightGray);

            //make grid with size
            for (int x = 0; x < this.wPanel; x += this.size)
            {
                g.DrawLine(P, x, 0, x,this.hPanel);
            }

            for (int y = 0; y < this.hPanel; y += this.size)
            {
                g.DrawLine(P, 0, y, this.wPanel, y);
            }
            
            //..make cartesian coordinate
            g.DrawLine(new Pen(Color.Black), this.midX, 0, this.midX, hPanel);
            g.DrawLine(new Pen(Color.Black), 0,this.midY, wPanel, this.midY);
        }

        public override string ToString()
        {
            return origin.ToString();
        }
    }
}
