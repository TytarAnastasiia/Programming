using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class Validator //чтобы не создавать экземпляры класса
    {
        public static bool AssertOnPositiveValue(int value, string exeptionParametr)
        {
            if (value < 0)
                throw new ArgumentException(exeptionParametr + " допускает только положительные значения!");
            return true;
        }
        public static bool AssertOnPositiveValue(double value, string exeptionParametr)
        {
            if (value < 0)
                throw new ArgumentException(exeptionParametr + " допускает только положительные значения!");
            return true;
        }
        public static bool AssertValueInRange(int value, int min, int max, string exeptionParametr)
        {
            if (value < min || value > max)
                throw new ArgumentException(exeptionParametr + " " + value + " выходит за рамки допустимых значений!(" + min + "-" + max + ")");
            return true;
        }
        public static bool AssertValueInRange(double value, double min, double max, string exeptionParametr)
        {
            if (value < min || value > max)
                throw new ArgumentException(exeptionParametr + " выходит за рамки допустимых значений!(" + min + "-" + max + ")");
            return true;
        }
    }
}
