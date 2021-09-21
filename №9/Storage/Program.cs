using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage st = new HDD("asd", "asd", "asd", "asd", "asd");
            BaseManagemant mng = new BaseManagemant();
            try
            {
                mng.AddStorage(st);
                int temp = 2;
                mng.MakeLogic(mng.FindByModel("asd"), temp);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
