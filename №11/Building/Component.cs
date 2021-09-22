using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    abstract class Component : IPart
    {
        protected string width;
        protected string @long;

        public Component(string width, string @long) 
        {
            this.width = width;
            this.@long = @long;
        }

        public virtual void Print()
        {
            Console.Write("Width - {0}, Long - {1}, ",width, @long); 
        }
    }
}
