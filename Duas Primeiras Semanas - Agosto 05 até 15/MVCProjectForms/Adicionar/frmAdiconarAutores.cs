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
    public partial class frmAdiconarAutores : Form
    {
        public frmAdiconarAutores()
        {
            InitializeComponent();
        }
        public Autor autoresRow;
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            autoresRow = new Autor
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text,
            };
            this.Close();
        }

        private void FrmAdiconarAutores_Load(object sender, EventArgs e)
        {

        }
    }
}
