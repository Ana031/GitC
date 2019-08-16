using MVCProjectForms.Adicionar;
using MVCProjectForms.Edicao;
using MVCProjectForms.Model;
using MVCProjectForms.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProjectForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            frmTelaLogin TLogin = new frmTelaLogin();
            TLogin.Show();

        }

        private void LblCadastrar_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios addUsu = new frmAdicionarUsuarios();
            addUsu.Show();
           
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
