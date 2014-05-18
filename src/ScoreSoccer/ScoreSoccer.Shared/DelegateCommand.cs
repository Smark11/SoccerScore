using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ScoreSoccer
{
    public class DelegateCommand : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }


        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
