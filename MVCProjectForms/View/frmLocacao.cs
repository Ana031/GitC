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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacao addLocacao = new frmAdicionarLocacao();
            addLocacao.ShowDialog();

            this.locacaoTableAdapter.Insert(
                addLocacao.locacaoRow.Livro,
                addLocacao.locacaoRow.Usuario,
                addLocacao.locacaoRow.Tipo,
                addLocacao.locacaoRow.Devolucaod,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProjectForms.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.DeleteQuery(locSelect.Id);
                    }break;
                case 1:
                    {
                        frmEdicaoLocacao editLocacao = new frmEdicaoLocacao();
                        editLocacao.LocacaoRow = locSelect;
                        editLocacao.ShowDialog();

                        this.locacaoTableAdapter.Update(editLocacao.LocacaoRow);
                    }break;
            }
        }
    }
}
