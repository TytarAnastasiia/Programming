﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static bool AssertOnPositiveValue(int value, string exceptionParameter)
        {
            if (value < 0)
            {
                throw new ArgumentException(exceptionParameter + 
                    " допускает только положительные значения!");
            }
            return true;
        }

        public static bool AssertOnPositiveValue(double value, string exceptionParameter)
        {
            if (value < 0)
            {
                throw new ArgumentException(exceptionParameter + 
                    " допускает только положительные значения!");
            }
            return true;
        }

        public static bool AssertValueInRange(int value, int min, int max, string exceptionParameter)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(exceptionParameter + " " + value + 
                    " выходит за рамки допустимых значений!(" + min + "-" + max + ")");
            }
            return true;
        }

        public static bool AssertValueInRange(double value, double min, double max, string exceptionParameter)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(exceptionParameter + 
                    " выходит за рамки допустимых значений!(" + min + "-" + max + ")");
            }
            return true;
        }
    }
}
