namespace Funcionarios
{
    partial class GruposDisciplinares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GruposDisciplinares));
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
            this.hideDisciplina = new System.Windows.Forms.PictureBox();
            this.addDiscButton = new System.Windows.Forms.Button();
            this.criarDisciplina = new System.Windows.Forms.Button();
            this.listObjects = new BrightIdeasSoftware.ObjectListView();
            this.nome = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelObject = new System.Windows.Forms.Panel();
            this.panelObjectSubtitulo = new System.Windows.Forms.Label();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelFormTitulo = new System.Windows.Forms.Label();
            this.panelFormFieldNome = new System.Windows.Forms.TextBox();
            this.panelFormDescricao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDisc = new System.Windows.Forms.Panel();
            this.tituloDisciplina = new System.Windows.Forms.Label();
            this.disciplinaNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideDisciplina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).BeginInit();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panelDisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(80, 54);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(96, 13);
            this.janelaSubtitulo.TabIndex = 15;
            this.janelaSubtitulo.Text = "A mostrar X grupos";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(76, 23);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(155, 20);
            this.janelaTitulo.TabIndex = 13;
            this.janelaTitulo.Text = "Grupos Disciplinares";
            // 
            // panelObjectEditar
            // 
            this.panelObjectEditar.Location = new System.Drawing.Point(40, 126);
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
            this.panelObjectEliminar.Location = new System.Drawing.Point(40, 155);
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
            this.buttonAdicionarObject.Location = new System.Drawing.Point(328, 23);
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
            this.panelFormButton.Location = new System.Drawing.Point(58, 101);
            this.panelFormButton.Name = "panelFormButton";
            this.panelFormButton.Size = new System.Drawing.Size(125, 25);
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
            this.panelFormHide.Location = new System.Drawing.Point(223, 12);
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
            this.ajudaBtn.Location = new System.Drawing.Point(459, 23);
            this.ajudaBtn.Name = "ajudaBtn";
            this.ajudaBtn.Size = new System.Drawing.Size(38, 47);
            this.ajudaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBtn.TabIndex = 16;
            this.ajudaBtn.TabStop = false;
            this.Ajuda.SetToolTip(this.ajudaBtn, resources.GetString("ajudaBtn.ToolTip"));
            // 
            // hideDisciplina
            // 
            this.hideDisciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hideDisciplina.Cursor = System.Windows.Forms.Cursors.Default;
            this.hideDisciplina.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.hideDisciplina.InitialImage = null;
            this.hideDisciplina.Location = new System.Drawing.Point(215, 12);
            this.hideDisciplina.Name = "hideDisciplina";
            this.hideDisciplina.Size = new System.Drawing.Size(14, 18);
            this.hideDisciplina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hideDisciplina.TabIndex = 25;
            this.hideDisciplina.TabStop = false;
            this.Ajuda.SetToolTip(this.hideDisciplina, "Esconder");
            this.hideDisciplina.Click += new System.EventHandler(this.hideDisciplina_Click);
            // 
            // addDiscButton
            // 
            this.addDiscButton.Location = new System.Drawing.Point(40, 86);
            this.addDiscButton.Name = "addDiscButton";
            this.addDiscButton.Size = new System.Drawing.Size(75, 34);
            this.addDiscButton.TabIndex = 31;
            this.addDiscButton.Text = "Adicionar Disciplina";
            this.Ajuda.SetToolTip(this.addDiscButton, "0");
            this.addDiscButton.UseVisualStyleBackColor = true;
            this.addDiscButton.Click += new System.EventHandler(this.addDiscButton_Click);
            // 
            // criarDisciplina
            // 
            this.criarDisciplina.Location = new System.Drawing.Point(55, 101);
            this.criarDisciplina.Name = "criarDisciplina";
            this.criarDisciplina.Size = new System.Drawing.Size(125, 25);
            this.criarDisciplina.TabIndex = 32;
            this.criarDisciplina.Text = "Adicionar";
            this.Ajuda.SetToolTip(this.criarDisciplina, "0");
            this.criarDisciplina.UseVisualStyleBackColor = true;
            this.criarDisciplina.Click += new System.EventHandler(this.criarDisciplina_Click);
            // 
            // listObjects
            // 
            this.listObjects.AllColumns.Add(this.nome);
            this.listObjects.CellEditUseWholeCell = false;
            this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome});
            this.listObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjects.HideSelection = false;
            this.listObjects.Location = new System.Drawing.Point(22, 105);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(299, 191);
            this.listObjects.TabIndex = 17;
            this.listObjects.UseCompatibleStateImageBehavior = false;
            this.listObjects.View = System.Windows.Forms.View.Details;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.funcionariosListView_SelectedIndexChanged);
            // 
            // nome
            // 
            this.nome.AspectName = "nome";
            this.nome.Text = "Nome";
            this.nome.Width = 265;
            // 
            // panelObject
            // 
            this.panelObject.Controls.Add(this.addDiscButton);
            this.panelObject.Controls.Add(this.panelObjectSubtitulo);
            this.panelObject.Controls.Add(this.panelObjectHide);
            this.panelObject.Controls.Add(this.panelObjectEliminar);
            this.panelObject.Controls.Add(this.panelObjectEditar);
            this.panelObject.Controls.Add(this.panelObjectTitulo);
            this.panelObject.Location = new System.Drawing.Point(345, 105);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(152, 191);
            this.panelObject.TabIndex = 19;
            this.panelObject.Visible = false;
            // 
            // panelObjectSubtitulo
            // 
            this.panelObjectSubtitulo.AutoSize = true;
            this.panelObjectSubtitulo.Location = new System.Drawing.Point(37, 59);
            this.panelObjectSubtitulo.Name = "panelObjectSubtitulo";
            this.panelObjectSubtitulo.Size = new System.Drawing.Size(42, 13);
            this.panelObjectSubtitulo.TabIndex = 30;
            this.panelObjectSubtitulo.Text = "XXXXX";
            this.panelObjectSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObjectTitulo
            // 
            this.panelObjectTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelObjectTitulo.AutoSize = true;
            this.panelObjectTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelObjectTitulo.Location = new System.Drawing.Point(49, 28);
            this.panelObjectTitulo.Name = "panelObjectTitulo";
            this.panelObjectTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelObjectTitulo.TabIndex = 20;
            this.panelObjectTitulo.Text = "Título";
            this.panelObjectTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.grupoDisciplinar;
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
            this.panelForm.Controls.Add(this.panelFormTitulo);
            this.panelForm.Controls.Add(this.panelFormFieldNome);
            this.panelForm.Controls.Add(this.panelFormHide);
            this.panelForm.Controls.Add(this.panelFormButton);
            this.panelForm.Controls.Add(this.panelFormDescricao);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Location = new System.Drawing.Point(9, 320);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(250, 144);
            this.panelForm.TabIndex = 24;
            this.panelForm.Visible = false;
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFormTitulo.AutoSize = true;
            this.panelFormTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormTitulo.Location = new System.Drawing.Point(9, 12);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelFormTitulo.TabIndex = 24;
            this.panelFormTitulo.Text = "Título";
            this.panelFormTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldNome
            // 
            this.panelFormFieldNome.Location = new System.Drawing.Point(44, 75);
            this.panelFormFieldNome.Name = "panelFormFieldNome";
            this.panelFormFieldNome.Size = new System.Drawing.Size(156, 20);
            this.panelFormFieldNome.TabIndex = 29;
            // 
            // panelFormDescricao
            // 
            this.panelFormDescricao.AutoSize = true;
            this.panelFormDescricao.Location = new System.Drawing.Point(10, 32);
            this.panelFormDescricao.Name = "panelFormDescricao";
            this.panelFormDescricao.Size = new System.Drawing.Size(42, 13);
            this.panelFormDescricao.TabIndex = 24;
            this.panelFormDescricao.Text = "XXXXX";
            this.panelFormDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDisc
            // 
            this.panelDisc.Controls.Add(this.tituloDisciplina);
            this.panelDisc.Controls.Add(this.disciplinaNome);
            this.panelDisc.Controls.Add(this.criarDisciplina);
            this.panelDisc.Controls.Add(this.label4);
            this.panelDisc.Controls.Add(this.hideDisciplina);
            this.panelDisc.Location = new System.Drawing.Point(268, 320);
            this.panelDisc.Name = "panelDisc";
            this.panelDisc.Size = new System.Drawing.Size(240, 144);
            this.panelDisc.TabIndex = 30;
            this.panelDisc.Visible = false;
            // 
            // tituloDisciplina
            // 
            this.tituloDisciplina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloDisciplina.AutoSize = true;
            this.tituloDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloDisciplina.Location = new System.Drawing.Point(6, 10);
            this.tituloDisciplina.Name = "tituloDisciplina";
            this.tituloDisciplina.Size = new System.Drawing.Size(129, 17);
            this.tituloDisciplina.TabIndex = 30;
            this.tituloDisciplina.Text = "Adicionar disciplina";
            this.tituloDisciplina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // disciplinaNome
            // 
            this.disciplinaNome.Location = new System.Drawing.Point(41, 75);
            this.disciplinaNome.Name = "disciplinaNome";
            this.disciplinaNome.Size = new System.Drawing.Size(156, 20);
            this.disciplinaNome.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nome Disciplina ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GruposDisciplinares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 476);
            this.Controls.Add(this.panelDisc);
            this.Controls.Add(this.ajudaBtn);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.janelaTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GruposDisciplinares";
            this.Text = "Sistema de Gestão Escolar | Grupos Disciplinares";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosed_Handler);
            this.Load += new System.EventHandler(this.FormLoad_Handler);
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideDisciplina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).EndInit();
            this.panelObject.ResumeLayout(false);
            this.panelObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelDisc.ResumeLayout(false);
            this.panelDisc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.Label janelaTitulo;
        private System.Windows.Forms.ToolTip Ajuda;
        private BrightIdeasSoftware.ObjectListView listObjects;
        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.Label panelObjectTitulo;
        private System.Windows.Forms.Button panelObjectEditar;
        private System.Windows.Forms.Button panelObjectEliminar;
        private System.Windows.Forms.Button buttonAdicionarObject;
        private System.Windows.Forms.PictureBox panelObjectHide;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label panelFormDescricao;
        private System.Windows.Forms.Label panelFormTitulo;
        private System.Windows.Forms.Button panelFormButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox panelFormHide;
        private BrightIdeasSoftware.OLVColumn nome;
        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.TextBox panelFormFieldNome;
        private System.Windows.Forms.Label panelObjectSubtitulo;
        private System.Windows.Forms.Button addDiscButton;
        private System.Windows.Forms.Panel panelDisc;
        private System.Windows.Forms.Label tituloDisciplina;
        private System.Windows.Forms.TextBox disciplinaNome;
        private System.Windows.Forms.Button criarDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox hideDisciplina;
    }
}