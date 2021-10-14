using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class ShowClient
    {
        static public void Show(IEnumerable<IInfo> currentClients)
        {
            if (currentClients is IEnumerable<Client>)
            {
                foreach (Client item in currentClients)
                    Console.WriteLine(item.Person.GetInfo() + item.GetInfo());
            }
            else if (currentClients is IEnumerable<Person>)
            {
                foreach (Person item in currentClients)
                    Console.WriteLine(item.GetInfo());
            }
        }
    }
}
