using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace TestWPFramework2.ViewModel
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

            SimpleIoc.Default.Register<MainViewModel>();
        }


        public MainViewModel MainWindowModel => ServiceLocator.Current.GetInstance<MainViewModel>();
                  
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}