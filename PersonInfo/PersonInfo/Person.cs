using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    class Person
    {
        private string name;
        private string surname;
        private string patronimic;
        private string sex;
        private DateTime birthday;
        private string famalyStatus;
        private string info;

        public Person (string[] info)
        {
            name = info[0];
            surname = info[1];
            patronimic = info[2];
            sex = info[3];
            birthday = DateTime.Parse(info[4]);
            famalyStatus = info[5];
            this.info = info[6];
        }

        public Person(string name, string surname, string patronimic, string sex,
            DateTime birthday, string famalyStatus, string info)
        {
            this.name = name;
            this.surname = surname;
            this.patronimic = patronimic;
            this.sex = sex;
            this.birthday = birthday;
            this.famalyStatus = famalyStatus;
            this.info = info;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Patronimic { get => patronimic; set => patronimic = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string FamalyStatus { get => famalyStatus; set => famalyStatus = value; }
        public string Info { get => info; set => info = value; }
    }
}
