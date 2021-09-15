using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkWithRegular
{
    class Regular
    {
        private Regex hasNumber = new Regex(@"[0-9]+");
        private Regex hasUpperChar = new Regex(@"[A-Z]+");
        private Regex hasLowerChar = new Regex(@"[a-z]+");
        private Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
       
        public Regex HasNumber { get { return hasNumber; } }
        public Regex HasUpperChar { get { return hasUpperChar; } }
        public Regex HasLowerChar { get { return hasLowerChar; } }
        public Regex HasSymbols { get { return hasSymbols; } }
    }
}
