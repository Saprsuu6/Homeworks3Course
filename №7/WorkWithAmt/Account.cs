using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAccount
{
    class Account
    {
        private string login;
        private string passWord;
        private uint cash = 0;

        public Account(string login, string passWord)
        {
            this.login = login;
            this.passWord = passWord;
        }

        public string Login { get { return login; } }
        public string PassWord { get { return passWord; } }
        public uint Cash { set { if (cash >= 0) cash = value; } get { return cash; } }
    }
}
