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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarGeneros addGeneros = new frmAdicionarGeneros();
            addGeneros.ShowDialog();

            this.generosTableAdapter.Insert(
                addGeneros.generoRow.Tipo,
                addGeneros.generoRow.Descricao
                );
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var genSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProjectForms.SistemaBibliotecaDBDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        //this.generosTableAdapter.DeleteQuery(genSelect.Id);
                    }break;
                case 1:
                    {
                        frmEdicaoGeneros editGeneros = new frmEdicaoGeneros();
                        editGeneros.GenerosRow = genSelect;
                        editGeneros.ShowDialog();

                        this.generosTableAdapter.Update(editGeneros.GenerosRow);
                    }break;
            }
        }
    }
}
