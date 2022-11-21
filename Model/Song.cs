using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    public class Song
    {
        public int year;

        public string Performer { get; set; }

        public string Name { get; set; }

        public string Album { get; set; }

        public Song() { }

        public Song(string performer, string name, string album, int year)
        {
            Performer = performer;

            Name = name;

            Album = album;

            Year = year;
        }

        public int Year
        {
            get { return year; }
            set
            {
                Validator.AssertValueInRange(value, 1960, 2020, "Год");
                year = value;
            }
        }
    }
}
