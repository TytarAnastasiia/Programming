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
        private string name;

        private int duration;

        private int year;

        private string genre;

        private double rating;

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
            get { return name; }
            set
            {
                if (value != "" && value != null)
                    name = value;
                else throw new ArgumentException("Название должно быть задано!");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "Год");
                year = value;
            }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Продолжительность");
                duration = value;
            }
        }

        public string Genre
        {
            get { return genre; }
            set
            {
                if (value != "" && value != null)
                    genre = value;
                else throw new ArgumentException("Жанр должен быть задан!");
            }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Рейтинг");
                rating = value;
            }
        }
    }
}
