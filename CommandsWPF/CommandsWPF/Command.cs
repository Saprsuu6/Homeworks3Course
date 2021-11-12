using System;
using System.Windows.Input;

namespace Wpf.Commands.HotKeys
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        protected abstract bool CanExecute();

        protected abstract void Execute();

        public virtual void OnCanExecuteChanged(EventArgs e) => CanExecuteChanged?.Invoke(this, e);

        bool ICommand.CanExecute(object parameter) => CanExecute();

        void ICommand.Execute(object parameter) => Execute();
    }
}