using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExempleForm.Edicao
{
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public DataGridViewExempleForm.QuerysInnerJoinDataSet1.VendasRow VendasRow;
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            VendasRow.Carro = int.Parse(tbxCarro.Text);
            VendasRow.Quantidade =  nQuantidade.DecimalPlaces;
            VendasRow.Valor = decimal.Parse(tbxValor.Text);

            this.Close();
        }

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
           //this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);

            tbxCarro.Text = VendasRow.Carro.ToString();
            nQuantidade.Value = VendasRow.Carro;
            tbxValor.Text = VendasRow.Carro.ToString();
        }
    }
}
