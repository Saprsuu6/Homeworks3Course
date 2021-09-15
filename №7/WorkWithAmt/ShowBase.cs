using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithBaseManagemant;

namespace WorkWithAmt
{
    class ShowBase
    {
        private BaseManagemant mng;

        public ShowBase(BaseManagemant mng) => this.mng = mng;

        public void Show()
        {
            for (int i = 0; i < mng.Length; i++)
            {
                Console.WriteLine("Login - {0}, Cash - {1}\n", mng[i].Login, mng[i].Cash);
            }
        }
    }
}
