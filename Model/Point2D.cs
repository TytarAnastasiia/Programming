using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Point2D
    {
        private int _x;

        private int _y;

        public Point2D (int x, int y)
        {
            X = x;

            Y = y;
        }
        
        public int X 
        { 
            get
            {
                return this._x;
            }  
            private set 
            {
                Validator.AssertValueInRange(value, 0, 1000, "Координата Х");
                _x = value;
            } 
        }
        
        public int Y
        {
            get
            {
                return this._y;
            }
            private set
            {
                Validator.AssertValueInRange(value, 0, 1000, "Координата Y");
                _y = value;
            }
        }
    }
}
