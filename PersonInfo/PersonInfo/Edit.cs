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
    public partial class Edit : Form, IViewEdit
    {
        public event EventHandler<EventArgs> dataSaveEdit;

        public string GetSetSurname { set => Surname.Text = value; get => Surname.Text; }
        public string GetSetName { set => PersonName.Text = value; get => PersonName.Text; }
        public string GetSetPatronimic { set => Patronimic.Text = value; get => Patronimic.Text; }
        public bool GetSetMen { set => Man.Checked = value; get => Man.Checked; }
        public bool GetSetWomen { set => Woman.Checked = value; get => Woman.Checked; }
        public DateTime GetSetBirthday { set => Birthday.Value = value; get => Birthday.Value; }
        public bool GetSetStatusWithFamaly { set => WithoutFamily.Checked = value; get => WithoutFamily.Checked; }
        public bool GetSetStatusWithoutFamaly { set => WithFamily.Checked = value; get => WithFamily.Checked; }
        public string GetSetInfo { set => Info.Text = value; get => Info.Text; }

        internal Edit(Person person, List<Person> people, int index)
        {
            InitializeComponent();
        }

        private void Check()
        {
            if (PersonName.Text != "" && Surname.Text != "" && Patronimic.Text != "")
                Save.Enabled = true;
            else
                Save.Enabled = false;
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
            dataSaveEdit?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
