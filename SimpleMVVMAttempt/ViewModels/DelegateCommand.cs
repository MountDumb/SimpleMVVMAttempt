using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleMVVMAttempt.ViewModels
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;

        public DelegateCommand(Action action)
        {
            _action = action;

        }

        public void Execute(object param)
        {
            _action();
        }

        public bool CanExecute(object param)
        {
            return true;
        }


        // pragma disables the warning: "Warning CS0067  The event 'DelegateCommand.CanExecuteChanged' is never used" 
        #pragma warning disable 67
        public event EventHandler CanExecuteChanged;
        #pragma warning restore 67
    }
}
