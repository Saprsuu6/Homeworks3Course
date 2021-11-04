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

namespace Claculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float a, b;
        int count;
        bool znak = true;

        public MainWindow()
        {
            InitializeComponent();
            Now.Text = "0";
        }

        #region numbers

        private void CheckhForNull(int number)
        {
            if (Now.Text == "0")
                Now.Text = number.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 1.ToString();
            else
                Now.Text = Now.Text + 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 2.ToString();
            else
                Now.Text = Now.Text + 2;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 3.ToString();
            else
                Now.Text = Now.Text + 3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 4.ToString();
            else
                Now.Text = Now.Text + 4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 5.ToString();
            else
                Now.Text = Now.Text + 5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 6.ToString();
            else
                Now.Text = Now.Text + 6;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 7.ToString();
            else
                Now.Text = Now.Text + 7;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 8.ToString();
            else
                Now.Text = Now.Text + 8;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 9.ToString();
            else
                Now.Text = Now.Text + 9;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (Now.Text == "0")
                Now.Text = 9.ToString();
            else
                Now.Text = Now.Text + 0;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Now.Text = Now.Text + ".";
        }
        #endregion

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Now.Text = "";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Now.Text = "";
            Previous.Text = "";
            a = 0;
            b = 0;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            int lenght = Now.Text.Length - 1;
            string text = Now.Text;
            Now.Clear();
            for (int i = 0; i < lenght; i++)
                Now.Text = Now.Text + text[i];
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            a += float.Parse(Now.Text);
            count = 1;
            Previous.Text = a.ToString() + "+";
            znak = true;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            a -= float.Parse(Now.Text);
            Now.Clear();
            count = 2;
            Previous.Text = a.ToString() + "-";
            znak = true;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            a *= float.Parse(Now.Text);
            Now.Clear();
            count = 3;
            Previous.Text = a.ToString() + "*";
            znak = true;
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            a = float.Parse(Now.Text);
            Now.Clear();
            count = 4;
            Previous.Text = a.ToString() + "/";
            znak = true;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            Previous.Text += Now.Text.ToString() + "=";

            Calculate();
        }

        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(Now.Text);
                    a = b;
                    Now.Text = b.ToString();
                    Previous.Text = b + "+";
                    break;
                case 2:
                    b = a - float.Parse(Now.Text);
                    a = b;
                    Now.Text = b.ToString();
                    Previous.Text = b + "-";
                    break;
                case 3:
                    b = a * float.Parse(Now.Text);
                    Now.Text = b.ToString();
                    Previous.Text = b + "*";
                    break;
                case 4:
                    b = a / float.Parse(Now.Text);
                    Now.Text = b.ToString();
                    Previous.Text = b + "/";
                    break;

                default:
                    break;
            }

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                Now.Text = "-" + Now.Text;
                znak = false;
            }
            else if (znak == false)
            {
                Now.Text = Now.Text.Replace("-", "");
                znak = true;
            }
        }
    }
}
