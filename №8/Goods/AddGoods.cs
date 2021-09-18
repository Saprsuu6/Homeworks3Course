using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class AddGoods
    {
        public void Enter(Logic logic)
        {
            Console.Write("Is that chemistry - 1 or food - 2: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the date of creation: ");
            string dateOfCreation = Console.ReadLine();

            Console.Write("Enter the date to: ");
            string dateTo = Console.ReadLine();

            Console.Write("Enter the components: ");
            string components = Console.ReadLine();

            Console.Write("Enter the instuction: ");
            string instuction = Console.ReadLine();

            Console.Write("Enter the price: ");
            double price = Convert.ToInt64(Console.ReadLine());

            if (temp == 1)
                logic.Add(new Chemistry(price, name, dateOfCreation, dateTo, components, instuction));
            else if (temp == 2)
                logic.Add(new Food(price, name, dateOfCreation, dateTo, components, instuction));
        }
    }
}
