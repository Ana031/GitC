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
    public partial class frmAdicionarEditoras : Form
    {
        public frmAdicionarEditoras()
        {
            InitializeComponent();
        }
        public Editora editorasRow;
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            editorasRow = new Editora
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text,
            };

            this.Close();
        }

        private void FrmAdicionarEditoras_Load(object sender, EventArgs e)
        {

        }
    }
}
