using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_tutorial.MVVM_PatternVersion.Model
{
    public class AccountModel : INotifyPropertyChanged
    {
        private string _name;
        private string _password;
        private string _validationMessage;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string ValidationMassage
        {
            get { return _validationMessage; }
            set
            {
                _validationMessage = value;
                OnPropertyChanged(nameof(ValidationMassage));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ValidatePassword()
        {
            
            if (Password.Trim().Length < 8)
            {
                ValidationMassage = "Password must be at least eight character long";
            }
            else if (Password.Trim().Length > 20)
            {
                ValidationMassage = "Password cannot be more than twenty character long";
            }
            else if (!Password.Any(char.IsUpper))
            {
                ValidationMassage = "Password must contain at least one upper-case character";
            }
            else if (!Password.Any(char.IsLower))
            {
                ValidationMassage = "Password must contain at least one lower-case character";
            }
            else if (!Password.Any(char.IsNumber))
            {
                ValidationMassage = "Password must contain at least one number";
            }
            else
            {
                ValidationMassage = "Password is secure";
            }
        }
    }
}
