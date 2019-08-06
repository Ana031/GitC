using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProjectForms.Edicao
{
    public partial class frmEdicaoGeneros : Form
    {
        public frmEdicaoGeneros()
        {
            InitializeComponent();
        }
        public MVCProjectForms.SistemaBibliotecaDBDataSet.GenerosRow GenerosRow;
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            GenerosRow.Tipo = tbxTipo.Text;
            GenerosRow.Descricao = tbxDescricao.Text;

            this.Close();
        }

        private void FrmEdicaoGeneros_Load(object sender, EventArgs e)
        {
            tbxTipo.Text = GenerosRow.Tipo;
            tbxDescricao.Text = GenerosRow.Descricao;
        }
    }
}
