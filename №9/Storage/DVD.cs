using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    class DVD : Storage
    {
        private string rotationSpeed;

        public DVD(string userName, string model,
            string capacity, string amount, string rotationSpeed)
            : base(userName, model, capacity, amount)
        {
            this.rotationSpeed = rotationSpeed;
        }

        public override string Field { set { rotationSpeed = value; } get { return rotationSpeed; } }
    }
}
