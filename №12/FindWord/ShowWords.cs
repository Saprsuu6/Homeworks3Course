using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWord
{
    class ShowWords
    {
        private Finder finder;

        public ShowWords(Finder finder) => this.finder = finder;

        public void Show()
        {
            foreach (KeyValuePair<string, int> item in finder.Words)
            {
                Console.WriteLine("{0} - {1}.", item.Key, item.Value);
            }
        }
    }
}
