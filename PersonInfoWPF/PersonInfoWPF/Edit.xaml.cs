using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PersonInfoWPF
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class EditPerson : Window, IViewEdit
    {
        public event EventHandler<EventArgs> dataSaveEdit;

        public string GetSetSurname { set => Surname.Text = value; get => Surname.Text; }
        public string GetSetName { set => Name.Text = value; get => Name.Text; }
        public string GetSetPatronimic { set => Patronimic.Text = value; get => Patronimic.Text; }
        public bool GetSetMen { set => Male.IsChecked = value; get => (bool)Male.IsChecked; }
        public bool GetSetWomen { set => Famale.IsChecked = value; get => (bool)Famale.IsChecked; }
        public DateTime GetSetBirthday { set => Birthday.SelectedDate = value; get => (DateTime)Birthday.SelectedDate; }
        public string GetSetInfo { set => Info.Text = value; get => Info.Text; }

        public EditPerson()
        {
            InitializeComponent();
        }

        private void Surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Name.Text != "" && Surname.Text != "" && Patronimic.Text != "")
                Save.IsEnabled = true;
            else
                Save.IsEnabled = false;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            dataSaveEdit?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
