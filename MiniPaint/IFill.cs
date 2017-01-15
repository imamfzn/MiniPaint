﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint
{
    interface IFill
    {
        void Fill(Bitmap canvas, int x, int y);
        void SetFillColor(Color fillColor);
    }
}
