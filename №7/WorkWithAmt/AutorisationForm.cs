using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithBaseManagemant;
using WorkWithRegular;
using WorkWithAccount;

namespace WorkWithAutorisation
{
    class AutorisationForm
    {
        private string login;
        private string passWord;
        private bool isValid;
        private Regular regular;
        private int counter = 0;

        public delegate bool AccountCheckHandler(string login);
        internal AccountCheckHandler delCheck;

        public void FindHandler(AccountCheckHandler delCheck) => this.delCheck = delCheck;

        private void Input()
        {
            Console.Write("Enter your login: ");
            login = Console.ReadLine();

            Console.Write("Enter your password: ");
            passWord = Console.ReadLine();
        }

        public AutorisationForm(Regular regular)
        {
            this.regular = regular;
        }

        public void Attemp()
        {
            counter++;
            Input();

            if (!delCheck.Invoke(login))
            {
                throw new ApplicationException("Employer whith ligon was not registrated.");
            }

            isValid = regular.HasLowerChar.IsMatch(passWord) &&
                regular.HasNumber.IsMatch(passWord) &&
                !regular.HasSymbols.IsMatch(passWord) &&
                regular.HasUpperChar.IsMatch(passWord);

            if (!isValid)
            {
                if (counter == 3)
                {
                    throw new ApplicationException("Amount of attempts is over.");
                }
                throw new ApplicationException("Unvalid password! Try again");
            }
        }

        public string Login { get { return login; } }
    }
}
