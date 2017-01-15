using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.Coloring
{
    class FloodFill : IFill
    {
        private Color currentColor;
        private Color oldColor;
        private Color fillColor;

        public FloodFill(Color old)
        {
            this.oldColor = oldColor;
        }

        public FloodFill(Color oldColor, Color currentColor)
        {
            this.oldColor = oldColor;
            this.currentColor = currentColor;
        }

        public FloodFill(Color fillColor, Color oldColor, Color currentColor)
        {
            this.oldColor = oldColor;
            this.currentColor = currentColor;
            this.fillColor = fillColor;
        }

        public void Fill(Bitmap canvas)
        {

        }

        public void Fill(Bitmap canvas, int x, int y)
        {
          
        }
    }
}
