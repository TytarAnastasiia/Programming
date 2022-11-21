using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        private double _externalRadius = -1;

        private double _internalRadius = -1;

        public Ring () { }

        public Ring ( Point2D center, double internalRadius, double externalRadius ) 
        {
            Center = center;

            InternalRadius = internalRadius;

            ExternalRadius = externalRadius;
        }

        public Point2D Center { get; set; }
        
        public double ExternalRadius
        {
            get { return _externalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Внешний радиус");
                if (_internalRadius != -1 && _internalRadius > value)
                {
                    throw new ArgumentException("Внешний радиус должен быть больше внутреннего!");
                }
                _externalRadius = value;
            }
        }

        public double InternalRadius
        {
            get { return _internalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Внешний радиус");
                if (_externalRadius != -1 && _externalRadius < value)
                {
                    throw new ArgumentException("Внутренний радиус должен быть меньше внешнего!");
                }
                _externalRadius = value;
            }
        }

        public double Area
        {
            get 
            {
                return Math.PI*(ExternalRadius*ExternalRadius - InternalRadius*InternalRadius);
            }
        }
    }
}
