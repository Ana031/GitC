namespace MVCProjectForms.Edicao
{
    partial class frmEdicaoLocacao
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
            this.lblLivro = new System.Windows.Forms.Label();
            this.tbxLivro = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbxTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbxDevolução = new System.Windows.Forms.TextBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(12, 9);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(33, 13);
            this.lblLivro.TabIndex = 0;
            this.lblLivro.Text = "Livro:";
            // 
            // tbxLivro
            // 
            this.tbxLivro.Location = new System.Drawing.Point(80, 6);
            this.tbxLivro.Name = "tbxLivro";
            this.tbxLivro.Size = new System.Drawing.Size(144, 20);
            this.tbxLivro.TabIndex = 1;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(80, 32);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(144, 20);
            this.tbxUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // tbxTipo
            // 
            this.tbxTipo.Location = new System.Drawing.Point(80, 58);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(144, 20);
            this.tbxTipo.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 61);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // tbxDevolução
            // 
            this.tbxDevolução.Location = new System.Drawing.Point(80, 84);
            this.tbxDevolução.Name = "tbxDevolução";
            this.tbxDevolução.Size = new System.Drawing.Size(144, 20);
            this.tbxDevolução.TabIndex = 7;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(12, 87);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(62, 13);
            this.lblDevolucao.TabIndex = 6;
            this.lblDevolucao.Text = "Devolução:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(149, 138);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmEdicaoLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 287);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbxDevolução);
            this.Controls.Add(this.lblDevolucao);
            this.Controls.Add(this.tbxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbxLivro);
            this.Controls.Add(this.lblLivro);
            this.Name = "frmEdicaoLocacao";
            this.Text = "frmEdicaoLocacao";
            this.Load += new System.EventHandler(this.FrmEdicaoLocacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.TextBox tbxLivro;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tbxDevolução;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.Button btnSalvar;
    }
}