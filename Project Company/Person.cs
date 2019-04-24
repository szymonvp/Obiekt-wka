using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Person
    {
        private string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }


    }
}
