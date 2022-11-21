using System;


namespace Programming.Model
{
    public class MyRectangle
    {
        private static int _allRectanglesCount = 0;

        private double _length;

        private double _width;

        private string _color;

        private int _id;

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

        public Point2D Centre 
        {
            get; set;
        }
        
        public Point2D VertexA
        {
            get
            {
                return new Point2D(Centre.X - (int)Width/2, Centre.Y - (int)Length/2);
            }
        }

        public double Length 
        { 
            get { return _length; } 
            set 
            {
                Validator.AssertOnPositiveValue(value, "Длина");
                _length = value;
            }
        }
        
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ширина");
                _width = value;
            }
        }
        
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
        
        public int Id
        {
            get { return _id; }
        }
        
        public string MyRectangleToString()
        {
            return "( X = " + Centre.X + "; Y = " + Centre.Y +
                "; W = " + Width + "; H = " + Length + ")";
        }
    }
}
