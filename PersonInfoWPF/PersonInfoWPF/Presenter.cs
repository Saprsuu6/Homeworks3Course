using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Effects;

namespace PersonInfoWPF
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
            model.Male = edit.GetSetMen;
            model.Famale = edit.GetSetWomen;
            model.Birthday = edit.GetSetBirthday;
            model.Info = edit.GetSetInfo;

            model.ChangePerson(person.listBox.SelectedIndex);

            WorkWithFile.DeletePerson(person.listBox.SelectedItem.ToString());
            string fio = model.Surname + " " + model.Name + " " + model.Patronimic;
            person.listBox.Items[person.listBox.SelectedIndex] = fio.ToLower();
            person.GetSavePersons.Effect = null;
            person.GetSavePersons.IsEnabled = true;
        }

        private void Edit(object sender, EventArgs e)
        {
            int index = person.listBox.SelectedIndex;
            edit = new EditPerson();

            edit.GetSetName = model.People[index].Name.ToLower();
            edit.GetSetSurname = model.People[index].Surname.ToLower();
            edit.GetSetPatronimic = model.People[index].Patronimic.ToLower();
            if (edit.GetSetMen)
                edit.GetSetMen = true;
            else if (edit.GetSetWomen)
                edit.GetSetWomen = true;
            edit.GetSetBirthday = model.People[index].Birthday;
            edit.GetSetInfo = model.People[index].Info.ToLower();

            edit.dataSaveEdit += new EventHandler<EventArgs>(SaveEdit);

            person.GetWindow.Effect = new BlurEffect();
            (edit as Window).ShowDialog();
            person.GetWindow.Effect = null;

            person.GetRemove.IsEnabled = false;
            person.GetEdit.IsEnabled = false;
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

            person.GetRemove.IsEnabled = false;
            person.GetEdit.IsEnabled = false;
        }

        private void Save(object sender, EventArgs e)
        {
            model.Name = person.GetSetName;
            model.Surname = person.GetSetSurname;
            model.Patronimic = person.GetSetPatronimic;
            model.Male = person.GetSetMen;
            model.Famale = person.GetSetWomen;
            model.Birthday = person.GetSetBirthday;
            model.Info = person.GetSetInfo;

            model.CreatePerson();

            Update();
        }

        private void Update()
        {
            string fio = model.Surname + " " + model.Name + " " + model.Patronimic;
            person.listBox.Items.Add(fio.ToLower());
            person.GetSavePersons.Effect = null;
            person.GetSavePersons.IsEnabled = true;
        }
    }
}
