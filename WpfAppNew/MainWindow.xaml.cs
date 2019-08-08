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
using WpfAppNew.Data;

namespace WpfAppNew
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
        public BibliotecaDBContext context;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context = new BibliotecaDBContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(context.Usuarios            //Tras somente os usuarios
                .OrderBy(x => x.Nome)                   //Ordena os nomes por asc ou desc
                .FirstOrDefault(x => x.Id > 0).Nome);   //Pega o primeiro nome que atende a condicao

            var runList = context.Usuarios
                .OrderBy(x => x.Nome).ToList<Usuarios>();

            gridView.ItemsSource = runList;
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
