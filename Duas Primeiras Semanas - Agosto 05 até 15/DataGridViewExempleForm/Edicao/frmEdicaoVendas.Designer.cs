namespace DataGridViewExempleForm.Edicao
{
    partial class frmEdicaoVendas
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
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbxCarro = new System.Windows.Forms.TextBox();
            this.nQuantidade = new System.Windows.Forms.NumericUpDown();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(40, 30);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(47, 17);
            this.lblCarro.TabIndex = 0;
            this.lblCarro.Text = "Carro:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(40, 66);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(94, 17);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidadde:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(40, 100);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 17);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            this.lblValor.Click += new System.EventHandler(this.Label3_Click);
            // 
            // tbxCarro
            // 
            this.tbxCarro.Location = new System.Drawing.Point(140, 27);
            this.tbxCarro.Name = "tbxCarro";
            this.tbxCarro.Size = new System.Drawing.Size(284, 22);
            this.tbxCarro.TabIndex = 3;
            this.tbxCarro.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // nQuantidade
            // 
            this.nQuantidade.Location = new System.Drawing.Point(140, 64);
            this.nQuantidade.Name = "nQuantidade";
            this.nQuantidade.Size = new System.Drawing.Size(284, 22);
            this.nQuantidade.TabIndex = 4;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(140, 97);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(284, 22);
            this.tbxValor.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(312, 151);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 45);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // frmEdicaoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 255);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.nQuantidade);
            this.Controls.Add(this.tbxCarro);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblCarro);
            this.Name = "frmEdicaoVendas";
            this.Text = "frmEdicaoVendas";
            this.Load += new System.EventHandler(this.FrmEdicaoVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbxCarro;
        private System.Windows.Forms.NumericUpDown nQuantidade;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Button btnSalvar;
    }
}