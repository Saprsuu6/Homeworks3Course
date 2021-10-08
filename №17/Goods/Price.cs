using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Price
    {
        public Price(uint price, uint priceForGoods)
        {
            _Price = price;
            PriceForGoods = priceForGoods;
        }

        public uint _Price { get; set; }
        public uint PriceForGoods { get; set; }
    }
}
