using System;

namespace Wpf.Commands.HotKeys
{
    internal sealed class DelegateCommand : Command
    {
        private readonly Func<bool> canExecuteMethod;
        private readonly Action executeMethod;

        public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            this.canExecuteMethod = canExecuteMethod;
            this.executeMethod = executeMethod;
        }

        protected override bool CanExecute() => canExecuteMethod();

        protected override void Execute() => executeMethod();
    }
}