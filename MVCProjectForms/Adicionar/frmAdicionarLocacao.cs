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
    public partial class frmAdicionarLocacao : Form
    {
        public frmAdicionarLocacao()
        {
            InitializeComponent(); 
        }
        public LocacaoC locacaoRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            locacaoRow = new LocacaoC
            {
                Livro = Convert.ToInt32(tbxLivro.Text),
                Usuario = Convert.ToInt32(tbxUsuario.Text),
                Tipo = Convert.ToInt32(tbxTipo.Text),
                Devolucaod = Convert.ToDateTime(tbxDevolução.Text),
            };
            this.Close();
        }

        private void FrmAdicionarLocacao_Load(object sender, EventArgs e)
        {
           
            // this.marcasTableAdapter1.Fill(this.querysInnerJoinDataSet1.Marcas);
        }
    }
}
