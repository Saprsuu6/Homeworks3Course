using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class MainForm : Form
    {
        private int seconds = 30;
        private Presenter presenter;

        public MainForm()
        {
            InitializeComponent();
            label1.BackColor = Color.DarkOrange;

            PlaySound.Play(@"..\..\..\sound\begin.wav");
        }

        public event EventHandler<EventArgs> answer;

        internal Presenter Presenter { get => presenter; set => presenter = value; }
        public string questionBox { get => QuestionBox.Text; set => QuestionBox.Text = value; }
        public string answer1 { get => Answer1.Text; set => Answer1.Text = value; }
        public string answer2 { get => Answer2.Text; set => Answer2.Text = value; }
        public string answer3 { get => Answer3.Text; set => Answer3.Text = value; }
        public string answer4 { get => Answer4.Text; set => Answer4.Text = value; }
        public Label maksLable { get => MaksLable; set => MaksLable = value; }
        public ToolStripMenuItem pause { get => Pause; set => Pause = value; }
        public System.Windows.Forms.Timer gameTimer { get => GameTimer; set => GameTimer = value; }

        private void Answer()
        {
            Pause.Enabled = false;
            answer?.Invoke(this, EventArgs.Empty);
            DiableAnswers();
            Timer.Enabled = true;
        }

        private void EnableAnswers()
        {
            QuestionBox.Enabled = true;
            Answer1.Enabled = true;
            Answer2.Enabled = true;
            Answer3.Enabled = true;
            Answer4.Enabled = true;
        }

        private void DiableAnswers()
        {
            QuestionBox.Enabled = false;
            Answer1.Enabled = false;
            Answer2.Enabled = false;
            Answer3.Enabled = false;
            Answer4.Enabled = false;
        }

        public void Reset()
        {
            PlaySound.Play(@"..\..\..\sound\gong.wav");

            Pause.Enabled = true;

            Left.Text = "Осталось 30 сек.";
            seconds = 30;
            GameTimer.Enabled = true;

            EnableAnswers();

            maksLable.Text = "Вопрос";
            maksLable.BackColor = Color.Black;
        }

        private void добавлениеВопросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();

            PlaySound.Stop();
            presenter.GetAddQuestion.Owner = this;
            presenter.GetAddQuestion.Show();
        }

        private void удалениеВопросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();

            PlaySound.Stop();
            presenter.GetRemoveQuestion.Owner = this;
            presenter.GetRemoveQuestion.Show();
        }

        private void редактированиеВопросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();

            PlaySound.Stop();
            presenter.GetChangeQuestion.Owner = this;
            presenter.GetChangeQuestion.Show();
        }

        private void Answer1_Click(object sender, EventArgs e)
        {
            GameTimer.Enabled = false;
            seconds = 0;
            presenter.Answer = Answer1.Text;
            Answer();
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            GameTimer.Enabled = false;
            seconds = 0;
            presenter.Answer = Answer2.Text;
            Answer();
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            GameTimer.Enabled = false;
            seconds = 0;
            presenter.Answer = Answer3.Text;
            Answer();
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            GameTimer.Enabled = false;
            seconds = 0;
            presenter.Answer = Answer4.Text;
            Answer();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (seconds == 2)
            {
                Timer.Enabled = false;
                Reset();
                GameTimer.Enabled = true;
            }
            else
                seconds++;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                GameTimer.Enabled = false;
                presenter.Answer = "";
                Answer();
            }
            else
            {
                seconds--;
                Left.Text = "Осталось " + seconds.ToString() + " сек.";
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (Pause.Text == "Пауза")
            {
                gameTimer.Enabled = false;
                DiableAnswers();
                Pause.Text = "Продолжить";
            }
            else
            {
                gameTimer.Enabled = true;
                EnableAnswers();
                Pause.Text = "Пауза";
            }
        }
    }
}
