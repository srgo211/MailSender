using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestWPFramework2.MVVM
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Обработчик событий
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Вызываем обработки событий для просмотра изменений
        /// </summary>
        /// <param name="PropertyName">Имя св-во которое изменилось</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>
        ///  Если событие изменилось - вызывается метод на обработчик событий
        /// </summary>
        /// <typeparam name="T">Данные хранения</typeparam>
        /// <param name="field">Ссылка на поле</param>
        /// <param name="value">Значение к-рое нужно присвоить</param>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;

        }



       


    }
}
