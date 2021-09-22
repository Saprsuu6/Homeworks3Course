using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Door : Component
    {
        private string material;
        private string countLoops;

        public Door(string width, string @long, string material, string countLoops) : base(width, @long)
        {
            this.material = material;
            this.countLoops = countLoops; 
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Material - {0}, Amount of loops - {1} (Door)", material, countLoops);
        }
    }
}
