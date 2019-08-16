using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CadastroComValidacaoWPF.View
{
    /// <summary>
    /// Interação lógica para TelaDeCadastro.xam
    /// </summary>
    public partial class TelaDeCadastro : UserControl
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }
        public event EventHandler Eventos;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Campos(tbxNome.Text, tbxEmail.Text, tbxTelefone.Text);
        }
        public void Campos(string nome,string email, string telefone)
        {
            
            var Response = 0;
            Regex regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            Match match = regex.Match(email);

            Regex regexx = new Regex(@"^(\+55) \([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
            Match matchh = regexx.Match(telefone);

            if (match.Success)
            {
                Response.ToString(email + " is correct");
                 this.Visibility = Visibility.Hidden;
            }
            else
            {
                Response.ToString(email + " is incorrect");

                MessageBox.Show("Login Invalido");
            };

            if (matchh.Success)
            {
                Response.ToString(telefone + "is correct");
                this.Visibility = Visibility.Hidden;
            }
            else
            {
                Response.ToString(telefone + "is incorrect");

                MessageBox.Show("Telefone invalido");
            };
        }
    }
}
