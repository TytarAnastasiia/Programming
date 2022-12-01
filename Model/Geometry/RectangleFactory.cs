using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Генерация прямоугольников на панели.
    /// </summary>
    static class RectangleFactory
    {
        /// <summary>
        /// Создаёт случайный прямоугольник на панели.
        /// </summary>
        /// <param name="maxWidth">Максимальная ширина прямоугольника.</param>
        /// <param name="maxHeight">Максимальная высота прямоугольника.</param>
        /// <returns>Возвращает созданный прямоугольник.</returns>
        public static MyRectangle Randomize(int maxWidth, int maxHeight)
        {
            Random rand = new Random();
            int width = rand.Next(1, maxWidth/2);
            int height = rand.Next(1, maxHeight/2);

            int x = rand.Next(width/2, maxWidth-width/2);
            int y = rand.Next(height/2, maxHeight-height/2);
            return new MyRectangle(height, width, "Green", new Point2D(x,y));
        }
    }
}
