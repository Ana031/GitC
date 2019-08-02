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
    public partial class frmAdicionarMarcas : Form
    {
        public frmAdicionarMarcas()
        {
            InitializeComponent();
        }

        public Marca_ marcasRow;
        
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            marcasRow = new Marca_
            {
                Nome = textBox1.Text,
                
            };

            this.Close();
        }

        private void FrmAdicionarMarcas_Load(object sender, EventArgs e)
        {
           // this.marcasTableAdapter1.Fill(this.querysInnerJoinDataSet1.Marcas);
        }
    }
}
