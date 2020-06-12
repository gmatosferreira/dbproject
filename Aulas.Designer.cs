namespace Funcionarios
{
    partial class Aulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aulas));
            this.panelObject = new System.Windows.Forms.Panel();
            this.panelObjectEliminar = new System.Windows.Forms.Button();
            this.panelObjectEditar = new System.Windows.Forms.Button();
            this.panelObjectSubtitulo = new System.Windows.Forms.Label();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.listObjects = new BrightIdeasSoftware.ObjectListView();
            this.sala = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.horario = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.disciplina = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.janelaSubtitulo = new System.Windows.Forms.Label();
            this.janelaTitulo = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelFormFieldHoraFim = new System.Windows.Forms.DateTimePicker();
            this.panelFormFieldHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.panelFormFieldFuncao = new System.Windows.Forms.ComboBox();
            this.panelFormFieldBloco = new System.Windows.Forms.ComboBox();
            this.panelFormButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFormTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormDescricao = new System.Windows.Forms.Label();
            this.buttonAdicionarObject = new System.Windows.Forms.Button();
            this.ajudaBtn = new System.Windows.Forms.PictureBox();
            this.panelFormHide = new System.Windows.Forms.PictureBox();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelObjectHide = new System.Windows.Forms.PictureBox();
            this.diaSemana = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.turma = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.anoLetivo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).BeginInit();
            this.SuspendLayout();
            // 
            // panelObject
            // 
            this.panelObject.Controls.Add(this.pictureBox1);
            this.panelObject.Controls.Add(this.panelObjectHide);
            this.panelObject.Controls.Add(this.panelObjectEliminar);
            this.panelObject.Controls.Add(this.panelObjectEditar);
            this.panelObject.Controls.Add(this.panelObjectSubtitulo);
            this.panelObject.Controls.Add(this.panelObjectTitulo);
            this.panelObject.Location = new System.Drawing.Point(505, 93);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(152, 225);
            this.panelObject.TabIndex = 24;
            this.panelObject.Visible = false;
            // 
            // panelObjectEliminar
            // 
            this.panelObjectEliminar.Location = new System.Drawing.Point(42, 178);
            this.panelObjectEliminar.Name = "panelObjectEliminar";
            this.panelObjectEliminar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectEliminar.TabIndex = 21;
            this.panelObjectEliminar.Text = "Eliminar";
            this.panelObjectEliminar.UseVisualStyleBackColor = true;
            // 
            // panelObjectEditar
            // 
            this.panelObjectEditar.Location = new System.Drawing.Point(42, 149);
            this.panelObjectEditar.Name = "panelObjectEditar";
            this.panelObjectEditar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectEditar.TabIndex = 20;
            this.panelObjectEditar.Text = "Editar";
            this.panelObjectEditar.UseVisualStyleBackColor = true;
            // 
            // panelObjectSubtitulo
            // 
            this.panelObjectSubtitulo.AutoSize = true;
            this.panelObjectSubtitulo.Location = new System.Drawing.Point(56, 110);
            this.panelObjectSubtitulo.Name = "panelObjectSubtitulo";
            this.panelObjectSubtitulo.Size = new System.Drawing.Size(39, 13);
            this.panelObjectSubtitulo.TabIndex = 20;
            this.panelObjectSubtitulo.Text = "horario";
            this.panelObjectSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObjectTitulo
            // 
            this.panelObjectTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelObjectTitulo.AutoSize = true;
            this.panelObjectTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelObjectTitulo.Location = new System.Drawing.Point(23, 81);
            this.panelObjectTitulo.Name = "panelObjectTitulo";
            this.panelObjectTitulo.Size = new System.Drawing.Size(76, 20);
            this.panelObjectTitulo.TabIndex = 20;
            this.panelObjectTitulo.Text = "Disciplina";
            this.panelObjectTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listObjects
            // 
            this.listObjects.AllColumns.Add(this.sala);
            this.listObjects.AllColumns.Add(this.horario);
            this.listObjects.AllColumns.Add(this.disciplina);
            this.listObjects.AllColumns.Add(this.diaSemana);
            this.listObjects.AllColumns.Add(this.turma);
            this.listObjects.AllColumns.Add(this.anoLetivo);
            this.listObjects.CellEditUseWholeCell = false;
            this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sala,
            this.horario,
            this.disciplina,
            this.diaSemana,
            this.turma,
            this.anoLetivo});
            this.listObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjects.HideSelection = false;
            this.listObjects.Location = new System.Drawing.Point(12, 93);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(487, 225);
            this.listObjects.TabIndex = 23;
            this.listObjects.UseCompatibleStateImageBehavior = false;
            this.listObjects.View = System.Windows.Forms.View.Details;
            // 
            // sala
            // 
            this.sala.AspectName = "sala";
            this.sala.Text = "Sala";
            this.sala.Width = 35;
            // 
            // horario
            // 
            this.horario.AspectName = "horario";
            this.horario.Text = "Horário";
            this.horario.Width = 95;
            // 
            // disciplina
            // 
            this.disciplina.AspectName = "disciplina";
            this.disciplina.AspectToStringFormat = "";
            this.disciplina.Text = "Disciplina";
            this.disciplina.Width = 121;
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(70, 56);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(158, 13);
            this.janelaSubtitulo.TabIndex = 22;
            this.janelaSubtitulo.Text = "A mostrar X aulas do Docente Y";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(66, 25);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(131, 20);
            this.janelaTitulo.TabIndex = 20;
            this.janelaTitulo.Text = "Docentes | Aulas";
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.comboBox1);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.panelFormFieldHoraFim);
            this.panelForm.Controls.Add(this.panelFormFieldHoraInicio);
            this.panelForm.Controls.Add(this.panelFormFieldFuncao);
            this.panelForm.Controls.Add(this.panelFormFieldBloco);
            this.panelForm.Controls.Add(this.panelFormHide);
            this.panelForm.Controls.Add(this.panelFormButton);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.panelFormTitulo);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.panelFormDescricao);
            this.panelForm.Location = new System.Drawing.Point(12, 337);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(461, 194);
            this.panelForm.TabIndex = 27;
            this.panelForm.Visible = false;
            // 
            // panelFormFieldHoraFim
            // 
            this.panelFormFieldHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.panelFormFieldHoraFim.Location = new System.Drawing.Point(178, 145);
            this.panelFormFieldHoraFim.Name = "panelFormFieldHoraFim";
            this.panelFormFieldHoraFim.ShowUpDown = true;
            this.panelFormFieldHoraFim.Size = new System.Drawing.Size(113, 20);
            this.panelFormFieldHoraFim.TabIndex = 40;
            // 
            // panelFormFieldHoraInicio
            // 
            this.panelFormFieldHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.panelFormFieldHoraInicio.Location = new System.Drawing.Point(32, 145);
            this.panelFormFieldHoraInicio.Name = "panelFormFieldHoraInicio";
            this.panelFormFieldHoraInicio.ShowUpDown = true;
            this.panelFormFieldHoraInicio.Size = new System.Drawing.Size(114, 20);
            this.panelFormFieldHoraInicio.TabIndex = 39;
            // 
            // panelFormFieldFuncao
            // 
            this.panelFormFieldFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelFormFieldFuncao.FormattingEnabled = true;
            this.panelFormFieldFuncao.Location = new System.Drawing.Point(202, 83);
            this.panelFormFieldFuncao.Name = "panelFormFieldFuncao";
            this.panelFormFieldFuncao.Size = new System.Drawing.Size(58, 21);
            this.panelFormFieldFuncao.TabIndex = 38;
            // 
            // panelFormFieldBloco
            // 
            this.panelFormFieldBloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelFormFieldBloco.FormattingEnabled = true;
            this.panelFormFieldBloco.Location = new System.Drawing.Point(21, 83);
            this.panelFormFieldBloco.Name = "panelFormFieldBloco";
            this.panelFormFieldBloco.Size = new System.Drawing.Size(139, 21);
            this.panelFormFieldBloco.TabIndex = 37;
            // 
            // panelFormButton
            // 
            this.panelFormButton.Location = new System.Drawing.Point(326, 140);
            this.panelFormButton.Name = "panelFormButton";
            this.panelFormButton.Size = new System.Drawing.Size(126, 37);
            this.panelFormButton.TabIndex = 25;
            this.panelFormButton.Text = "Botao";
            this.panelFormButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Hora de fim";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Turma";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hora de início";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFormTitulo.AutoSize = true;
            this.panelFormTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormTitulo.Location = new System.Drawing.Point(15, 15);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelFormTitulo.TabIndex = 24;
            this.panelFormTitulo.Text = "Título";
            this.panelFormTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Disciplina";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormDescricao
            // 
            this.panelFormDescricao.AutoSize = true;
            this.panelFormDescricao.Location = new System.Drawing.Point(18, 43);
            this.panelFormDescricao.Name = "panelFormDescricao";
            this.panelFormDescricao.Size = new System.Drawing.Size(42, 13);
            this.panelFormDescricao.TabIndex = 24;
            this.panelFormDescricao.Text = "XXXXX";
            this.panelFormDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdicionarObject
            // 
            this.buttonAdicionarObject.Location = new System.Drawing.Point(521, 350);
            this.buttonAdicionarObject.Name = "buttonAdicionarObject";
            this.buttonAdicionarObject.Size = new System.Drawing.Size(112, 53);
            this.buttonAdicionarObject.TabIndex = 26;
            this.buttonAdicionarObject.Text = "Adicionar novo";
            this.buttonAdicionarObject.UseVisualStyleBackColor = true;
            // 
            // ajudaBtn
            // 
            this.ajudaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajudaBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.ajudaBtn.Image = global::Funcionarios.Properties.Resources.Ajuda;
            this.ajudaBtn.InitialImage = null;
            this.ajudaBtn.Location = new System.Drawing.Point(563, 457);
            this.ajudaBtn.Name = "ajudaBtn";
            this.ajudaBtn.Size = new System.Drawing.Size(38, 47);
            this.ajudaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBtn.TabIndex = 25;
            this.ajudaBtn.TabStop = false;
            // 
            // panelFormHide
            // 
            this.panelFormHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFormHide.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.panelFormHide.InitialImage = null;
            this.panelFormHide.Location = new System.Drawing.Point(438, 3);
            this.panelFormHide.Name = "panelFormHide";
            this.panelFormHide.Size = new System.Drawing.Size(14, 18);
            this.panelFormHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelFormHide.TabIndex = 24;
            this.panelFormHide.TabStop = false;
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.Docentes;
            this.janelaLogo.InitialImage = null;
            this.janelaLogo.Location = new System.Drawing.Point(12, 24);
            this.janelaLogo.Name = "janelaLogo";
            this.janelaLogo.Size = new System.Drawing.Size(39, 45);
            this.janelaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.janelaLogo.TabIndex = 24;
            this.janelaLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Funcionarios.Properties.Resources.Aula;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(56, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            // 
            // diaSemana
            // 
            this.diaSemana.AspectName = "diaSemanaStr";
            this.diaSemana.Text = "Dia da Semana";
            this.diaSemana.Width = 97;
            // 
            // turma
            // 
            this.turma.AspectName = "turma";
            this.turma.Text = "Turma";
            this.turma.Width = 45;
            // 
            // anoLetivo
            // 
            this.anoLetivo.AspectName = "anoStr";
            this.anoLetivo.Text = "Ano Letivo";
            this.anoLetivo.Width = 83;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(302, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Dia da Semana";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Aulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 543);
            this.Controls.Add(this.ajudaBtn);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aulas";
            this.Text = "Sistema de Gestão Escolar | Docentes | Aulas";
            this.panelObject.ResumeLayout(false);
            this.panelObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.PictureBox panelObjectHide;
        private System.Windows.Forms.Button panelObjectEliminar;
        private System.Windows.Forms.Button panelObjectEditar;
        private System.Windows.Forms.Label panelObjectSubtitulo;
        private System.Windows.Forms.Label panelObjectTitulo;
        private BrightIdeasSoftware.ObjectListView listObjects;
        private BrightIdeasSoftware.OLVColumn sala;
        private BrightIdeasSoftware.OLVColumn horario;
        private BrightIdeasSoftware.OLVColumn disciplina;
        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.Label janelaTitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.DateTimePicker panelFormFieldHoraFim;
        private System.Windows.Forms.DateTimePicker panelFormFieldHoraInicio;
        private System.Windows.Forms.ComboBox panelFormFieldFuncao;
        private System.Windows.Forms.ComboBox panelFormFieldBloco;
        private System.Windows.Forms.PictureBox panelFormHide;
        private System.Windows.Forms.Button panelFormButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label panelFormTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label panelFormDescricao;
        private System.Windows.Forms.Button buttonAdicionarObject;
        private BrightIdeasSoftware.OLVColumn diaSemana;
        private BrightIdeasSoftware.OLVColumn turma;
        private BrightIdeasSoftware.OLVColumn anoLetivo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}