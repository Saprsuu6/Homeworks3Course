using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    class Sale : ISale
    {
        private static uint saleNumber = 0;
        private uint amount;
        private string furnitureName;
        private string model;

        public Sale(uint amount, string furnitureName, string model)
        {
            this.amount = amount;
            this.furnitureName = furnitureName;
            this.model = model;
        }

        public uint SaleNumber => saleNumber;
        public uint Amount { get => amount; set => amount = value; }
        public string FurnitureName { get => furnitureName; set => furnitureName = value; }
        public string Model { get => model ; set => model = value; }
    }
}
