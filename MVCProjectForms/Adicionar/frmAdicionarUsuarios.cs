using MVCProjectForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProjectForms.Adicionar
{
    public partial class frmAdicionarUsuarios : Form
    {
        public frmAdicionarUsuarios()
        {
            InitializeComponent();
        }
        public Usuario usuariosRow;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           // usuariosRow = new Usuario
           // {
           //     Nome = tbxNome.Text,
           //     Email = tbxEmail.Text,
           //     Senha = tbxSenha.Text,
           // };
           //
           // this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            usuariosRow = new Usuario
            {
                Nome = tbxNome.Text,
                Email = tbxEmail.Text,
                Senha = tbxSenha.Text,
                Login = textBox1.Text,
            };

            this.Close();
        }

        private void FrmAdicionarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
