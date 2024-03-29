﻿using DataGridViewExempleForm.Adicionar;
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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var venSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExempleForm.QuerysInnerJoinDataSet1.VendasRow;

            switch(e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(venSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoVendas editVendas = new frmEdicaoVendas();
                        editVendas.VendasRow = venSelect;
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(editVendas.VendasRow);
                    }
                    break;
            }

           // this.vendasTableAdapter.DeleteQuery(venSelect.Id);
            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Vendas);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas formAddVendas = new frmAdicionarVendas();
            formAddVendas.ShowDialog();

            if (formAddVendas.vendasRow?.Carro > 0 && formAddVendas.vendasRow?.Valor > 0)

            this.vendasTableAdapter.Insert(
                formAddVendas.vendasRow.Carro,
                formAddVendas.vendasRow.Quantidade,
                formAddVendas.vendasRow.Valor,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
            );
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }
    }
}
