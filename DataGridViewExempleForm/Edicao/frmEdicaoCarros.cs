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
    public partial class frmEdicaoCarros : Form
    {
        public frmEdicaoCarros()
        {
            InitializeComponent();
        }

        public DataGridViewExempleForm.QuerysInnerJoinDataSet1.CarrosRow CarrosRow;
        private void FrmEdicaoCarros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet1.Marcas);

            tbxModelo.Text          = CarrosRow.Modelo;
            dateTimePicker1.Value   = CarrosRow.Ano;
            comboBox1.SelectedValue = CarrosRow.Marca;

            //Transparencia
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            //button1.Enabled = false;
        }
        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet1.Marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void FillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet1.Marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            CarrosRow.Modelo = tbxModelo.Text;
            CarrosRow.Ano = dateTimePicker1.Value;
            CarrosRow.Marca = (int)comboBox1.SelectedValue;

            this.Close();
        }
    }
}
