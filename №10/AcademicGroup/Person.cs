using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicGroup
{
    abstract class Person
    {
        protected string name;
        protected string surname;
        protected uint age;
        protected string phoneNumber;

        public Person(string name, string surname, uint age, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.phoneNumber = phoneNumber;
        }

        public string Name { set { name = value; } get { return name; } }
        public string Surame { set { surname = value; } get { return surname; } }
        public uint Age { set { age = value; } get { return age; } }
        public string PhoneNumber { set { phoneNumber = value; } get { return phoneNumber; } }
    }
}
