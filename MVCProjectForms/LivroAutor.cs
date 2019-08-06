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

namespace MVCProjectForms
{
    public partial class LivroAutor : Form
    {
        public LivroAutor()
        {
            InitializeComponent();
        }

        public MVCProjectForms.SistemaBibliotecaDBDataSet.AutoresRow AutorRow;
        public MVCProjectForms.SistemaBibliotecaDBDataSet.LivroRow LivroRow;

        private void LivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.LivroAutor'. Você pode movê-la ou removê-la conforme necessário.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                return;
            }
            else
            {
                this.livroAutorTableAdapter1.InsertQuery
                    (LivroRow.Id,
                    (int)comboBox1.SelectedValue);


                this.livroAutorTableAdapter.FillBy
                    (this.sistemaBibliotecaDBDataSet.LivroAutor);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
