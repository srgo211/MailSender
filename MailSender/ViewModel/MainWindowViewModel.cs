using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using LibMailSender.Entities;
using LibMailSender.Modules;
using LibMailSender.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel: ViewModelBase
    {

        private readonly IRecipientsStore _RecipientsDataService;

        private readonly IRecipientManager _RecipientsManager;

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


        public ICommand CreateRecipientCommand { get; }

        #endregion


        /// <summary>
        /// Конструктур для Инициализации объектов 
        /// </summary>
        /// <param name="RecipientsManager"></param>
        public MainWindowViewModel(IRecipientManager RecipientsManager,
                                   IRecipientsStore  RecipientsDataService)
        {
            _RecipientsDataService = RecipientsDataService;

            //инициализируем команду Обновить Получателей - Рассылки
            LoadRecipientsDataCommand = new RelayCommand(OnLoadRecipientsDataCommandExecuted, CanLoadRecipientsDataCommandExecute());
           
            //инициализируем Типизированнаю команду
            SaveRecipientsChangesCommand = new RelayCommand<Recipient>(OnSaveRecipientsChangesCommand, CanSaveRecipientsChangesCommandExecute);
            
            
            _RecipientsManager = RecipientsManager;


            CreateRecipientCommand = new RelayCommand(OnCreateRecipientExecuted, CanCreateRecipientExecuted);

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


        private Recipient _CurrentRecipient;
        public Recipient CurrentRecipient
        {
            get => _CurrentRecipient;
            set => Set(ref _CurrentRecipient, value);
        }





        


        private bool CanCreateRecipientExecuted() => true;
        private  void OnCreateRecipientExecuted()
        {

            for (int a = 1; a < 1000; a++)
            {
                Recipient new_recipient = new Recipient()
                {
                    Id = a,
                    Name = "New_Recipient" + a,
                    AddressToEmail = "recipient@server.net" + a
                };



                _RecipientsDataService.Create(new_recipient);
                _Recipients.Add(new_recipient);
                CurrentRecipient = new_recipient;

            }
            
            
        }

    }
}
