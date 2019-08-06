using MVCProjectForms.Adicionar;
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

namespace MVCProjectForms.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            if (Session.user == null)
                throw new Exception("Erro Critico de Sistma!");
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios Usuarios = new frmUsuarios();
            Usuarios.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao Locacao = new frmLocacao();
            Locacao.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras Editoras = new frmEditoras();
            Editoras.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros Livros = new frmLivros();
            Livros.ShowDialog();
        }

        private void GenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros Generos = new frmGeneros();
            Generos.ShowDialog();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores Autores = new frmAutores();
            Autores.ShowDialog();
        }
    }
}
