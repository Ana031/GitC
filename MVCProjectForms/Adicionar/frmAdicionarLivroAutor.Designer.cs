namespace MVCProjectForms.Adicionar
{
    partial class frmAdicionarLivroAutor
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
            this.lblAutor = new System.Windows.Forms.Label();
            this.tbxLivro = new System.Windows.Forms.TextBox();
            this.tbxAutor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(12, 9);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(43, 17);
            this.lblLivro.TabIndex = 0;
            this.lblLivro.Text = "Livro:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 49);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(46, 17);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // tbxLivro
            // 
            this.tbxLivro.Location = new System.Drawing.Point(76, 6);
            this.tbxLivro.Name = "tbxLivro";
            this.tbxLivro.Size = new System.Drawing.Size(207, 22);
            this.tbxLivro.TabIndex = 2;
            // 
            // tbxAutor
            // 
            this.tbxAutor.Location = new System.Drawing.Point(76, 46);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(207, 22);
            this.tbxAutor.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(183, 121);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 34);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // frmAdicionarLivroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 273);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxAutor);
            this.Controls.Add(this.tbxLivro);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblLivro);
            this.Name = "frmAdicionarLivroAutor";
            this.Text = "frmAdicionarLivroAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox tbxLivro;
        private System.Windows.Forms.TextBox tbxAutor;
        private System.Windows.Forms.Button btnAdicionar;
    }
}