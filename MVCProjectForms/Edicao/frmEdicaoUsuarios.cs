using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProjectForms.Edicao
{
    public partial class frmEdicaoUsuarios : Form
    {
        public frmEdicaoUsuarios()
        {
            InitializeComponent();
        }
        public MVCProjectForms.SistemaBibliotecaDBDataSet.UsuariosRow UsuariosRow;
        private void FrmEdicaoUsuarios_Load(object sender, EventArgs e)
        {
            tbxNome.Text = UsuariosRow.Nome;
            tbxEmail.Text = UsuariosRow.Email;
            tbxSenha.Text = UsuariosRow.Senha;

            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UsuariosRow.Nome = tbxNome.Text;
            UsuariosRow.Email = tbxEmail.Text;
            UsuariosRow.Senha = tbxSenha.Text;

            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
