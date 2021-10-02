using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCs
{
    class Changing
    {
        string line;
        string prevLine = null;
        int countTabs = 0;
        private string[] array = null;

        public void Split() => array = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        public void UpperCase()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 2)
                {
                    array[i] = array[i].ToUpper();
                }
            }
        }
        public void Join() => line = string.Join(" ", array);
        public void Tabulation()
        {
            if (prevLine != null &&
                (countTabs > 0 || prevLine.Contains('{') || prevLine.Contains('}')))
            {
                if (prevLine.Contains('}'))
                    countTabs--;

                if (!prevLine.Contains('{'))
                    countTabs--;

                for (int i = 0; i < countTabs + 1; i++)
                {
                    line = line.Insert(0, "\t");
                }

                countTabs++;
            }
        }

        public string Line { get { return line; }  set { line = value; } }
        public string PrevLine { get { return prevLine; } set { prevLine = value; } }
        public int CountTabs { get { return countTabs; } set { countTabs = value; } }
    }
}
