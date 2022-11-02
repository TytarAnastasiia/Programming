using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    class Movie
    {
        private string name;
        private int duration; //in minutes
        private int year; //1900...
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
            set
            {
                if (value != "" && value != null)
                    name = value;
                else throw new ArgumentException("Название должно быть задано!");
            }
            get { return name; }
        }
        public int Year
        {
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "Год");
                year = value;
            }
            get { return year; }

        }
        public int Duration
        {
            set
            {
                Validator.AssertOnPositiveValue(value, "Продолжительность");
                duration = value;
            }
            get { return duration; }

        }
        public string Genre
        {
            set
            {
                if (value != "" && value != null)
                    genre = value;
                else throw new ArgumentException("Жанр должен быть задан!");
            }
            get { return genre; }
        }
        public double Rating
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Рейтинг");
                rating = value;
            }
            get { return rating; }
        }
    }
}
