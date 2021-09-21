using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    class USB : Storage
    {
        private string workSpeed;

        public USB(string userName, string model,
            string capacity, string amount, string workSpeed) 
            : base(userName, model, capacity, amount)
        {
            this.workSpeed = workSpeed;
        }

        public override string Field { set { workSpeed = value; } get { return workSpeed; } }
    }
}
