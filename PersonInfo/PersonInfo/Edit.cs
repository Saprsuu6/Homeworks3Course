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
    public partial class Edit : Form
    {
        private List<Person> people;
        private Person person;
        private string sex;
        private string famalyState;
        private int index;

        internal Edit(Person person, List<Person> people, int index)
        {
            InitializeComponent();
            this.person = person;
            this.people = people;
            this.index = index;

            FillInfo();
        }

        private void Check()
        {
            if (PersonName.Text != "" && Surname.Text != "" && Patronimic.Text != "")
                Save.Enabled = true;
            else
                Save.Enabled = false;
        }

        private void FillInfo()
        {
            PersonName.Text = person.Name.ToLower();
            Surname.Text = person.Surname.ToLower();
            Patronimic.Text = person.Patronimic.ToLower();
            if (person.Sex == "мужчина")
                Мужчина.Checked = true;
            else if (person.Sex == "женщина")
                Женщина.Checked = true;
            Birthday.Value = person.Birthday;
            if (person.FamalyStatus == "без семьи")
                БезСемьи.Checked = true;
            else if (person.FamalyStatus == "eсть семья")
                ЕстьСемья.Checked = true;
            Info.Text = person.Info.ToLower();
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
            people[index] = person;

            string fio = person.Surname + " " + person.Name + " " + person.Patronimic;
            Close();
        }
    }
}
