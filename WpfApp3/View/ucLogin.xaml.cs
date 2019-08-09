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
    /// Interação lógica para ucLogin.xam
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }
        public event EventHandler sucess;
        public event EventHandler fail;
        public BibliotecaDBContext context = new BibliotecaDBContext();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userName = tbxLogin.Text;
            var userPass = tbxSenha.Password;

            var result = context.Usuarios
                .First(x =>
                x.Login == userName
                && x.Senha == userPass);

            if (result?.Id > 0)
            {
                sucess("Usuario logado com sucesso!", new EventArgs());
            }
            else
                fail($"Falha ao logar com usuário {userName}.", new EventArgs());
        }
    }
}
