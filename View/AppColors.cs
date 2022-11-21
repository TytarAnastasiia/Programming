﻿using Programming.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.View
{
    static class AppColors
    {
        public static Color StandartColor
        {
            get;
        }
    = Color.White;
        
        public static Color AutumnColor
        {
            get;
        }
    = Color.Orange;
        
        public static Color SpringColor
        {
            get;
        }
    = Color.Green;
        
        public static Color NotValidColor
        {
            get;
        }
    = Color.LightPink;
        
        public static Color GreenRectangle
        {
            get;
        }
    = Color.FromArgb(127, 127, 255, 127);

        public static Color RedRectangle
        {
            get;
        }
    = Color.FromArgb(127, 255, 127, 127);
    }
}
