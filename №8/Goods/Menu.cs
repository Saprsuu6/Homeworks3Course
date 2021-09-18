using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Menu
    {
        protected Logic logic;

        public Menu() => logic = new Logic();

        public virtual void Enter()
        {
            Console.WriteLine("1. Add product.\n2. Sell product.");
            Console.Write("Make your choose: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 1)
            {
                AddGoods add = new AddGoods();
                add.Enter(logic);
            }
            else if (temp == 2)
            {
                DeleteGoods delete = new DeleteGoods();
                delete.Enter(logic);
            }
        }
    }
}
