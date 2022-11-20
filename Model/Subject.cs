using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Subject
    {
        public string TeacherName { set; get; }

        public string Name { set; get; }

        public string Department { set; get; }

        public int Grade { set; get; }

        public int Hours { set; get; }

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
