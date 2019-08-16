using MVCProjectForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProjectForms.Adicionar
{
    public partial class frmAdicionarGeneros : Form
    {
        public frmAdicionarGeneros()
        {
            InitializeComponent();
        }
        public Genero generoRow;
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            generoRow = new Genero
            {
                Tipo = tbxTipo.Text,
                Descricao = tbxDescricao.Text,
            };

            this.Close();
        }

        private void FrmAdicionarGeneros_Load(object sender, EventArgs e)
        {

        }
    }
}
