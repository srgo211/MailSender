using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using LibMailSender.Modules;

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
            services.Register<RecipientsManager>(); // регистрируем менеджера  получателей
            services.Register<RecipientsStoreInMemory>(); //регистрируем ср-во хранения данных для менеджера получателей

        }

        //создаем св-во 
        public MainWindowViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();
    }
}
