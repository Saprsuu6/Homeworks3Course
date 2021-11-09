using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ARGB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public uint count = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetColor()
        {
            byte red = Convert.ToByte(Reds.Value);
            byte green = Convert.ToByte(Greens.Value);
            byte blue = Convert.ToByte(Blues.Value);

            Color color = Color.FromRgb(red, green, blue);

            CurrentColor.Background = new SolidColorBrush(color);
            CurrentColor.Opacity = Alphas.Value / 255;
        }

        // Я создал эти обработчики, потому что при обычном связывании показываются числа с точнкой

        private void Alphas_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)Alphas.Value;
            AlphaValue.Text = value.ToString();
            SetColor();
        }

        private void Reds_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)Reds.Value;
            RedValue.Text = value.ToString();
            SetColor();
        }

        private void Greens_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)Greens.Value;
            GreenValue.Text = value.ToString();
            SetColor();
        }

        private void Blues_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)Blues.Value;
            BlueValue.Text = value.ToString();
            SetColor();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            count--;

            Button button = sender as Button;
            string name = Convert.ToString(button.Name); 
            Match match = Regex.Match(name, @"\d");
            int index = Convert.ToInt32(match.Value);
            Values.Items.RemoveAt(index);

            for (int i = index; i < Values.Items.Count; i++)
            {
                UniformGrid grid = (UniformGrid)Values.Items[i];
                (grid.Children[2] as Button).Name = "Remove" + i;
            }

            if (Values.Items.Count < 10)
                Add.IsEnabled = true;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            UniformGrid grid = new UniformGrid();
            grid.Columns = 3;

            TextBlock textBlock = new TextBlock();
            Label label = new Label();
            Button button = new Button();

            textBlock.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock.Text = CurrentColor.Background.ToString();
            label.Background = CurrentColor.Background;
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.Content = "Remove";
            button.Name = "Remove" + count;
            count++;
            button.Click += Remove_Click;

            grid.Children.Add(textBlock);
            grid.Children.Add(label);
            grid.Children.Add(button);

            Values.Items.Add(grid);

            if (Values.Items.Count == 10)
                Add.IsEnabled = false;
        }
    }
}
