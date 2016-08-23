using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using WpfAppDemo.ViewModel;

namespace WpfAppDemo.ViewModel
{
    public class CommandBinder : ICommand
    {
        private MainViewModel _objViewModel;

        public CommandBinder(MainViewModel objViewModel)
        {
            _objViewModel = objViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }


        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            //if (string.IsNullOrWhiteSpace(_objViewModel))
            //{

            //}
            //else if (string.IsNullOrWhiteSpace(_objViewModel.Email))
            //{
            //}
            //else if (string.IsNullOrWhiteSpace(_objViewModel.Address))
            //{
            //}
            //else if (string.IsNullOrWhiteSpace(_objViewModel.Phone))
            //{
            //}
            //else if (string.IsNullOrWhiteSpace(_objViewModel.ProfileImage))
            //{
            //}
        }
    }
}
