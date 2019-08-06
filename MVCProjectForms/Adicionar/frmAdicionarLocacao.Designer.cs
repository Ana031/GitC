namespace MVCProjectForms.Adicionar
{
    partial class frmAdicionarLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.tbxTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.cbxLivro = new System.Windows.Forms.ComboBox();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProjectForms.SistemaBibliotecaDBDataSet();
            this.livroTableAdapter = new MVCProjectForms.SistemaBibliotecaDBDataSetTableAdapters.LivroTableAdapter();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new MVCProjectForms.SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(211, 185);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 28);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(28, 122);
            this.lblDevolucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(79, 17);
            this.lblDevolucao.TabIndex = 15;
            this.lblDevolucao.Text = "Devolução:";
            // 
            // tbxTipo
            // 
            this.tbxTipo.Location = new System.Drawing.Point(119, 86);
            this.tbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(191, 22);
            this.tbxTipo.TabIndex = 14;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 90);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 58);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(28, 26);
            this.lblLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(43, 17);
            this.lblLivro.TabIndex = 9;
            this.lblLivro.Text = "Livro:";
            // 
            // cbxLivro
            // 
            this.cbxLivro.DataSource = this.livroBindingSource;
            this.cbxLivro.DisplayMember = "Titulo";
            this.cbxLivro.FormattingEnabled = true;
            this.cbxLivro.Location = new System.Drawing.Point(119, 22);
            this.cbxLivro.Name = "cbxLivro";
            this.cbxLivro.Size = new System.Drawing.Size(192, 24);
            this.cbxLivro.TabIndex = 18;
            this.cbxLivro.ValueMember = "Id";
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.DataSource = this.usuariosBindingSource;
            this.cbxUsuario.DisplayMember = "Nome";
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(119, 58);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(192, 24);
            this.cbxUsuario.TabIndex = 19;
            this.cbxUsuario.ValueMember = "Id";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // frmAdicionarLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 379);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.cbxLivro);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblDevolucao);
            this.Controls.Add(this.tbxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblLivro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdicionarLocacao";
            this.Text = "frmAdicionarLocacao";
            this.Load += new System.EventHandler(this.FrmAdicionarLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.TextBox tbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.ComboBox cbxLivro;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}