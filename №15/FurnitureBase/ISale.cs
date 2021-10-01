using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    interface ISale
    {
        uint SaleNumber { get; }
        uint Amount { get; set; }
        string FurnitureName { get; set; }
        string Model { get; set; }
    }
}
