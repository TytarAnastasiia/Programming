using System;


namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о прямоугольнике.
    /// </summary>
    public class MyRectangle
    {
        /// <summary>
        /// Порядковый номер прямоугольника.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Уникальный идентификатор для прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MyRectangle"/>.
        /// </summary>
        /// <param name="length">Длина. Должна принимать положительные значения.</param>
        /// <param name="width">Ширина. Должна принимать положительные значения.</param>
        /// <param name="color">Цвет. Должен быть задан.</param>
        /// <param name="centre">Точка центра прямоугольника.</param>
        public MyRectangle(double length, double width, string color, Point2D centre)
        {
            this.Length = length;

            this.Width = width;

            this.Color = color;

            this.Centre = centre;

            _allRectanglesCount++;

            _id = _allRectanglesCount;
        }
        
        public MyRectangle() 
        { 
            _allRectanglesCount++;

            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Устанавливает центр прямоугольника.
        /// </summary>
        public Point2D Centre 
        {
            get; set;
        }
        
        /// <summary>
        /// Высчитывает одну из вершин прямоугольника.
        /// </summary>
        public Point2D VertexA
        {
            get
            {
                return new Point2D(Centre.X - (int)Width/2, Centre.Y - (int)Length/2);
            }
        }

        /// <summary>
        /// Проверяет длину на положительное значение.
        /// </summary>
        public double Length 
        { 
            get { return _length; } 
            set 
            {
                Validator.AssertOnPositiveValue(value, "Длина");
                _length = value;
            }
        }
        
        /// <summary>
        /// Проверяет ширину на положительное значение.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ширина");
                _width = value;
            }
        }
        
        /// <summary>
        /// Проверяет цвет.
        /// </summary>
        public string Color
        {
            get { return _color; }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("Цвет должен быть задан!");
                _color = value;
            }
        }
        
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        /// <summary>
        /// Устанавливает уникальный идентификатор для прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }
        
        /// <summary>
        /// Переводит информацию о прямоугольнике в строку.
        /// </summary>
        /// <returns>Возвращает строку с конкретными данными.</returns>
        public string MyRectangleToString()
        {
            return "( X = " + Centre.X + "; Y = " + Centre.Y +
                "; W = " + Width + "; H = " + Length + ")";
        }
    }
}
