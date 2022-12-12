using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о продукте.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Название продукта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Цена продукта.
        /// </summary>
        private double _price;

        /// <summary>
        /// Вес продукта.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Цвет продукта.
        /// </summary>
        private string _color;

        /// <summary>
        /// Проверяет имя на ограничения.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (AssertStringContainsOnlyLetters(value, nameof(Name)))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Проверяет вес на положительное значение.
        /// </summary>
        public double Weight
        {
            get { return _weight; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Weight));
                _weight = value;
            }
        }

        /// <summary>
        /// Проверяет цену на положительное значение.
        /// </summary>
        public double Price
        {
            get { return _price; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Price));
                _price = value;
            }
        }

        /// <summary>
        /// Проверяет цвет на ограничения.
        /// </summary>
        public string Color
        {
            get { return _color; }
            set
            {
                if (AssertStringContainsOnlyLetters(value, nameof(Color)))
                {
                    _color = value;
                }
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Product"/>
        /// </summary>
        /// <param name="name">Название. Должно состоять из букв.</param>
        /// <param name="price">Цена. Должна быть положительной.</param>
        /// <param name="weight">Вес. Должен быть положительным.</param>
        /// <param name="color">Цвет. Должен состоять из букв.</param>
        public Product(string name, double price, double weight, string color)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Color = color;
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
            {
                return false;
            }
        }
    }
}
