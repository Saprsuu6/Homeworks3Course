using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class AllInfo
    {
        public AllInfo(Good good, Manufucturer manufucturer, Chracteristics chracteristics, Price price, Credit credit)
        {
            Good = good;
            Manufucturer = manufucturer;
            Chracteristics = chracteristics;
            Price = price;
            Credit = credit;
        }

        public Good Good{ get; set; }
        public Manufucturer Manufucturer { get; set; }
        public Chracteristics Chracteristics { get; set; }
        public Price Price { get; set; }
        public Credit Credit { get; set; }
    }
}
