using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        public int hours;

        public int minutes;

        public int seconds;

        public int Hours
        {
            get { return hours; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Часы");
                hours = value;
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Минуты");
                minutes = value;
            }
        }

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
