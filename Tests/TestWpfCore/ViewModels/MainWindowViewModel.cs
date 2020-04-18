using System;
using System.Collections.Generic;
using System.Text;
using LibMailSender.MVVM;

namespace TestWpfCore.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        string _Title = "Наше новое окно!!!";

        public string Title
        {
            get => _Title; //возращает значение нашего поля
            set => Set(ref _Title, value);

            /*
             set
            {
                if (Equals(_Title, value)) return; //если новое значение равно старому то ничего изменять не надо 
                _Title = value;  //устанавливает значение нашего поля
                OnPropertyChanged(); //сюда автоматически подставится Title (OnPropertyChanged(Title)) - т.к. мы заранее так сделали
            }
            */
        }


        string _TestTxtValue = "100";
        public string TestTxtValue
        {
            get => _TestTxtValue;
            set => Set(ref _TestTxtValue, value);
        }

    }
}
