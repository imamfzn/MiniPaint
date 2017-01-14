using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    interface ITransformation:IDraw
    {
        IDraw Transform(Graphics g, Double[][] Mt);
    }
}
