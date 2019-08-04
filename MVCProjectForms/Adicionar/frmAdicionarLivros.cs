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
    public partial class frmAdicionarLivros : Form
    {
        public frmAdicionarLivros()
        {
            InitializeComponent();
        }
        public LivroC livrosRow;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            livrosRow = new LivroC
            {
                Registro = Convert.ToInt32(tbxRegistro.Text),
                Titulo = tbxTitulo.Text,
                ISBN = tbxISBN.Text,
                Genero = Convert.ToInt32(tbxGenero.Text),
                Editora = Convert.ToInt32(tbxEditora.Text),
                Sinopse = tbxSinopse.Text,
                Observacoes = tbxSinopse.Text,
            };
        }
    }
}
