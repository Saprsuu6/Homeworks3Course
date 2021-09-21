using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    class HDD : Storage
    {
        private string wilingSpeed;

        public HDD(string userName, string model,
            string capacity, string amount, string wilingSpeed)
            : base(userName, model, capacity, amount)
        {
            this.wilingSpeed = wilingSpeed;
        }

        public override string Field { set { wilingSpeed = value; } get { return wilingSpeed; } }
    }
}
