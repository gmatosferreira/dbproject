namespace Funcionarios
{
    partial class EstudantesTurma
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
            this.buttonAdicionarObject = new System.Windows.Forms.Button();
            this.listObjects = new BrightIdeasSoftware.ObjectListView();
            this.NMec = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NomeEstudante = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.janelaSubtitulo = new System.Windows.Forms.Label();
            this.janelaTitulo = new System.Windows.Forms.Label();
            this.panelObject = new System.Windows.Forms.Panel();
            this.panelObjectHide = new System.Windows.Forms.PictureBox();
            this.panelObjectEliminar = new System.Windows.Forms.Button();
            this.panelObjectSubtitulo = new System.Windows.Forms.Label();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelFormTitulo = new System.Windows.Forms.Label();
            this.panelFormButton = new System.Windows.Forms.Button();
            this.panelFormAddAluno = new System.Windows.Forms.Panel();
            this.hidde1 = new System.Windows.Forms.PictureBox();
            this.comboEstudantesSemTurma = new System.Windows.Forms.ComboBox();
            this.panelRecado = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.docenteCombo = new System.Windows.Forms.ComboBox();
            this.hide2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.assuntoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MensagemText = new System.Windows.Forms.RichTextBox();
            this.destinarioCombo = new System.Windows.Forms.ComboBox();
            this.enviarRecado = new System.Windows.Forms.Button();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.ajudaBtn = new System.Windows.Forms.PictureBox();
            this.pesquisaAtributo = new System.Windows.Forms.ComboBox();
            this.pesquisaLabel = new System.Windows.Forms.Label();
            this.pesquisaTexto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).BeginInit();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).BeginInit();
            this.panelFormAddAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidde1)).BeginInit();
            this.panelRecado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdicionarObject
            // 
            this.buttonAdicionarObject.Location = new System.Drawing.Point(683, 312);
            this.buttonAdicionarObject.Name = "buttonAdicionarObject";
            this.buttonAdicionarObject.Size = new System.Drawing.Size(102, 47);
            this.buttonAdicionarObject.TabIndex = 24;
            this.buttonAdicionarObject.Text = "Adicionar Aluno";
            this.buttonAdicionarObject.UseVisualStyleBackColor = true;
            this.buttonAdicionarObject.Click += new System.EventHandler(this.buttonAdicionarObject_Click);
            // 
            // listObjects
            // 
            this.listObjects.AllColumns.Add(this.NMec);
            this.listObjects.AllColumns.Add(this.NomeEstudante);
            this.listObjects.CellEditUseWholeCell = false;
            this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NMec,
            this.NomeEstudante});
            this.listObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjects.HideSelection = false;
            this.listObjects.Location = new System.Drawing.Point(12, 81);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(531, 234);
            this.listObjects.TabIndex = 25;
            this.listObjects.UseCompatibleStateImageBehavior = false;
            this.listObjects.View = System.Windows.Forms.View.Details;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.listObjects_SelectedIndexChanged);
            // 
            // NMec
            // 
            this.NMec.AspectName = "NMec";
            this.NMec.Text = "NMec";
            this.NMec.Width = 121;
            // 
            // NomeEstudante
            // 
            this.NomeEstudante.AspectName = "NomeEstudante";
            this.NomeEstudante.Text = "Nome";
            this.NomeEstudante.Width = 375;
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(81, 53);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(142, 13);
            this.janelaSubtitulo.TabIndex = 28;
            this.janelaSubtitulo.Text = "Esta turma tem X estudantes";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(77, 22);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(162, 20);
            this.janelaTitulo.TabIndex = 26;
            this.janelaTitulo.Text = "Estudantes da Turma";
            // 
            // panelObject
            // 
            this.panelObject.Controls.Add(this.panelObjectHide);
            this.panelObject.Controls.Add(this.panelObjectEliminar);
            this.panelObject.Controls.Add(this.panelObjectSubtitulo);
            this.panelObject.Controls.Add(this.panelObjectTitulo);
            this.panelObject.Location = new System.Drawing.Point(578, 81);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(199, 213);
            this.panelObject.TabIndex = 29;
            this.panelObject.Visible = false;
            // 
            // panelObjectHide
            // 
            this.panelObjectHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelObjectHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelObjectHide.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.panelObjectHide.InitialImage = null;
            this.panelObjectHide.Location = new System.Drawing.Point(161, 13);
            this.panelObjectHide.Name = "panelObjectHide";
            this.panelObjectHide.Size = new System.Drawing.Size(24, 23);
            this.panelObjectHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelObjectHide.TabIndex = 23;
            this.panelObjectHide.TabStop = false;
            this.panelObjectHide.Click += new System.EventHandler(this.panelObjectHide_Click);
            // 
            // panelObjectEliminar
            // 
            this.panelObjectEliminar.Location = new System.Drawing.Point(64, 152);
            this.panelObjectEliminar.Name = "panelObjectEliminar";
            this.panelObjectEliminar.Size = new System.Drawing.Size(75, 28);
            this.panelObjectEliminar.TabIndex = 21;
            this.panelObjectEliminar.Text = "Eliminar";
            this.panelObjectEliminar.UseVisualStyleBackColor = true;
            this.panelObjectEliminar.Click += new System.EventHandler(this.panelObjectEliminar_Click);
            // 
            // panelObjectSubtitulo
            // 
            this.panelObjectSubtitulo.AutoSize = true;
            this.panelObjectSubtitulo.Location = new System.Drawing.Point(77, 93);
            this.panelObjectSubtitulo.Name = "panelObjectSubtitulo";
            this.panelObjectSubtitulo.Size = new System.Drawing.Size(42, 13);
            this.panelObjectSubtitulo.TabIndex = 20;
            this.panelObjectSubtitulo.Text = "XXXXX";
            this.panelObjectSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObjectTitulo
            // 
            this.panelObjectTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelObjectTitulo.AutoSize = true;
            this.panelObjectTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelObjectTitulo.Location = new System.Drawing.Point(68, 58);
            this.panelObjectTitulo.Name = "panelObjectTitulo";
            this.panelObjectTitulo.Size = new System.Drawing.Size(51, 20);
            this.panelObjectTitulo.TabIndex = 20;
            this.panelObjectTitulo.Text = "Nome";
            this.panelObjectTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 47);
            this.button2.TabIndex = 31;
            this.button2.Text = "Escrever Recado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFormTitulo.AutoSize = true;
            this.panelFormTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormTitulo.Location = new System.Drawing.Point(54, 21);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(90, 20);
            this.panelFormTitulo.TabIndex = 24;
            this.panelFormTitulo.Text = "Novo Aluno";
            this.panelFormTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormButton
            // 
            this.panelFormButton.Location = new System.Drawing.Point(58, 163);
            this.panelFormButton.Name = "panelFormButton";
            this.panelFormButton.Size = new System.Drawing.Size(95, 25);
            this.panelFormButton.TabIndex = 25;
            this.panelFormButton.Text = "Botao";
            this.panelFormButton.UseVisualStyleBackColor = true;
            this.panelFormButton.Click += new System.EventHandler(this.panelFormButton_Click);
            // 
            // panelFormAddAluno
            // 
            this.panelFormAddAluno.Controls.Add(this.hidde1);
            this.panelFormAddAluno.Controls.Add(this.comboEstudantesSemTurma);
            this.panelFormAddAluno.Controls.Add(this.panelFormButton);
            this.panelFormAddAluno.Controls.Add(this.panelFormTitulo);
            this.panelFormAddAluno.Location = new System.Drawing.Point(578, 365);
            this.panelFormAddAluno.Name = "panelFormAddAluno";
            this.panelFormAddAluno.Size = new System.Drawing.Size(207, 223);
            this.panelFormAddAluno.TabIndex = 30;
            this.panelFormAddAluno.Visible = false;
            // 
            // hidde1
            // 
            this.hidde1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hidde1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hidde1.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.hidde1.InitialImage = null;
            this.hidde1.Location = new System.Drawing.Point(182, 5);
            this.hidde1.Name = "hidde1";
            this.hidde1.Size = new System.Drawing.Size(17, 22);
            this.hidde1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidde1.TabIndex = 42;
            this.hidde1.TabStop = false;
            this.hidde1.Click += new System.EventHandler(this.hidde1_Click);
            // 
            // comboEstudantesSemTurma
            // 
            this.comboEstudantesSemTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstudantesSemTurma.FormattingEnabled = true;
            this.comboEstudantesSemTurma.Location = new System.Drawing.Point(17, 67);
            this.comboEstudantesSemTurma.Name = "comboEstudantesSemTurma";
            this.comboEstudantesSemTurma.Size = new System.Drawing.Size(177, 21);
            this.comboEstudantesSemTurma.Sorted = true;
            this.comboEstudantesSemTurma.TabIndex = 41;
            // 
            // panelRecado
            // 
            this.panelRecado.Controls.Add(this.label4);
            this.panelRecado.Controls.Add(this.docenteCombo);
            this.panelRecado.Controls.Add(this.hide2);
            this.panelRecado.Controls.Add(this.label2);
            this.panelRecado.Controls.Add(this.assuntoText);
            this.panelRecado.Controls.Add(this.label3);
            this.panelRecado.Controls.Add(this.label1);
            this.panelRecado.Controls.Add(this.MensagemText);
            this.panelRecado.Controls.Add(this.destinarioCombo);
            this.panelRecado.Controls.Add(this.enviarRecado);
            this.panelRecado.Location = new System.Drawing.Point(12, 321);
            this.panelRecado.Name = "panelRecado";
            this.panelRecado.Size = new System.Drawing.Size(534, 267);
            this.panelRecado.TabIndex = 32;
            this.panelRecado.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Docente:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // docenteCombo
            // 
            this.docenteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docenteCombo.FormattingEnabled = true;
            this.docenteCombo.Location = new System.Drawing.Point(77, 32);
            this.docenteCombo.Name = "docenteCombo";
            this.docenteCombo.Size = new System.Drawing.Size(204, 21);
            this.docenteCombo.Sorted = true;
            this.docenteCombo.TabIndex = 49;
            // 
            // hide2
            // 
            this.hide2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hide2.Cursor = System.Windows.Forms.Cursors.Default;
            this.hide2.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.hide2.InitialImage = null;
            this.hide2.Location = new System.Drawing.Point(503, 3);
            this.hide2.Name = "hide2";
            this.hide2.Size = new System.Drawing.Size(17, 22);
            this.hide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide2.TabIndex = 48;
            this.hide2.TabStop = false;
            this.hide2.Click += new System.EventHandler(this.hide2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Assunto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assuntoText
            // 
            this.assuntoText.Location = new System.Drawing.Point(77, 5);
            this.assuntoText.Name = "assuntoText";
            this.assuntoText.Size = new System.Drawing.Size(385, 20);
            this.assuntoText.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Mensagem: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Para:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MensagemText
            // 
            this.MensagemText.Location = new System.Drawing.Point(11, 80);
            this.MensagemText.Name = "MensagemText";
            this.MensagemText.Size = new System.Drawing.Size(520, 161);
            this.MensagemText.TabIndex = 43;
            this.MensagemText.Text = "";
            // 
            // destinarioCombo
            // 
            this.destinarioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinarioCombo.FormattingEnabled = true;
            this.destinarioCombo.Location = new System.Drawing.Point(346, 31);
            this.destinarioCombo.Name = "destinarioCombo";
            this.destinarioCombo.Size = new System.Drawing.Size(185, 21);
            this.destinarioCombo.Sorted = true;
            this.destinarioCombo.TabIndex = 42;
            // 
            // enviarRecado
            // 
            this.enviarRecado.Location = new System.Drawing.Point(456, 244);
            this.enviarRecado.Name = "enviarRecado";
            this.enviarRecado.Size = new System.Drawing.Size(75, 23);
            this.enviarRecado.TabIndex = 21;
            this.enviarRecado.Text = "Enviar";
            this.enviarRecado.UseVisualStyleBackColor = true;
            this.enviarRecado.Click += new System.EventHandler(this.enviarRecado_Click);
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.Estudantes2;
            this.janelaLogo.InitialImage = null;
            this.janelaLogo.Location = new System.Drawing.Point(23, 22);
            this.janelaLogo.Name = "janelaLogo";
            this.janelaLogo.Size = new System.Drawing.Size(39, 45);
            this.janelaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.janelaLogo.TabIndex = 27;
            this.janelaLogo.TabStop = false;
            // 
            // ajudaBtn
            // 
            this.ajudaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajudaBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.ajudaBtn.Image = global::Funcionarios.Properties.Resources.Ajuda;
            this.ajudaBtn.InitialImage = null;
            this.ajudaBtn.Location = new System.Drawing.Point(739, 19);
            this.ajudaBtn.Name = "ajudaBtn";
            this.ajudaBtn.Size = new System.Drawing.Size(38, 47);
            this.ajudaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBtn.TabIndex = 23;
            this.ajudaBtn.TabStop = false;
            // 
            // pesquisaAtributo
            // 
            this.pesquisaAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pesquisaAtributo.FormattingEnabled = true;
            this.pesquisaAtributo.Items.AddRange(new object[] {
            "Número mecanográfico",
            "Nome"});
            this.pesquisaAtributo.Location = new System.Drawing.Point(394, 28);
            this.pesquisaAtributo.Name = "pesquisaAtributo";
            this.pesquisaAtributo.Size = new System.Drawing.Size(149, 21);
            this.pesquisaAtributo.TabIndex = 35;
            // 
            // pesquisaLabel
            // 
            this.pesquisaLabel.AutoSize = true;
            this.pesquisaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaLabel.Location = new System.Drawing.Point(493, 8);
            this.pesquisaLabel.Name = "pesquisaLabel";
            this.pesquisaLabel.Size = new System.Drawing.Size(50, 13);
            this.pesquisaLabel.TabIndex = 34;
            this.pesquisaLabel.Text = "Pesquisa";
            this.pesquisaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pesquisaTexto
            // 
            this.pesquisaTexto.Location = new System.Drawing.Point(378, 55);
            this.pesquisaTexto.Name = "pesquisaTexto";
            this.pesquisaTexto.Size = new System.Drawing.Size(165, 20);
            this.pesquisaTexto.TabIndex = 33;
            // 
            // EstudantesTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.pesquisaAtributo);
            this.Controls.Add(this.pesquisaLabel);
            this.Controls.Add(this.pesquisaTexto);
            this.Controls.Add(this.panelRecado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelFormAddAluno);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.janelaTitulo);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.ajudaBtn);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Name = "EstudantesTurma";
            this.Text = "Sistema de Gestão Escolar | Lista de Estudantes da Turma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EstudantesTurma_FormClosed);
            this.Load += new System.EventHandler(this.EstudantesTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).EndInit();
            this.panelObject.ResumeLayout(false);
            this.panelObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).EndInit();
            this.panelFormAddAluno.ResumeLayout(false);
            this.panelFormAddAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidde1)).EndInit();
            this.panelRecado.ResumeLayout(false);
            this.panelRecado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.Button buttonAdicionarObject;
        private BrightIdeasSoftware.ObjectListView listObjects;
        private BrightIdeasSoftware.OLVColumn NMec;
        private BrightIdeasSoftware.OLVColumn NomeEstudante;
        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.Label janelaTitulo;
        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.PictureBox panelObjectHide;
        private System.Windows.Forms.Button panelObjectEliminar;
        private System.Windows.Forms.Label panelObjectSubtitulo;
        private System.Windows.Forms.Label panelObjectTitulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label panelFormTitulo;
        private System.Windows.Forms.Button panelFormButton;
        private System.Windows.Forms.Panel panelFormAddAluno;
        private System.Windows.Forms.Panel panelRecado;
        private System.Windows.Forms.Button enviarRecado;
        private System.Windows.Forms.ComboBox comboEstudantesSemTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assuntoText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox MensagemText;
        private System.Windows.Forms.ComboBox destinarioCombo;
        private System.Windows.Forms.PictureBox hidde1;
        private System.Windows.Forms.PictureBox hide2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox docenteCombo;
        private System.Windows.Forms.ComboBox pesquisaAtributo;
        private System.Windows.Forms.Label pesquisaLabel;
        private System.Windows.Forms.TextBox pesquisaTexto;
    }
}