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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbxDevolução = new System.Windows.Forms.TextBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.tbxTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbxLivro = new System.Windows.Forms.TextBox();
            this.lblLivro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(158, 150);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // tbxDevolução
            // 
            this.tbxDevolução.Location = new System.Drawing.Point(89, 96);
            this.tbxDevolução.Name = "tbxDevolução";
            this.tbxDevolução.Size = new System.Drawing.Size(144, 20);
            this.tbxDevolução.TabIndex = 16;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(21, 99);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(62, 13);
            this.lblDevolucao.TabIndex = 15;
            this.lblDevolucao.Text = "Devolução:";
            // 
            // tbxTipo
            // 
            this.tbxTipo.Location = new System.Drawing.Point(89, 70);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(144, 20);
            this.tbxTipo.TabIndex = 14;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 73);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo:";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(89, 44);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(144, 20);
            this.tbxUsuario.TabIndex = 12;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(21, 47);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario:";
            // 
            // tbxLivro
            // 
            this.tbxLivro.Location = new System.Drawing.Point(89, 18);
            this.tbxLivro.Name = "tbxLivro";
            this.tbxLivro.Size = new System.Drawing.Size(144, 20);
            this.tbxLivro.TabIndex = 10;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(21, 21);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(33, 13);
            this.lblLivro.TabIndex = 9;
            this.lblLivro.Text = "Livro:";
            // 
            // frmAdicionarLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 308);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxDevolução);
            this.Controls.Add(this.lblDevolucao);
            this.Controls.Add(this.tbxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbxLivro);
            this.Controls.Add(this.lblLivro);
            this.Name = "frmAdicionarLocacao";
            this.Text = "frmAdicionarLocacao";
            this.Load += new System.EventHandler(this.FrmAdicionarLocacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbxDevolução;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.TextBox tbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbxLivro;
        private System.Windows.Forms.Label lblLivro;
    }
}