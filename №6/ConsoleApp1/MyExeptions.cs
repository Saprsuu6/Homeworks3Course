using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyExeptions : ApplicationException
    {
        public MyExeptions(string message) : base(message) { }
    }

    class NotEquals : MyExeptions
    {
        public NotEquals() : base("Vectors isn't equals") { }
    }

    class Equals : MyExeptions
    {
        public Equals() : base("Vectors is equals") { }
    }

    class CoppyTheSame : MyExeptions
    {
        public CoppyTheSame() : base("You can't coppy the same vector") { }
    }
}
