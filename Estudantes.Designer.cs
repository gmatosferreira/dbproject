namespace Funcionarios
{
    partial class Estudantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estudantes));
            this.pesquisaAtributo = new System.Windows.Forms.ComboBox();
            this.pesquisaLabel = new System.Windows.Forms.Label();
            this.pesquisaTexto = new System.Windows.Forms.TextBox();
            this.buttonAdicionarObject = new System.Windows.Forms.Button();
            this.panelObject = new System.Windows.Forms.Panel();
            this.panelObjectHide = new System.Windows.Forms.PictureBox();
            this.panelObjectEliminar = new System.Windows.Forms.Button();
            this.panelObjectEditar = new System.Windows.Forms.Button();
            this.panelObjectSubtitulo = new System.Windows.Forms.Label();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.panelObjectImage = new System.Windows.Forms.PictureBox();
            this.listObjects = new BrightIdeasSoftware.ObjectListView();
            this.nmec = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nome = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nomeEE = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.telemovelEE = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.email_EE = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.janelaSubtitulo = new System.Windows.Forms.Label();
            this.janelaTitulo = new System.Windows.Forms.Label();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelFormFieldContacto = new System.Windows.Forms.TextBox();
            this.EmailEE = new System.Windows.Forms.Label();
            this.panelFormFieldEmailEE = new System.Windows.Forms.TextBox();
            this.panelFormHide = new System.Windows.Forms.PictureBox();
            this.panelFormButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFormFieldNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFormFieldContactoEE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFormFieldEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFormTitulo = new System.Windows.Forms.Label();
            this.panelFormFieldNomeEE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormFieldNMec = new System.Windows.Forms.TextBox();
            this.panelFormDescricao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ajudaBtn = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisaAtributo
            // 
            this.pesquisaAtributo.FormattingEnabled = true;
            this.pesquisaAtributo.Items.AddRange(new object[] {
            "Número mecanográfico",
            "Nome",
            "Nome Enc Educ",
            "Contacto Enc Educ",
            "Email Enc Educ"});
            this.pesquisaAtributo.Location = new System.Drawing.Point(453, 35);
            this.pesquisaAtributo.Name = "pesquisaAtributo";
            this.pesquisaAtributo.Size = new System.Drawing.Size(149, 21);
            this.pesquisaAtributo.TabIndex = 36;
            this.pesquisaAtributo.SelectedIndexChanged += new System.EventHandler(this.pesquisaAtributo_SelectedIndexChanged);
            // 
            // pesquisaLabel
            // 
            this.pesquisaLabel.AutoSize = true;
            this.pesquisaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaLabel.Location = new System.Drawing.Point(552, 12);
            this.pesquisaLabel.Name = "pesquisaLabel";
            this.pesquisaLabel.Size = new System.Drawing.Size(50, 13);
            this.pesquisaLabel.TabIndex = 35;
            this.pesquisaLabel.Text = "Pesquisa";
            this.pesquisaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pesquisaTexto
            // 
            this.pesquisaTexto.Location = new System.Drawing.Point(437, 66);
            this.pesquisaTexto.Name = "pesquisaTexto";
            this.pesquisaTexto.Size = new System.Drawing.Size(165, 20);
            this.pesquisaTexto.TabIndex = 34;
            this.pesquisaTexto.TextChanged += new System.EventHandler(this.pesquisaTexto_TextChanged);
            // 
            // buttonAdicionarObject
            // 
            this.buttonAdicionarObject.Location = new System.Drawing.Point(643, 374);
            this.buttonAdicionarObject.Name = "buttonAdicionarObject";
            this.buttonAdicionarObject.Size = new System.Drawing.Size(112, 53);
            this.buttonAdicionarObject.TabIndex = 33;
            this.buttonAdicionarObject.Text = "Adicionar novo";
            this.buttonAdicionarObject.UseVisualStyleBackColor = true;
            this.buttonAdicionarObject.Click += new System.EventHandler(this.buttonAdicionarObject_Click);
            // 
            // panelObject
            // 
            this.panelObject.Controls.Add(this.panelObjectHide);
            this.panelObject.Controls.Add(this.panelObjectEliminar);
            this.panelObject.Controls.Add(this.panelObjectEditar);
            this.panelObject.Controls.Add(this.panelObjectSubtitulo);
            this.panelObject.Controls.Add(this.panelObjectTitulo);
            this.panelObject.Controls.Add(this.panelObjectImage);
            this.panelObject.Location = new System.Drawing.Point(626, 12);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(152, 336);
            this.panelObject.TabIndex = 32;
            this.panelObject.Visible = false;
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
            this.panelObjectHide.Click += new System.EventHandler(this.panelObjectEsconder_Click);
            // 
            // panelObjectEliminar
            // 
            this.panelObjectEliminar.Location = new System.Drawing.Point(40, 276);
            this.panelObjectEliminar.Name = "panelObjectEliminar";
            this.panelObjectEliminar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectEliminar.TabIndex = 21;
            this.panelObjectEliminar.Text = "Eliminar";
            this.panelObjectEliminar.UseVisualStyleBackColor = true;
            this.panelObjectEliminar.Click += new System.EventHandler(this.panelObjectEliminar_Click);
            // 
            // panelObjectEditar
            // 
            this.panelObjectEditar.Location = new System.Drawing.Point(40, 236);
            this.panelObjectEditar.Name = "panelObjectEditar";
            this.panelObjectEditar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectEditar.TabIndex = 20;
            this.panelObjectEditar.Text = "Editar";
            this.panelObjectEditar.UseVisualStyleBackColor = true;
            this.panelObjectEditar.Click += new System.EventHandler(this.panelObjectEditar_Click);
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
            this.panelObjectImage.Image = global::Funcionarios.Properties.Resources.Estudante;
            this.panelObjectImage.InitialImage = null;
            this.panelObjectImage.Location = new System.Drawing.Point(24, 45);
            this.panelObjectImage.Name = "panelObjectImage";
            this.panelObjectImage.Size = new System.Drawing.Size(91, 84);
            this.panelObjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelObjectImage.TabIndex = 18;
            this.panelObjectImage.TabStop = false;
            // 
            // listObjects
            // 
            this.listObjects.AllColumns.Add(this.nmec);
            this.listObjects.AllColumns.Add(this.nome);
            this.listObjects.AllColumns.Add(this.nomeEE);
            this.listObjects.AllColumns.Add(this.telemovelEE);
            this.listObjects.AllColumns.Add(this.email_EE);
            this.listObjects.CellEditUseWholeCell = false;
            this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nmec,
            this.nome,
            this.nomeEE,
            this.telemovelEE,
            this.email_EE});
            this.listObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.listObjects.HideSelection = false;
            this.listObjects.Location = new System.Drawing.Point(22, 103);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(580, 336);
            this.listObjects.TabIndex = 31;
            this.listObjects.UseCompatibleStateImageBehavior = false;
            this.listObjects.View = System.Windows.Forms.View.Details;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.estudantesListView_SelectedIndexChanged);
            // 
            // nmec
            // 
            this.nmec.AspectName = "nmec";
            this.nmec.Text = "NMec";
            this.nmec.Width = 77;
            // 
            // nome
            // 
            this.nome.AspectName = "nome";
            this.nome.Text = "Nome";
            this.nome.Width = 137;
            // 
            // nomeEE
            // 
            this.nomeEE.AspectName = "nomeEE";
            this.nomeEE.Text = "Nome EE";
            // 
            // telemovelEE
            // 
            this.telemovelEE.AspectName = "telemovelEE";
            this.telemovelEE.Text = "Contato EE";
            this.telemovelEE.Width = 100;
            // 
            // email_EE
            // 
            this.email_EE.AspectName = "emailEE";
            this.email_EE.Text = "Email EE";
            this.email_EE.Width = 207;
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(80, 43);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(100, 13);
            this.janelaSubtitulo.TabIndex = 30;
            this.janelaSubtitulo.Text = "A mostrar X registos";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(76, 12);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(91, 20);
            this.janelaTitulo.TabIndex = 28;
            this.janelaTitulo.Text = "Estudantes";
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.Estudantes;
            this.janelaLogo.InitialImage = null;
            this.janelaLogo.Location = new System.Drawing.Point(22, 12);
            this.janelaLogo.Name = "janelaLogo";
            this.janelaLogo.Size = new System.Drawing.Size(39, 45);
            this.janelaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.janelaLogo.TabIndex = 29;
            this.janelaLogo.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.panelFormFieldContacto);
            this.panelForm.Controls.Add(this.EmailEE);
            this.panelForm.Controls.Add(this.panelFormFieldEmailEE);
            this.panelForm.Controls.Add(this.panelFormHide);
            this.panelForm.Controls.Add(this.panelFormButton);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.panelFormFieldNome);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.panelFormFieldContactoEE);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.panelFormFieldEmail);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.panelFormTitulo);
            this.panelForm.Controls.Add(this.panelFormFieldNomeEE);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.panelFormFieldNMec);
            this.panelForm.Controls.Add(this.panelFormDescricao);
            this.panelForm.Location = new System.Drawing.Point(22, 472);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(580, 189);
            this.panelForm.TabIndex = 37;
            this.panelForm.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Contacto (opcional)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldContacto
            // 
            this.panelFormFieldContacto.Location = new System.Drawing.Point(6, 160);
            this.panelFormFieldContacto.Name = "panelFormFieldContacto";
            this.panelFormFieldContacto.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldContacto.TabIndex = 37;
            // 
            // EmailEE
            // 
            this.EmailEE.AutoSize = true;
            this.EmailEE.Location = new System.Drawing.Point(352, 102);
            this.EmailEE.Name = "EmailEE";
            this.EmailEE.Size = new System.Drawing.Size(49, 13);
            this.EmailEE.TabIndex = 36;
            this.EmailEE.Text = "Email EE";
            this.EmailEE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldEmailEE
            // 
            this.panelFormFieldEmailEE.Location = new System.Drawing.Point(350, 118);
            this.panelFormFieldEmailEE.Name = "panelFormFieldEmailEE";
            this.panelFormFieldEmailEE.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldEmailEE.TabIndex = 35;
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
            // panelFormButton
            // 
            this.panelFormButton.Location = new System.Drawing.Point(415, 151);
            this.panelFormButton.Name = "panelFormButton";
            this.panelFormButton.Size = new System.Drawing.Size(139, 23);
            this.panelFormButton.TabIndex = 25;
            this.panelFormButton.Text = "Botao";
            this.panelFormButton.UseVisualStyleBackColor = true;
            this.panelFormButton.Click += new System.EventHandler(this.panelFormButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nome EE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldNome
            // 
            this.panelFormFieldNome.Location = new System.Drawing.Point(179, 73);
            this.panelFormFieldNome.Name = "panelFormFieldNome";
            this.panelFormFieldNome.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldNome.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Contacto EE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldContactoEE
            // 
            this.panelFormFieldContactoEE.Location = new System.Drawing.Point(179, 118);
            this.panelFormFieldContactoEE.Name = "panelFormFieldContactoEE";
            this.panelFormFieldContactoEE.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldContactoEE.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldEmail
            // 
            this.panelFormFieldEmail.Location = new System.Drawing.Point(350, 73);
            this.panelFormFieldEmail.Name = "panelFormFieldEmail";
            this.panelFormFieldEmail.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldEmail.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 57);
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
            this.panelFormTitulo.Location = new System.Drawing.Point(21, 12);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelFormTitulo.TabIndex = 24;
            this.panelFormTitulo.Text = "Título";
            this.panelFormTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldNomeEE
            // 
            this.panelFormFieldNomeEE.Location = new System.Drawing.Point(6, 120);
            this.panelFormFieldNomeEE.Name = "panelFormFieldNomeEE";
            this.panelFormFieldNomeEE.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldNomeEE.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Número mecanográfico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormFieldNMec
            // 
            this.panelFormFieldNMec.Enabled = false;
            this.panelFormFieldNMec.Location = new System.Drawing.Point(6, 73);
            this.panelFormFieldNMec.Name = "panelFormFieldNMec";
            this.panelFormFieldNMec.Size = new System.Drawing.Size(139, 20);
            this.panelFormFieldNMec.TabIndex = 25;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ajudaBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(626, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 189);
            this.panel1.TabIndex = 38;
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
            // Estudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.pesquisaAtributo);
            this.Controls.Add(this.pesquisaLabel);
            this.Controls.Add(this.pesquisaTexto);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.janelaTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estudantes";
            this.Text = "Sistema de Gestão Escolar | Estudantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Estudantes_FormClosed);
            this.Load += new System.EventHandler(this.Estudantes_Load);
            this.panelObject.ResumeLayout(false);
            this.panelObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormHide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pesquisaAtributo;
        private System.Windows.Forms.Label pesquisaLabel;
        private System.Windows.Forms.TextBox pesquisaTexto;
        private System.Windows.Forms.Button buttonAdicionarObject;
        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.PictureBox panelObjectHide;
        private System.Windows.Forms.Button panelObjectEliminar;
        private System.Windows.Forms.Button panelObjectEditar;
        private System.Windows.Forms.Label panelObjectSubtitulo;
        private System.Windows.Forms.Label panelObjectTitulo;
        private System.Windows.Forms.PictureBox panelObjectImage;
        private BrightIdeasSoftware.ObjectListView listObjects;
        private BrightIdeasSoftware.OLVColumn nmec;
        private BrightIdeasSoftware.OLVColumn nome;
        private BrightIdeasSoftware.OLVColumn email_EE;
        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.Label janelaTitulo;
        public BrightIdeasSoftware.OLVColumn telemovelEE;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.PictureBox panelFormHide;
        private System.Windows.Forms.Button panelFormButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox panelFormFieldNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox panelFormFieldContactoEE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox panelFormFieldEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label panelFormTitulo;
        private System.Windows.Forms.TextBox panelFormFieldNomeEE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox panelFormFieldNMec;
        private System.Windows.Forms.Label panelFormDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label EmailEE;
        private System.Windows.Forms.TextBox panelFormFieldEmailEE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox panelFormFieldContacto;
        private BrightIdeasSoftware.OLVColumn nomeEE;
    }
}