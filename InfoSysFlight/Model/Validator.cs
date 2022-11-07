using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSysFlight.Model
{
    static class Validator
    {
        public static bool AssertOnValidText(string text)
        {
            if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrEmpty(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!((text[i] >= 'a' && text[i] <= 'z') ||
                        (text[i] >= 'A' && text[i] <= 'Z') ||
                        (text[i] == '-' || text[i] == '.') || 
                        (text[i] >= 'а' && text[i] <= 'я') ||
                        (text[i] >= 'А' && text[i] <= 'Я')))
                    {
                        //return false;
                        throw new ArgumentException("Недопустимый символ в строке");
                    }
                }
                return true;
            }
            else throw new ArgumentException("Строка не может быть пустой");
        }
        public static bool AssertOnValidLength(string text, int minLength = 0, int maxLength = 100)
        {
            if (text.Length > minLength && text.Length <= maxLength)
            {
                return true;
            }
            throw new ArgumentException("Превышено допустимое количество символов");
        }
        public static bool AssertOnInRange(int min, int max, int number)
        {
            if (number >= min && number <= max)
            {
                return true;
            }
            else throw new ArgumentException("Выход за пределы допустимого диапазона от " + 
                min + " до " + max);
        }
        public static bool AssertOnValidDate(DateTime chosenDate, int maxNumberOfYear = 1)
        {
            if ((chosenDate >= DateTime.Now) && (DateTime.Now.Year - chosenDate.Year) <= 1)
            {
                return true;
            }
            else throw new ArgumentException("Выходит за допустимый диапазон дат");
        }
        public static bool AssertOnIsNumber(string text)
        {
            if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrEmpty(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!((text[i] >= '0' && text[i] <= '9')))
                    {
                        //return false;
                        throw new ArgumentException("Допустимы только цифры");
                    }
                }
                return true;
            }
            else throw new ArgumentException("Значение должно быть задано");
        }
    }
}
