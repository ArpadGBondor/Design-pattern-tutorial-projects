using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM_tutorial.MVVM_NonPatternVersion
{
    /// <summary>
    /// Interaction logic for AccountCreationView.xaml
    /// </summary>
    public partial class AccountCreationView : Window
    {
        public AccountCreationView()
        {
            InitializeComponent();
        }

        private void OnClick_ValidatePassword(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Text.Trim().Length < 8)
            {
                lblErrorMessage.Text = "Password must be at least eight character long";
            }
            else if (txtPassword.Text.Trim().Length > 20)
            {
                lblErrorMessage.Text = "Password cannot be more than twenty character long";
            }
            else if (!txtPassword.Text.Any(char.IsUpper))
            {
                lblErrorMessage.Text = "Password must contain at least one upper-case character";
            }
            else if (!txtPassword.Text.Any(char.IsLower))
            {
                lblErrorMessage.Text = "Password must contain at least one lower-case character";
            }
            else if (!txtPassword.Text.Any(char.IsNumber))
            {
                lblErrorMessage.Text = "Password must contain at least one number";
            }
            else
            {
                lblErrorMessage.Text = "Password is secure";
            }
        }
    }
}
