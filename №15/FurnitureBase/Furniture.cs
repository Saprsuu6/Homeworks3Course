using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    abstract class Furniture : IFurniture
    {
        protected string name;
        protected string model;
        protected string material;
        protected uint length;
        protected uint width;
        protected uint hight;
        protected uint price;

        public Furniture(string name, string model, string material, 
            uint length, uint width, uint hight, uint price)
        {
            this.name = name;
            this.model = model;
            this.material = material;
            this.length = length;
            this.width = width;
            this.hight = hight;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public string Material { get => material; set => material = value; }
        public uint Length { get => length; set => length = value; }
        public uint Width { get => width; set => width = value; }
        public uint Hight { get => hight; set => hight = value; }
        public uint Price { get => price; set => price = value; }
    }
}
