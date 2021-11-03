using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    interface IQuestionsBase
    {
        List<string> Questions { get; }
        List<string[]> Answers { get; }
        List<string> RightAnswers { get;  }

        string GetRamdomQuestion();
        string[] GetAnswers();
        string GetRightAnswer();

        void AddQuestion(string question);
        void RemoveQuestion(int index);
        void AddAnswers(string[] answers);
        void RemoveAnswers(int index);
        void AddRightAnswer(string rightAnswer);
        void RemoveRightAnswer(int index);
    }
}
