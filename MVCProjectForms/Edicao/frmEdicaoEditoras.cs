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
    public partial class frmEdicaoEditoras : Form
    {
        public frmEdicaoEditoras()
        {
            InitializeComponent();
        }
        public MVCProjectForms.SistemaBibliotecaDBDataSet.EditorasRow EditoraRow;
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            EditoraRow.Nome = tbxNome.Text;
            EditoraRow.Descricao = tbxDescricao.Text;

            this.Close();
        }
        private void FrmEdicaoEditoras_Load(object sender, EventArgs e)
        {
            tbxNome.Text = EditoraRow.Nome;
            tbxDescricao.Text = EditoraRow.Descricao;

          
        }
    }
}
