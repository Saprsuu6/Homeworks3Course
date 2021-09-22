using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Basemant : Component
    {
        private string depth;

        public Basemant(string width, string @long, string depth) : base(width, @long)
        {
            this.depth = depth;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("depth - {0} (Basemant)", depth);
        }
    }
}
