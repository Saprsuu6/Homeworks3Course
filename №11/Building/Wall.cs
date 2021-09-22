using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Wall : Component
    {
        private string material;
        public Wall(string width, string @long, string material) : base(width, @long)
        {
            this.material = material;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("material - {0} (Wall)", material);
        }
    }
}
