using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Contact
    {
        private string name;
        private string surname;
        public string Number { set; get; } 
        public string Email { set; get; }

        public Contact() { }

        public Contact(string name, string surname, string number, string email)
        {
            Name = name;
            Surname = surname;
            Number = number;
            Email = email;
        }

        private bool AssertStringContainsOnlyLetters(string value, string exeptionParametr)
        {
            if (!string.IsNullOrEmpty(value))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if ((value[i] < 'A' || value[i] > 'Z') || (value[i] < 'a' || value[i] > 'z'))
                    {
                        throw new ArgumentException(exeptionParametr + " Допускаюся только буквы английского алфавита!");
                        //return false;
                    }
                }
                return true;
            }
            else
                return false;
        }
        public string Name
        {
            set 
            {
                if (AssertStringContainsOnlyLetters(value, "Имя"))
                    name = value;
            }
            get { return name; }
        }

        public string Surname 
        {
            set
            {
                if (AssertStringContainsOnlyLetters(value, "Фамилия"))
                    surname = value;
            }
            get { return surname; }
        }
        
    }
}
