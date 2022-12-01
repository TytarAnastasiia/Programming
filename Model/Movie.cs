using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _name;

        /// <summary>
        /// Продолжительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Оценка фильма.
        /// </summary>
        private double _rating;

        public Movie() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название фильма. Должно быть задано.</param>
        /// <param name="duration">Продолжительность фильма. 
        /// Значение должно быть положительным.</param>
        /// <param name="year">Год выпуска. От 1900 года.</param>
        /// <param name="genre">Жанр. Должен быть задан.</param>
        /// <param name="rating">Оценка. От 0 до 10.</param>
        public Movie(string name, int duration, int year, string genre, double rating)
        {
            Name = name;

            Duration = duration;

            Year = year;

            Genre = genre;

            Rating = rating;
        }

        /// <summary>
        /// Проверяет название.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != "" && value != null)
                    _name = value;
                else throw new ArgumentException("Название должно быть задано!");
            }
        }

        /// <summary>
        /// Проверяет год на заданный интервал.
        /// </summary>
        public int Year
        {
            get { return _year; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "Год");
                _year = value;
            }
        }

        /// <summary>
        /// Проверяет продолжительность на положительное значение.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Продолжительность");
                _duration = value;
            }
        }

        /// <summary>
        /// Проверяет жанр.
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (value != "" && value != null)
                    _genre = value;
                else throw new ArgumentException("Жанр должен быть задан!");
            }
        }

        /// <summary>
        /// Проверяет оценку на заданный интервал.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Рейтинг");
                _rating = value;
            }
        }
    }
}
