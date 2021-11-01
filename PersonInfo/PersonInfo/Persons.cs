using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfo
{
    public partial class Persons : Form, IViewAdd
    {
        public event EventHandler<EventArgs> dataSave;
        public event EventHandler<EventArgs> dataRemove;
        public event EventHandler<EventArgs> dataSaveInFile;
        public event EventHandler<EventArgs> dataEdit;

        public Persons()
        { 
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        public Button GetRemove { get => Remove; }
        public ListBox listBox { get => List; }
        public ToolStripButton Button { get => toolStripButton1; }
        public string GetSetSurname { set => Surname.Text = value; get => Surname.Text; }
        public string GetSetName { set => PersonName.Text = value; get => PersonName.Text; }
        public string GetSetPatronimic { set => Patronimic.Text = value; get => Patronimic.Text; }
        public bool GetSetMen { set => Men.Checked = value; get => Men.Checked; }
        public bool GetSetWomen { set => Woman.Checked = value; get => Woman.Checked; }
        public DateTime GetSetBirthday { set => Birthday.Value = value; get => Birthday.Value; }
        public bool GetSetStatusWithFamaly { set => WithooutFamily.Checked = value; get => WithooutFamily.Checked; }
        public bool GetSetStatusWithoutFamaly { set => WithFamily.Checked = value; get => WithFamily.Checked; }
        public string GetSetInfo { set => Info.Text = value; get => Info.Text; }

        private void Check()
        {
            if (PersonName.Text != "" && Surname.Text != "" && Patronimic.Text != "")
                Save.Enabled = true;
            else
                Save.Enabled = false;
        }

        private void Clear()
        {
            PersonName.Text = "";
            Surname.Text = "";
            Patronimic.Text = "";
            Men.Checked = false;
            Woman.Checked = false;
            Birthday.Refresh();
            WithooutFamily.Checked = false;
            WithFamily.Checked = false;
            Info.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            dataSave?.Invoke(this, EventArgs.Empty);

            Clear();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List.SelectedItem != null)
            {
                Remove.Enabled = true;
                Edit.Enabled = true;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (List.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                    dataRemove?.Invoke(this, EventArgs.Empty);
            }

            Clear();
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void PersonName_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void Patronimic_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            dataEdit?.Invoke(this, EventArgs.Empty);
            Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                Surname.Font = FontDialog.Font;
                PersonName.Font = FontDialog.Font;
                Patronimic.Font = FontDialog.Font;
                Birthday.Font = FontDialog.Font;
                Info.Font = FontDialog.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
                BackColor = ColorDialog.Color;
        }

        private void colourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Surname.ForeColor = ColorDialog.Color;
                PersonName.ForeColor = ColorDialog.Color;
                Patronimic.ForeColor = ColorDialog.Color;
                Birthday.ForeColor = ColorDialog.Color;
                Info.ForeColor = ColorDialog.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataSaveInFile?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Информация успешно сохранена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
                List.Font = FontDialog.Font;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
                List.ForeColor = ColorDialog.Color;
        }

        private void backgroundColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
                List.BackColor = ColorDialog.Color;
        }
    }
}
