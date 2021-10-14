using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Base
    {
        private List<Client> clients = new List<Client>();

        public List<Client> Clients { get => clients; }

        public void AddClient(Client client)
        {
            foreach (Client item in clients)
            {
                if (item.ComputerNumber == client.ComputerNumber)
                    throw new ApplicationException("Computer is bisy.");
            }

            clients.Add(client);
        }
        public void DeleteClient(uint computerNumber)
        {
            foreach (Client item in clients)
            {
                if (item.ComputerNumber == computerNumber)
                    clients.Remove(new Client(computerNumber));
            }

            throw new ApplicationException("This computer is not bisy.");
        }

        public Client this[uint computerNumber]
        {
            get
            {
                Client currentClient = null;

                foreach (Client item in clients)
                {
                    if (item.ComputerNumber == computerNumber)
                        currentClient = new Client(computerNumber);
                }

                if (currentClient == null)
                    throw new ApplicationException("This computer is not bisy.");

                return currentClient;
            }
        }
    }
}
