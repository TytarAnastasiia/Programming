using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о точке на плоскости.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. От 0 до 1000.</param>
        /// <param name="y">Координата Y. От 0 до 1000.</param>
        public Point2D (int x, int y)
        {
            X = x;

            Y = y;
        }
        
        /// <summary>
        /// Проверяет X на ограничение.
        /// </summary>
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
        
        /// <summary>
        /// Проверяет Y на ограничение.
        /// </summary>
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
