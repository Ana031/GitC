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

            LocacaoRow.Livro =   (int)cbxLivro.SelectedValue;
            LocacaoRow.Usuario = (int)cbxUsuario.SelectedValue;
            LocacaoRow.Tipo =         Convert.ToInt32(tbxTipo.Text);
            LocacaoRow.Devolucao =    dateTimePicker1.Value;

            this.Close();
        }

        private void FrmEdicaoLocacao_Load(object sender, EventArgs e)
        {
            
            cbxLivro.SelectedValue  = LocacaoRow.Livro;
            cbxUsuario.SelectedValue  = LocacaoRow.Usuario;
            tbxTipo.Text   = LocacaoRow.Tipo.ToString();
            dateTimePicker1.Value       = LocacaoRow.Devolucao;

          

        }
    }
}
