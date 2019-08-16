using MyFirstWpfApp.Views;
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

namespace MyFirstWpfApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FormLogin_loginCorrect(object sender, EventArgs e)
        {
            ucDesignCalc.Visibility = Visibility.Hidden;
            ucDesignCalc.Visibility = Visibility.Visible;

        }

        private void FormLogin_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
