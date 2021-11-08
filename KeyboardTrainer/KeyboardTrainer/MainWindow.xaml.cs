using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Input;
using System;
using System.Windows.Threading;

namespace KeyboardTrainer
{
    internal sealed partial class MainWindow : Window
    {
        int tempTimer = 0;
        int fails = 0;
        Random rendChar = new Random();
        string baceString = "QWERTYUIOPASDFGHJKLZXCVBNM~!@#$%^&*()_+{}|:\"<>?1234567890[],./\\`-=;'qwertyuiopasdfghjklzxcvbnm";
        private bool flagCapsLock;
        bool flagBackspase;
        DispatcherTimer timer = null;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
        }

        private void CapitalLetters()
        {
            Qtxt.Text = "Q";
            Wtxt.Text = "W";
            Etxt.Text = "E";
            Rtxt.Text = "R";
            Ttxt.Text = "T";
            Ytxt.Text = "Y";
            Utxt.Text = "U";
            Itxt.Text = "I";
            Otxt.Text = "O";
            Ptxt.Text = "P";
            Atxt.Text = "A";
            Stxt.Text = "S";
            Dtxt.Text = "D";
            Ftxt.Text = "F";
            Gtxt.Text = "G";
            Htxt.Text = "H";
            Jtxt.Text = "J";
            Ktxt.Text = "K";
            Ltxt.Text = "L";
            Ztxt.Text = "Z";
            Xtxt.Text = "X";
            Ctxt.Text = "C";
            Vtxt.Text = "V";
            Btxt.Text = "B";
            Ntxt.Text = "N";
            Mtxt.Text = "M";
        }

        private void LoverLetters()
        {
            Qtxt.Text = "q";
            Wtxt.Text = "w";
            Etxt.Text = "e";
            Rtxt.Text = "r";
            Ttxt.Text = "t";
            Ytxt.Text = "y";
            Utxt.Text = "u";
            Itxt.Text = "i";
            Otxt.Text = "o";
            Ptxt.Text = "p";
            Atxt.Text = "a";
            Stxt.Text = "s";
            Dtxt.Text = "d";
            Ftxt.Text = "f";
            Gtxt.Text = "g";
            Htxt.Text = "h";
            Jtxt.Text = "j";
            Ktxt.Text = "k";
            Ltxt.Text = "l";
            Ztxt.Text = "z";
            Xtxt.Text = "x";
            Ctxt.Text = "c";
            Vtxt.Text = "v";
            Btxt.Text = "b";
            Ntxt.Text = "n";
            Mtxt.Text = "m";
        }

        private void CapitalSymbol()
        {
            Oem3txt.Text = "~";
            D1txt.Text = "!";
            D2txt.Text = "@";
            D3txt.Text = "#";
            D4txt.Text = "$";
            D5txt.Text = "%";
            D6txt.Text = "^";
            D7txt.Text = "&";
            D8txt.Text = "*";
            D9txt.Text = "(";
            D0txt.Text = ")";
            OemMinustxt.Text = "_";
            OemPlustxt.Text = "+";
            OemOpenBracketstxt.Text = "{";
            Oem6txt.Text = "}";
            Oem5txt.Text = "|";
            Oem1txt.Text = ":";
            OemQuotestxt.Text = "\"";
            OemCommatxt.Text = "<";
            OemPeriodtxt.Text = ">";
            OemQuestiontxt.Text = "?";
        }

        private void LoverSymbol()
        {
            Oem3txt.Text = "`";
            D1txt.Text = "1";
            D2txt.Text = "2";
            D3txt.Text = "3";
            D4txt.Text = "4";
            D5txt.Text = "5";
            D6txt.Text = "6";
            D7txt.Text = "7";
            D8txt.Text = "8";
            D9txt.Text = "9";
            D0txt.Text = "0";
            OemMinustxt.Text = "-";
            OemPlustxt.Text = "=";
            OemOpenBracketstxt.Text = "[";
            Oem6txt.Text = "]";
            Oem5txt.Text = "\\";
            Oem1txt.Text = ";";
            OemQuotestxt.Text = "'";
            OemCommatxt.Text = ",";
            OemPeriodtxt.Text = ".";
            OemQuestiontxt.Text = "/";
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            foreach (UIElement it1 in (Content as Grid).Children)
            {
                if (it1 is Grid)
                {
                    foreach (UIElement it2 in (it1 as Grid).Children)
                    {
                        if (it2 is StackPanel)
                        {
                            foreach (UIElement it3 in (it2 as StackPanel).Children)
                            {
                                if (it3 is StackPanel)
                                {
                                    foreach (UIElement it4 in (it3 as StackPanel).Children)
                                    {
                                        if (it4 is Grid)
                                        {
                                            foreach (UIElement it5 in (it4 as Grid).Children)
                                            {
                                                if (it5 is Border && (it5 as Border).Name == e.Key.ToString())
                                                {
                                                    (it5 as Border).BorderBrush = Brushes.Yellow;
                                                }

                                                if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
                                                {
                                                    CapitalSymbol();
                                                    if (!flagCapsLock)
                                                    {
                                                        CapitalLetters();
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        LoverLetters();
                                                        return;
                                                    }
                                                }

                                                else if (e.Key == Key.Capital)
                                                {
                                                    if (!flagCapsLock)
                                                    {
                                                        CapitalLetters();
                                                        flagCapsLock = true;
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        LoverLetters();
                                                        flagCapsLock = false;
                                                        return;
                                                    }
                                                }

                                                else if (e.Key == Key.Back)
                                                {
                                                    flagBackspase = true;
                                                    return;
                                                }
                                                else
                                                    flagBackspase = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            foreach (UIElement it1 in (Content as Grid).Children)
            {
                if (it1 is Grid)
                {
                    foreach (UIElement it2 in (it1 as Grid).Children)
                    {
                        if (it2 is StackPanel)
                        {
                            foreach (UIElement it3 in (it2 as StackPanel).Children)
                            {
                                if (it3 is StackPanel)
                                {
                                    foreach (UIElement it4 in (it3 as StackPanel).Children)
                                    {
                                        if (it4 is Grid)
                                        {
                                            foreach (UIElement it5 in (it4 as Grid).Children)
                                            {
                                                if (it5 is Border && (it5 as Border).Name == e.Key.ToString())
                                                {
                                                    (it5 as Border).BorderBrush = Brushes.Black;
                                                }

                                                if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
                                                {
                                                    LoverSymbol();
                                                    if (flagCapsLock)
                                                    {
                                                        CapitalLetters();
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        LoverLetters();
                                                        return;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = false;
            SliderDifficulty.IsEnabled = false;
            CaseSensitive.IsEnabled = false;
            Stop.IsEnabled = true;
            tempTimer = 0;
            timer.Start();
            CollectString(Convert.ToInt32(Difficulty.Text), baceString, !(bool)CaseSensitive.IsChecked);
            lineUser.IsReadOnly = false;
            lineUser.IsEnabled = true;
            lineUser.Focus();
        }

        private void CollectString(int countChar, string baceString, bool flagSensitive)
        {
            string carhs = "";
            int sensitive = flagSensitive ? 47 : 0;
            for (int i = 0; i < countChar; i++)
            {
                carhs += baceString[rendChar.Next(sensitive, baceString.Length)];
            }
            carhs += " ";
            int countString = flagSensitive ? 65 : 60;
            for (int i = 0; i < countString; i++)
            {
                linePrograms.Text += carhs[rendChar.Next(0, carhs.Length)];
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tempTimer++;
            Speed();
        }

        void Speed()
        {
            SpeedChar.Text = Math.Round(((double)lineUser.Text.Length / tempTimer) * 60).ToString();
        }

        private void SliderDifficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int num;
            num = (int)(sender as Slider).Value;
            Difficulty.Text = num.ToString();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = true;
            SliderDifficulty.IsEnabled = true;
            CaseSensitive.IsEnabled = true;
            Stop.IsEnabled = false;
            lineUser.Text = "";
            linePrograms.Text = "";
            Fails.Text = "0";
            SpeedChar.Text = "0";
            lineUser.IsReadOnly = true;
            lineUser.IsEnabled = false;
            lineUser.Background = Brushes.Cyan;
            timer.Stop();
            tempTimer = 0;
            fails = 0;
        }

        private void lineUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = null;

            if (lineUser.Text.Length < linePrograms.Text.Length)
                str = linePrograms.Text.Substring(0, lineUser.Text.Length);

            if (str != null)
            {
                if (lineUser.Text == str)
                {
                    if (!flagBackspase)
                        Speed();
                    lineUser.Background = Brushes.Green;
                }
                else
                {
                    if (!flagBackspase)
                        fails++;
                    lineUser.Background = Brushes.Red;
                    Fails.Text = Convert.ToString(fails);
                }
            }

            if (lineUser.Text.Length == linePrograms.Text.Length)
            {
                if (lineUser.Background == Brushes.Green)
                {
                    timer.Stop();
                    Speed();

                    Effect = new BlurEffect();

                    MessageBox.Show($"Задание завершенно!\n " +
                        $"Коилчество символов {linePrograms.Text.Length}.\n" +
                        $" Коилчество ошибок {Fails.Text}." +
                        $"\nДля завершения задания нажмите Stop.", 
                        "", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                    Effect = null;
                    Stop_Click(sender, e);
                }
            }
        }

        private void CaseSensitive_Checked(object sender, RoutedEventArgs e)
        {
            if (CaseSensitive.IsChecked == true)
                SliderDifficulty.Maximum = 94;
            else
                SliderDifficulty.Maximum = 47;
        }
    }
}
