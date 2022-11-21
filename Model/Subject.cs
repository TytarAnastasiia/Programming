using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Subject
    {
        public string TeacherName { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public int Grade { get; set; }

        public int Hours { get; set; }

        public Subject() { }

        public Subject(string teacherName, string name, string department, int grade, int hours)
        {
            TeacherName = teacherName;

            Name = name;

            Department = department;

            Grade = grade;

            Hours = hours;
        }
    }

}
