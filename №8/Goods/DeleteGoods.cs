using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class DeleteGoods
    {
        public void Enter(Logic logic)
        {
            Console.Write("Enter the name of product: ");
            string name = Console.ReadLine();

            logic.Sell(name);
        }
    }
}
