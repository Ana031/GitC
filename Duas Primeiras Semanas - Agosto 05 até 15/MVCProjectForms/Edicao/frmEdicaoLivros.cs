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
    public partial class frmEdicaoLivros : Form
    {
        public frmEdicaoLivros()
        {
            InitializeComponent();
        }

        public MVCProjectForms.SistemaBibliotecaDBDataSet.LivroRow LivroRow;

        private void TbxLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblRegistros_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            LivroRow.Registro = (int)numericUpDown1.Value;
            LivroRow.Titulo = tbxTitulo.Text;
            LivroRow.ISBN = tbxISBN.Text;
            LivroRow.Genero = (int)comboBox1.SelectedValue;
            LivroRow.Editora = (int)comboBox2.SelectedValue;
            LivroRow.Sinopse = tbxSinopse.Text;
            LivroRow.Observacoes = tbxObs.Text;


            this.Close();
        }

        private void FrmEdicaoLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livro);

            numericUpDown1.Value = LivroRow.Registro;
            tbxTitulo.Text = LivroRow.Titulo;
            tbxISBN.Text = LivroRow.ISBN;
            comboBox1.SelectedItem = LivroRow.Genero;
            comboBox2.SelectedItem = LivroRow.Editora;
            tbxSinopse.Text = LivroRow.Sinopse;
            tbxObs.Text = LivroRow.Observacoes;

            
        }
    }
}
