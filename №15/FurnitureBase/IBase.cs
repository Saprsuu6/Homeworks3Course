using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    interface IBase
    {
        void AddFurniture(IFurniture furniture);
        void DeleteFurniture(string furnitureName, string model);
        void AddClient(IClient client);
        void DeleteClient(uint clientCode);
        void MakeContract(IContract constract);
        Client FindClient(string phoneNumber);
        Furniture FindFurniture(string furnitureName, string model);
        uint AmountOfFurniture(string furnitureName, string model);
    }
}
