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
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }
        public Carro_ carrosRow;
        private object marcasTableAdapter;

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter1.Fill(this.querysInnerJoinDataSet1.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Carro_
            {
                Modelo = textBox1.Text,
                Ano = dateTimePicker1.Value,
                Marca = (int)comboBox1.SelectedValue
            };

            this.Close();
        }
    }
}
