using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfo
{
    class Presenter
    {
        private readonly Model model = new Model();
        private readonly IViewAdd person;
        private IViewEdit edit;

        public Presenter(IViewAdd person)
        {
            WorkWithFile.ReadingXml(model.People);

            this.person = person;
            person.dataSave += new EventHandler<EventArgs>(Save);
            person.dataRemove += new EventHandler<EventArgs>(Remove);
            person.dataSaveInFile += new EventHandler<EventArgs>(SaveInFile);
            person.dataEdit += new EventHandler<EventArgs>(Edit);

            if (model.People.Count > 0)
            {
                foreach (Person item in model.People)
                    person.listBox.Items.Add(item.Surname + " " + item.Name + " " + item.Patronimic);
            }
        }

        private void SaveEdit(object sender, EventArgs e)
        {
            model.Name = edit.GetSetName;
            model.Surname = edit.GetSetSurname;
            model.Patronimic = edit.GetSetPatronimic;
            model.Men = edit.GetSetMen;
            model.Women = edit.GetSetWomen;
            model.Birthday = edit.GetSetBirthday;
            model.WithFamaly = edit.GetSetStatusWithFamaly;
            model.WithoutFamaly = edit.GetSetStatusWithoutFamaly;
            model.Info = edit.GetSetInfo;

            model.ChangePerson(person.listBox.SelectedIndex);

            WorkWithFile.DeletePerson(person.listBox.SelectedItem.ToString());
            string fio = model.Surname + " " + model.Name + " " + model.Patronimic;
            person.listBox.Items[person.listBox.SelectedIndex] = fio.ToLower();
            person.Button.Enabled = true;
        }

        private void Edit(object sender, EventArgs e)
        {
            int index = person.listBox.SelectedIndex;
            edit = new Edit(model.People[index], model.People, index);

            edit.GetSetName = model.People[index].Name.ToLower();
            edit.GetSetSurname = model.People[index].Surname.ToLower();
            edit.GetSetPatronimic = model.People[index].Patronimic.ToLower();
            if (edit.GetSetMen)
                edit.GetSetMen = true;
            else if (edit.GetSetWomen)
                edit.GetSetWomen = true;
            edit.GetSetBirthday = model.People[index].Birthday;
            if (edit.GetSetStatusWithoutFamaly)
                edit.GetSetStatusWithoutFamaly = true;
            else if (edit.GetSetStatusWithFamaly)
                edit.GetSetStatusWithFamaly = true;
            edit.GetSetInfo = model.People[index].Info.ToLower();

            edit.dataSaveEdit += new EventHandler<EventArgs>(SaveEdit);
            (edit as Form).Owner = person as Form;
            (edit as Form).ShowDialog();
        }

        private void SaveInFile(object sender, EventArgs e)
        {
            foreach (Person item in model.People)
            {
                WorkWithFile.WriteToFileXml(item);
                WorkWithFile.WriteToFileTxt(item);
            }
        }

        private void Remove(object sender, EventArgs e)
        {
            int index = person.listBox.SelectedIndex;
            WorkWithFile.DeletePerson(person.listBox.SelectedItem.ToString());
            model.People.RemoveAt(index);
            person.listBox.Items.RemoveAt(index);

            person.GetRemove.Enabled = false;
        }

        private void Save(object sender, EventArgs e)
        {
            model.Name = person.GetSetName;
            model.Surname = person.GetSetSurname;
            model.Patronimic = person.GetSetPatronimic;
            model.Men = person.GetSetMen;
            model.Women = person.GetSetWomen;
            model.Birthday = person.GetSetBirthday;
            model.WithFamaly = person.GetSetStatusWithFamaly;
            model.WithoutFamaly = person.GetSetStatusWithoutFamaly;
            model.Info = person.GetSetInfo;

            model.CreatePerson();

            Update();
        }

        private void Update()
        {
            string fio = model.Surname + " " + model.Name + " " + model.Patronimic;
            person.listBox.Items.Add(fio.ToLower());
            person.Button.Enabled = true;
        }
    }
}
