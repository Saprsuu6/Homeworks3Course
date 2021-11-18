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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animation
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

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation sizeAnimation = new DoubleAnimation();
            sizeAnimation.From = Text.FontSize;
            sizeAnimation.To = 30;
            sizeAnimation.Duration = TimeSpan.FromSeconds(1);
            sizeAnimation.DecelerationRatio = 1;

            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = Button1.Width;
            widthAnimation.To = Width - 25;
            widthAnimation.Duration = TimeSpan.FromSeconds(1);
            widthAnimation.Completed += AnimationCompleted;
            widthAnimation.DecelerationRatio = 1;

            Text.BeginAnimation(Button.FontSizeProperty, sizeAnimation);
            Button1.BeginAnimation(Button.WidthProperty, widthAnimation);
        }

        private void AnimationCompleted(object sender, EventArgs e)
        {
            DoubleAnimation sizeAnimation = new DoubleAnimation();
            sizeAnimation.From = Text.FontSize;
            sizeAnimation.To = 20;
            sizeAnimation.Duration = TimeSpan.FromSeconds(5);
            sizeAnimation.DecelerationRatio = 1;

            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = Button1.Width;
            widthAnimation.To = 400;
            widthAnimation.Duration = TimeSpan.FromSeconds(5);
            widthAnimation.DecelerationRatio = 1;

            Text.BeginAnimation(Button.FontSizeProperty, sizeAnimation);
            Button1.BeginAnimation(Button.WidthProperty, widthAnimation);
        }

        private void Button1_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation sizeAnimation = new DoubleAnimation();
            sizeAnimation.From = Text.FontSize;
            sizeAnimation.To = 16;
            sizeAnimation.Duration = TimeSpan.FromSeconds(1);
            sizeAnimation.DecelerationRatio = 1;

            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = Button1.Width;
            widthAnimation.To = 200;
            widthAnimation.Duration = TimeSpan.FromSeconds(1);
            widthAnimation.DecelerationRatio = 1;

            Text.BeginAnimation(Button.FontSizeProperty, sizeAnimation);
            Button1.BeginAnimation(Button.WidthProperty, widthAnimation);
        }
    }
}
