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
using WpfApp3.Data;

namespace WpfApp3.View
{
    /// <summary>
    /// Interação lógica para ucGridView.xam
    /// </summary>
    public partial class ucGridView : UserControl
    {
        public ucGridView()
        {
            InitializeComponent();
        }
        public BibliotecaDBContext context = new BibliotecaDBContext();
        private void DtGridView_Loaded(object sender, RoutedEventArgs e)
        {
            dtGridView.ItemsSource = context.Usuarios.ToList<Usuario>();
        }

        private void DtGridView_CellEditEnding_1(object sender, DataGridCellEditEndingEventArgs e)
        {
            //var objectToRemove = ((DataGrid)sender).SelectedValue as Usuario;     //Criar um botao excluir na tela e colocar esse comando dentro
            //Criar um botao excluir na tela e colocar esse comando dentro
            //context.Usuarios.Remove(objectToRemove);                              //Criar um botao excluir na tela e colocar esse comando dentro

            var objectToEdit = ((DataGrid)sender).SelectedValue as Usuario;

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();

            MessageBox.Show("Itens Salvos Com Sucesso");
        }
    }
}
