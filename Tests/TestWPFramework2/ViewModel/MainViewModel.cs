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
            //set => Set(ref _Text, value);

            set
            {
                if (Set(ref _Text, value))
                    OnPropertyChanged(nameof(TextLight));
                    OnPropertyChanged(nameof(MyList));
            }

    }
    #endregion



    public string TextLight => _Text.Length.ToString();




        private ObservableCollection<MyListClass> _MyList;

        public ObservableCollection<MyListClass> MyList
        {
            get => _MyList;
            private set => Set(ref _MyList, value);
        }

    }

     public class MyListClass
    {

        public int id { get; set; }

        public string name { get; set; }

    }

}
