using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    class Cupboard : Furniture, IMirror
    {
        private uint amountLocks;
        private bool mirror;

        public Cupboard(string name, string model, string material,
            uint length, uint width, uint hight, uint price, uint amountLocks, bool mirror)
            : base(name, model, material, length, width, hight, price)
        {
            this.amountLocks = amountLocks;
            this.mirror = mirror;
        }

        public uint AmountLocks { get => amountLocks; set => amountLocks = value; }
        public bool Mirror { get => mirror; set => mirror = value; }
    }
}
