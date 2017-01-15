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
        void Fill(Bitmap canvas);
        void SetFillColor(Color fillColor);
    }
}
