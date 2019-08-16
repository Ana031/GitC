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
            livrosRow = new LivroC()
            {
                Registro = (int)numericUpDown1.Value,
                Titulo = tbxTitulo.Text,
                ISBN = tbxISBN.Text,
                Genero = (int)comboBox1.SelectedValue,
                Editora = (int)comboBox2.SelectedValue,
                Sinopse = tbxSinopse.Text,
                Observacoes = tbxObs.Text,
                

            };
            this.Close();
        }

        private void FrmAdicionarLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }
    }
}
