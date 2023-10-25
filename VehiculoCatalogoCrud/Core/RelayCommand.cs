using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VehiculoCatalogoCrud.Core
{
    internal class RelayCommand : ICommand
    {
        protected Action<object> _execute;
        protected Func<object,bool>? _canExecute;

        public event EventHandler? CanExecuteChanged;


        public RelayCommand(Action<object> execute, Func<object,bool> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute)
        {
            this._execute = execute;
            this._canExecute = null;
        }

        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
