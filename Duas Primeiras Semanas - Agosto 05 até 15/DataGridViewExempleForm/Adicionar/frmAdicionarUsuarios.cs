using DataGridViewExempleForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExempleForm.Adicionar
{
    public partial class frmAdicionarUsuarios : Form
    {
        public frmAdicionarUsuarios()
        {
            InitializeComponent();
        }
        public Usuario_ usuariosRow;
        private void FrmAdicionarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            usuariosRow = new Usuario_
            {
                Usuario = tbxUsuario.Text,
                
            };

            this.Close();
        }
    }
}
