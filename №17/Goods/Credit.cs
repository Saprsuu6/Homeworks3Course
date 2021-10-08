using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Credit
    {
        public Credit(uint amountMonth, uint sumByMonth)
        {
            AmountMonth = amountMonth;
            SumByMonth = sumByMonth;
        }

        public uint AmountMonth { get; set; }
        public uint SumByMonth { get; set; }
    }
}
