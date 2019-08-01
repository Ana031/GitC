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
    public partial class Carro : Form
    {
        public Carro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.


        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            Marcas frmMarcas = new Marcas();
            frmMarcas.ShowDialog();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            Usuario frmUsuario = new Usuario();
            frmUsuario.ShowDialog();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Vendas frmVenda = new Vendas();
            frmVenda.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                case 1: {
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
                    } break;
            }
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }

 

        //MessageBox.Show(carSelect)

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();

            this.carrosTableAdapter.Insert (
                formAdd.carrosRow.Modelo,
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
            );
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
        }

        private void BtnLixeira_Click(object sender, EventArgs e)
        {
            Lixeira fmrlixo = new Lixeira();
                fmrlixo.ShowDialog();
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            Restaurar fmrRest = new Restaurar();
            fmrRest.ShowDialog();
        }
    }
}
