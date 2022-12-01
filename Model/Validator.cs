using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Содержит методы для проверки различных ограничений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет значение на положительность.
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="exceptionParameter">Вызываемый параметр.</param>
        /// <returns>Возвращает true, если значение положительно.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertOnPositiveValue(int value, string exceptionParameter)
        {
            if (value < 0)
            {
                throw new ArgumentException(exceptionParameter + 
                    " допускает только положительные значения!");
            }
            return true;
        }

        /// <summary>
        /// Проверяет значение на положительность.
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="exceptionParameter">Вызываемый параметр.</param>
        /// <returns>Возвращает true, если значение положительно.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertOnPositiveValue(double value, string exceptionParameter)
        {
            if (value < 0)
            {
                throw new ArgumentException(exceptionParameter + 
                    " допускает только положительные значения!");
            }
            return true;
        }

        /// <summary>
        /// Проверяет принадлежность значения заданному интервалу.
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="min">Нижняя граница интервала.</param>
        /// <param name="max">Верхняя граница интервала.</param>
        /// <param name="exceptionParameter">Вызываемый параметр.</param>
        /// <returns>Возвращает true, если значение принадлежит
        /// заданному интервалу.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertValueInRange(int value, int min, int max, string exceptionParameter)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(exceptionParameter + " " + value + 
                    " выходит за рамки допустимых значений!(" + min + "-" + max + ")");
            }
            return true;
        }

        /// <summary>
        /// Проверяет принадлежность значения заданному интервалу.
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="min">Нижняя граница интервала.</param>
        /// <param name="max">Верхняя граница интервала.</param>
        /// <param name="exceptionParameter">Вызываемый параметр.</param>
        /// <returns>Возвращает true, если значение принадлежит
        /// заданному интервалу.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertValueInRange(double value, double min, double max, string exceptionParameter)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(exceptionParameter + 
                    " выходит за рамки допустимых значений!(" + min + "-" + max + ")");
            }
            return true;
        }
    }
}
