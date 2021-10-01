using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    class Curbstone : Furniture, IForm
    {
        private uint amountLocks;
        private string form;

        public Curbstone(string name, string model, string material,
            uint length, uint width, uint hight, uint price, uint amountLocks, string form)
            : base(name, model, material, length, width, hight, price)
        {
            this.amountLocks = amountLocks;
            this.form = form;
        }

        public uint AmountLocks { get => amountLocks; set => amountLocks = value; }
        public string Form { get => form; set => form = value; }
    }
}
