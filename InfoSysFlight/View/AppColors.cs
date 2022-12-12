using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InfoSysFlight.View
{
    /// <summary>
    /// Хранит информацию о цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Устанавливает цвет ошибки.
        /// </summary>
        public static Color ColorOfError
        {
            get; set;
        }
        = Color.LightPink;

        /// <summary>
        /// Устанавливает стандартный цвет.
        /// </summary>
        public static Color StandartColor
        {
            get; set;
        }
        = Color.White;
    }
}
