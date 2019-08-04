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
            this.tbxRegistro = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // tbxRegistro
            // 
            this.tbxRegistro.Location = new System.Drawing.Point(94, 12);
            this.tbxRegistro.Name = "tbxRegistro";
            this.tbxRegistro.Size = new System.Drawing.Size(121, 20);
            this.tbxRegistro.TabIndex = 3;
            this.tbxRegistro.TextChanged += new System.EventHandler(this.TbxLivro_TextChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(15, 15);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 13);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "Registros:";
            this.lblRegistros.Click += new System.EventHandler(this.LblRegistros_Click);
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(94, 38);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(121, 20);
            this.tbxTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Título:";
            // 
            // tbxISBN
            // 
            this.tbxISBN.Location = new System.Drawing.Point(94, 64);
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(121, 20);
            this.tbxISBN.TabIndex = 7;
            this.tbxISBN.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(15, 67);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(15, 93);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(15, 119);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(43, 13);
            this.lblEditora.TabIndex = 9;
            this.lblEditora.Text = "Editora:";
            // 
            // tbxSinopse
            // 
            this.tbxSinopse.Location = new System.Drawing.Point(94, 141);
            this.tbxSinopse.Name = "tbxSinopse";
            this.tbxSinopse.Size = new System.Drawing.Size(121, 20);
            this.tbxSinopse.TabIndex = 11;
            // 
            // lblSinopse
            // 
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Location = new System.Drawing.Point(15, 144);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(48, 13);
            this.lblSinopse.TabIndex = 10;
            this.lblSinopse.Text = "Sinopse:";
            // 
            // tbxObs
            // 
            this.tbxObs.Location = new System.Drawing.Point(94, 167);
            this.tbxObs.Name = "tbxObs";
            this.tbxObs.Size = new System.Drawing.Size(121, 20);
            this.tbxObs.TabIndex = 13;
            this.tbxObs.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(15, 170);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(73, 13);
            this.lblObs.TabIndex = 12;
            this.lblObs.Text = "Observações:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(187, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // frmEdicaoLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 303);
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
            this.Controls.Add(this.tbxRegistro);
            this.Controls.Add(this.lblRegistros);
            this.Name = "frmEdicaoLivros";
            this.Text = "frmEdicaoLivros";
            this.Load += new System.EventHandler(this.FrmEdicaoLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRegistro;
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
    }
}