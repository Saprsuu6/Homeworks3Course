using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    abstract class Goods
    {
        protected double price;
        protected string name;
        protected string dateOfCreation;
        protected string dateTo;
        private string components;
        private string instruction;

        public Goods(double price, string name, string dateOfCreation,
            string dateTo, string components, string instruction)
        {
            this.name = name;
            this.dateOfCreation = dateOfCreation;
            this.dateTo = dateTo;
            this.price = price;
            this.components = components;
            this.instruction = instruction;
        }

        public abstract int Amount { get; }

        public string DateOfCreation 
        {
            set { dateOfCreation = value; }
            get { return dateOfCreation; }
        }
        public string DateTo
        {
            set { dateTo = value; }
            get { return dateTo; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        protected double Price
        {
            set { if (value > 0) price = value; }
            get { return price; }
        }
        public string Components
        {
            set { components = value; }
            get { return components; }
        }
        public string Instruction
        {
            set { instruction = value; }
            get { return instruction; }
        }
    }
}
