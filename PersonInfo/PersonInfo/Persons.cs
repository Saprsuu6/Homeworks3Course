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

            List.Items.Add(person.Surname + " " + person.Name + " " + person.Patronimic);

            WorkWithFile.WriteToFileXml(person);
            WorkWithFile.WriteToFileTxt(person);

            MessageBox.Show("Информация успешно сохранена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List.SelectedItem != null)
            {
                Remove.Enabled = true;

                int index = List.SelectedIndex;
                Person person = people[index];

                PersonName.Text = person.Name;
                Surname.Text = person.Surname;
                Patronimic.Text = person.Patronimic;
                if (person.Sex == "Мужчина")
                    Мужчина.Checked = true;
                else if (person.Sex == "Женщина")
                    Женщина.Checked = true;
                Birthday.Value = person.Birthday;
                if (person.FamalyStatus == "Без семьи")
                    БезСемьи.Checked = true;
                else if (person.FamalyStatus == "Есть семья")
                    ЕстьСемья.Checked = true;
                Info.Text = person.Info;
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
    }
}
