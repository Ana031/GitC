using CadastroDeLanchesForm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeLanchesForm
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }
        public Lanche novoLanche = new Lanche();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoLanche.Modelo = tbxModelo.Text;
            novoLanche.Ano = (int)nrAno.Value;
           

            this.Close();
        }
    }
}
