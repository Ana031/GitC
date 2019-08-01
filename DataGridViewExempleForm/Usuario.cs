using DataGridViewExempleForm.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExempleForm
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.CustumQuery(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExempleForm.QuerysInnerJoinDataSet1.UsuariosRow;

            switch(e.ColumnIndex)
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

                        this.usuariosTableAdapter.Update(editUsuario.UsuariosRow);
                    }
                    break;
            }

           // this.usuariosTableAdapter.DeleteQuery(usuSelect.Id);
            this.usuariosTableAdapter.CustumQuery(querysInnerJoinDataSet1.Usuarios);
        }
    }
}
