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
    public partial class frmAdicionarLocacao : Form
    {
        public frmAdicionarLocacao()
        {
            InitializeComponent(); 
        }
        public LocacaoC locacaoRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            locacaoRow = new LocacaoC
            {
                Livro = (int)cbxLivro.SelectedValue,
                Usuario = (int)cbxUsuario.SelectedValue,
                Tipo = Convert.ToInt32(tbxTipo.Text),
                Devolucaod = dateTimePicker1.Value,
            };
            this.Close();
        }

        private void FrmAdicionarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livro);

            // this.marcasTableAdapter1.Fill(this.querysInnerJoinDataSet1.Marcas);
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.livroTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Livro);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Usuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
