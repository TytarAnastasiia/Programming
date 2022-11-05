using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.Model
{
    class MyRectangle
    {
        double length;
        double width;
        string color;
        private static int _allRectanglesCount = 0;
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
        public Point2D VertexB
        {
            get
            {
                return new Point2D(Centre.X + (int)Width/2, Centre.Y - (int)Length/2);
            }
        }
        public Point2D VertexC
        {
            get
            {
                return new Point2D(Centre.X + (int)Width/2, Centre.Y + (int)Length/2);
            }
        }
        public Point2D VertexD
        {
            get
            {
                return new Point2D(Centre.X - (int)Width/2, Centre.Y + (int)Length/2);
            }
        }

        public double Length 
        { 
            get { return length; } 
            set 
            {
                Validator.AssertOnPositiveValue(value, "Длина");
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Ширина");
                width = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("Цвет должен быть задан!");
                color = value;
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
