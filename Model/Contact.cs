using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о пользователе.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Номер телефона пользователя.
        /// </summary>
        public string Number { set; get; }
        
        /// <summary>
        /// Электронная почта пользователя.
        /// </summary>
        public string Email { set; get; }

        public Contact() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Состоит только из букв.</param>
        /// <param name="surname">Фамилия. Состоит только из букв.</param>
        /// <param name="number">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string name, string surname, string number, string email)
        {
            Name = name;

            Surname = surname;

            Number = number;

            Email = email;
        }
        
        /// <summary>
        /// Проверяет имя.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                if (AssertStringContainsOnlyLetters(value, "Имя"))
                    _name = value;
            }
        }

        /// <summary>
        /// Проверяет фамилию.
        /// </summary>
        public string Surname 
        {
            get { return _surname; }
            set
            {
                if (AssertStringContainsOnlyLetters(value, "Фамилия"))
                    _surname = value;
            }
        }

        /// <summary>
        /// Проверяет, чтобы строка состояла только их букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="exceptionParameter">Вызываемый параметр.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private bool AssertStringContainsOnlyLetters(string value, string exceptionParameter)
        {
            if (!string.IsNullOrEmpty(value))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if ((value[i] < 'A' || value[i] > 'Z') || (value[i] < 'a' || value[i] > 'z'))
                    {
                        throw new ArgumentException(exceptionParameter +
                            " Допускаюся только буквы английского алфавита!");
                    }
                }
                return true;
            }
            else
                return false;
        }
    }
}
