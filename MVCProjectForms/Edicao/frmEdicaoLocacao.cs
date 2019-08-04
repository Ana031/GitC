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
    public partial class frmEdicaoLocacao : Form
    {
        public frmEdicaoLocacao()
        {
            InitializeComponent();
        }
        public MVCProjectForms.SistemaBibliotecaDBDataSet.LocacaoRow LocacaoRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            LocacaoRow.Livro = Convert.ToInt32(tbxLivro.Text);
            LocacaoRow.Usuario = Convert.ToInt32(tbxUsuario.Text);
            LocacaoRow.Tipo = Convert.ToInt32(tbxTipo);
            LocacaoRow.Devolucao = Convert.ToDateTime(tbxDevolução);

            this.Close();
        }

        private void FrmEdicaoLocacao_Load(object sender, EventArgs e)
        {
            
            tbxLivro.Text = Convert.ToString(LocacaoRow.Livro);
            tbxUsuario.Text = Convert.ToString(LocacaoRow.Usuario);
            tbxTipo.Text = Convert.ToString(LocacaoRow.Tipo);
            tbxDevolução.Text = Convert.ToString(LocacaoRow.Devolucao);

            this.Close();

        }
    }
}
