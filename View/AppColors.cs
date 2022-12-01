using Programming.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.View
{
    /// <summary>
    /// Хранит информацию о цветах.
    /// </summary>
    static class AppColors
    {
        /// <summary>
        /// Устанавливает белый цвет.
        /// </summary>
        public static Color StandartColor
        {
            get;
        }
    = Color.White;
        
        /// <summary>
        /// Устанавливает оранжевый цвет.
        /// </summary>
        public static Color AutumnColor
        {
            get;
        }
    = Color.Orange;
        
        /// <summary>
        /// Устанавливает зелёный цвет.
        /// </summary>
        public static Color SpringColor
        {
            get;
        }
    = Color.Green;
        
        /// <summary>
        /// Устанавливает светло-розовый цвет.
        /// Для выделения неверно заполненных полей.
        /// </summary>
        public static Color NotValidColor
        {
            get;
        }
    = Color.LightPink;
        
        /// <summary>
        /// Устанавливает зеленый цвет.
        /// Для непересекающихся прямоугольников.
        /// </summary>
        public static Color GreenRectangle
        {
            get;
        }
    = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Устанавливает красный цвет.
        /// Для пересекающихся прямоугольников.
        /// </summary>
        public static Color RedRectangle
        {
            get;
        }
    = Color.FromArgb(127, 255, 127, 127);
    }
}
