using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class ChangeQuestion : Form
    {
        private Presenter presenter;

        public ChangeQuestion()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> numberQuestion;
        public event EventHandler<EventArgs> edit;

        internal Presenter Presenter { get => presenter; set => presenter = value; }
        public NumericUpDown numberOfQuestion { get => NumberOfQuestion; }
        public string changeQuestionBox { get => ChangeQuestionBox.Text; set => ChangeQuestionBox.Text = value; }
        public string changeRightAnswerBox { get => ChangeRightAnswerBox.Text; set => ChangeRightAnswerBox.Text = value; }
        public string changeAnswer1 { get => ChangeAnswer1.Text; set => ChangeAnswer1.Text = value; }
        public string changeAnswer2 { get => ChangeAnswer2.Text; set => ChangeAnswer2.Text = value; }
        public string changeAnswer3 { get => ChangeAnswer3.Text; set => ChangeAnswer3.Text = value; }
        public string changeAnswer4 { get => ChangeAnswer4.Text; set => ChangeAnswer4.Text = value; }

        private void ChangeQuestionBox_TextChanged(object sender, EventArgs e)
        {
            if (ChangeQuestionBox.Text != "" && ChangeRightAnswerBox.Text != "" &&
                    ChangeAnswer1.Text != "" && ChangeAnswer2.Text != "" &&
                    ChangeAnswer3.Text != "" && ChangeAnswer4.Text != "")
                Edit.Enabled = true;
            else
                Edit.Enabled = false;
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            Owner.Show();
            presenter.MainForm.Reset();
            presenter.MainForm.pause.Enabled = true;
            PlaySound.Play(@"..\..\..\sound\gong.wav");
            Hide();
        }

        private void NumberOfQuestion_ValueChanged(object sender, EventArgs e)
        {
            if (NumberOfQuestion.Value == 0)
            {
                ChangeQuestionBox.Text = "";
                ChangeRightAnswerBox.Text = "";
                ChangeAnswer1.Text = "";
                ChangeAnswer2.Text = "";
                ChangeAnswer3.Text = "";
                ChangeAnswer4.Text = "";

                ChangeQuestionBox.Enabled = false;
                ChangeRightAnswerBox.Enabled = false;
                ChangeAnswer1.Enabled = false;
                ChangeAnswer2.Enabled = false;
                ChangeAnswer3.Enabled = false;
                ChangeAnswer4.Enabled = false;

                Edit.Enabled = false;
            }
            else
            {
                numberQuestion?.Invoke(this, EventArgs.Empty);

                ChangeQuestionBox.Enabled = true;
                ChangeRightAnswerBox.Enabled = true;
                ChangeAnswer1.Enabled = true;
                ChangeAnswer2.Enabled = true;
                ChangeAnswer3.Enabled = true;
                ChangeAnswer4.Enabled = true;

                Edit.Enabled = true;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            edit?.Invoke(this, EventArgs.Empty);
        }
    }
}
