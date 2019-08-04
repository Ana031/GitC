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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarEditoras addEditoras = new frmAdicionarEditoras();
            addEditoras.ShowDialog();

            this.editorasTableAdapter.Insert(
                addEditoras.editorasRow.Nome,
                addEditoras.editorasRow.Descricao
                );
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ediSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProjectForms.SistemaBibliotecaDBDataSet.EditorasRow;

            switch(e.ColumnIndex)
            {
                case 0:
                    {
                       // this.editorasTableAdapter.DeleteQuery(ediSelect.Id);
                    }break;
                case 1:
                    {
                        frmEdicaoEditoras editEditoras = new frmEdicaoEditoras();
                        editEditoras.EditoraRow = ediSelect;
                        editEditoras.ShowDialog();

                        this.editorasTableAdapter.Update(editEditoras.EditoraRow);
                    }break;
            }
            this.editorasTableAdapter.Fill(sistemaBibliotecaDBDataSet.Editoras);
        }
    }
}
