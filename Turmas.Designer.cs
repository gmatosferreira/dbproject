namespace Funcionarios
{
    partial class Turmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turmas));
            this.janelaSubtitulo = new System.Windows.Forms.Label();
            this.janelaTitulo = new System.Windows.Forms.Label();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.pesquisaAtributo = new System.Windows.Forms.ComboBox();
            this.pesquisaLabel = new System.Windows.Forms.Label();
            this.pesquisaTexto = new System.Windows.Forms.TextBox();
            this.panelObject = new System.Windows.Forms.Panel();
            this.estudantes = new System.Windows.Forms.Button();
            this.panelObjectSubTitulo = new System.Windows.Forms.Label();
            this.panelObjectHide = new System.Windows.Forms.PictureBox();
            this.panelObjectEditar = new System.Windows.Forms.Button();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.panelObjectImage = new System.Windows.Forms.PictureBox();
            this.listObjects = new BrightIdeasSoftware.ObjectListView();
            this.nivel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nome = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nomeDT = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.anoLetivo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonAdicionarObject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ajudaBtn = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelFormDescricao = new System.Windows.Forms.Label();
            this.panelFormFieldNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelFormTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFormButton = new System.Windows.Forms.Button();
            this.panelFormHide = new System.Windows.Forms.PictureBox();
            this.panelFormFieldNivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFormFieldAno = new System.Windows.Forms.TextBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(70, 43);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(100, 13);
            this.janelaSubtitulo.TabIndex = 33;
            this.janelaSubtitulo.Text = "A mostrar X registos";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(66, 12);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(62, 20);
            this.janelaTitulo.TabIndex = 31;
            this.janelaTitulo.Text = "Turmas";
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.Turmas;
            this.janelaLogo.InitialImage = null;
            this.janelaLogo.Location = new System.Drawing.Point(12, 12);
            this.janelaLogo.Name = "janelaLogo";
            this.janelaLogo.Size = new System.Drawing.Size(39, 45);
            this.janelaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.janelaLogo.TabIndex = 32;
            this.janelaLogo.TabStop = false;
            // 
            // pesquisaAtributo
            // 
            this.pesquisaAtributo.FormattingEnabled = true;
            this.pesquisaAtributo.Items.AddRange(new object[] {
            "Nome de Turma",
            "Nome Diretor de Turma",
            "Nivel",
            "Ano Letivo"});
            this.pesquisaAtributo.Location = new System.Drawing.Point(460, 42);
            this.pesquisaAtributo.Name = "pesquisaAtributo";
            this.pesquisaAtributo.Size = new System.Drawing.Size(149, 21);
            this.pesquisaAtributo.TabIndex = 39;
            this.pesquisaAtributo.SelectedIndexChanged += new System.EventHandler(this.pesquisar);
            // 
            // pesquisaLabel
            // 
            this.pesquisaLabel.AutoSize = true;
            this.pesquisaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaLabel.Location = new System.Drawing.Point(559, 19);
            this.pesquisaLabel.Name = "pesquisaLabel";
            this.pesquisaLabel.Size = new System.Drawing.Size(50, 13);
            this.pesquisaLabel.TabIndex = 38;
            this.pesquisaLabel.Text = "Pesquisa";
            this.pesquisaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pesquisaTexto
            // 
            this.pesquisaTexto.Location = new System.Drawing.Point(444, 73);
            this.pesquisaTexto.Name = "pesquisaTexto";
            this.pesquisaTexto.Size = new System.Drawing.Size(165, 20);
            this.pesquisaTexto.TabIndex = 37;
            this.pesquisaTexto.TextChanged += new System.EventHandler(this.pesquisar);
            // 
            // panelObject
            // 
            this.panelObject.Controls.Add(this.estudantes);
            this.panelObject.Controls.Add(this.panelObjectSubTitulo);
            this.panelObject.Controls.Add(this.panelObjectHide);
            this.panelObject.Controls.Add(this.panelObjectEditar);
            this.panelObject.Controls.Add(this.panelObjectTitulo);
            this.panelObject.Controls.Add(this.panelObjectImage);
            this.panelObject.Location = new System.Drawing.Point(636, 19);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(152, 336);
            this.panelObject.TabIndex = 40;
            this.panelObject.Visible = false;
            // 
            // estudantes
            // 
            this.estudantes.Location = new System.Drawing.Point(29, 260);
            this.estudantes.Name = "estudantes";
            this.estudantes.Size = new System.Drawing.Size(96, 23);
            this.estudantes.TabIndex = 26;
            this.estudantes.Text = "Ver Estudantes";
            this.estudantes.UseVisualStyleBackColor = true;
            this.estudantes.Click += new System.EventHandler(this.estudantes_Click);
            // 
            // panelObjectSubTitulo
            // 
            this.panelObjectSubTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelObjectSubTitulo.AutoSize = true;
            this.panelObjectSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelObjectSubTitulo.Location = new System.Drawing.Point(25, 162);
            this.panelObjectSubTitulo.Name = "panelObjectSubTitulo";
            this.panelObjectSubTitulo.Size = new System.Drawing.Size(57, 20);
            this.panelObjectSubTitulo.TabIndex = 24;
            this.panelObjectSubTitulo.Text = "Diretor";
            this.panelObjectSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObjectHide
            // 
            this.panelObjectHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelObjectHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelObjectHide.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.panelObjectHide.InitialImage = null;
            this.panelObjectHide.Location = new System.Drawing.Point(131, 16);
            this.panelObjectHide.Name = "panelObjectHide";
            this.panelObjectHide.Size = new System.Drawing.Size(14, 18);
            this.panelObjectHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelObjectHide.TabIndex = 23;
            this.panelObjectHide.TabStop = false;
            this.panelObjectHide.Click += new System.EventHandler(this.panelObjectHide_Click);
            // 
            // panelObjectEditar
            // 
            this.panelObjectEditar.Location = new System.Drawing.Point(29, 231);
            this.panelObjectEditar.Name = "panelObjectEditar";
            this.panelObjectEditar.Size = new System.Drawing.Size(96, 23);
            this.panelObjectEditar.TabIndex = 20;
            this.panelObjectEditar.Text = "Alterar DT";
            this.panelObjectEditar.UseVisualStyleBackColor = true;
            this.panelObjectEditar.Click += new System.EventHandler(this.editDT);
            // 
            // panelObjectTitulo
            // 
            this.panelObjectTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelObjectTitulo.AutoSize = true;
            this.panelObjectTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelObjectTitulo.Location = new System.Drawing.Point(51, 142);
            this.panelObjectTitulo.Name = "panelObjectTitulo";
            this.panelObjectTitulo.Size = new System.Drawing.Size(51, 20);
            this.panelObjectTitulo.TabIndex = 20;
            this.panelObjectTitulo.Text = "Nome";
            this.panelObjectTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObjectImage
            // 
            this.panelObjectImage.BackColor = System.Drawing.SystemColors.Control;
            this.panelObjectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelObjectImage.Image = global::Funcionarios.Properties.Resources.Turmas;
            this.panelObjectImage.InitialImage = null;
            this.panelObjectImage.Location = new System.Drawing.Point(29, 43);
            this.panelObjectImage.Name = "panelObjectImage";
            this.panelObjectImage.Size = new System.Drawing.Size(91, 84);
            this.panelObjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelObjectImage.TabIndex = 18;
            this.panelObjectImage.TabStop = false;
            // 
            // listObjects
            // 
            this.listObjects.AllColumns.Add(this.nivel);
            this.listObjects.AllColumns.Add(this.nome);
            this.listObjects.AllColumns.Add(this.nomeDT);
            this.listObjects.AllColumns.Add(this.anoLetivo);
            this.listObjects.CellEditUseWholeCell = false;
            this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nivel,
            this.nome,
            this.nomeDT,
            this.anoLetivo});
            this.listObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjects.HideSelection = false;
            this.listObjects.Location = new System.Drawing.Point(12, 113);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(580, 336);
            this.listObjects.TabIndex = 41;
            this.listObjects.UseCompatibleStateImageBehavior = false;
            this.listObjects.View = System.Windows.Forms.View.Details;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.listObjects_SelectedIndexChanged);
            // 
            // nivel
            // 
            this.nivel.AspectName = "nivel";
            this.nivel.Text = "Nivel";
            this.nivel.Width = 77;
            // 
            // nome
            // 
            this.nome.AspectName = "nome";
            this.nome.Text = "Nome";
            this.nome.Width = 93;
            // 
            // nomeDT
            // 
            this.nomeDT.AspectName = "nomeDT";
            this.nomeDT.Text = "Nome DT";
            this.nomeDT.Width = 300;
            // 
            // anoLetivo
            // 
            this.anoLetivo.AspectName = "anoLetivo";
            this.anoLetivo.Text = "Ano Letivo";
            this.anoLetivo.Width = 100;
            // 
            // buttonAdicionarObject
            // 
            this.buttonAdicionarObject.Location = new System.Drawing.Point(660, 383);
            this.buttonAdicionarObject.Name = "buttonAdicionarObject";
            this.buttonAdicionarObject.Size = new System.Drawing.Size(112, 53);
            this.buttonAdicionarObject.TabIndex = 42;
            this.buttonAdicionarObject.Text = "Adicionar novo";
            this.buttonAdicionarObject.UseVisualStyleBackColor = true;
            this.buttonAdicionarObject.Click += new System.EventHandler(this.addObject);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ajudaBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(636, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 189);
            this.panel1.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 105);
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
            this.ajudaBtn.Location = new System.Drawing.Point(56, 23);
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
            this.label9.Location = new System.Drawing.Point(40, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Dúvidas?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFormDescricao
            // 
            this.panelFormDescricao.AutoSize = true;
            this.panelFormDescricao.Location = new System.Drawing.Point(22, 34);
            this.panelFormDescricao.Name = "panelFormDescricao";
            this.panelFormDescricao.Size = new System.Drawing.Size(42, 13);
            this.panelFormDescricao.TabIndex = 24;
            this.panelFormDescricao.Text = "XXXXX";
            this.panelFormDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldNome
            // 
            this.panelFormFieldNome.Enabled = false;
            this.panelFormFieldNome.Location = new System.Drawing.Point(61, 73);
            this.panelFormFieldNome.Name = "panelFormFieldNome";
            this.panelFormFieldNome.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldNome.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nome";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFormTitulo.AutoSize = true;
            this.panelFormTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormTitulo.Location = new System.Drawing.Point(21, 12);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelFormTitulo.TabIndex = 24;
            this.panelFormTitulo.Text = "Título";
            this.panelFormTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Diretor de Turma";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormButton
            // 
            this.panelFormButton.Location = new System.Drawing.Point(429, 122);
            this.panelFormButton.Name = "panelFormButton";
            this.panelFormButton.Size = new System.Drawing.Size(139, 23);
            this.panelFormButton.TabIndex = 25;
            this.panelFormButton.Text = "Botao";
            this.panelFormButton.UseVisualStyleBackColor = true;
            this.panelFormButton.Click += new System.EventHandler(this.panelFormButton_Click);
            // 
            // panelFormHide
            // 
            this.panelFormHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFormHide.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.panelFormHide.InitialImage = null;
            this.panelFormHide.Location = new System.Drawing.Point(554, 14);
            this.panelFormHide.Name = "panelFormHide";
            this.panelFormHide.Size = new System.Drawing.Size(14, 18);
            this.panelFormHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelFormHide.TabIndex = 24;
            this.panelFormHide.TabStop = false;
            this.panelFormHide.Click += new System.EventHandler(this.panelFormHide_Click);
            // 
            // panelFormFieldNivel
            // 
            this.panelFormFieldNivel.Enabled = false;
            this.panelFormFieldNivel.Location = new System.Drawing.Point(61, 122);
            this.panelFormFieldNivel.Name = "panelFormFieldNivel";
            this.panelFormFieldNivel.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldNivel.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nivel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ano Letivo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldAno
            // 
            this.panelFormFieldAno.Location = new System.Drawing.Point(265, 123);
            this.panelFormFieldAno.Name = "panelFormFieldAno";
            this.panelFormFieldAno.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldAno.TabIndex = 37;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.comboBox1);
            this.panelForm.Controls.Add(this.panelFormFieldAno);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.panelFormFieldNivel);
            this.panelForm.Controls.Add(this.panelFormHide);
            this.panelForm.Controls.Add(this.panelFormButton);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.panelFormTitulo);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.panelFormFieldNome);
            this.panelForm.Controls.Add(this.panelFormDescricao);
            this.panelForm.Location = new System.Drawing.Point(12, 472);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(580, 189);
            this.panelForm.TabIndex = 43;
            this.panelForm.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 40;
            // 
            // Turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.pesquisaAtributo);
            this.Controls.Add(this.pesquisaLabel);
            this.Controls.Add(this.pesquisaTexto);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.janelaTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Turmas";
            this.Text = "Sistema de Gestão Escolar | Turmas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Turmas_FormClosed);
            this.Load += new System.EventHandler(this.Turmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            this.panelObject.ResumeLayout(false);
            this.panelObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.Label janelaTitulo;
        private System.Windows.Forms.ComboBox pesquisaAtributo;
        private System.Windows.Forms.Label pesquisaLabel;
        private System.Windows.Forms.TextBox pesquisaTexto;
        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.Label panelObjectSubTitulo;
        private System.Windows.Forms.PictureBox panelObjectHide;
        private System.Windows.Forms.Button panelObjectEditar;
        private System.Windows.Forms.Label panelObjectTitulo;
        private System.Windows.Forms.PictureBox panelObjectImage;
        private BrightIdeasSoftware.ObjectListView listObjects;
        private BrightIdeasSoftware.OLVColumn nivel;
        private BrightIdeasSoftware.OLVColumn nome;
        private BrightIdeasSoftware.OLVColumn nomeDT;
        public BrightIdeasSoftware.OLVColumn anoLetivo;
        private System.Windows.Forms.Button buttonAdicionarObject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button estudantes;
        private System.Windows.Forms.Label panelFormDescricao;
        private System.Windows.Forms.TextBox panelFormFieldNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label panelFormTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button panelFormButton;
        private System.Windows.Forms.PictureBox panelFormHide;
        private System.Windows.Forms.TextBox panelFormFieldNivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox panelFormFieldAno;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}