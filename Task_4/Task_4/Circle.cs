﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Task_4
{
    public class Circle
    {
        Pen p;
        GraphicsPath path_Circle;
        public Circle(int x, int y)
        {
            path_Circle.AddEllipse(x, y, 40, 40);
        }
    }
}
