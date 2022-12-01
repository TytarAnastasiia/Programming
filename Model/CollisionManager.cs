using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    /// <summary>
    /// Определение пересечения для прямоугольников и колец.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Определяет пересечение прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники пересекаются.
        /// Возвращает false, если они не пересекаются.</returns>
        public static bool IsCollision(MyRectangle rectangle1, MyRectangle rectangle2)
        {
            double dx = Math.Abs(rectangle1.Centre.X - rectangle2.Centre.X);
            double dy = Math.Abs(rectangle1.Centre.Y - rectangle2.Centre.Y);
            double widthDifference = (rectangle1.Width + rectangle2.Width) / 2;
            double heightDifference = (rectangle1.Length + rectangle2.Length) / 2;
            if (dx < widthDifference && dy < heightDifference )
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Определяет пересечение колец.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если кольца пересекаются.
        /// Возвращает false, если они не пересекаются.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dy = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dx * dx + dy * dy);
            if (c < (ring1.ExternalRadius + ring2.ExternalRadius))
                return true;
            return false;
        }
    }
}
