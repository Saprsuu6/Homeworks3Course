using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;
using System.Resources;
using System.IO;
using System.Globalization;
using System.Windows.Resources;
using System.Windows.Threading;
using Microsoft.Win32;

namespace AssemblyResources
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class Window1 : System.Windows.Window
    {
        private DispatcherTimer timer = new DispatcherTimer();

        public Window1()
        {
            InitializeComponent();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (Slider.Value == Slider.Maximum)
                Button_Click_2(null, null);
            else
                Slider.Value = Media.Position.TotalSeconds;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Media.Source != null)
            {
                Media.LoadedBehavior = MediaState.Play;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Interval = new TimeSpan(0, 0, 1);
                timer.Start();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Media.LoadedBehavior = MediaState.Pause;
            timer.Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Media.LoadedBehavior = MediaState.Stop;
            Media.LoadedBehavior = MediaState.Manual;
            timer.Stop();
            Slider.Value = 0;
        }

        private void Media_MediaOpened(object sender, RoutedEventArgs e)
        {
            Slider.Maximum = Media.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void Slider_LostMouseCapture(object sender, MouseEventArgs e)
        {
            TimeSpan time = new TimeSpan(0, 0, Convert.ToInt32(Math.Round(Slider.Value)));
            Media.Position = time;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TimeSpan time = new TimeSpan(0, 0, Convert.ToInt32(Media.Position.TotalSeconds - 1));
            Media.Position = time;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TimeSpan time = new TimeSpan(0, 0, Convert.ToInt32(Media.Position.TotalSeconds + 1));
            Media.Position = time;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                Uri uri = new Uri(openFileDialog.FileName);
                Media.Source = uri;
            }
        }
    }
}