using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class LastQuize
    {
        static public int Check(string[] answers, string[] rightAnswers)
        {
            int result = 0;

            foreach (string item1 in answers)
            {
                foreach (string item2 in rightAnswers)
                {
                    if (item1 == item2)
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }

        private ConcreteQuestion quizz;
        private string fio;
        private string[] personAnswers;
        private int result;

        public LastQuize(ConcreteQuestion quizz, string fio, 
            string[] personAnswers, int result)
        {
            this.quizz = quizz;
            this.fio = fio;
            this.personAnswers = personAnswers;
            this.result = result;
        }

        public string Fio { get => fio; set => fio = value; }
        public string[] PersonAnswers { get => personAnswers; set => personAnswers = value; }
        internal ConcreteQuestion Quizz { get => quizz; set => quizz = value; }
        public int Result { get => result; set => result = value; }
    }
}
