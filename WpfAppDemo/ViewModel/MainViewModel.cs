using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppDemo.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private CommandBinder myCommand;

        public MainViewModel()
        {
            myCommand = new CommandBinder(this);
        }

        public ICommand CommandAction
        {
            get { return myCommand; }
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }
        private string _emailid;

        public string EmailID
        {
            get { return _emailid; }
            set
            {
                _emailid = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EmailID"));
            }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Phone"));

            }
        }

        private string _ProfileImage;

        public string ProfileImage
        {
            get { return _ProfileImage; }
            set
            {
                _ProfileImage = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ProfileImage"));

            }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Address"));

            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        string IDataErrorInfo.Error
        {
            get { throw new NotImplementedException(); }
        }

        static readonly string[] ValidationProperties =
        {
            "Name",
            "Email"
        };

        string IDataErrorInfo.this[string propertyName]
        {
            get { return GetValidationError(propertyName); }
        }

        public bool IsValid
        {
            get
            {
                foreach (string property in ValidationProperties)
                {
                    if (GetValidationError(property) != null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        string GetValidationError(string propertyName)
        {
            string error = null;
            switch (propertyName)
            {
                case "Name":
                    error = ValidateNameFields(propertyName);
                    break;
                case "Email":
                    error = ValidateEmailFields(propertyName);
                    break;

            }
            return error;
        }

        private string ValidateNameFields(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                return "Customer Name is Required";
            }

            return null;
        }

        private string ValidateEmailFields(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                return "Customer Email is Required";
            }

            return null;
        }
    }

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
            if (string.IsNullOrWhiteSpace(_objViewModel.Name))
            {

            }
            else if (string.IsNullOrWhiteSpace(_objViewModel.EmailID))
            {
            }
            else if (string.IsNullOrWhiteSpace(_objViewModel.EmailID))
            {
            }
            else if (string.IsNullOrWhiteSpace(_objViewModel.EmailID))
            {
            }
            else if (string.IsNullOrWhiteSpace(_objViewModel.EmailID))
            {
            }
        }
    }
}
