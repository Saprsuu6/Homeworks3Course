using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Chemistry : Goods
    {
        static private int amount;

        public Chemistry(double price, string name, string dateOfCreation,
            string dateTo, string components, string instruction) : 
            base(price, name, dateOfCreation, dateTo, components, instruction)
        { amount++; }

        public override int Amount { get { return amount; } }
    }
}
