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

namespace FontSettings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetColor(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red = Convert.ToByte(Red.Value);
            byte green = Convert.ToByte(Green.Value);
            byte blue = Convert.ToByte(Blue.Value);

            Color color = Color.FromRgb(red, green, blue);

            CurrentColor.Background = new SolidColorBrush(color);
        }

        private void Find(ListBox listBox, string name)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i].ToString().Contains(name))
                {
                    listBox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void CurrentFont_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = CurrentFont.Text;
            Find(Fonts, name);
        }

        private void CurrentStyle_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = CurrentStyle.Text;
            Find(Styles, name);
        }

        private void CurrentSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = CurrentSize.Text;
            Find(Sizes, name);
        }
    }
}
