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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdiconarAutores addAutores = new frmAdiconarAutores();
            addAutores.ShowDialog();

            this.autoresTableAdapter.Insert(
                addAutores.autoresRow.Nome,
                addAutores.autoresRow.Descricao
                );
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var AutSelect = ((System.Data.DataRowView)
                   this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                   as MVCProjectForms.SistemaBibliotecaDBDataSet.AutoresRow;

            switch(e.ColumnIndex)
            {
                case 0:
                    {
                        this.autoresTableAdapter.DeleteQuery1(AutSelect.Id);
                    }break;
                case 1:
                    {
                        frmEdicaoAutores editAutor = new frmEdicaoAutores();
                        editAutor.AutoresRow = AutSelect;
                        editAutor.ShowDialog();

                        this.autoresTableAdapter.Update(editAutor.AutoresRow);
                    }break;
            }
            this.autoresTableAdapter.Fill(sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
