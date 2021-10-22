using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOIL.Classes
{
    class MiniCafe
    {
        private string[] food = { "Хот-дог", "Гамбургер", "Картошка-фри", "Кока-кола" };
        private double[] prices = { 4, 5.40, 7.20, 8 };

        public string[] Food { get => food; set => food = value; }
        public double[] Prices { get => prices; set => prices = value; }
    }
}
