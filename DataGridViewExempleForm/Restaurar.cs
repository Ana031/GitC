using DataGridViewExempleForm.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExempleForm
{
    public partial class Restaurar : Form
    {
        public Restaurar()
        {
            InitializeComponent();
        }

        private void Restaurar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Restaurar(this.querysInnerJoinDataSet1.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExempleForm.QuerysInnerJoinDataSet1.CarrosRow;

            switch (e.ColumnIndex)
            {
                //Coluna Deletar
                case 0:
                    {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                    }
                    break;
                //Editar
                case 1:
                    {
                        frmEdicaoCarros editCarro = new frmEdicaoCarros();
                        editCarro.CarrosRow = carSelect;
                        editCarro.ShowDialog();

                        //ou
                        this.carrosTableAdapter.Update(editCarro.CarrosRow);
                        /*    (editCarro.CarrosRow.Modelo,
                             editCarro.CarrosRow.Ano.ToString(),
                             editCarro.CarrosRow.Marca,
                             editCarro.CarrosRow.UsuAlt,
                             DateTime.Now,
                             editCarro.CarrosRow.Id);*/
                    }
                    break;
            }
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
