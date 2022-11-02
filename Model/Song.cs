using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Song
    {
        public string Performer { set; get; }
        public string Name { set; get; }
        public string Album { set; get; }
        public int Year { set; get; }

        public Song() { }

        public Song(string performer, string name, string album, int year)
        {
            Performer = performer;
            Name = name;
            Album = album;
            Year = year;
        }
    }
}
