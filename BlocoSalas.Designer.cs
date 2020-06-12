namespace Funcionarios
{
    partial class BlocoSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlocoSalas));
            this.listObjects = new BrightIdeasSoftware.ObjectListView();
            this.numSala = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.janelaSubtitulo = new System.Windows.Forms.Label();
            this.janelaTitulo = new System.Windows.Forms.Label();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.panelCriarSala = new System.Windows.Forms.Panel();
            this.panelFormHide = new System.Windows.Forms.PictureBox();
            this.panelFormButton = new System.Windows.Forms.Button();
            this.panelFormTitulo = new System.Windows.Forms.Label();
            this.buttonAdicionarObject = new System.Windows.Forms.Button();
            this.numSalaInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSala = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ajudaBtn = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            this.panelCriarSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).BeginInit();
            this.panelSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // listObjects
            // 
            this.listObjects.AllColumns.Add(this.numSala);
            this.listObjects.CellEditUseWholeCell = false;
            this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numSala});
            this.listObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjects.HideSelection = false;
            this.listObjects.Location = new System.Drawing.Point(12, 81);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(164, 215);
            this.listObjects.TabIndex = 23;
            this.listObjects.UseCompatibleStateImageBehavior = false;
            this.listObjects.View = System.Windows.Forms.View.Details;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.listObjects_SelectedIndexChanged);
            // 
            // numSala
            // 
            this.numSala.AspectName = "numSala";
            this.numSala.Text = "Número da Sala";
            this.numSala.Width = 151;
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(70, 43);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(143, 13);
            this.janelaSubtitulo.TabIndex = 22;
            this.janelaSubtitulo.Text = "A mostrar X salas do Bloco Y";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(66, 12);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(102, 20);
            this.janelaTitulo.TabIndex = 20;
            this.janelaTitulo.Text = "Bloco | Salas";
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.Sala;
            this.janelaLogo.InitialImage = null;
            this.janelaLogo.Location = new System.Drawing.Point(12, 12);
            this.janelaLogo.Name = "janelaLogo";
            this.janelaLogo.Size = new System.Drawing.Size(39, 45);
            this.janelaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.janelaLogo.TabIndex = 21;
            this.janelaLogo.TabStop = false;
            // 
            // panelCriarSala
            // 
            this.panelCriarSala.Controls.Add(this.label4);
            this.panelCriarSala.Controls.Add(this.numSalaInput);
            this.panelCriarSala.Controls.Add(this.panelFormHide);
            this.panelCriarSala.Controls.Add(this.panelFormButton);
            this.panelCriarSala.Controls.Add(this.panelFormTitulo);
            this.panelCriarSala.Location = new System.Drawing.Point(12, 302);
            this.panelCriarSala.Name = "panelCriarSala";
            this.panelCriarSala.Size = new System.Drawing.Size(166, 176);
            this.panelCriarSala.TabIndex = 27;
            this.panelCriarSala.Visible = false;
            // 
            // panelFormHide
            // 
            this.panelFormHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFormHide.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.panelFormHide.InitialImage = null;
            this.panelFormHide.Location = new System.Drawing.Point(142, 3);
            this.panelFormHide.Name = "panelFormHide";
            this.panelFormHide.Size = new System.Drawing.Size(14, 18);
            this.panelFormHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelFormHide.TabIndex = 24;
            this.panelFormHide.TabStop = false;
            this.panelFormHide.Click += new System.EventHandler(this.panelFormHide_Click);
            // 
            // panelFormButton
            // 
            this.panelFormButton.Location = new System.Drawing.Point(44, 137);
            this.panelFormButton.Name = "panelFormButton";
            this.panelFormButton.Size = new System.Drawing.Size(67, 28);
            this.panelFormButton.TabIndex = 25;
            this.panelFormButton.Text = "Criar";
            this.panelFormButton.UseVisualStyleBackColor = true;
            this.panelFormButton.Click += new System.EventHandler(this.panelFormButton_Click);
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFormTitulo.AutoSize = true;
            this.panelFormTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormTitulo.Location = new System.Drawing.Point(11, 10);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(78, 20);
            this.panelFormTitulo.TabIndex = 24;
            this.panelFormTitulo.Text = "Criar Sala";
            this.panelFormTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdicionarObject
            // 
            this.buttonAdicionarObject.Location = new System.Drawing.Point(197, 286);
            this.buttonAdicionarObject.Name = "buttonAdicionarObject";
            this.buttonAdicionarObject.Size = new System.Drawing.Size(134, 44);
            this.buttonAdicionarObject.TabIndex = 26;
            this.buttonAdicionarObject.Text = "Adicionar sala";
            this.buttonAdicionarObject.UseVisualStyleBackColor = true;
            this.buttonAdicionarObject.Click += new System.EventHandler(this.buttonAdicionarObject_Click);
            // 
            // numSalaInput
            // 
            this.numSalaInput.Location = new System.Drawing.Point(28, 90);
            this.numSalaInput.Name = "numSalaInput";
            this.numSalaInput.Size = new System.Drawing.Size(100, 20);
            this.numSalaInput.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Número:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSala
            // 
            this.panelSala.Controls.Add(this.label1);
            this.panelSala.Controls.Add(this.pictureBox2);
            this.panelSala.Controls.Add(this.panelObjectTitulo);
            this.panelSala.Controls.Add(this.pictureBox1);
            this.panelSala.Location = new System.Drawing.Point(193, 81);
            this.panelSala.Name = "panelSala";
            this.panelSala.Size = new System.Drawing.Size(156, 191);
            this.panelSala.TabIndex = 28;
            this.panelSala.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(124, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelObjectTitulo
            // 
            this.panelObjectTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelObjectTitulo.AutoSize = true;
            this.panelObjectTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelObjectTitulo.Location = new System.Drawing.Point(63, 145);
            this.panelObjectTitulo.Name = "panelObjectTitulo";
            this.panelObjectTitulo.Size = new System.Drawing.Size(42, 20);
            this.panelObjectTitulo.TabIndex = 26;
            this.panelObjectTitulo.Text = "XXX";
            this.panelObjectTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Funcionarios.Properties.Resources.Sala;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(54, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ajudaBtn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(193, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 142);
            this.panel2.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 52);
            this.label7.TabIndex = 24;
            this.label7.Text = "Passe o rato sobre a\r\nimagem acima e saiba\r\nmais sobre como utilizar\r\nesta interf" +
    "ace!";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ajudaBtn
            // 
            this.ajudaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajudaBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.ajudaBtn.Image = global::Funcionarios.Properties.Resources.Ajuda;
            this.ajudaBtn.InitialImage = null;
            this.ajudaBtn.Location = new System.Drawing.Point(56, 9);
            this.ajudaBtn.Name = "ajudaBtn";
            this.ajudaBtn.Size = new System.Drawing.Size(38, 47);
            this.ajudaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBtn.TabIndex = 16;
            this.ajudaBtn.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Dúvidas?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sala número:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlocoSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSala);
            this.Controls.Add(this.panelCriarSala);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.janelaTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlocoSalas";
            this.Text = "Sistema de Gestão Escolar | Bloco | Salas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BlocoSalas_FormClosed);
            this.Load += new System.EventHandler(this.loadSalas);
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            this.panelCriarSala.ResumeLayout(false);
            this.panelCriarSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).EndInit();
            this.panelSala.ResumeLayout(false);
            this.panelSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.ObjectListView listObjects;
        private BrightIdeasSoftware.OLVColumn numSala;
        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.Label janelaTitulo;
        private System.Windows.Forms.Panel panelCriarSala;
        private System.Windows.Forms.PictureBox panelFormHide;
        private System.Windows.Forms.Button panelFormButton;
        private System.Windows.Forms.Label panelFormTitulo;
        private System.Windows.Forms.Button buttonAdicionarObject;
        private System.Windows.Forms.TextBox numSalaInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSala;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label panelObjectTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}