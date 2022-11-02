using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        int hours;   // от 0 до 23
        int minutes; // от 0 до 60
        int seconds; // от 0 до 60

        public int Hours
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Часы");
                hours = value;
            }
            get { return hours; }

        }
        public int Minutes
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Минуты");
                minutes = value;
            }
            get { return minutes; }

        }
        public int Seconds
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Секунды");
                seconds = value;
            }
            get { return seconds; }

        }
    }
}
