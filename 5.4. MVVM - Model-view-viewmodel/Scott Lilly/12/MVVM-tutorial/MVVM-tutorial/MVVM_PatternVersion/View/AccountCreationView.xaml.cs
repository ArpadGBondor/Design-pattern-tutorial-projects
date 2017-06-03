using MVVM_tutorial.MVVM_PatternVersion.ViewModel;
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

namespace MVVM_tutorial.MVVM_PatternVersion.View
{
    /// <summary>
    /// Interaction logic for AccountCreationView.xaml
    /// </summary>
    public partial class AccountCreationView : Window
    {
        private readonly AccountCreationViewModel _vievModel = new AccountCreationViewModel();
        public AccountCreationView()
        {
            InitializeComponent();

            DataContext = _vievModel;
        }

        private void OnClick_ValidatePassword(object sender, RoutedEventArgs e)
        {
            _vievModel.ValidatePassword();
        }
    }
}
