using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Names
    {
        string name;
        string surname;
        string patronymic;
        public Names(string name)
        {
            this.name = name;
            surname = null;
            patronymic = null;
        }
        public Names(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            patronymic = null;
        }
        public Names(string name, string surname, string patronymic) 
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }

        public override string ToString()
        {
            string st = name;
            if (surname != null)
            {
                st += " " + surname;
            }
            if (patronymic != null)
            {
                st += " " + patronymic;
            }
            return "Создалось имя: " + st;
        }
    }
}
