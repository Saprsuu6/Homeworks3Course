using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    class Base : IBase
    {
        private List<IFurniture> furniture = new List<IFurniture>();
        private List<IClient> clients = new List<IClient>();
        private List<IContract> constracts = new List<IContract>();

        public void AddClient(IClient client) 
        {
            Client newClient = null;

            foreach (Client item in clients)
            {
                if (item.PhoneNumber == client.PhoneNumber)
                {
                    client = item;
                    break;
                }
            }

            if (newClient != null)
                throw new ApplicationException("The client already exists.");

            clients.Add(client);
        }
        public void AddFurniture(IFurniture furniture) => this.furniture.Add(furniture);
        public void DeleteClient(uint clientCode)
        {
            if (clients.Count <= 0)
                throw new ApplicationException("No clients.");

            foreach (Client item in clients)
            {
                if (item.Code == clientCode)
                {
                    clients.Remove(item);
                    break;
                }       
            }
        }
        public void DeleteFurniture(string furnitureName, string model)
        {
            if (furniture.Count <= 0)
                throw new ApplicationException("No furniture.");

            foreach (Furniture item in furniture)
            {
                if (item.Name == furnitureName &&
                    item.Model == model)
                {
                    furniture.Remove(item);
                    break;
                }
            }
        }
        public void MakeContract(IContract constract) => constracts.Add(constract);
        public Client FindClient(string phoneNumber)
        {
            if (clients.Count <= 0)
                throw new ApplicationException("No clients.");

            Client client = null;

            foreach (Client item in clients)
            {
                if (item.PhoneNumber == phoneNumber)
                {
                    client = item;
                    break;
                }
            }

            if (client == null)
                throw new ApplicationException("The client was not found.");

            return client;
        }
        public Furniture FindFurniture(string furnitureName, string model)
        {
            if (furniture.Count <= 0)
                throw new ApplicationException("No clients.");

            Furniture currentFurniture = null;

            foreach (Furniture item in furniture)
            {
                if (item.Name == furnitureName &&
                    item.Model == model)
                {
                    currentFurniture = item;
                    break;
                }
            }

            if (currentFurniture == null)
                throw new ApplicationException("The furniture was not found.");

            return currentFurniture;
        }
        public uint AmountOfFurniture(string furnitureName, string model)
        {
            uint count = 0;

            foreach (Furniture item in furniture)
            {
                if (item.Name == furnitureName &&
                    item.Model == model)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
