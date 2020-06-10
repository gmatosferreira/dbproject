namespace Funcionarios
{
    partial class Bibliotecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bibliotecas));
            this.janelaSubtitulo = new System.Windows.Forms.Label();
            this.janelaTitulo = new System.Windows.Forms.Label();
            this.Ajuda = new System.Windows.Forms.ToolTip(this.components);
            this.panelObjectCatalogoEditar = new System.Windows.Forms.Button();
            this.panelObjectCatalogoEliminar = new System.Windows.Forms.Button();
            this.buttonAdicionarObjectCatalogo = new System.Windows.Forms.Button();
            this.panelObjectCatalogoHide = new System.Windows.Forms.PictureBox();
            this.panelFormCatalogoBotaoSubmeter = new System.Windows.Forms.Button();
            this.panelFormCatalogoHide = new System.Windows.Forms.PictureBox();
            this.listCatalogo = new BrightIdeasSoftware.ObjectListView();
            this.catalogoIDInterno = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.catalogoISBN = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.catalogoEstado = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.catalogoTitulo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.catalogoAno = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.catalogoEditora = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.catalogoAutores = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelObjectCatalogo = new System.Windows.Forms.Panel();
            this.panelObjectCatalogoSubtitulo = new System.Windows.Forms.Label();
            this.panelObjectCatalogoTitulo = new System.Windows.Forms.Label();
            this.panelObjectImage = new System.Windows.Forms.PictureBox();
            this.janelaLogo = new System.Windows.Forms.PictureBox();
            this.panelFormCatalogo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFormCatalogoFieldAutores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFormCatalogoFieldAnoEdicao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFormCatalogoFieldTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFormCatalogoTitulo = new System.Windows.Forms.Label();
            this.panelFormCatalogoFieldEditora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormCatalogoFieldISBN = new System.Windows.Forms.TextBox();
            this.panelFormCatalogoSubtitulo = new System.Windows.Forms.Label();
            this.pesquisaCatalogoTexto = new System.Windows.Forms.TextBox();
            this.pesquisaCatalogoLabel = new System.Windows.Forms.Label();
            this.pesquisaCatalogoSelect = new System.Windows.Forms.ComboBox();
            this.escolhaBiblioteca = new System.Windows.Forms.ComboBox();
            this.catalogoTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectCatalogoHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormCatalogoHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCatalogo)).BeginInit();
            this.panelObjectCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).BeginInit();
            this.panelFormCatalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // janelaSubtitulo
            // 
            this.janelaSubtitulo.AutoSize = true;
            this.janelaSubtitulo.Location = new System.Drawing.Point(155, 28);
            this.janelaSubtitulo.Name = "janelaSubtitulo";
            this.janelaSubtitulo.Size = new System.Drawing.Size(111, 13);
            this.janelaSubtitulo.TabIndex = 15;
            this.janelaSubtitulo.Text = "Selecione a biblioteca";
            // 
            // janelaTitulo
            // 
            this.janelaTitulo.AutoSize = true;
            this.janelaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelaTitulo.Location = new System.Drawing.Point(76, 23);
            this.janelaTitulo.Name = "janelaTitulo";
            this.janelaTitulo.Size = new System.Drawing.Size(78, 20);
            this.janelaTitulo.TabIndex = 13;
            this.janelaTitulo.Text = "Biblioteca";
            // 
            // panelObjectCatalogoEditar
            // 
            this.panelObjectCatalogoEditar.Location = new System.Drawing.Point(40, 182);
            this.panelObjectCatalogoEditar.Name = "panelObjectCatalogoEditar";
            this.panelObjectCatalogoEditar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectCatalogoEditar.TabIndex = 20;
            this.panelObjectCatalogoEditar.Text = "Editar";
            this.Ajuda.SetToolTip(this.panelObjectCatalogoEditar, "0");
            this.panelObjectCatalogoEditar.UseVisualStyleBackColor = true;
            this.panelObjectCatalogoEditar.Click += new System.EventHandler(this.panelObjectCatalogoEditar_Click);
            // 
            // panelObjectCatalogoEliminar
            // 
            this.panelObjectCatalogoEliminar.Location = new System.Drawing.Point(40, 218);
            this.panelObjectCatalogoEliminar.Name = "panelObjectCatalogoEliminar";
            this.panelObjectCatalogoEliminar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectCatalogoEliminar.TabIndex = 21;
            this.panelObjectCatalogoEliminar.Text = "Eliminar";
            this.Ajuda.SetToolTip(this.panelObjectCatalogoEliminar, "0");
            this.panelObjectCatalogoEliminar.UseVisualStyleBackColor = true;
            this.panelObjectCatalogoEliminar.Click += new System.EventHandler(this.panelObjectCatalogoEliminar_Click);
            // 
            // buttonAdicionarObjectCatalogo
            // 
            this.buttonAdicionarObjectCatalogo.Location = new System.Drawing.Point(97, 115);
            this.buttonAdicionarObjectCatalogo.Name = "buttonAdicionarObjectCatalogo";
            this.buttonAdicionarObjectCatalogo.Size = new System.Drawing.Size(22, 28);
            this.buttonAdicionarObjectCatalogo.TabIndex = 22;
            this.buttonAdicionarObjectCatalogo.Text = "+";
            this.Ajuda.SetToolTip(this.buttonAdicionarObjectCatalogo, "Adicionar livro novo");
            this.buttonAdicionarObjectCatalogo.UseVisualStyleBackColor = true;
            this.buttonAdicionarObjectCatalogo.Visible = false;
            this.buttonAdicionarObjectCatalogo.Click += new System.EventHandler(this.panelObjectCatalogoAdicionar_Click);
            // 
            // panelObjectCatalogoHide
            // 
            this.panelObjectCatalogoHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelObjectCatalogoHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelObjectCatalogoHide.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.panelObjectCatalogoHide.InitialImage = null;
            this.panelObjectCatalogoHide.Location = new System.Drawing.Point(131, 16);
            this.panelObjectCatalogoHide.Name = "panelObjectCatalogoHide";
            this.panelObjectCatalogoHide.Size = new System.Drawing.Size(14, 18);
            this.panelObjectCatalogoHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelObjectCatalogoHide.TabIndex = 23;
            this.panelObjectCatalogoHide.TabStop = false;
            this.Ajuda.SetToolTip(this.panelObjectCatalogoHide, "Esconder");
            this.panelObjectCatalogoHide.Click += new System.EventHandler(this.panelObjectCatalogoEsconder_Click);
            // 
            // panelFormCatalogoBotaoSubmeter
            // 
            this.panelFormCatalogoBotaoSubmeter.Location = new System.Drawing.Point(184, 218);
            this.panelFormCatalogoBotaoSubmeter.Name = "panelFormCatalogoBotaoSubmeter";
            this.panelFormCatalogoBotaoSubmeter.Size = new System.Drawing.Size(139, 23);
            this.panelFormCatalogoBotaoSubmeter.TabIndex = 25;
            this.panelFormCatalogoBotaoSubmeter.Text = "Botao";
            this.Ajuda.SetToolTip(this.panelFormCatalogoBotaoSubmeter, "0");
            this.panelFormCatalogoBotaoSubmeter.UseVisualStyleBackColor = true;
            this.panelFormCatalogoBotaoSubmeter.Click += new System.EventHandler(this.panelFormCatalogoSubmit_Click);
            // 
            // panelFormCatalogoHide
            // 
            this.panelFormCatalogoHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormCatalogoHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFormCatalogoHide.Image = global::Funcionarios.Properties.Resources.Esconder;
            this.panelFormCatalogoHide.InitialImage = null;
            this.panelFormCatalogoHide.Location = new System.Drawing.Point(292, 14);
            this.panelFormCatalogoHide.Name = "panelFormCatalogoHide";
            this.panelFormCatalogoHide.Size = new System.Drawing.Size(14, 18);
            this.panelFormCatalogoHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelFormCatalogoHide.TabIndex = 24;
            this.panelFormCatalogoHide.TabStop = false;
            this.Ajuda.SetToolTip(this.panelFormCatalogoHide, "Esconder");
            this.panelFormCatalogoHide.Click += new System.EventHandler(this.panelFormCatalogoHide_Click);
            // 
            // listCatalogo
            // 
            this.listCatalogo.AllColumns.Add(this.catalogoIDInterno);
            this.listCatalogo.AllColumns.Add(this.catalogoISBN);
            this.listCatalogo.AllColumns.Add(this.catalogoEstado);
            this.listCatalogo.AllColumns.Add(this.catalogoTitulo);
            this.listCatalogo.AllColumns.Add(this.catalogoAno);
            this.listCatalogo.AllColumns.Add(this.catalogoEditora);
            this.listCatalogo.AllColumns.Add(this.catalogoAutores);
            this.listCatalogo.CellEditUseWholeCell = false;
            this.listCatalogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.catalogoIDInterno,
            this.catalogoISBN,
            this.catalogoEstado,
            this.catalogoTitulo,
            this.catalogoAno,
            this.catalogoEditora,
            this.catalogoAutores});
            this.listCatalogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.listCatalogo.HideSelection = false;
            this.listCatalogo.Location = new System.Drawing.Point(22, 154);
            this.listCatalogo.Name = "listCatalogo";
            this.listCatalogo.Size = new System.Drawing.Size(509, 242);
            this.listCatalogo.TabIndex = 17;
            this.listCatalogo.UseCompatibleStateImageBehavior = false;
            this.listCatalogo.View = System.Windows.Forms.View.Details;
            this.listCatalogo.Visible = false;
            this.listCatalogo.SelectedIndexChanged += new System.EventHandler(this.funcionariosListView_SelectedIndexChanged);
            // 
            // catalogoIDInterno
            // 
            this.catalogoIDInterno.AspectName = "idinterno";
            this.catalogoIDInterno.Text = "ID";
            this.catalogoIDInterno.Width = 30;
            // 
            // catalogoISBN
            // 
            this.catalogoISBN.AspectName = "ISBN";
            this.catalogoISBN.Text = "ISBN";
            this.catalogoISBN.Width = 120;
            // 
            // catalogoEstado
            // 
            this.catalogoEstado.AspectName = "estado";
            this.catalogoEstado.Text = "Estado";
            this.catalogoEstado.Width = 80;
            // 
            // catalogoTitulo
            // 
            this.catalogoTitulo.AspectName = "titulo";
            this.catalogoTitulo.Text = "Título";
            this.catalogoTitulo.Width = 120;
            // 
            // catalogoAno
            // 
            this.catalogoAno.AspectName = "anoedicao";
            this.catalogoAno.AspectToStringFormat = "";
            this.catalogoAno.Text = "Ano Edição";
            this.catalogoAno.Width = 71;
            // 
            // catalogoEditora
            // 
            this.catalogoEditora.AspectName = "editora";
            this.catalogoEditora.Text = "Editora";
            this.catalogoEditora.Width = 104;
            // 
            // catalogoAutores
            // 
            this.catalogoAutores.AspectName = "autores";
            this.catalogoAutores.Text = "Autores";
            this.catalogoAutores.Width = 300;
            // 
            // panelObjectCatalogo
            // 
            this.panelObjectCatalogo.Controls.Add(this.panelObjectCatalogoHide);
            this.panelObjectCatalogo.Controls.Add(this.panelObjectCatalogoEliminar);
            this.panelObjectCatalogo.Controls.Add(this.panelObjectCatalogoEditar);
            this.panelObjectCatalogo.Controls.Add(this.panelObjectCatalogoSubtitulo);
            this.panelObjectCatalogo.Controls.Add(this.panelObjectCatalogoTitulo);
            this.panelObjectCatalogo.Controls.Add(this.panelObjectImage);
            this.panelObjectCatalogo.Location = new System.Drawing.Point(22, 422);
            this.panelObjectCatalogo.Name = "panelObjectCatalogo";
            this.panelObjectCatalogo.Size = new System.Drawing.Size(152, 257);
            this.panelObjectCatalogo.TabIndex = 19;
            this.panelObjectCatalogo.Visible = false;
            // 
            // panelObjectCatalogoSubtitulo
            // 
            this.panelObjectCatalogoSubtitulo.AutoSize = true;
            this.panelObjectCatalogoSubtitulo.Location = new System.Drawing.Point(55, 155);
            this.panelObjectCatalogoSubtitulo.Name = "panelObjectCatalogoSubtitulo";
            this.panelObjectCatalogoSubtitulo.Size = new System.Drawing.Size(42, 13);
            this.panelObjectCatalogoSubtitulo.TabIndex = 20;
            this.panelObjectCatalogoSubtitulo.Text = "XXXXX";
            this.panelObjectCatalogoSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObjectCatalogoTitulo
            // 
            this.panelObjectCatalogoTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelObjectCatalogoTitulo.AutoSize = true;
            this.panelObjectCatalogoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelObjectCatalogoTitulo.Location = new System.Drawing.Point(24, 121);
            this.panelObjectCatalogoTitulo.Name = "panelObjectCatalogoTitulo";
            this.panelObjectCatalogoTitulo.Size = new System.Drawing.Size(108, 20);
            this.panelObjectCatalogoTitulo.TabIndex = 20;
            this.panelObjectCatalogoTitulo.Text = "Nome Apelido";
            this.panelObjectCatalogoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObjectImage
            // 
            this.panelObjectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelObjectImage.Image = global::Funcionarios.Properties.Resources.Funcionario;
            this.panelObjectImage.InitialImage = null;
            this.panelObjectImage.Location = new System.Drawing.Point(40, 36);
            this.panelObjectImage.Name = "panelObjectImage";
            this.panelObjectImage.Size = new System.Drawing.Size(59, 68);
            this.panelObjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelObjectImage.TabIndex = 18;
            this.panelObjectImage.TabStop = false;
            // 
            // janelaLogo
            // 
            this.janelaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.janelaLogo.Image = global::Funcionarios.Properties.Resources.Biblioteca;
            this.janelaLogo.InitialImage = null;
            this.janelaLogo.Location = new System.Drawing.Point(22, 23);
            this.janelaLogo.Name = "janelaLogo";
            this.janelaLogo.Size = new System.Drawing.Size(39, 45);
            this.janelaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.janelaLogo.TabIndex = 14;
            this.janelaLogo.TabStop = false;
            // 
            // panelFormCatalogo
            // 
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoHide);
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoBotaoSubmeter);
            this.panelFormCatalogo.Controls.Add(this.label6);
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoFieldAutores);
            this.panelFormCatalogo.Controls.Add(this.label3);
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoFieldAnoEdicao);
            this.panelFormCatalogo.Controls.Add(this.label4);
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoFieldTitulo);
            this.panelFormCatalogo.Controls.Add(this.label2);
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoTitulo);
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoFieldEditora);
            this.panelFormCatalogo.Controls.Add(this.label1);
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoFieldISBN);
            this.panelFormCatalogo.Controls.Add(this.panelFormCatalogoSubtitulo);
            this.panelFormCatalogo.Location = new System.Drawing.Point(192, 422);
            this.panelFormCatalogo.Name = "panelFormCatalogo";
            this.panelFormCatalogo.Size = new System.Drawing.Size(339, 257);
            this.panelFormCatalogo.TabIndex = 24;
            this.panelFormCatalogo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Autores";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormCatalogoFieldAutores
            // 
            this.panelFormCatalogoFieldAutores.Location = new System.Drawing.Point(21, 185);
            this.panelFormCatalogoFieldAutores.Name = "panelFormCatalogoFieldAutores";
            this.panelFormCatalogoFieldAutores.Size = new System.Drawing.Size(302, 20);
            this.panelFormCatalogoFieldAutores.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ano de edição";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormCatalogoFieldAnoEdicao
            // 
            this.panelFormCatalogoFieldAnoEdicao.Location = new System.Drawing.Point(184, 134);
            this.panelFormCatalogoFieldAnoEdicao.Name = "panelFormCatalogoFieldAnoEdicao";
            this.panelFormCatalogoFieldAnoEdicao.Size = new System.Drawing.Size(139, 20);
            this.panelFormCatalogoFieldAnoEdicao.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Título";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormCatalogoFieldTitulo
            // 
            this.panelFormCatalogoFieldTitulo.Location = new System.Drawing.Point(184, 87);
            this.panelFormCatalogoFieldTitulo.Name = "panelFormCatalogoFieldTitulo";
            this.panelFormCatalogoFieldTitulo.Size = new System.Drawing.Size(139, 20);
            this.panelFormCatalogoFieldTitulo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Editora";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormCatalogoTitulo
            // 
            this.panelFormCatalogoTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFormCatalogoTitulo.AutoSize = true;
            this.panelFormCatalogoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormCatalogoTitulo.Location = new System.Drawing.Point(14, 16);
            this.panelFormCatalogoTitulo.Name = "panelFormCatalogoTitulo";
            this.panelFormCatalogoTitulo.Size = new System.Drawing.Size(47, 20);
            this.panelFormCatalogoTitulo.TabIndex = 24;
            this.panelFormCatalogoTitulo.Text = "Título";
            this.panelFormCatalogoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormCatalogoFieldEditora
            // 
            this.panelFormCatalogoFieldEditora.Location = new System.Drawing.Point(19, 134);
            this.panelFormCatalogoFieldEditora.Name = "panelFormCatalogoFieldEditora";
            this.panelFormCatalogoFieldEditora.Size = new System.Drawing.Size(139, 20);
            this.panelFormCatalogoFieldEditora.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ISBN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFormCatalogoFieldISBN
            // 
            this.panelFormCatalogoFieldISBN.Enabled = false;
            this.panelFormCatalogoFieldISBN.Location = new System.Drawing.Point(19, 87);
            this.panelFormCatalogoFieldISBN.Name = "panelFormCatalogoFieldISBN";
            this.panelFormCatalogoFieldISBN.Size = new System.Drawing.Size(139, 20);
            this.panelFormCatalogoFieldISBN.TabIndex = 25;
            // 
            // panelFormCatalogoSubtitulo
            // 
            this.panelFormCatalogoSubtitulo.AutoSize = true;
            this.panelFormCatalogoSubtitulo.Location = new System.Drawing.Point(18, 43);
            this.panelFormCatalogoSubtitulo.Name = "panelFormCatalogoSubtitulo";
            this.panelFormCatalogoSubtitulo.Size = new System.Drawing.Size(42, 13);
            this.panelFormCatalogoSubtitulo.TabIndex = 24;
            this.panelFormCatalogoSubtitulo.Text = "XXXXX";
            this.panelFormCatalogoSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pesquisaCatalogoTexto
            // 
            this.pesquisaCatalogoTexto.Location = new System.Drawing.Point(366, 120);
            this.pesquisaCatalogoTexto.Name = "pesquisaCatalogoTexto";
            this.pesquisaCatalogoTexto.Size = new System.Drawing.Size(165, 20);
            this.pesquisaCatalogoTexto.TabIndex = 25;
            this.pesquisaCatalogoTexto.Visible = false;
            this.pesquisaCatalogoTexto.TextChanged += new System.EventHandler(this.pesquisaCatalogoTexto_TextChanged);
            // 
            // pesquisaCatalogoLabel
            // 
            this.pesquisaCatalogoLabel.AutoSize = true;
            this.pesquisaCatalogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaCatalogoLabel.Location = new System.Drawing.Point(155, 127);
            this.pesquisaCatalogoLabel.Name = "pesquisaCatalogoLabel";
            this.pesquisaCatalogoLabel.Size = new System.Drawing.Size(50, 13);
            this.pesquisaCatalogoLabel.TabIndex = 26;
            this.pesquisaCatalogoLabel.Text = "Pesquisa";
            this.pesquisaCatalogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pesquisaCatalogoLabel.Visible = false;
            // 
            // pesquisaCatalogoSelect
            // 
            this.pesquisaCatalogoSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pesquisaCatalogoSelect.FormattingEnabled = true;
            this.pesquisaCatalogoSelect.Items.AddRange(new object[] {
            "ISBN",
            "Estado",
            "Título",
            "Ano edição",
            "Editora",
            "Autores"});
            this.pesquisaCatalogoSelect.Location = new System.Drawing.Point(211, 119);
            this.pesquisaCatalogoSelect.Name = "pesquisaCatalogoSelect";
            this.pesquisaCatalogoSelect.Size = new System.Drawing.Size(149, 21);
            this.pesquisaCatalogoSelect.TabIndex = 27;
            this.pesquisaCatalogoSelect.Visible = false;
            this.pesquisaCatalogoSelect.SelectedIndexChanged += new System.EventHandler(this.pesquisaCatalogoAtributo_SelectedIndexChanged);
            // 
            // escolhaBiblioteca
            // 
            this.escolhaBiblioteca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.escolhaBiblioteca.FormattingEnabled = true;
            this.escolhaBiblioteca.Location = new System.Drawing.Point(80, 47);
            this.escolhaBiblioteca.Name = "escolhaBiblioteca";
            this.escolhaBiblioteca.Size = new System.Drawing.Size(149, 21);
            this.escolhaBiblioteca.TabIndex = 29;
            this.escolhaBiblioteca.SelectedIndexChanged += new System.EventHandler(this.listCatalogo_SelectedIndexChanged);
            // 
            // catalogoTitle
            // 
            this.catalogoTitle.AutoSize = true;
            this.catalogoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogoTitle.Location = new System.Drawing.Point(18, 120);
            this.catalogoTitle.Name = "catalogoTitle";
            this.catalogoTitle.Size = new System.Drawing.Size(73, 20);
            this.catalogoTitle.TabIndex = 30;
            this.catalogoTitle.Text = "Catálogo";
            this.catalogoTitle.Visible = false;
            // 
            // Bibliotecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.catalogoTitle);
            this.Controls.Add(this.escolhaBiblioteca);
            this.Controls.Add(this.pesquisaCatalogoSelect);
            this.Controls.Add(this.pesquisaCatalogoLabel);
            this.Controls.Add(this.pesquisaCatalogoTexto);
            this.Controls.Add(this.panelFormCatalogo);
            this.Controls.Add(this.buttonAdicionarObjectCatalogo);
            this.Controls.Add(this.panelObjectCatalogo);
            this.Controls.Add(this.listCatalogo);
            this.Controls.Add(this.janelaSubtitulo);
            this.Controls.Add(this.janelaLogo);
            this.Controls.Add(this.janelaTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bibliotecas";
            this.Text = "Sistema de Gestão Escolar | Bibliotecas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Funcionarios_FormClosed);
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectCatalogoHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormCatalogoHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCatalogo)).EndInit();
            this.panelObjectCatalogo.ResumeLayout(false);
            this.panelObjectCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelaLogo)).EndInit();
            this.panelFormCatalogo.ResumeLayout(false);
            this.panelFormCatalogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label janelaSubtitulo;
        private System.Windows.Forms.PictureBox janelaLogo;
        private System.Windows.Forms.Label janelaTitulo;
        private System.Windows.Forms.ToolTip Ajuda;
        private BrightIdeasSoftware.ObjectListView listCatalogo;
        private BrightIdeasSoftware.OLVColumn catalogoIDInterno;
        private BrightIdeasSoftware.OLVColumn catalogoAno;
        private BrightIdeasSoftware.OLVColumn catalogoTitulo;
        private BrightIdeasSoftware.OLVColumn catalogoEditora;
        private BrightIdeasSoftware.OLVColumn catalogoEstado;
        private System.Windows.Forms.PictureBox panelObjectImage;
        private System.Windows.Forms.Panel panelObjectCatalogo;
        private System.Windows.Forms.Label panelObjectCatalogoTitulo;
        private System.Windows.Forms.Label panelObjectCatalogoSubtitulo;
        private System.Windows.Forms.Button panelObjectCatalogoEditar;
        private System.Windows.Forms.Button panelObjectCatalogoEliminar;
        private System.Windows.Forms.Button buttonAdicionarObjectCatalogo;
        private System.Windows.Forms.PictureBox panelObjectCatalogoHide;
        private System.Windows.Forms.Panel panelFormCatalogo;
        private System.Windows.Forms.Label panelFormCatalogoSubtitulo;
        private System.Windows.Forms.Label panelFormCatalogoTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox panelFormCatalogoFieldISBN;
        private System.Windows.Forms.Button panelFormCatalogoBotaoSubmeter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox panelFormCatalogoFieldAutores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox panelFormCatalogoFieldAnoEdicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox panelFormCatalogoFieldTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox panelFormCatalogoFieldEditora;
        private System.Windows.Forms.PictureBox panelFormCatalogoHide;
        private System.Windows.Forms.TextBox pesquisaCatalogoTexto;
        private System.Windows.Forms.Label pesquisaCatalogoLabel;
        private System.Windows.Forms.ComboBox pesquisaCatalogoSelect;
        private BrightIdeasSoftware.OLVColumn catalogoISBN;
        private System.Windows.Forms.ComboBox escolhaBiblioteca;
        private System.Windows.Forms.Label catalogoTitle;
        private BrightIdeasSoftware.OLVColumn catalogoAutores;
    }
}