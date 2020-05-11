namespace Funcionarios
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.title = new System.Windows.Forms.Label();
            this.statsGroup = new System.Windows.Forms.GroupBox();
            this.statsFuncionarios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statsFuncionariosLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuGroup = new System.Windows.Forms.GroupBox();
            this.menuFuncionariosPanel = new System.Windows.Forms.Panel();
            this.menuFuncionariosLabel = new System.Windows.Forms.Label();
            this.menuFuncionariosImagem = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statsGroup.SuspendLayout();
            this.statsFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuGroup.SuspendLayout();
            this.menuFuncionariosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuFuncionariosImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(85, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(367, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Sistema de Gestão Escolar";
            // 
            // statsGroup
            // 
            this.statsGroup.Controls.Add(this.statsFuncionarios);
            this.statsGroup.Location = new System.Drawing.Point(25, 105);
            this.statsGroup.Name = "statsGroup";
            this.statsGroup.Size = new System.Drawing.Size(752, 120);
            this.statsGroup.TabIndex = 2;
            this.statsGroup.TabStop = false;
            this.statsGroup.Text = "Estatísticas";
            // 
            // statsFuncionarios
            // 
            this.statsFuncionarios.BackColor = System.Drawing.SystemColors.Window;
            this.statsFuncionarios.Controls.Add(this.label1);
            this.statsFuncionarios.Controls.Add(this.statsFuncionariosLabel);
            this.statsFuncionarios.Controls.Add(this.pictureBox1);
            this.statsFuncionarios.Location = new System.Drawing.Point(20, 30);
            this.statsFuncionarios.Name = "statsFuncionarios";
            this.statsFuncionarios.Size = new System.Drawing.Size(135, 74);
            this.statsFuncionarios.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Funcionários";
            // 
            // statsFuncionariosLabel
            // 
            this.statsFuncionariosLabel.AutoSize = true;
            this.statsFuncionariosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsFuncionariosLabel.Location = new System.Drawing.Point(59, 14);
            this.statsFuncionariosLabel.Name = "statsFuncionariosLabel";
            this.statsFuncionariosLabel.Size = new System.Drawing.Size(42, 26);
            this.statsFuncionariosLabel.TabIndex = 8;
            this.statsFuncionariosLabel.Text = "XX";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Funcionarios.Properties.Resources.Funcionários;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // menuGroup
            // 
            this.menuGroup.Controls.Add(this.menuFuncionariosPanel);
            this.menuGroup.Location = new System.Drawing.Point(25, 231);
            this.menuGroup.Name = "menuGroup";
            this.menuGroup.Size = new System.Drawing.Size(752, 207);
            this.menuGroup.TabIndex = 4;
            this.menuGroup.TabStop = false;
            this.menuGroup.Text = "Menu";
            // 
            // menuFuncionariosPanel
            // 
            this.menuFuncionariosPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuFuncionariosPanel.Controls.Add(this.menuFuncionariosLabel);
            this.menuFuncionariosPanel.Controls.Add(this.menuFuncionariosImagem);
            this.menuFuncionariosPanel.Location = new System.Drawing.Point(20, 31);
            this.menuFuncionariosPanel.Name = "menuFuncionariosPanel";
            this.menuFuncionariosPanel.Size = new System.Drawing.Size(101, 106);
            this.menuFuncionariosPanel.TabIndex = 5;
            this.menuFuncionariosPanel.Click += new System.EventHandler(this.menuFuncionariosPanel_Click);
            // 
            // menuFuncionariosLabel
            // 
            this.menuFuncionariosLabel.AutoSize = true;
            this.menuFuncionariosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFuncionariosLabel.Location = new System.Drawing.Point(9, 77);
            this.menuFuncionariosLabel.Name = "menuFuncionariosLabel";
            this.menuFuncionariosLabel.Size = new System.Drawing.Size(89, 17);
            this.menuFuncionariosLabel.TabIndex = 7;
            this.menuFuncionariosLabel.Text = "Funcionários";
            this.menuFuncionariosLabel.Click += new System.EventHandler(this.menuFuncionariosPanel_Click);
            // 
            // menuFuncionariosImagem
            // 
            this.menuFuncionariosImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuFuncionariosImagem.Image = global::Funcionarios.Properties.Resources.Funcionários;
            this.menuFuncionariosImagem.InitialImage = null;
            this.menuFuncionariosImagem.Location = new System.Drawing.Point(28, 17);
            this.menuFuncionariosImagem.Name = "menuFuncionariosImagem";
            this.menuFuncionariosImagem.Size = new System.Drawing.Size(44, 52);
            this.menuFuncionariosImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuFuncionariosImagem.TabIndex = 5;
            this.menuFuncionariosImagem.TabStop = false;
            this.menuFuncionariosImagem.Click += new System.EventHandler(this.menuFuncionariosPanel_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::Funcionarios.Properties.Resources.Livro;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(25, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(44, 52);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "© Gonçalo matos (92972) e Maria Inês (93320) 2020";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuGroup);
            this.Controls.Add(this.statsGroup);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Sistema de Gestão Escolar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statsGroup.ResumeLayout(false);
            this.statsFuncionarios.ResumeLayout(false);
            this.statsFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuGroup.ResumeLayout(false);
            this.menuFuncionariosPanel.ResumeLayout(false);
            this.menuFuncionariosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuFuncionariosImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox statsGroup;
        private System.Windows.Forms.GroupBox menuGroup;
        private System.Windows.Forms.PictureBox menuFuncionariosImagem;
        private System.Windows.Forms.Panel menuFuncionariosPanel;
        private System.Windows.Forms.Label menuFuncionariosLabel;
        private System.Windows.Forms.Label statsFuncionariosLabel;
        private System.Windows.Forms.Panel statsFuncionarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

