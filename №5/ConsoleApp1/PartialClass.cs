using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Car
    {
        public void GoFaster() => speedNow++;
        public void GoSlowly() => speedNow--;
    }
}
