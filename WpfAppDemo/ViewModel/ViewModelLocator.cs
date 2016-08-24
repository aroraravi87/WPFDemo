/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WpfAppDemo"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace WpfAppDemo.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);


            RegisterViewModel();
            
        }

        private void RegisterViewModel()
        {
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<PersonViewModel>();
            SimpleIoc.Default.Register<AccountViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public AccountViewModel AccountVM
        {
            get
            {
                if (!((SimpleIoc)(ServiceLocator.Current)).IsRegistered<AccountViewModel>())
                {
                    SimpleIoc.Default.Register<AccountViewModel>();
                }
                return ServiceLocator.Current.GetInstance<AccountViewModel>();
            }
        }

        public DashBoardViewModel DashboardVM
        {
            get
            {
                if (!((SimpleIoc)(ServiceLocator.Current)).IsRegistered<DashBoardViewModel>())
                {
                    SimpleIoc.Default.Register<DashBoardViewModel>();
                }
                return ServiceLocator.Current.GetInstance<DashBoardViewModel>();
            }
        }


        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}