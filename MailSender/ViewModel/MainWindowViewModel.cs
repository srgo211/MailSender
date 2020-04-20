using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using LibMailSender.Entities;
using LibMailSender.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

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

        #region Команды
        /// <summary>Обновить Получателей</summary>
        public ICommand LoadRecipientsDataCommand { get; }

        public ICommand SaveRecipientsChangesCommand { get; }
        #endregion


        /// <summary>
        /// Конструктур для Инициализации объектов 
        /// </summary>
        /// <param name="RecipientsManager"></param>
        public MainWindowViewModel(RecipientsManager RecipientsManager)
        {
            //инициализируем команду Обновить Получателей - Рассылки
            LoadRecipientsDataCommand = new RelayCommand(OnLoadRecipientsDataCommandExecuted, CanLoadRecipientsDataCommandExecute());
           
            //инициализируем Типизированнаю команду
            SaveRecipientsChangesCommand = new RelayCommand<Recipient>(OnSaveRecipientsChangesCommand, CanSaveRecipientsChangesCommandExecute);
            
            
            _RecipientsManager = RecipientsManager;
            
        }


        private bool CanLoadRecipientsDataCommandExecute() => true;
        private void OnLoadRecipientsDataCommandExecuted()
        {
            //загружаем данные в получателей
            Recipients = new ObservableCollection<Recipient>(_RecipientsManager.GetAll());

            //TODO загружаем данные в сервера, отправители

        }


        /// <summary>Критерий возможности выполнения команды для Сохранить Получателей</summary>
        private bool CanSaveRecipientsChangesCommandExecute(Recipient recipient) => recipient!=null;
       
        /// <summary>метод сохранения данных Получателей</summary>
        private void OnSaveRecipientsChangesCommand(Recipient recipient)
        {
            //правка данных
            _RecipientsManager.Edit(recipient);
            //сохранение информации
            _RecipientsManager.SaveChanges();

        }
    }
}
