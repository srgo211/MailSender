using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using LibMailSender.Modules;
using LibMailSender.Modules.Interfaces;

namespace MailSender.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc services = SimpleIoc.Default;

            //региструем в контейнере сервиса класс
            services.Register<MainWindowViewModel>();
            services.Register<IRecipientManager, RecipientsManager>(); // регистрируем менеджера  получателей c помощью интерфейса
            services.Register<IRecipientsStore, RecipientsStoreInMemory>(); //регистрируем ср-во хранения данных для менеджера получателей

            /* TODO  Если мы напишем другую реализацию хранения данных например через БД
             * то нужно подменить только в 1 месте
             * services.Register<IRecipientsStore, ТУТ БУДЕТ Метод Хранения данных>();
             */
        }

        //создаем св-во 
        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();
    }
}
