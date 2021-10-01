using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    class Program
    {
        static void Main(string[] args)
        {
            IBase @base = new Base();
            @base.AddFurniture(new ComputerTable("table", "123", "wood", 1, 1, 1, 1000, 5, "cub"));
            @base.AddFurniture(new Cupboard("cupboard", "123", "wood", 10, 10, 10, 1000, 5, true));
            @base.AddFurniture(new Curbstone("curbstone", "123", "wood", 10, 10, 10, 1000, 5, "cub"));

            IFurniture furniture = @base.FindFurniture("cupboard", "123");

            if (furniture is IForm)
            {
                IForm concretFurniture = (IForm)furniture;
                Console.WriteLine("Amount locks is - {0}", concretFurniture.AmountLocks);
            }
            else if (furniture is IMirror)
            {
                IMirror concretFurniture = (IMirror)furniture;
                Console.WriteLine("Amount locks is - {0}", concretFurniture.AmountLocks);
            }

            try
            {
                @base.AddClient(new Client("Andry", "Saprigin", "0639830317", "asd"));

                IContract contract = new Contract(
                    @base.FindClient("0639830317").Code,
                    "2002.08.08", "2030.08.07");

                Console.WriteLine("Amount - {0}", @base.AmountOfFurniture("table", "123"));

                contract.AddSale(new Sale(1, "table", "123"));
                @base.DeleteFurniture("table", "123");

                Console.WriteLine("Amount - {0}", @base.AmountOfFurniture("table", "123"));

                contract.AddSale(new Sale(1, "cupboard", "123"));
                @base.DeleteFurniture("cupboard", "123");

                Console.WriteLine("Amount - {0}", @base.AmountOfFurniture("table", "123"));

                contract.AddSale(new Sale(1, "curbstone", "123"));
                @base.DeleteFurniture("curbstone", "123");

                @base.MakeContract(contract);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
