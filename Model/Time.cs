using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о времени.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        public int hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        public int minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        public int seconds;

        /// <summary>
        /// Проверяет часы на промежуток от 0 до 23.
        /// </summary>
        public int Hours
        {
            get { return hours; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Часы");
                hours = value;
            }
        }

        /// <summary>
        /// Проверяет минуты на промежуток от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get { return minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Минуты");
                minutes = value;
            }
        }

        /// <summary>
        /// Проверяет секунды на промежуток от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get { return seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Секунды");
                seconds = value;
            }
        }
    }
}
