using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class QuestionsBase : IQuestionsBase
    {
        private int numberOfQuestion;
        private List<string> questions = new List<string>();
        private List<string[]> answers = new List<string[]>();
        private List<string> rightAnswers = new List<string>();

        public List<string> Questions { get => questions; }
        public List<string[]> Answers { get => answers; }
        public List<string> RightAnswers { get => rightAnswers;}

        public QuestionsBase() { }

        public QuestionsBase(List<string> questions, List<string[]> answers, List<string> rightAnswers)
        {
            this.questions = questions;
            this.answers = answers;
            this.rightAnswers = rightAnswers;
        }

        public void AddAnswers(string[] answers) => this.answers.Add(answers);
        public void AddQuestion(string question) => questions.Add(question);
        public void AddRightAnswer(string rightAnswer) => rightAnswers.Add(rightAnswer);

        public string GetRamdomQuestion()
        {
            Random random = new Random();
            numberOfQuestion = random.Next(questions.Count);

            if (questions.Count == 0)
                return null;

            return questions[numberOfQuestion];
        }
        public string[] GetAnswers()
        {
            if (questions.Count == 0)
                return new string[] { "", "", "", ""};

            return answers[numberOfQuestion];
        }
        public string GetRightAnswer()
        {
            if (rightAnswers.Count == 0)
                return null;

            return rightAnswers[numberOfQuestion];
        }

        public void RemoveQuestion(int index) => questions.RemoveAt(index);
        public void RemoveAnswers(int index) => answers.RemoveAt(index);
        public void RemoveRightAnswer(int index) => rightAnswers.RemoveAt(index);
    }
}
