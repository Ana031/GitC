using MVCProjectForms.Adicionar;
using MVCProjectForms.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProjectForms.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios frmAddUsuarios = new frmAdicionarUsuarios();
            frmAddUsuarios.ShowDialog();

            if (!string.IsNullOrEmpty(frmAddUsuarios.usuariosRow?.Nome))

            this.usuariosTableAdapter.Insert(
                frmAddUsuarios.usuariosRow.Nome,
                frmAddUsuarios.usuariosRow.Email,
                frmAddUsuarios.usuariosRow.Senha,
                frmAddUsuarios.usuariosRow.Login,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProjectForms.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoUsuarios editUsuario = new frmEdicaoUsuarios();
                        editUsuario.UsuariosRow = usuSelect;
                        editUsuario.ShowDialog();
                    }
                    break;
            }
            this.usuariosTableAdapter.DeleteQuery(usuSelect.Id);
           // this.usuariosTableAdapter.CustomQuery(SistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
