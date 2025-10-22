using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Names
    {
        string name, surname, patronymic;
        string res;
        public Names(string name)
        {
            this.name = name;
            res = name;
        }
        public Names(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            res = name + " " + surname;
        }
        public Names(string name, string surname, string patronymic) 
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            res = name + " " + surname + " " + patronymic;
        }

        public override string ToString()
        {
            return "Создалось имя: " + res;
        }

    }
}
