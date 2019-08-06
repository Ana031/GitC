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

namespace MVCProjectForms.View
{
    public partial class frmTelaLogin : Form
    {
       

        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
          // if (!this.tbxEmail.Text.Contains('@')
          //     || !this.tbxEmail.Text.Contains('.')) ;
            //{
            //    MessageBox.Show("Please Enter a Valid Email", "Invalid Email",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            
           // frmPrincipal principal = new frmPrincipal();
           // principal.Show();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            var result = this.usuariosTableAdapter1.LoginQuery(tbxEmail.Text, tbxSenha.Text);

            if (result != null) 
            {
                Session.user = new Usuario
              
                {
                    Id = (int)result
                };

                frmPrincipal frm = new frmPrincipal();
                frm.ShowDialog();
            }
            else
            {
                throw new Exception("Fuuuuuuuuuuu!");
            }

           // frmPrincipal principal = new frmPrincipal();
           // principal.Show();
        }

        private void TbxSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmTelaLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
