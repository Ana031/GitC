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
    }
}
