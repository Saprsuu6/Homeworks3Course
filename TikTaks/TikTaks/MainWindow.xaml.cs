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

namespace TikTaks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Gameplay gameplay;
        private bool first;
        private uint complexity;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            Button0.Content = null;
            Button1.Content = null;
            Button2.Content = null;
            Button3.Content = null;
            Button4.Content = null;
            Button5.Content = null;
            Button6.Content = null;
            Button7.Content = null;
            Button8.Content = null;
        }

        private void EnableisableMenu(bool temp)
        {
            X.IsEnabled = temp;
            O.IsEnabled = temp;

            Easy.IsEnabled = temp;
            Normal.IsEnabled = temp;
            Hard.IsEnabled = temp;
        }

        private void EnableDisableButtons(bool temp)
        {
            Button0.IsEnabled = temp;
            Button1.IsEnabled = temp;
            Button2.IsEnabled = temp;
            Button3.IsEnabled = temp;
            Button4.IsEnabled = temp;
            Button5.IsEnabled = temp;
            Button6.IsEnabled = temp;
            Button7.IsEnabled = temp;
            Button8.IsEnabled = temp;
        }

        private void X_Checked(object sender, RoutedEventArgs e)
        {
            if (X.IsChecked == true)
                first = true;
            else if(O.IsChecked == true)
                first = false;
        }

        private void Easy_Checked(object sender, RoutedEventArgs e)
        {
            if (Easy.IsChecked == true)
                complexity = 1;
            else if (Normal.IsChecked == true)
                complexity = 2;
            else if (Hard.IsChecked == true)
                complexity = 3;
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            EnableisableMenu(false);
            EnableDisableButtons(true);

            switch (complexity)
            {
                case 1:
                    gameplay = new Easy(first);
                    break;
            }
        }

        private Button Logic(Button button)
        {
            string strIndex = Convert.ToString(button.Name[button.Name.Length - 1]);
            int index = Convert.ToInt32(strIndex);

            gameplay.SetFigure(index);

            gameplay.CheckWin(1);
            gameplay.CheckWin(2);
            gameplay.Draw();

            int comButton = gameplay.SetFigureComputer();

            string name = "Button" + comButton;
            Button buttun = (Button)FindName(name);

            return buttun;
        }

        private void X_O(Button button)
        {
            if (button.Content == null)
            {
                if (first)
                    button.Content = "X";
                else
                    button.Content = "O";

                Button comButton = Logic(button);

                if (first)
                    comButton.Content = "O";
                else
                    comButton.Content = "X";
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                X_O(sender as Button);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Result", MessageBoxButton.OK, MessageBoxImage.Information);

                Clear();
                gameplay.Clear();
                EnableisableMenu(true);
                EnableDisableButtons(false);
            }
        }
    }
}
