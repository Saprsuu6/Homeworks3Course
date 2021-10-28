using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int numberOfQuestion;
        private List<LastQuize> lastQuizes = new List<LastQuize>();
        private List<ConcreteQuestion> questions = new List<ConcreteQuestion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void FillResult(LastQuize lastQuize)
        {
            ResultFio.Text = lastQuize.Fio;
            ResultQuestion.Text = lastQuize.Quizz.Question + " (by " + lastQuize.Quizz.Author + ")";
            ResultRightAnswers.Text = string.Join(", ", lastQuize.Quizz.RightAnswers);
            ResultPersonAnswers.Text = string.Join(", ", lastQuize.PersonAnswers);
            int result = (lastQuize.Result * 100) / lastQuize.Quizz.RightAnswers.Length;
            ResultResult.Text = result.ToString();
        }

        private void ClearQuestion()
        {
            PlayerFIO.Text = "";
            for (int i = 0; i < CheckAnswers.Items.Count; i++)
                CheckAnswers.SetItemChecked(i, false);
        }

        private void ClearAdd()
        {
            Answers.Text = "";
            RightAnswers.Text = "";
            TextQuestion.Text = "";
            FIO.Text = "";
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            string[] answers = Answers.Text.Split(new[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] rightAnswers = RightAnswers.Text.Split(new[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);

            ConcreteQuestion question = new ConcreteQuestion(FIO.Text, TextQuestion.Text, answers, rightAnswers);
            questions.Add(question);
            MessageBox.Show("Question was edded.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAdd();

            ComboQuestions.Items.Add(question.Question);
        }

        private void ComboQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberOfQuestion = ComboQuestions.SelectedIndex;
            string[] answers = questions[numberOfQuestion].Answers;
            CheckAnswers.Items.AddRange(answers);
        }

        private void TextQuestion_TextChanged(object sender, EventArgs e)
        {
            if (FIO.Text == "" || TextQuestion.Text == "" 
                || Answers.Text == "" || RightAnswers.Text == "")
                AddQuestionButton.Enabled = false;
            else
                AddQuestionButton.Enabled = true;
        }

        private void CheckAnswers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int сount = CheckAnswers.CheckedItems.Count;

            if (e.NewValue == CheckState.Checked)
                сount++; 
            if (e.NewValue == CheckState.Unchecked)
                сount--;

            if (сount > 0)
                Answer.Enabled = true;
            else
                Answer.Enabled = false;
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            int index = ComboQuestions.SelectedIndex;
            CheckedItemCollection checkedItemCollection = CheckAnswers.CheckedItems;
            string playerAnswers = "";
            foreach (string item in checkedItemCollection)
                playerAnswers += item + ",";

            string[] splitPlayerAnswers = playerAnswers.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int result = LastQuize.Check(splitPlayerAnswers, questions[index].RightAnswers);
            LastQuize lastQuize = new LastQuize(questions[index], PlayerFIO.Text, splitPlayerAnswers, result);

            MessageBox.Show("Go to result.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearQuestion();

            FillResult(lastQuize);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = SaveFile.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("FIO: " + ResultFio.Text);
                    writer.WriteLine("Question: " + ResultQuestion.Text);
                    writer.WriteLine("Right answers: " + ResultRightAnswers.Text);
                    writer.WriteLine("Your answers: " + ResultPersonAnswers.Text);
                    writer.WriteLine("Result: " + ResultResult.Text);
                }
            }
        }

        private void ResultQuestion_TextChanged(object sender, EventArgs e)
        {
            if (ResultQuestion.Text == "" || ResultRightAnswers.Text == ""
                || ResultPersonAnswers.Text == "" || ResultResult.Text == "")
                Save.Enabled = true;
            else
                Save.Enabled = false;
        }
    }
}
