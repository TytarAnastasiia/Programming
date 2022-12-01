using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _externalRadius = -1;

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _internalRadius = -1;

        public Ring () { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Точка центра кольца.</param>
        /// <param name="internalRadius">Внутренний радиус.
        /// Должен быть положительным и не превышать внешний радиус.</param>
        /// <param name="externalRadius">Внешний радиус.
        /// Должен быть положительным и быть больше, чем внутренний радиус.</param>
        public Ring ( Point2D center, double internalRadius, double externalRadius ) 
        {
            Center = center;

            InternalRadius = internalRadius;

            ExternalRadius = externalRadius;
        }

        /// <summary>
        /// Устанавливает точку центра кольца.
        /// </summary>
        public Point2D Center { get; set; }
        
        /// <summary>
        /// Проверка внешнего радиуса на заданные ограничения.
        /// </summary>
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

        /// <summary>
        /// Проверка внутреннего радиуса на заданные ограничения.
        /// </summary>
        public double InternalRadius
        {
            get { return _internalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Внутренний радиус");
                if (_externalRadius != -1 && _externalRadius < value)
                {
                    throw new ArgumentException("Внутренний радиус должен быть меньше внешнего!");
                }
                _externalRadius = value;
            }
        }

        /// <summary>
        /// Определение площади кольца.
        /// </summary>
        public double Area
        {
            get 
            {
                return Math.PI*(ExternalRadius*ExternalRadius - InternalRadius*InternalRadius);
            }
        }
    }
}
