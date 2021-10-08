using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Good
    {
        public Good(string name, string firm, string model, uint serialNumber, uint number)
        {
            Name = name;
            Firm = Firm;
            Model = model;
            SerialNumber = serialNumber;
            Number = number;
        }

        public string Name { get; set; }
        public string Firm { get; set; }
        public string Model { get; set; }
        public uint SerialNumber { get; set; }
        public uint Number { get; set; }
    }
}
