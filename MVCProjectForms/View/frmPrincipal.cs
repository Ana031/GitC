using MVCProjectForms.Adicionar;
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
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios addUsuarios = new frmAdicionarUsuarios();
            addUsuarios.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacao addLocacao = new frmAdicionarLocacao();
            addLocacao.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarEditoras addEditoras = new frmAdicionarEditoras();
            addEditoras.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarLivros addLivros = new frmAdicionarLivros();
            addLivros.ShowDialog();
        }

        private void GenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarGeneros addGeneros = new frmAdicionarGeneros();
            addGeneros.ShowDialog();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdiconarAutores addAutores = new frmAdiconarAutores();
            addAutores.ShowDialog();
        }
    }
}
