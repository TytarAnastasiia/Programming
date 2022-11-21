using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    public class Movie
    {
        private string _name;

        private int _duration;

        private int _year;

        private string _genre;

        private double _rating;

        public Movie() { }

        public Movie(string name, int duration, int year, string genre, double rating)
        {
            Name = name;

            Duration = duration;

            Year = year;

            Genre = genre;

            Rating = rating;
        }

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

        public int Year
        {
            get { return _year; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "Год");
                _year = value;
            }
        }

        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Продолжительность");
                _duration = value;
            }
        }

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
