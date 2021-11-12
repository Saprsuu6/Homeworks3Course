using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Wpf.Commands.HotKeys
{
    internal sealed class DataSource : INotifyPropertyChanged
    {
        private readonly Command blueCommand;
        private readonly Command greenCommand;
        private readonly Command redCommand;

        private string selectedColor = "Black";

        public event PropertyChangedEventHandler PropertyChanged;

        public DataSource()
        {
            blueCommand = new DelegateCommand(() => SelectedColor = "Blue", () => SelectedColor != "Blue");
            greenCommand = new DelegateCommand(() => SelectedColor = "Green", () => SelectedColor != "Green");
            redCommand = new DelegateCommand(() => SelectedColor = "Red", () => SelectedColor != "Red");

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals(nameof(SelectedColor)))
                {
                    blueCommand.OnCanExecuteChanged(EventArgs.Empty);
                    greenCommand.OnCanExecuteChanged(EventArgs.Empty);
                    redCommand.OnCanExecuteChanged(EventArgs.Empty);
                }
            };
        }

        public ICommand BlueCommand => blueCommand;

        public ICommand GreenCommand => greenCommand;

        public ICommand RedCommand => redCommand;

        public string SelectedColor
        {
            get => selectedColor;
            set
            {
                if (!selectedColor.Equals(value))
                {
                    selectedColor = value;
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedColor)));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged?.Invoke(this, e);
    }
}