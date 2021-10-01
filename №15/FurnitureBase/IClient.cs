using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    interface IClient
    {
        string PhoneNumber { get; set; }
        string Adress { get; set; }
        uint Code { get; }
    }
}
