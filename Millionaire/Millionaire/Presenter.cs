using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Millionaire
{
    class Presenter
    {
        private IQuestionsBase questionsBase = new QuestionsBase();
        private MainForm mainForm;
        private AddQuestion addQuestion;
        private RemoveQuestion removeQuestion;
        private ChangeQuestion changeQuestion;
        private string answer;

        private int numOfLabel = 1;
        private string label = "label1";

        public Presenter(MainForm mainForm, AddQuestion addQuestion, RemoveQuestion removeQuestion, ChangeQuestion changeQuestion)
        {
            removeQuestion.numberOfQuestion.Maximum = questionsBase.Questions.Count;
            changeQuestion.numberOfQuestion.Maximum = questionsBase.Questions.Count;

            this.mainForm = mainForm;
            this.addQuestion = addQuestion;
            this.removeQuestion = removeQuestion;
            this.changeQuestion = changeQuestion;

            mainForm.answer += new EventHandler<EventArgs>(CheckAnswer);
            addQuestion.add += new EventHandler<EventArgs>(AddQuestion);
            removeQuestion.numberQuestion += new EventHandler<EventArgs>(GetCurrentQuestion);
            removeQuestion.remove += new EventHandler<EventArgs>(Remove);
            changeQuestion.numberQuestion += new EventHandler<EventArgs>(GetCurrentQuestionToEdit);
            changeQuestion.edit += new EventHandler<EventArgs>(Edit);
        }

        public MainForm MainForm { get => mainForm; }
        public AddQuestion GetAddQuestion { get => addQuestion; }
        public RemoveQuestion GetRemoveQuestion { get => removeQuestion; }
        public ChangeQuestion GetChangeQuestion { get => changeQuestion; }
        public string Answer { set => answer = value; }

        private void CheckAnswer(object sender, EventArgs e)
        {
            string reightAnswer = questionsBase.GetRightAnswer();
            
            if (answer.ToLower() == reightAnswer.ToLower())
            {
                PlaySound.Play(@"..\..\..\sound\true.wav");

                mainForm.maksLable.Text = "Правильно!";
                mainForm.maksLable.BackColor = Color.Green;

                Label lab1 = mainForm.Controls.Find(label, true).FirstOrDefault() as Label;
                lab1.BackColor = Color.Black;

                numOfLabel++;
                label = "label" + numOfLabel.ToString();
                Label lab2 = mainForm.Controls.Find(label, true).FirstOrDefault() as Label;
                lab2.BackColor = Color.DarkOrange;

                if (numOfLabel == 15)
                {
                    PlaySound.Play(@"..\..\..\sound\true.wav");
                    MessageBox.Show("Вы выиграли 1 000 000 рублей!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                PlaySound.Play(@"..\..\..\sound\false.wav");

                mainForm.maksLable.Text = "Не правильно!";
                mainForm.maksLable.BackColor = Color.Red;
                Label lab2 = mainForm.Controls.Find(label, true).FirstOrDefault() as Label;
                string sum = lab2.Text.Remove(0, 5);
                MessageBox.Show("Вы выиграли " + sum + " рублей!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lab2.BackColor = Color.Black;

                Label lab3 = mainForm.Controls.Find("label1", true).FirstOrDefault() as Label;
                lab3.BackColor = Color.DarkOrange;

                label = "label1";
                numOfLabel = 1;
            }

            Update();
        }

        private void Edit(object sender, EventArgs e)
        {
            string[] answers = new string[4];
            int index = Convert.ToInt32(changeQuestion.numberOfQuestion.Value) - 1;
            string question = changeQuestion.changeQuestionBox;
            string rightAnswer = changeQuestion.changeRightAnswerBox;
            answers[0] = changeQuestion.changeAnswer1;
            answers[1] = changeQuestion.changeAnswer2;
            answers[2] = changeQuestion.changeAnswer3;
            answers[3] = changeQuestion.changeAnswer4;

            questionsBase.Questions[Convert.ToInt32(changeQuestion.numberOfQuestion.Value) - 1] = question;
            questionsBase.RightAnswers[Convert.ToInt32(changeQuestion.numberOfQuestion.Value) - 1] = rightAnswer;
            
            for (int i = 0; i < 4; i++)
                questionsBase.Answers[Convert.ToInt32(changeQuestion.numberOfQuestion.Value) - 1][i] = answers[i];

            Update();
        }

        private void GetCurrentQuestionToEdit(object sender, EventArgs e)
        {
            string question = questionsBase.Questions[Convert.ToInt32(changeQuestion.numberOfQuestion.Value) - 1];
            string[] answers = questionsBase.Answers[Convert.ToInt32(changeQuestion.numberOfQuestion.Value) - 1];
            string rightAnswer = questionsBase.RightAnswers[Convert.ToInt32(changeQuestion.numberOfQuestion.Value) - 1];

            changeQuestion.changeQuestionBox = question;
            changeQuestion.changeRightAnswerBox = rightAnswer;
            changeQuestion.changeAnswer1 = answers[0];
            changeQuestion.changeAnswer2 = answers[1];
            changeQuestion.changeAnswer3 = answers[2];
            changeQuestion.changeAnswer4 = answers[3];
        }

        private void Remove(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(removeQuestion.numberOfQuestion.Value) - 1;
            questionsBase.RemoveQuestion(index);
            questionsBase.RemoveAnswers(index);
            questionsBase.RemoveRightAnswer(index);

            removeQuestion.numberOfQuestion.Maximum = questionsBase.Questions.Count;
            changeQuestion.numberOfQuestion.Maximum = questionsBase.Questions.Count;

            Update();
        }

        private void GetCurrentQuestion(object sender, EventArgs e)
        {
            string question = questionsBase.Questions[Convert.ToInt32(removeQuestion.numberOfQuestion.Value) - 1];
            removeQuestion.question = question;
        }

        private void AddQuestion(object sender, EventArgs e)
        {
            string[] answers = new string[4];
            string question = addQuestion.addQuestionBox;
            string rightAnswer = addQuestion.addRightAnswerBox;
            answers[0] = addQuestion.addAnswer1;
            answers[1] = addQuestion.addAnswer2;
            answers[2] = addQuestion.addAnswer3;
            answers[3] = addQuestion.addAnswer4;

            questionsBase.AddQuestion(question);
            questionsBase.AddRightAnswer(rightAnswer);
            questionsBase.AddAnswers(answers);

            removeQuestion.numberOfQuestion.Maximum = questionsBase.Questions.Count;
            changeQuestion.numberOfQuestion.Maximum = questionsBase.Questions.Count;
            Update();
        }

        private void Update()
        {
            string question = questionsBase.GetRamdomQuestion();
            string[] answers = questionsBase.GetAnswers();

            mainForm.questionBox = question;
            mainForm.answer1 = answers[0];
            mainForm.answer2 = answers[1];
            mainForm.answer3 = answers[2];
            mainForm.answer4 = answers[3];
        }
    }
}
