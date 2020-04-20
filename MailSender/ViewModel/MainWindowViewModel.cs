using GalaSoft.MvvmLight;
using LibMailSender.Entities;
using LibMailSender.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel: ViewModelBase
    {
        private readonly RecipientsManager _RecipientsManager;

        private string _Title = "Рассыльщик почты";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        private ObservableCollection<Recipient> _Recipients;

        public ObservableCollection<Recipient> Recipients 
        { 
            get => _Recipients;
            private set => Set(ref _Recipients, value);
        }

        private Recipient _SalectedRecipient;
        /// <summary>
        ////св-во уведомлений об изменении объекта
        /// </summary>
        public Recipient SalectedRecipient
        {
            get => _SalectedRecipient;
            set => Set(ref _SalectedRecipient, value);
        }

        public MainWindowViewModel(RecipientsManager RecipientsManager)
        {
            _RecipientsManager = RecipientsManager;
            _Recipients = new ObservableCollection<Recipient>(RecipientsManager.GetAll());
        }
    }
}
