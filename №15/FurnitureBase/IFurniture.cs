using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    interface IFurniture
    {
        string Name { get; set; }
        string Model { get; set; }
        string Material { get; set; }
        uint Length { get; set; }
        uint Width { get; set; }
        uint Hight { get; set; }
        uint Price { get; set; }
    }
}
