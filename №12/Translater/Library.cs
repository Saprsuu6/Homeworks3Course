using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater
{
    class Library
    {
        private readonly string name;
        private Dictionary<string, string> dictionary;

        public Library(string name) 
        {
            this.name = name;
            dictionary = new Dictionary<string, string>();
        }

        public void AddWord(string original, string translate)
        {
            dictionary.Add(original, translate);
        }

        public void RemoveWord(string word)
        {
            dictionary.Remove(word);
        }

        public void ChangeTranslateWord(string word, string newWord)
        {
            dictionary[word] = newWord;
        }

        public string GetTranslate(string word)
        {
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                if (item.Key == word)
                {
                    return item.Value;
                }
            }

            return null;
        }
    }
}
