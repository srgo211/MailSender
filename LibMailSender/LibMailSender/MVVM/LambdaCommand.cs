using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LibMailSender.MVVM
{
    public class LambdaCommand : ICommand
    {
        //Реализуем интерфейс ICommand
        /// <summary>Событие ответчает за вкл/выкл </summary>
        public event EventHandler CanExecuteChanged;


        private Action<object> _CommandAction;
        private Func<object, bool> _CanExecute;

        public LambdaCommand(Action<object> CommandAction, Func<object, bool> CanExecute = null)
        {
            _CommandAction = CommandAction;
            _CanExecute = CanExecute;

        }

        /// <summary>
        /// Отслеживает изменения
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ??true;
        

        /// <summary>
        /// Логика события
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter) => _CommandAction(parameter);
    }
}
