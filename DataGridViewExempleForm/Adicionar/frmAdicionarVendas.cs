using DataGridViewExempleForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExempleForm.Adicionar
{
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }
        public Venda_ vendasRow;
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TbxCarro_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
            

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            vendasRow = new Venda_
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = (int)nQuantidade.Value,
                Valor = decimal.Parse(tbxValor.Text)
            };

            this.Close();
        }
    }
}
