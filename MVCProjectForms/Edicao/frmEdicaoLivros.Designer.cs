namespace MVCProjectForms.Edicao
{
    partial class frmEdicaoLivros
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
            this.lblRegistros = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.tbxSinopse = new System.Windows.Forms.TextBox();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.tbxObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.sistemaBibliotecaDBDataSet = new MVCProjectForms.SistemaBibliotecaDBDataSet();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroTableAdapter = new MVCProjectForms.SistemaBibliotecaDBDataSetTableAdapters.LivroTableAdapter();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosTableAdapter = new MVCProjectForms.SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter();
            this.editorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorasTableAdapter = new MVCProjectForms.SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(20, 18);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(72, 17);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "Registros:";
            this.lblRegistros.Click += new System.EventHandler(this.LblRegistros_Click);
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(125, 47);
            this.tbxTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(160, 22);
            this.tbxTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 50);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 17);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Título:";
            // 
            // tbxISBN
            // 
            this.tbxISBN.Location = new System.Drawing.Point(125, 79);
            this.tbxISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(160, 22);
            this.tbxISBN.TabIndex = 7;
            this.tbxISBN.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(20, 82);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(43, 17);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(20, 114);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 17);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(20, 146);
            this.lblEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(57, 17);
            this.lblEditora.TabIndex = 9;
            this.lblEditora.Text = "Editora:";
            // 
            // tbxSinopse
            // 
            this.tbxSinopse.Location = new System.Drawing.Point(125, 174);
            this.tbxSinopse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSinopse.Name = "tbxSinopse";
            this.tbxSinopse.Size = new System.Drawing.Size(160, 22);
            this.tbxSinopse.TabIndex = 11;
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Location = new System.Drawing.Point(20, 177);
            this.lblSinopse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(63, 17);
            this.lblSinopse.TabIndex = 10;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // tbxObs
            // 
            this.tbxObs.Location = new System.Drawing.Point(125, 206);
            this.tbxObs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxObs.Name = "tbxObs";
            this.tbxObs.Size = new System.Drawing.Size(160, 22);
            this.tbxObs.TabIndex = 13;
            this.tbxObs.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(20, 209);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(96, 17);
            this.lblObs.TabIndex = 12;
            this.lblObs.Text = "Observações:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.generosBindingSource;
            this.comboBox1.DisplayMember = "Tipo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 111);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.editorasBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 140);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.ValueMember = "Id";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(249, 270);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // editorasBindingSource
            // 
            this.editorasBindingSource.DataMember = "Editoras";
            this.editorasBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // editorasTableAdapter
            // 
            this.editorasTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 17;
            // 
            // frmEdicaoLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 373);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbxObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.tbxSinopse);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.tbxISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblRegistros);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEdicaoLivros";
            this.Text = "frmEdicaoLivros";
            this.Load += new System.EventHandler(this.FrmEdicaoLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox tbxSinopse;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.TextBox tbxObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSalvar;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.BindingSource editorasBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter editorasTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}