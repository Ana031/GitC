namespace CadastroDeLanchesForm
{
    partial class TelaDeCadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.nrAno = new System.Windows.Forms.NumericUpDown();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nrAno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalvar.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(272, 135);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 55);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 17);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 17);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // nrAno
            // 
            this.nrAno.Location = new System.Drawing.Point(100, 54);
            this.nrAno.Name = "nrAno";
            this.nrAno.Size = new System.Drawing.Size(305, 22);
            this.nrAno.TabIndex = 2;
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(100, 12);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(305, 22);
            this.tbxModelo.TabIndex = 3;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(12, 59);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 17);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano:";
            // 
            // TelaDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(476, 245);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.nrAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnSalvar);
            this.Name = "TelaDeCadastro";
            this.Text = "TelaDeCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.nrAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.NumericUpDown nrAno;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.Label lblAno;
    }
}