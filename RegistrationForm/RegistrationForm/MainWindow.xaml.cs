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

namespace RegistrationForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ResourceDictionary light = new ResourceDictionary();
        private ResourceDictionary dark = new ResourceDictionary();

        public MainWindow()
        {
            InitializeComponent();
            light.Source = new Uri("Resources/Light.xaml", UriKind.Relative);
            dark.Source = new Uri("Resources/Dark.xaml", UriKind.Relative);
        }

        private void LightDark_Checked(object sender, RoutedEventArgs e)
        {
            Resources.MergedDictionaries[0] = dark;
        }

        private void LightDark_Unchecked(object sender, RoutedEventArgs e)
        {
            Resources.MergedDictionaries[0] = light;
        }
    }
}
