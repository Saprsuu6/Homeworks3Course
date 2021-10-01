using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    class Client : IClient, IPerson
    {
        private static uint code = 0;
        private string phoneNumber;
        private string adress;
        private Person person;

        public Client(string name, string surname,
            string phoneNumber, string adress)
        {
            person = new Person(name, surname);
            
            this.phoneNumber = phoneNumber;
            this.adress = adress;

            code++;
        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Adress { get => adress; set => adress = value; }
        public uint Code { get => code; }
        public string Name { get => person.Name; set => person.Name = value; }
        public string Surname { get => person.Surname; set => person.Surname = value; }
    }
}
