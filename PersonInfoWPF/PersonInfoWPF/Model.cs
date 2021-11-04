using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoWPF
{
    class Model
    {
        private List<Person> people = new List<Person>();
        private string sex;

        public string Surname { set; get; }
        public string Name { set; get; }
        public string Patronimic { set; get; }
        public bool Male { set; get; }
        public bool Famale { set; get; }
        public DateTime Birthday { set; get; }
        public string Info { set; get; }
        internal List<Person> People { get => people; set => people = value; }

        private void SetInfo()
        {
            if (Male)
                sex = "Man";
            else if (Famale)
                sex = "Woman";
        }

        public void ChangePerson(int index)
        {
            SetInfo();

            Person person = new Person(Name, Surname, Patronimic, sex, Birthday, Info);
            people[index] = person;
        }

        public void CreatePerson()
        {
            SetInfo();

            Person person = new Person(Name, Surname, Patronimic, sex, Birthday, Info);
            people.Add(person);
        }
    }
}
