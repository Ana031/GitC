﻿using System;
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
    public partial class frmEdicaoAutores : Form
    {
        public frmEdicaoAutores()
        {
            InitializeComponent();
        }
        public MVCProjectForms.SistemaBibliotecaDBDataSet.AutoresRow AutoresRow;
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            AutoresRow.Nome = tbxNome.Text;
            AutoresRow.Descricao = tbxDescricao.Text;

            this.Close();
        }

        private void FrmEdicaoAutores_Load(object sender, EventArgs e)
        {
            tbxNome.Text = AutoresRow.Nome;
            tbxDescricao.Text = AutoresRow.Descricao;

        }
    }
}
