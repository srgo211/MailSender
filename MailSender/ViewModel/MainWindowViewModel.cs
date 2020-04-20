using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel: ViewModelBase
    {
        private string _Title = "Рассыльщик почты";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        public MainWindowViewModel()
        { 
        
        }
    }
}
