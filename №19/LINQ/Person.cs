using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Person : IInfo
    {
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string GetInfo() => "Name: " + Name + "\tSurname: " + Surname;
    }
}
