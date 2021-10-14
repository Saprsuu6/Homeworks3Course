using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Client(Base @base) => @base.AddClient(FillClient.Invoke());

        static void ClientWithMaxTime(Base @base)
        {
            var currentClients = from client in @base.Clients
                                 where client.EndTime - client.RecordingTime == (from time in @base.Clients
                                                                             select time.EndTime - time.RecordingTime).Max()
                                 select client;

            ShowClient.Show(currentClients);
        }

        static void ClientWithMinTime(Base @base)
        {
            var currentClients = from client in @base.Clients
                                 where client.EndTime - client.RecordingTime == (from time in @base.Clients
                                                                                 select time.EndTime - time.RecordingTime).Min()
                                 select client;

            ShowClient.Show(currentClients);
        }

        static void AllPersons(Base @base)
        {
            IEnumerable<IInfo> currentClients = from client in @base.Clients
                                                 select client.Person;

            ShowClient.Show(currentClients);
        }

        static void AllClients(Base @base)
        {
            IEnumerable<IInfo> currentClients = from client in @base.Clients
                                                 select client;

            ShowClient.Show(currentClients);
        }

        static void ClientsFromEvenComputers(Base @base)
        {
            IEnumerable<IInfo> currentClients = from client in @base.Clients
                                                 where client.ComputerNumber % 2 == 0
                                                 select client;

            ShowClient.Show(currentClients);
        }

        static void ClientsFromNotEvenComputers(Base @base)
        {
            IEnumerable<IInfo> currentClients = from client in @base.Clients
                                                 where client.ComputerNumber % 2 != 0
                                                 select client;

            ShowClient.Show(currentClients);
        }

        static void Main(string[] args)
        {
            Base @base = new Base();
            Client(@base);

            AllClients(@base);
            ClientsFromEvenComputers(@base);
            ClientsFromNotEvenComputers(@base);
            AllPersons(@base);
            ClientWithMaxTime(@base);
            ClientWithMinTime(@base);
        }
    }
}
