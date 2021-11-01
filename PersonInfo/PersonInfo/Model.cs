using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    class Model
    {
        private List<Person> people = new List<Person>();
        private string sex;
        private string famalyState;

        public string Surname { set; get; }
        public string Name { set; get; }
        public string Patronimic { set; get; }
        public bool Men { set; get; }
        public bool Women { set; get; }
        public DateTime Birthday { set; get; }
        public bool WithFamaly { set; get; }
        public bool WithoutFamaly { set; get; }
        public string Info { set; get; }
        internal List<Person> People { get => people; set => people = value; }

        private void SetInfo()
        {
            if (Men)
                sex = "Мужчина";
            else if (Women)
                sex = "Женщина";

            if (WithoutFamaly)
                famalyState = "Без семьи";
            else if (WithFamaly)
                famalyState = "Есть семья";
        }

        public void ChangePerson(int index)
        {
            SetInfo();

            Person person = new Person(Name, Surname, Patronimic, sex, Birthday, famalyState, Info);
            people[index] = person;
        }

        public void CreatePerson()
        {
            SetInfo();

            Person person = new Person(Name, Surname, Patronimic, sex, Birthday, famalyState, Info);
            people.Add(person);
        }
    }
}
