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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Effects;

namespace PersonInfoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewAdd
    {
        public MainWindow()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
            Birthday.SelectedDate = DateTime.Today;
        }

        public event EventHandler<EventArgs> dataRemove;
        public event EventHandler<EventArgs> dataSave;
        public event EventHandler<EventArgs> dataSaveInFile;
        public event EventHandler<EventArgs> dataEdit;

        public Window GetWindow { get => this; }
        public Button GetRemove { get => Remove; }
        public Button GetEdit { get => Edit; }
        public ListBox listBox { get => Persons; }
        public Image GetSavePersons { get => SavePersons; }
        public string GetSetSurname { set => Surname.Text = value; get => Surname.Text; }
        public string GetSetName { set => Name.Text = value; get => Name.Text; }
        public string GetSetPatronimic { set => Patronimic.Text = value; get => Patronimic.Text; }
        public bool GetSetMen { set => Male.IsChecked = value; get => (bool)Male.IsChecked; }
        public bool GetSetWomen { set => Famale.IsChecked = value; get => (bool)Famale.IsChecked; }
        public DateTime GetSetBirthday { set => Birthday.SelectedDate = value; get => (DateTime)Birthday.SelectedDate; }
        public string GetSetInfo { set => Info.Text = value; get => Info.Text; }
        public bool GetSetStatusWithFamaly { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool GetSetStatusWithoutFamaly { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void Clear()
        {
            Name.Text = "";
            Surname.Text = "";
            Patronimic.Text = "";
            Male.IsChecked = false;
            Famale.IsChecked = false;
            Birthday.SelectedDate = DateTime.Today;
            Info.Text = "";
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Name.Text != "" && Surname.Text != "" && Patronimic.Text != "")
                Save.IsEnabled = true;
            else
                Save.IsEnabled = false;
        }

        private void Persons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Persons.SelectedItem != null)
            {
                Remove.IsEnabled = true;
                Edit.IsEnabled = true;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            dataSave?.Invoke(this, EventArgs.Empty);
            Clear();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (Persons.SelectedItem != null)
            {
                MessageBoxResult dialogResult = MessageBox.Show("Вы хотите удалить?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (dialogResult == MessageBoxResult.Yes)
                    dataRemove?.Invoke(this, EventArgs.Empty);
            }

            Clear();
        }

        private void SavePersons_MouseDown(object sender, MouseButtonEventArgs e)
        {
            dataSaveInFile?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Информация успешно сохранена", "", MessageBoxButton.OK, MessageBoxImage.Information);
            Clear();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            dataEdit?.Invoke(this, EventArgs.Empty);
        }
    }
}
