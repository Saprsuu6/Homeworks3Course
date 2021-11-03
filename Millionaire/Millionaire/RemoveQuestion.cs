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
    public partial class RemoveQuestion : Form
    {
        private Presenter presenter;

        public RemoveQuestion()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> numberQuestion;
        public event EventHandler<EventArgs> remove;

        internal Presenter Presenter { get => presenter; set => presenter = value; }
        public string question { set => Question.Text = value; }
        public NumericUpDown numberOfQuestion { get => NumberOfQuestion; }

        private void NumberOfQuestion_ValueChanged(object sender, EventArgs e)
        {
            if (NumberOfQuestion.Value == 0)
            {
                Question.Text = "";
                Remove.Enabled = false;
            }
            else
            {
                numberQuestion?.Invoke(this, EventArgs.Empty);
                Remove.Enabled = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Owner.Show();
            presenter.MainForm.Reset();
            presenter.MainForm.pause.Enabled = true;
            PlaySound.Play(@"..\..\..\sound\gong.wav");
            Hide();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            remove?.Invoke(this, EventArgs.Empty);
            NumberOfQuestion.Value = 0;
        }
    }
}
