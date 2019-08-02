using DataGridViewExempleForm.Adicionar;
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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExempleForm.QuerysInnerJoinDataSet1.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoMarcas editMarca = new frmEdicaoMarcas();
                        editMarca.ModeloRow = marSelect;
                        editMarca.ShowDialog();

                        this.marcasTableAdapter.Update(editMarca.ModeloRow);
                    }
                    break;
            }



            //this.marcasTableAdapter.DeleteQuery(marSelect.Id);
            this.marcasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Marcas);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarMarcas formAddMarcas = new frmAdicionarMarcas();
            formAddMarcas.ShowDialog();

            if (!string.IsNullOrEmpty(formAddMarcas.marcasRow?.Nome))

                this.marcasTableAdapter.Insert(
                formAddMarcas.marcasRow.Nome,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
            );
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);
        }
    }
}
