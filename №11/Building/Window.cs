using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Window : Component
    {
        private string material;
        private string type;

        public Window(string width, string @long, string material, string type) : base(width, @long)
        {
            this.material = material;
            this.type = type;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Material - {0}, Type - {1} (Window)", material, type);
        }
    }
}
