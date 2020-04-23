using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestWPFramework2.Command
{
    public delegate void CustomVarsDelegate(Dictionary<string, object> vars);

    public class MyICommand : ICommand
    {

        #region ICommand - Реализация интерфейса

        bool ICommand.CanExecute(object parameter)
        {
            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }
            else if (_TargetExecuteMethod != null)
                return true;
            return false;
        }

        void ICommand.Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod();
            }
        }

        #endregion ICommand Members

        private Func<bool> _TargetCanExecuteMethod;
        private Action _TargetExecuteMethod;


        public MyICommand(Action executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public MyICommand(Action executeMethod, Func<bool> canExecuteMethod)
            : this(executeMethod)
        {
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        [field: NonSerializedAttribute()]
        public event EventHandler CanExecuteChanged = delegate { };

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

       
    }
}
