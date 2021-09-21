using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Storage
{
    abstract class Storage
    {
        protected string userName;
        protected string model;
        protected string capacity;
        protected string amount;

        public Storage(string userName, string model,
            string capacity, string amount)
        {
            this.userName = userName;
            this.model = model;
            this.capacity = capacity;
            this.amount = amount;
        }

        public string UserName { set { userName = value; } get { return userName; } }
        public string Model { set { model = value; } get { return model; } }
        public string Capacity { set { capacity = value; } get { return capacity; } }
        public string Amount { set { amount = value; } get { return amount; } }

        public abstract string Field { set; get; }
    }
}
