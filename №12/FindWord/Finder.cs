using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWord
{
    sealed class Finder
    {
        private Dictionary<string, int> words;
        private int current = -1;

        public Finder() => words = new Dictionary<string, int>();

        public Dictionary<string, int> Words { get { return words; } }

        public void Find(string word, string text)
        {
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            foreach (string item in words)
            {
                if (item == word)
                    counter++;
            }

            if (counter == 0)
                throw new ApplicationException("The word was not found");

            this.words.Add(word, counter);
        }
    }
}
