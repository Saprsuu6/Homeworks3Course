using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithAccount;

namespace WorkWithAmt
{
    class AMT
    {
        private uint cash = 10000;
        private Account account;

        public AMT(Account account) => this.account = account;
      
        public void TopUpAccount(uint sum)
        {
            account.Cash += sum;
        }

        public uint WithDrawCash(uint sum)
        {
            account.Cash -= sum;
            cash -= sum;
            
            return sum;
        }

        public uint Cash { get { return cash; } }
        public uint ClientCash { get { return account.Cash; } }
    }
}
