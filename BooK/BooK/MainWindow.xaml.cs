using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace BooK
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

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";

            if(openFileDialog.ShowDialog() == true)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);

                Run runFirst = new Run();
                runFirst.Text = sr.ReadToEnd();

                GeneralText.Inlines.Add(runFirst);
            }
        }

        private void DarkLight_Checked(object sender, RoutedEventArgs e)
        {
            Resources.MergedDictionaries[0] = dark;
        }

        private void DarkLight_Unchecked(object sender, RoutedEventArgs e)
        {
            Resources.MergedDictionaries[0] = light;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FontFamilyConverter ffc = new FontFamilyConverter();

                GeneralText.FontSize = fontDialog.Font.Size;
                GeneralText.FontFamily = (System.Windows.Media.FontFamily)ffc.ConvertFromString(fontDialog.Font.Name);
                GeneralText.FontWeight = fontDialog.Font.Bold ? FontWeights.Bold : FontWeights.Normal;
                GeneralText.FontStyle = fontDialog.Font.Italic ? FontStyles.Italic : FontStyles.Normal;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Windows.Media.Brush brush = new SolidColorBrush(
                    System.Windows.Media.Color.FromArgb(
                        colorDialog.Color.A,
                        colorDialog.Color.R,
                        colorDialog.Color.G,
                        colorDialog.Color.B));

                GeneralText.Foreground = brush;
            }
        }
    }
}
