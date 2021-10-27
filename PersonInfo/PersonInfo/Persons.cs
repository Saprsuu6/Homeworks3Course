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
    public partial class Persons : Form
    {
        private List<Person> people = new List<Person>();
        private string sex;
        private string famalyState;

        public Persons()
        { 
            InitializeComponent();
            WorkWithFile.ReadingXml(people, this);
        }

        public ListBox listBox { get => List; set => List = value; }
        public ToolStripButton Button { get => toolStripButton1; set => toolStripButton1 = value; }

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
            Мужчина.Checked = false;
            Женщина.Checked = false;
            Birthday.Refresh();
            БезСемьи.Checked = false;
            ЕстьСемья.Checked = false;
            Info.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Мужчина.Checked)
                sex = "Мужчина";
            else if (Женщина.Checked)
                sex = "Женщина";

            if (БезСемьи.Checked)
                famalyState = "Без семьи";
            else if (ЕстьСемья.Checked)
                famalyState = "Есть семья";

            DateTime birthday = new DateTime(Birthday.Value.Year, Birthday.Value.Month, Birthday.Value.Day);
            Person person = new Person(PersonName.Text, Surname.Text, Patronimic.Text,
                sex, birthday, famalyState, Info.Text);
            people.Add(person);

            if (List.SelectedItem != null)
            {
                int index = List.SelectedIndex;
                people.RemoveAt(index);
                List.Items.RemoveAt(index);

                Remove.Enabled = false;
                Clear();
            }

            string fio = person.Surname + " " + person.Name + " " + person.Patronimic;
            List.Items.Add(fio.ToLower());
            toolStripButton1.Enabled = true;
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
                {
                    int index = List.SelectedIndex;
                    WorkWithFile.DeletePerson(List.SelectedItem.ToString());
                    people.RemoveAt(index);
                    List.Items.RemoveAt(index);

                    Remove.Enabled = false;
                    Clear();
                }
            }
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
            int index = List.SelectedIndex;
            Edit edit = new Edit(people[index], people, index);
            edit.Owner = this;
            edit.ShowDialog();

            WorkWithFile.DeletePerson(List.SelectedItem.ToString());
            string fio = people[index].Surname + " " + people[index].Name + " " + people[index].Patronimic;
            List.Items[index] = fio.ToLower();
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
            foreach (Person item in people)
            {
                WorkWithFile.WriteToFileXml(item);
                WorkWithFile.WriteToFileTxt(item);
            }

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
