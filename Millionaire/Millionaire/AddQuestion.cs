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
    public partial class AddQuestion : Form
    {
        private Presenter presenter;

        public AddQuestion()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> add;

        internal Presenter Presenter { get => presenter; set => presenter = value; }
        public string addQuestionBox { get => AddQuestionBox.Text; }
        public string addRightAnswerBox { get => AddRightAnswerBox.Text; }
        public string addAnswer1 { get => AddAnswer1.Text; }
        public string addAnswer2 { get => AddAnswer2.Text; }
        public string addAnswer3 { get => AddAnswer3.Text; }
        public string addAnswer4 { get => AddAnswer4.Text; }

        private void Clear()
        {
            AddQuestionBox.Text = "";
            AddRightAnswerBox.Text = "";
            AddAnswer1.Text = "";
            AddAnswer2.Text = "";
            AddAnswer3.Text = "";
            AddAnswer4.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Owner.Show();
            presenter.MainForm.Reset();
            presenter.MainForm.pause.Enabled = true;
            PlaySound.Play(@"..\..\..\sound\gong.wav");
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            add?.Invoke(this, EventArgs.Empty);
            Clear();
        }

        private void AddQuestionBox_TextChanged(object sender, EventArgs e)
        {
            if (AddQuestionBox.Text != "" && AddRightAnswerBox.Text != "" &&
                AddAnswer1.Text != "" && AddAnswer2.Text != "" &&
                AddAnswer3.Text != "" && AddAnswer4.Text != "")
                Add.Enabled = true;
            else
                Add.Enabled = false;
        }
    }
}
