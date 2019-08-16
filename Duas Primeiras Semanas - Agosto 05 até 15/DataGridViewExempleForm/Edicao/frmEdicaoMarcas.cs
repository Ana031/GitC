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
    public partial class frmEdicaoMarcas : Form
    {
        public frmEdicaoMarcas()
        {
            InitializeComponent();
        }
        public DataGridViewExempleForm.QuerysInnerJoinDataSet1.MarcasRow ModeloRow;
        private void BtnSalvarModelo_Click(object sender, EventArgs e)
        {
            ModeloRow.Nome = textBox1.Text;

            this.Close();
        }

        private void FrmEdicaoModelos_Load(object sender, EventArgs e)
        {
            textBox1.Text = ModeloRow.Nome;
        }
    }
}
