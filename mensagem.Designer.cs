namespace Funcionarios
{
    partial class mensagem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.assuntoText = new System.Windows.Forms.Label();
            this.assuntoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mensagemText = new System.Windows.Forms.Label();
            this.data_hora = new System.Windows.Forms.Label();
            this.docenteLabel = new System.Windows.Forms.Label();
            this.docenteNome = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // assuntoText
            // 
            this.assuntoText.AutoSize = true;
            this.assuntoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assuntoText.Location = new System.Drawing.Point(94, 41);
            this.assuntoText.Name = "assuntoText";
            this.assuntoText.Size = new System.Drawing.Size(79, 15);
            this.assuntoText.TabIndex = 1;
            this.assuntoText.Text = "assunto texto";
            // 
            // assuntoLabel
            // 
            this.assuntoLabel.AutoSize = true;
            this.assuntoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assuntoLabel.Location = new System.Drawing.Point(3, 39);
            this.assuntoLabel.Name = "assuntoLabel";
            this.assuntoLabel.Size = new System.Drawing.Size(67, 17);
            this.assuntoLabel.TabIndex = 2;
            this.assuntoLabel.Text = "Assunto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensagem: ";
            // 
            // mensagemText
            // 
            this.mensagemText.AutoSize = true;
            this.mensagemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemText.Location = new System.Drawing.Point(94, 72);
            this.mensagemText.Name = "mensagemText";
            this.mensagemText.Size = new System.Drawing.Size(99, 15);
            this.mensagemText.TabIndex = 4;
            this.mensagemText.Text = "mensagem texto";
            // 
            // data_hora
            // 
            this.data_hora.AutoSize = true;
            this.data_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_hora.Location = new System.Drawing.Point(519, 143);
            this.data_hora.Name = "data_hora";
            this.data_hora.Size = new System.Drawing.Size(81, 17);
            this.data_hora.TabIndex = 5;
            this.data_hora.Text = "data e hora";
            // 
            // docenteLabel
            // 
            this.docenteLabel.AutoSize = true;
            this.docenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docenteLabel.Location = new System.Drawing.Point(3, 11);
            this.docenteLabel.Name = "docenteLabel";
            this.docenteLabel.Size = new System.Drawing.Size(69, 17);
            this.docenteLabel.TabIndex = 8;
            this.docenteLabel.Text = "Docente: ";
            // 
            // docenteNome
            // 
            this.docenteNome.AutoSize = true;
            this.docenteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docenteNome.Location = new System.Drawing.Point(94, 13);
            this.docenteNome.Name = "docenteNome";
            this.docenteNome.Size = new System.Drawing.Size(51, 15);
            this.docenteNome.TabIndex = 7;
            this.docenteNome.Text = "docente";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(597, 11);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(31, 17);
            this.tipo.TabIndex = 9;
            this.tipo.Text = "tipo";
            // 
            // mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.docenteLabel);
            this.Controls.Add(this.docenteNome);
            this.Controls.Add(this.data_hora);
            this.Controls.Add(this.mensagemText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assuntoLabel);
            this.Controls.Add(this.assuntoText);
            this.Name = "mensagem";
            this.Size = new System.Drawing.Size(657, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label assuntoText;
        private System.Windows.Forms.Label assuntoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mensagemText;
        private System.Windows.Forms.Label data_hora;
        private System.Windows.Forms.Label docenteLabel;
        private System.Windows.Forms.Label docenteNome;
        private System.Windows.Forms.Label tipo;
    }
}
