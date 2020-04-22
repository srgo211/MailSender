using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestWPFramework2.MVVM;

namespace TestWPFramework2.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        public ICommand CreateRecipientCommand { get; }

     
        #region Обработка текста Text
        private string _Text = "Любой текст";

        public string Text 
        {
            get => _Text;
            set => Set(ref _Text, value); 
        }
        #endregion





    }
}
