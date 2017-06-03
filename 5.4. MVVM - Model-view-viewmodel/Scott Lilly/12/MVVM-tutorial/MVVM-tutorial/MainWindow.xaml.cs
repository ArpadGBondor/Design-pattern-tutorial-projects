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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNonPatternVersion_Click(object sender, RoutedEventArgs e)
        {
            MVVM_NonPatternVersion.AccountCreationView view =
                new MVVM_NonPatternVersion.AccountCreationView();

            view.ShowDialog();
        }

        private void btnPatternVersion_Click(object sender, RoutedEventArgs e)
        {
            MVVM_PatternVersion.View.AccountCreationView view =
                new MVVM_PatternVersion.View.AccountCreationView();

            view.ShowDialog();
        }
    }
}
