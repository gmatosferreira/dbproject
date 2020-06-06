namespace Funcionarios
{
    partial class NaoDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaoDocentes));
            this.janelaSubtitulo = new System.Windows.Forms.Label();
            this.janelaTitulo = new System.Windows.Forms.Label();
            this.Ajuda = new System.Windows.Forms.ToolTip(this.components);
            this.panelObjectEditar = new System.Windows.Forms.Button();
            this.panelObjectEliminar = new System.Windows.Forms.Button();
            this.buttonAdicionarObject = new System.Windows.Forms.Button();
            this.panelObjectHide = new System.Windows.Forms.PictureBox();
            this.ajudaBtn = new System.Windows.Forms.PictureBox();
            this.panelFormButton = new System.Windows.Forms.Button();
            this.panelFormHide = new System.Windows.Forms.PictureBox();
            this.listObjects = new BrightIdeasSoftware.ObjectListView();
            this.nmec = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.grupoDisciplinar = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.salario = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nome = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelObject = new System.Windows.Forms.Panel();
            this.panelObjectSubtitulo = new System.Windows.Forms.Label();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.panelObjectImage = new System.Windows.Forms.PictureBox();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelFormFieldTurno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFormFieldSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFormFieldContacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFormFieldEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFormTitulo = new System.Windows.Forms.Label();
            this.panelFormFieldNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormFieldNMec = new System.Windows.Forms.TextBox();
            this.panelFormDescricao = new System.Windows.Forms.Label();
            this.pesquisaTexto = new System.Windows.Forms.TextBox();
            this.pesquisaLabel = new System.Windows.Forms.Label();
            this.pesquisaAtributo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).BeginInit();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(80, 54);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(100, 13);
            this.janelaSubtitulo.TabIndex = 15;
            this.janelaSubtitulo.Text = "A mostrar X registos";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(76, 23);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(108, 20);
            this.janelaTitulo.TabIndex = 13;
            this.janelaTitulo.Text = "Não docentes";
            // 
            // panelObjectEditar
            // 
            this.panelObjectEditar.Location = new System.Drawing.Point(40, 236);
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
            this.panelObjectEliminar.Location = new System.Drawing.Point(40, 276);
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
            this.buttonAdicionarObject.Location = new System.Drawing.Point(643, 385);
            this.buttonAdicionarObject.Name = "buttonAdicionarObject";
            this.buttonAdicionarObject.Size = new System.Drawing.Size(112, 53);
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
            this.Ajuda.SetToolTip(this.ajudaBtn, resources.GetString("ajudaBtn.ToolTip"));
            // 
            // panelFormButton
            // 
            this.panelFormButton.Location = new System.Drawing.Point(415, 164);
            this.panelFormButton.Name = "panelFormButton";
            this.panelFormButton.Size = new System.Drawing.Size(139, 23);
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
            this.panelFormHide.Location = new System.Drawing.Point(554, 14);
            this.panelFormHide.Name = "panelFormHide";
            this.panelFormHide.Size = new System.Drawing.Size(14, 18);
            this.panelFormHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelFormHide.TabIndex = 24;
            this.panelFormHide.TabStop = false;
            this.Ajuda.SetToolTip(this.panelFormHide, "Esconder");
            this.panelFormHide.Click += new System.EventHandler(this.panelFormHide_Click);
            // 
            // listObjects
            // 
            this.listObjects.AllColumns.Add(this.nmec);
            this.listObjects.AllColumns.Add(this.grupoDisciplinar);
            this.listObjects.AllColumns.Add(this.salario);
            this.listObjects.AllColumns.Add(this.nome);
            this.listObjects.AllColumns.Add(this.tel);
            this.listObjects.AllColumns.Add(this.email);
            this.listObjects.CellEditUseWholeCell = false;
            this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nmec,
            this.grupoDisciplinar,
            this.salario,
            this.nome,
            this.tel,
            this.email});
            this.listObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjects.HideSelection = false;
            this.listObjects.Location = new System.Drawing.Point(22, 114);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(580, 336);
            this.listObjects.TabIndex = 17;
            this.listObjects.UseCompatibleStateImageBehavior = false;
            this.listObjects.View = System.Windows.Forms.View.Details;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.funcionariosListView_SelectedIndexChanged);
            // 
            // nmec
            // 
            this.nmec.AspectName = "nmec";
            this.nmec.Text = "NMec";
            this.nmec.Width = 77;
            // 
            // grupoDisciplinar
            // 
            this.grupoDisciplinar.AspectName = "grupoDisciplinarStr";
            this.grupoDisciplinar.Text = "Grupo Disciplinar";
            // 
            // salario
            // 
            this.salario.AspectName = "salario";
            this.salario.AspectToStringFormat = "{0:0.00}";
            this.salario.Text = "Salário";
            this.salario.Width = 71;
            // 
            // nome
            // 
            this.nome.AspectName = "nome";
            this.nome.Text = "Nome";
            this.nome.Width = 137;
            // 
            // tel
            // 
            this.tel.AspectName = "telemovel";
            this.tel.Text = "Contacto";
            this.tel.Width = 104;
            // 
            // email
            // 
            this.email.AspectName = "email";
            this.email.Text = "Email";
            this.email.Width = 156;
            // 
            // panelObject
            // 
            this.panelObject.Controls.Add(this.panelObjectHide);
            this.panelObject.Controls.Add(this.panelObjectEliminar);
            this.panelObject.Controls.Add(this.panelObjectEditar);
            this.panelObject.Controls.Add(this.panelObjectSubtitulo);
            this.panelObject.Controls.Add(this.panelObjectTitulo);
            this.panelObject.Controls.Add(this.panelObjectImage);
            this.panelObject.Location = new System.Drawing.Point(626, 23);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(152, 336);
            this.panelObject.TabIndex = 19;
            this.panelObject.Visible = false;
            // 
            // panelObjectSubtitulo
            // 
            this.panelObjectSubtitulo.AutoSize = true;
            this.panelObjectSubtitulo.Location = new System.Drawing.Point(53, 173);
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
            this.panelObjectTitulo.Location = new System.Drawing.Point(20, 144);
            this.panelObjectTitulo.Name = "panelObjectTitulo";
            this.panelObjectTitulo.Size = new System.Drawing.Size(108, 20);
            this.panelObjectTitulo.TabIndex = 20;
            this.panelObjectTitulo.Text = "Nome Apelido";
            this.panelObjectTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObjectImage
            // 
            this.panelObjectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelObjectImage.Image = global::Funcionarios.Properties.Resources.Funcionario;
            this.panelObjectImage.InitialImage = null;
            this.panelObjectImage.Location = new System.Drawing.Point(45, 60);
            this.panelObjectImage.Name = "panelObjectImage";
            this.panelObjectImage.Size = new System.Drawing.Size(59, 68);
            this.panelObjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelObjectImage.TabIndex = 18;
            this.panelObjectImage.TabStop = false;
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.Nao_Docente;
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
            this.panelForm.Controls.Add(this.panelFormFieldTurno);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.panelFormHide);
            this.panelForm.Controls.Add(this.panelFormButton);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.panelFormFieldSalario);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.panelFormFieldContacto);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.panelFormFieldEmail);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.panelFormTitulo);
            this.panelForm.Controls.Add(this.panelFormFieldNome);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.panelFormFieldNMec);
            this.panelForm.Controls.Add(this.panelFormDescricao);
            this.panelForm.Location = new System.Drawing.Point(22, 477);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(580, 202);
            this.panelForm.TabIndex = 24;
            this.panelForm.Visible = false;
            // 
            // panelFormFieldTurno
            // 
            this.panelFormFieldTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelFormFieldTurno.FormattingEnabled = true;
            this.panelFormFieldTurno.Location = new System.Drawing.Point(415, 133);
            this.panelFormFieldTurno.Name = "panelFormFieldTurno";
            this.panelFormFieldTurno.Size = new System.Drawing.Size(139, 21);
            this.panelFormFieldTurno.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Turno";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Salario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldSalario
            // 
            this.panelFormFieldSalario.Location = new System.Drawing.Point(415, 87);
            this.panelFormFieldSalario.Name = "panelFormFieldSalario";
            this.panelFormFieldSalario.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldSalario.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Contacto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldContacto
            // 
            this.panelFormFieldContacto.Location = new System.Drawing.Point(229, 134);
            this.panelFormFieldContacto.Name = "panelFormFieldContacto";
            this.panelFormFieldContacto.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldContacto.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldEmail
            // 
            this.panelFormFieldEmail.Location = new System.Drawing.Point(229, 87);
            this.panelFormFieldEmail.Name = "panelFormFieldEmail";
            this.panelFormFieldEmail.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldEmail.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFormTitulo.AutoSize = true;
            this.panelFormTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormTitulo.Location = new System.Drawing.Point(17, 14);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelFormTitulo.TabIndex = 24;
            this.panelFormTitulo.Text = "Título";
            this.panelFormTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldNome
            // 
            this.panelFormFieldNome.Location = new System.Drawing.Point(19, 134);
            this.panelFormFieldNome.Name = "panelFormFieldNome";
            this.panelFormFieldNome.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldNome.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Número mecanográfico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldNMec
            // 
            this.panelFormFieldNMec.Enabled = false;
            this.panelFormFieldNMec.Location = new System.Drawing.Point(19, 87);
            this.panelFormFieldNMec.Name = "panelFormFieldNMec";
            this.panelFormFieldNMec.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldNMec.TabIndex = 25;
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
            // pesquisaTexto
            // 
            this.pesquisaTexto.Location = new System.Drawing.Point(437, 77);
            this.pesquisaTexto.Name = "pesquisaTexto";
            this.pesquisaTexto.Size = new System.Drawing.Size(165, 20);
            this.pesquisaTexto.TabIndex = 25;
            this.pesquisaTexto.TextChanged += new System.EventHandler(this.pesquisaTexto_TextChanged);
            // 
            // pesquisaLabel
            // 
            this.pesquisaLabel.AutoSize = true;
            this.pesquisaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaLabel.Location = new System.Drawing.Point(552, 23);
            this.pesquisaLabel.Name = "pesquisaLabel";
            this.pesquisaLabel.Size = new System.Drawing.Size(50, 13);
            this.pesquisaLabel.TabIndex = 26;
            this.pesquisaLabel.Text = "Pesquisa";
            this.pesquisaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pesquisaAtributo
            // 
            this.pesquisaAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pesquisaAtributo.FormattingEnabled = true;
            this.pesquisaAtributo.Items.AddRange(new object[] {
            "Número mecanográfico",
            "Grupo disciplinar",
            "Salário",
            "Nome",
            "Contacto",
            "Email"});
            this.pesquisaAtributo.Location = new System.Drawing.Point(453, 46);
            this.pesquisaAtributo.Name = "pesquisaAtributo";
            this.pesquisaAtributo.Size = new System.Drawing.Size(149, 21);
            this.pesquisaAtributo.TabIndex = 27;
            this.pesquisaAtributo.SelectedIndexChanged += new System.EventHandler(this.pesquisaAtributo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ajudaBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(626, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 174);
            this.panel1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 52);
            this.label5.TabIndex = 24;
            this.label5.Text = "Passe o rato sobre a\r\nimagem acima e saiba\r\nmais sobre como utilizar\r\nesta interf" +
    "ace!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Dúvidas?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NaoDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 723);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pesquisaAtributo);
            this.Controls.Add(this.pesquisaLabel);
            this.Controls.Add(this.pesquisaTexto);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.janelaTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NaoDocentes";
            this.Text = "Sistema de Gestão Escolar | Não docentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosed_Handler);
            this.Load += new System.EventHandler(this.FormLoad_Handler);
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).EndInit();
            this.panelObject.ResumeLayout(false);
            this.panelObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.Label janelaTitulo;
        private System.Windows.Forms.ToolTip Ajuda;
        private BrightIdeasSoftware.ObjectListView listObjects;
        private BrightIdeasSoftware.OLVColumn nmec;
        private BrightIdeasSoftware.OLVColumn salario;
        private BrightIdeasSoftware.OLVColumn nome;
        private BrightIdeasSoftware.OLVColumn tel;
        private BrightIdeasSoftware.OLVColumn email;
        private System.Windows.Forms.PictureBox panelObjectImage;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox panelFormFieldNMec;
        private System.Windows.Forms.Button panelFormButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox panelFormFieldSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox panelFormFieldContacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox panelFormFieldEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox panelFormFieldNome;
        private System.Windows.Forms.PictureBox panelFormHide;
        private System.Windows.Forms.TextBox pesquisaTexto;
        private System.Windows.Forms.Label pesquisaLabel;
        private System.Windows.Forms.ComboBox pesquisaAtributo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private BrightIdeasSoftware.OLVColumn grupoDisciplinar;
        private System.Windows.Forms.ComboBox panelFormFieldTurno;
        private System.Windows.Forms.Label label8;
    }
}