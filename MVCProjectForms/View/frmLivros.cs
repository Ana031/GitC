using MVCProjectForms.Adicionar;
using MVCProjectForms.Edicao;
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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livro);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivros addLivros = new frmAdicionarLivros();
            addLivros.ShowDialog();

            this.livroTableAdapter.Insert(
                addLivros.livrosRow.Registro,
                addLivros.livrosRow.Titulo,
                addLivros.livrosRow.ISBN,
                addLivros.livrosRow.Genero,
                addLivros.livrosRow.Editora,
                addLivros.livrosRow.Sinopse,
                addLivros.livrosRow.Observacoes,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.livroTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Livro);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var livSelect = ((System.Data.DataRowView)
                  this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row 
                  as MVCProjectForms.SistemaBibliotecaDBDataSet.LivroRow;
        
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livroTableAdapter.DeleteQuery(livSelect.Id);
                        
                    }
                    break;
                case 1:
                    {
                        frmEdicaoLivros editLivros = new frmEdicaoLivros();
                        editLivros.LivroRow = livSelect;
                        editLivros.ShowDialog();

                        this.livroTableAdapter.Update(editLivros.LivroRow);
                    }break;
                   
            }
            this.livroTableAdapter.Fill(sistemaBibliotecaDBDataSet.Livro);
        }
    }
}
