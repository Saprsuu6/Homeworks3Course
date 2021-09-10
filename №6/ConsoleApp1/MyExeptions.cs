using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NotEquals : ApplicationException
    {
        public NotEquals() : base("Vectors isn't equals") { }
    }

    class Equals : ApplicationException
    {
        public Equals() : base("Vectors is equals") { }
    }

    class CountParams : ApplicationException
    {
        public CountParams() : base("Could be grater or less the 3 parametrs") { }
    }
}
