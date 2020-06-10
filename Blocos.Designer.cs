namespace Funcionarios
{
    partial class Blocos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blocos));
            this.janelaSubtitulo = new System.Windows.Forms.Label();
            this.janelaTitulo = new System.Windows.Forms.Label();
            this.Ajuda = new System.Windows.Forms.ToolTip(this.components);
            this.panelObjectEditar = new System.Windows.Forms.Button();
            this.panelObjectEliminar = new System.Windows.Forms.Button();
            this.buttonAdicionarObject = new System.Windows.Forms.Button();
            this.panelObjectHide = new System.Windows.Forms.PictureBox();
            this.panelFormButton = new System.Windows.Forms.Button();
            this.panelFormHide = new System.Windows.Forms.PictureBox();
            this.ajudaBtn = new System.Windows.Forms.PictureBox();
            this.listObjects = new BrightIdeasSoftware.ObjectListView();
            this.coordenadas = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nome = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.supervisor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tipo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelObject = new System.Windows.Forms.Panel();
            this.panelObjectSubtitulo = new System.Windows.Forms.Label();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelFormFieldCoordenadas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFormFieldNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFormFieldSupervisor = new System.Windows.Forms.ComboBox();
            this.panelFormFieldTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormTitulo = new System.Windows.Forms.Label();
            this.panelFormDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).BeginInit();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(80, 54);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(96, 13);
            this.janelaSubtitulo.TabIndex = 15;
            this.janelaSubtitulo.Text = "A mostrar X turnos ";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(76, 23);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(57, 20);
            this.janelaTitulo.TabIndex = 13;
            this.janelaTitulo.Text = "Blocos";
            // 
            // panelObjectEditar
            // 
            this.panelObjectEditar.Location = new System.Drawing.Point(40, 105);
            this.panelObjectEditar.Name = "panelObjectEditar";
            this.panelObjectEditar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectEditar.TabIndex = 20;
            this.panelObjectEditar.Text = "Editar";
            this.Ajuda.SetToolTip(this.panelObjectEditar, "0");
            this.panelObjectEditar.UseVisualStyleBackColor = true;
            this.panelObjectEditar.Click += new System.EventHandler(this.panelObjectEditar_Click);
            // 
            // panelObjectEliminar
            // 
            this.panelObjectEliminar.Location = new System.Drawing.Point(40, 145);
            this.panelObjectEliminar.Name = "panelObjectEliminar";
            this.panelObjectEliminar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectEliminar.TabIndex = 21;
            this.panelObjectEliminar.Text = "Eliminar";
            this.Ajuda.SetToolTip(this.panelObjectEliminar, "0");
            this.panelObjectEliminar.UseVisualStyleBackColor = true;
            this.panelObjectEliminar.Click += new System.EventHandler(this.panelObjectEliminar_Click);
            // 
            // buttonAdicionarObject
            // 
            this.buttonAdicionarObject.Location = new System.Drawing.Point(505, 23);
            this.buttonAdicionarObject.Name = "buttonAdicionarObject";
            this.buttonAdicionarObject.Size = new System.Drawing.Size(112, 47);
            this.buttonAdicionarObject.TabIndex = 22;
            this.buttonAdicionarObject.Text = "Adicionar novo";
            this.Ajuda.SetToolTip(this.buttonAdicionarObject, "0");
            this.buttonAdicionarObject.UseVisualStyleBackColor = true;
            this.buttonAdicionarObject.Click += new System.EventHandler(this.buttonAdicionarObject_Click);
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
            this.Ajuda.SetToolTip(this.panelObjectHide, "Esconder");
            this.panelObjectHide.Click += new System.EventHandler(this.panelObjectEsconder_Click);
            // 
            // panelFormButton
            // 
            this.panelFormButton.Location = new System.Drawing.Point(357, 128);
            this.panelFormButton.Name = "panelFormButton";
            this.panelFormButton.Size = new System.Drawing.Size(95, 25);
            this.panelFormButton.TabIndex = 25;
            this.panelFormButton.Text = "Botao";
            this.Ajuda.SetToolTip(this.panelFormButton, "0");
            this.panelFormButton.UseVisualStyleBackColor = true;
            this.panelFormButton.Click += new System.EventHandler(this.panelFormButton_Click);
            // 
            // panelFormHide
            // 
            this.panelFormHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFormHide.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.panelFormHide.InitialImage = null;
            this.panelFormHide.Location = new System.Drawing.Point(438, 14);
            this.panelFormHide.Name = "panelFormHide";
            this.panelFormHide.Size = new System.Drawing.Size(14, 18);
            this.panelFormHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelFormHide.TabIndex = 24;
            this.panelFormHide.TabStop = false;
            this.Ajuda.SetToolTip(this.panelFormHide, "Esconder");
            this.panelFormHide.Click += new System.EventHandler(this.panelFormHide_Click);
            // 
            // ajudaBtn
            // 
            this.ajudaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajudaBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.ajudaBtn.Image = global::Funcionarios.Properties.Resources.Ajuda;
            this.ajudaBtn.InitialImage = null;
            this.ajudaBtn.Location = new System.Drawing.Point(636, 23);
            this.ajudaBtn.Name = "ajudaBtn";
            this.ajudaBtn.Size = new System.Drawing.Size(38, 47);
            this.ajudaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBtn.TabIndex = 16;
            this.ajudaBtn.TabStop = false;
            this.Ajuda.SetToolTip(this.ajudaBtn, resources.GetString("ajudaBtn.ToolTip"));
            // 
            // listObjects
            // 
            this.listObjects.AllColumns.Add(this.coordenadas);
            this.listObjects.AllColumns.Add(this.nome);
            this.listObjects.AllColumns.Add(this.supervisor);
            this.listObjects.AllColumns.Add(this.tipo);
            this.listObjects.CellEditUseWholeCell = false;
            this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coordenadas,
            this.nome,
            this.supervisor,
            this.tipo});
            this.listObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjects.HideSelection = false;
            this.listObjects.Location = new System.Drawing.Point(22, 114);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(652, 191);
            this.listObjects.TabIndex = 17;
            this.listObjects.UseCompatibleStateImageBehavior = false;
            this.listObjects.View = System.Windows.Forms.View.Details;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.funcionariosListView_SelectedIndexChanged);
            // 
            // coordenadas
            // 
            this.coordenadas.AspectName = "coordenadas";
            this.coordenadas.Groupable = false;
            this.coordenadas.Text = "Coordenadas";
            this.coordenadas.Width = 150;
            // 
            // nome
            // 
            this.nome.AspectName = "nome";
            this.nome.Text = "Nome";
            this.nome.Width = 143;
            // 
            // supervisor
            // 
            this.supervisor.AspectName = "supervisor.nome";
            this.supervisor.Text = "Supervisor";
            this.supervisor.Width = 143;
            // 
            // tipo
            // 
            this.tipo.AspectName = "tipo.nome";
            this.tipo.Text = "Tipo";
            this.tipo.Width = 143;
            // 
            // panelObject
            // 
            this.panelObject.Controls.Add(this.panelObjectHide);
            this.panelObject.Controls.Add(this.panelObjectEliminar);
            this.panelObject.Controls.Add(this.panelObjectEditar);
            this.panelObject.Controls.Add(this.panelObjectSubtitulo);
            this.panelObject.Controls.Add(this.panelObjectTitulo);
            this.panelObject.Location = new System.Drawing.Point(522, 333);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(152, 191);
            this.panelObject.TabIndex = 19;
            this.panelObject.Visible = false;
            // 
            // panelObjectSubtitulo
            // 
            this.panelObjectSubtitulo.AutoSize = true;
            this.panelObjectSubtitulo.Location = new System.Drawing.Point(39, 77);
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
            this.panelObjectTitulo.Location = new System.Drawing.Point(49, 46);
            this.panelObjectTitulo.Name = "panelObjectTitulo";
            this.panelObjectTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelObjectTitulo.TabIndex = 20;
            this.panelObjectTitulo.Text = "Título";
            this.panelObjectTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.bloco;
            this.janelaLogo.InitialImage = null;
            this.janelaLogo.Location = new System.Drawing.Point(22, 23);
            this.janelaLogo.Name = "janelaLogo";
            this.janelaLogo.Size = new System.Drawing.Size(39, 45);
            this.janelaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.janelaLogo.TabIndex = 14;
            this.janelaLogo.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelFormFieldCoordenadas);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.panelFormFieldNome);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.panelFormFieldSupervisor);
            this.panelForm.Controls.Add(this.panelFormFieldTipo);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.panelFormHide);
            this.panelForm.Controls.Add(this.panelFormButton);
            this.panelForm.Controls.Add(this.panelFormTitulo);
            this.panelForm.Controls.Add(this.panelFormDescricao);
            this.panelForm.Location = new System.Drawing.Point(22, 333);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(475, 166);
            this.panelForm.TabIndex = 24;
            this.panelForm.Visible = false;
            // 
            // panelFormFieldCoordenadas
            // 
            this.panelFormFieldCoordenadas.Location = new System.Drawing.Point(191, 87);
            this.panelFormFieldCoordenadas.Name = "panelFormFieldCoordenadas";
            this.panelFormFieldCoordenadas.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldCoordenadas.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Coordenadas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldNome
            // 
            this.panelFormFieldNome.Location = new System.Drawing.Point(19, 87);
            this.panelFormFieldNome.Name = "panelFormFieldNome";
            this.panelFormFieldNome.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldNome.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldSupervisor
            // 
            this.panelFormFieldSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelFormFieldSupervisor.FormattingEnabled = true;
            this.panelFormFieldSupervisor.Location = new System.Drawing.Point(191, 132);
            this.panelFormFieldSupervisor.Name = "panelFormFieldSupervisor";
            this.panelFormFieldSupervisor.Size = new System.Drawing.Size(139, 21);
            this.panelFormFieldSupervisor.TabIndex = 44;
            // 
            // panelFormFieldTipo
            // 
            this.panelFormFieldTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelFormFieldTipo.FormattingEnabled = true;
            this.panelFormFieldTipo.Location = new System.Drawing.Point(19, 132);
            this.panelFormFieldTipo.Name = "panelFormFieldTipo";
            this.panelFormFieldTipo.Size = new System.Drawing.Size(139, 21);
            this.panelFormFieldTipo.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Supervisor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFormTitulo.AutoSize = true;
            this.panelFormTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormTitulo.Location = new System.Drawing.Point(15, 14);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelFormTitulo.TabIndex = 24;
            this.panelFormTitulo.Text = "Título";
            this.panelFormTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Blocos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 515);
            this.Controls.Add(this.ajudaBtn);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.janelaTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Blocos";
            this.Text = "Sistema de Gestão Escolar | Blocos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosed_Handler);
            this.Load += new System.EventHandler(this.FormLoad_Handler);
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).EndInit();
            this.panelObject.ResumeLayout(false);
            this.panelObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.Label janelaTitulo;
        private System.Windows.Forms.ToolTip Ajuda;
        private BrightIdeasSoftware.ObjectListView listObjects;
        private BrightIdeasSoftware.OLVColumn nome;
        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.Label panelObjectTitulo;
        private System.Windows.Forms.Label panelObjectSubtitulo;
        private System.Windows.Forms.Button panelObjectEditar;
        private System.Windows.Forms.Button panelObjectEliminar;
        private System.Windows.Forms.Button buttonAdicionarObject;
        private System.Windows.Forms.PictureBox panelObjectHide;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label panelFormDescricao;
        private System.Windows.Forms.Label panelFormTitulo;
        private System.Windows.Forms.Button panelFormButton;
        private System.Windows.Forms.PictureBox panelFormHide;
        private BrightIdeasSoftware.OLVColumn coordenadas;
        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.TextBox panelFormFieldCoordenadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox panelFormFieldNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox panelFormFieldSupervisor;
        private System.Windows.Forms.ComboBox panelFormFieldTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.OLVColumn supervisor;
        private BrightIdeasSoftware.OLVColumn tipo;
    }
}