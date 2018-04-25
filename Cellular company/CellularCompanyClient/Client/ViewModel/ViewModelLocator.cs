using Client.Pages;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Diagnostics;
using Client.ServerServiceReference;

namespace Client.ViewModel
{
    public class ViewModelLocator
    {
        public const string FirstPageKey = "FirstPage";
        public const string SecondPageKey = "CustomersPage";
        public const string LinesPageKey = "LinesPage";
        public const string SimulatorPageKey = "SimulatorPage";
        public const string PaymentPageKey = "PaymentPage";

        public ViewModelLocator()
        {
            try
            {
                ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
                var nav = new NavigationService();
                nav.Configure(FirstPageKey, typeof(MainPage));
                nav.Configure(SecondPageKey, typeof(CustomerPage));
                nav.Configure(LinesPageKey, typeof(LinePage));
                nav.Configure(SimulatorPageKey, typeof(SimulatorPage));
                nav.Configure(PaymentPageKey, typeof(CalculateBillingPage));


                //Register your services used here
                SimpleIoc.Default.Register<INavigationService>(() => nav);
                SimpleIoc.Default.Register<MainViewModel>();
                SimpleIoc.Default.Register<ClientViewModel>();
                SimpleIoc.Default.Register<LinesViewModel>();
                SimpleIoc.Default.Register<SimulatorViewModel>();
                SimpleIoc.Default.Register<PaymentViewModel>();
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public MainViewModel MainVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public ClientViewModel ClientVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ClientViewModel>();
            }
        }

        public LinesViewModel LineVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LinesViewModel>();
            }
        }

        public SimulatorViewModel SimulatorVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SimulatorViewModel>();
            }
        }

        public PaymentViewModel PaymentVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PaymentViewModel>();
            }
        }

        public static void Cleanup()
        {
        }
    }
}