using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class ConcreteQuestion
    {
        private string author;
        private string question;
        private string[] answers;
        private string[] rightAnswers;

        public ConcreteQuestion(string author, string question, string[] answers, string[] rightAnswers)
        {
            this.author = author;
            this.question = question;
            this.answers = answers;
            this.rightAnswers = rightAnswers;
        }

        public string Author { get => author; set => author = value; }
        public string Question { get => question; set => question = value; }
        public string[] Answers { get => answers; set => answers = value; }
        public string[] RightAnswers { get => rightAnswers; set => rightAnswers = value; }
    }
}
