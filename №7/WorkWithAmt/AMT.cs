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
        private uint sum;
        private uint cash = 10000;
        private Account account;

        public delegate Account AccountHandler(string login);
        public delegate void AccountDoSmthAccountHandler();
        internal AccountHandler del;
        internal AccountDoSmthAccountHandler delToUp;

        public void Input()
        {
            Random rand = new Random();
            int num = rand.Next(100, 1000);

            // подсказка
            Console.Write("{0}", num);

            Console.Write("Enter the 4 numbers in your massges: ");
            if (Convert.ToUInt32(Console.ReadLine()) != num)
            {
                throw new ApplicationException("Not correct number.");
            }
        }

        public void DoSmthHandler(AccountDoSmthAccountHandler delInput,
            AccountDoSmthAccountHandler delToUp)
        {
            this.delToUp += delInput;
            this.delToUp += delToUp;
        }

        public void FindHandler(AccountHandler del) => this.del = del;

        public void SetAccount(string login) => account = del?.Invoke(login);

        public AMT() { }

        public void TopUp()
        {
            account.Cash += sum;
        }

        public void TopUpAccount(uint sum)
        {
            this.sum = sum;
            delToUp?.Invoke();
            this.sum = 0;
        }

        public void WithDraw()
        {
            if (sum <= cash)
            {
                account.Cash -= sum;
                cash -= sum;
            }
            else
                throw new ApplicationException("Not enought maney is AMT.");
        }

        public uint WithDrawCash(uint sum)
        {
            this.sum = sum;
            delToUp?.Invoke();
            this.sum = 0;

            return sum;
        }

        public uint Cash { get { return cash; } }
        public uint ClientCash { get { return account.Cash; } }
    }
}
