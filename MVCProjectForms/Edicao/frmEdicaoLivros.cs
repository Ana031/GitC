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
            LivroRow.Registro = Convert.ToInt32(tbxRegistro.Text);
            LivroRow.Titulo = tbxTitulo.Text;
            LivroRow.ISBN = tbxISBN.Text;
            LivroRow.Genero = comboBox1.SelectedIndex;
            LivroRow.Editora = comboBox2.SelectedIndex;
            LivroRow.Sinopse = tbxSinopse.Text;
            LivroRow.Observacoes = tbxObs.Text;


            this.Close();
        }

        private void FrmEdicaoLivros_Load(object sender, EventArgs e)
        {
            tbxRegistro.Text = Convert.ToString(LivroRow.Registro);
            tbxTitulo.Text = LivroRow.Titulo;
            tbxISBN.Text = LivroRow.ISBN;
            comboBox1.SelectedItem = LivroRow.Genero;
            comboBox2.SelectedItem = LivroRow.Editora;
            tbxSinopse.Text = LivroRow.Sinopse;
            tbxObs.Text = LivroRow.Observacoes;

            this.Close();
        }
    }
}
