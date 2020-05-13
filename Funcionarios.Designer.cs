namespace Funcionarios
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.stats = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.Ajuda = new System.Windows.Forms.ToolTip(this.components);
            this.ajudaBtn = new System.Windows.Forms.PictureBox();
            this.panelObjectEditar = new System.Windows.Forms.Button();
            this.panelObjectEliminar = new System.Windows.Forms.Button();
            this.buttonAdicionarObject = new System.Windows.Forms.Button();
            this.funcionariosListView = new BrightIdeasSoftware.ObjectListView();
            this.nmec = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.salario = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nome = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelObject = new System.Windows.Forms.Panel();
            this.panelObjectSubtitulo = new System.Windows.Forms.Label();
            this.panelObjectTitulo = new System.Windows.Forms.Label();
            this.panelObjectImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosListView)).BeginInit();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stats
            // 
            this.stats.AutoSize = true;
            this.stats.Location = new System.Drawing.Point(80, 54);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(100, 13);
            this.stats.TabIndex = 15;
            this.stats.Text = "A mostrar X registos";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(76, 23);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(100, 20);
            this.titulo.TabIndex = 13;
            this.titulo.Text = "Funcionários";
            // 
            // ajudaBtn
            // 
            this.ajudaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ajudaBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.ajudaBtn.Image = global::Funcionarios.Properties.Resources.Ajuda;
            this.ajudaBtn.InitialImage = null;
            this.ajudaBtn.Location = new System.Drawing.Point(742, 23);
            this.ajudaBtn.Name = "ajudaBtn";
            this.ajudaBtn.Size = new System.Drawing.Size(30, 30);
            this.ajudaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajudaBtn.TabIndex = 16;
            this.ajudaBtn.TabStop = false;
            this.Ajuda.SetToolTip(this.ajudaBtn, resources.GetString("ajudaBtn.ToolTip"));
            // 
            // panelObjectEditar
            // 
            this.panelObjectEditar.Location = new System.Drawing.Point(40, 181);
            this.panelObjectEditar.Name = "panelObjectEditar";
            this.panelObjectEditar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectEditar.TabIndex = 20;
            this.panelObjectEditar.Text = "Editar";
            this.Ajuda.SetToolTip(this.panelObjectEditar, "0");
            this.panelObjectEditar.UseVisualStyleBackColor = true;
            // 
            // panelObjectEliminar
            // 
            this.panelObjectEliminar.Location = new System.Drawing.Point(40, 223);
            this.panelObjectEliminar.Name = "panelObjectEliminar";
            this.panelObjectEliminar.Size = new System.Drawing.Size(75, 23);
            this.panelObjectEliminar.TabIndex = 21;
            this.panelObjectEliminar.Text = "Eliminar";
            this.Ajuda.SetToolTip(this.panelObjectEliminar, "0");
            this.panelObjectEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarObject
            // 
            this.buttonAdicionarObject.Location = new System.Drawing.Point(645, 427);
            this.buttonAdicionarObject.Name = "buttonAdicionarObject";
            this.buttonAdicionarObject.Size = new System.Drawing.Size(112, 23);
            this.buttonAdicionarObject.TabIndex = 22;
            this.buttonAdicionarObject.Text = "Adicionar novo";
            this.Ajuda.SetToolTip(this.buttonAdicionarObject, "0");
            this.buttonAdicionarObject.UseVisualStyleBackColor = true;
            // 
            // funcionariosListView
            // 
            this.funcionariosListView.AllColumns.Add(this.nmec);
            this.funcionariosListView.AllColumns.Add(this.salario);
            this.funcionariosListView.AllColumns.Add(this.nome);
            this.funcionariosListView.AllColumns.Add(this.tel);
            this.funcionariosListView.AllColumns.Add(this.email);
            this.funcionariosListView.CellEditUseWholeCell = false;
            this.funcionariosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nmec,
            this.salario,
            this.nome,
            this.tel,
            this.email});
            this.funcionariosListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.funcionariosListView.HideSelection = false;
            this.funcionariosListView.Location = new System.Drawing.Point(22, 114);
            this.funcionariosListView.Name = "funcionariosListView";
            this.funcionariosListView.Size = new System.Drawing.Size(580, 336);
            this.funcionariosListView.TabIndex = 17;
            this.funcionariosListView.UseCompatibleStateImageBehavior = false;
            this.funcionariosListView.View = System.Windows.Forms.View.Details;
            this.funcionariosListView.SelectedIndexChanged += new System.EventHandler(this.funcionariosListView_SelectedIndexChanged);
            // 
            // nmec
            // 
            this.nmec.AspectName = "nmec";
            this.nmec.Text = "NMec";
            this.nmec.Width = 77;
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
            this.panelObject.Controls.Add(this.panelObjectEliminar);
            this.panelObject.Controls.Add(this.panelObjectEditar);
            this.panelObject.Controls.Add(this.panelObjectSubtitulo);
            this.panelObject.Controls.Add(this.panelObjectTitulo);
            this.panelObject.Controls.Add(this.panelObjectImage);
            this.panelObject.Location = new System.Drawing.Point(620, 114);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(152, 267);
            this.panelObject.TabIndex = 19;
            this.panelObject.Visible = false;
            // 
            // panelObjectSubtitulo
            // 
            this.panelObjectSubtitulo.AutoSize = true;
            this.panelObjectSubtitulo.Location = new System.Drawing.Point(54, 129);
            this.panelObjectSubtitulo.Name = "panelObjectSubtitulo";
            this.panelObjectSubtitulo.Size = new System.Drawing.Size(42, 13);
            this.panelObjectSubtitulo.TabIndex = 20;
            this.panelObjectSubtitulo.Text = "XXXXX";
            // 
            // panelObjectTitulo
            // 
            this.panelObjectTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelObjectTitulo.AutoSize = true;
            this.panelObjectTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelObjectTitulo.Location = new System.Drawing.Point(21, 100);
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
            this.panelObjectImage.Location = new System.Drawing.Point(46, 16);
            this.panelObjectImage.Name = "panelObjectImage";
            this.panelObjectImage.Size = new System.Drawing.Size(59, 68);
            this.panelObjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelObjectImage.TabIndex = 18;
            this.panelObjectImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Funcionarios.Properties.Resources.Funcionários;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.buttonAdicionarObject);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.funcionariosListView);
            this.Controls.Add(this.ajudaBtn);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionarios";
            this.Text = "Sistema de Gestão Escolar | Funcionários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Funcionarios_FormClosed);
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajudaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosListView)).EndInit();
            this.panelObject.ResumeLayout(false);
            this.panelObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelObjectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ajudaBtn;
        private System.Windows.Forms.Label stats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ToolTip Ajuda;
        private BrightIdeasSoftware.ObjectListView funcionariosListView;
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
    }
}