using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    class XML : Log
    {
        public override void Print(Storage st)
        {
            base.Print(st);
            Console.WriteLine("In XML form");
        }
    }
}
