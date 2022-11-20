using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        private double externalRadius = -1;

        private double internalRadius = -1;

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
            get { return externalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Внешний радиус");
                if (internalRadius != -1 && internalRadius > value)
                {
                    throw new ArgumentException("Внешний радиус должен быть больше внутреннего!");
                }
                externalRadius = value;
            }
        }

        public double InternalRadius
        {
            get { return internalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Внешний радиус");
                if (externalRadius != -1 && externalRadius < value)
                {
                    throw new ArgumentException("Внутренний радиус должен быть меньше внешнего!");
                }
                externalRadius = value;
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
