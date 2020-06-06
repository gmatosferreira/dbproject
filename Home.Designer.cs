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
            this.statsNaoDocentes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statsNaoDocentesLabel = new System.Windows.Forms.Label();
            this.menuGroup = new System.Windows.Forms.GroupBox();
            this.menuNaoDocentesPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuDocentesPanel = new System.Windows.Forms.Panel();
            this.menuDocentesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuDocentesImagem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.statsDocentesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statsDocentes = new System.Windows.Forms.Panel();
            this.statsGroup.SuspendLayout();
            this.statsNaoDocentes.SuspendLayout();
            this.menuGroup.SuspendLayout();
            this.menuNaoDocentesPanel.SuspendLayout();
            this.menuDocentesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDocentesImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.statsDocentes.SuspendLayout();
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
            this.statsGroup.Controls.Add(this.statsDocentes);
            this.statsGroup.Controls.Add(this.statsNaoDocentes);
            this.statsGroup.Location = new System.Drawing.Point(25, 105);
            this.statsGroup.Name = "statsGroup";
            this.statsGroup.Size = new System.Drawing.Size(752, 120);
            this.statsGroup.TabIndex = 2;
            this.statsGroup.TabStop = false;
            this.statsGroup.Text = "Estatísticas";
            // 
            // statsNaoDocentes
            // 
            this.statsNaoDocentes.BackColor = System.Drawing.SystemColors.Window;
            this.statsNaoDocentes.Controls.Add(this.label1);
            this.statsNaoDocentes.Controls.Add(this.statsNaoDocentesLabel);
            this.statsNaoDocentes.Controls.Add(this.pictureBox1);
            this.statsNaoDocentes.Location = new System.Drawing.Point(177, 30);
            this.statsNaoDocentes.Name = "statsNaoDocentes";
            this.statsNaoDocentes.Size = new System.Drawing.Size(135, 74);
            this.statsNaoDocentes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Não docentes";
            // 
            // statsNaoDocentesLabel
            // 
            this.statsNaoDocentesLabel.AutoSize = true;
            this.statsNaoDocentesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsNaoDocentesLabel.Location = new System.Drawing.Point(59, 14);
            this.statsNaoDocentesLabel.Name = "statsNaoDocentesLabel";
            this.statsNaoDocentesLabel.Size = new System.Drawing.Size(42, 26);
            this.statsNaoDocentesLabel.TabIndex = 8;
            this.statsNaoDocentesLabel.Text = "XX";
            // 
            // menuGroup
            // 
            this.menuGroup.Controls.Add(this.menuNaoDocentesPanel);
            this.menuGroup.Controls.Add(this.menuDocentesPanel);
            this.menuGroup.Location = new System.Drawing.Point(25, 231);
            this.menuGroup.Name = "menuGroup";
            this.menuGroup.Size = new System.Drawing.Size(752, 207);
            this.menuGroup.TabIndex = 4;
            this.menuGroup.TabStop = false;
            this.menuGroup.Text = "Menu";
            // 
            // menuNaoDocentesPanel
            // 
            this.menuNaoDocentesPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuNaoDocentesPanel.Controls.Add(this.label3);
            this.menuNaoDocentesPanel.Controls.Add(this.pictureBox2);
            this.menuNaoDocentesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuNaoDocentesPanel.Location = new System.Drawing.Point(139, 31);
            this.menuNaoDocentesPanel.Name = "menuNaoDocentesPanel";
            this.menuNaoDocentesPanel.Size = new System.Drawing.Size(101, 106);
            this.menuNaoDocentesPanel.TabIndex = 8;
            this.menuNaoDocentesPanel.Click += new System.EventHandler(this.menuNaoDocentesPanel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Não docentes";
            // 
            // menuDocentesPanel
            // 
            this.menuDocentesPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuDocentesPanel.Controls.Add(this.menuDocentesLabel);
            this.menuDocentesPanel.Controls.Add(this.menuDocentesImagem);
            this.menuDocentesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuDocentesPanel.Location = new System.Drawing.Point(20, 31);
            this.menuDocentesPanel.Name = "menuDocentesPanel";
            this.menuDocentesPanel.Size = new System.Drawing.Size(101, 106);
            this.menuDocentesPanel.TabIndex = 5;
            this.menuDocentesPanel.Click += new System.EventHandler(this.menuFuncionariosPanel_Click);
            // 
            // menuDocentesLabel
            // 
            this.menuDocentesLabel.AutoSize = true;
            this.menuDocentesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDocentesLabel.Location = new System.Drawing.Point(17, 80);
            this.menuDocentesLabel.Name = "menuDocentesLabel";
            this.menuDocentesLabel.Size = new System.Drawing.Size(68, 17);
            this.menuDocentesLabel.TabIndex = 7;
            this.menuDocentesLabel.Text = "Docentes";
            this.menuDocentesLabel.Click += new System.EventHandler(this.menuFuncionariosPanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "© Gonçalo matos (92972) e Maria Inês (93320) 2020";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Funcionarios.Properties.Resources.Funcionários;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(28, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // menuDocentesImagem
            // 
            this.menuDocentesImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuDocentesImagem.Image = global::Funcionarios.Properties.Resources.Docentes;
            this.menuDocentesImagem.InitialImage = null;
            this.menuDocentesImagem.Location = new System.Drawing.Point(28, 17);
            this.menuDocentesImagem.Name = "menuDocentesImagem";
            this.menuDocentesImagem.Size = new System.Drawing.Size(44, 52);
            this.menuDocentesImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuDocentesImagem.TabIndex = 5;
            this.menuDocentesImagem.TabStop = false;
            this.menuDocentesImagem.Click += new System.EventHandler(this.menuFuncionariosPanel_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Funcionarios.Properties.Resources.Docentes;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(14, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // statsDocentesLabel
            // 
            this.statsDocentesLabel.AutoSize = true;
            this.statsDocentesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsDocentesLabel.Location = new System.Drawing.Point(59, 14);
            this.statsDocentesLabel.Name = "statsDocentesLabel";
            this.statsDocentesLabel.Size = new System.Drawing.Size(42, 26);
            this.statsDocentesLabel.TabIndex = 8;
            this.statsDocentesLabel.Text = "XX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Docentes";
            // 
            // statsDocentes
            // 
            this.statsDocentes.BackColor = System.Drawing.SystemColors.Window;
            this.statsDocentes.Controls.Add(this.label4);
            this.statsDocentes.Controls.Add(this.statsDocentesLabel);
            this.statsDocentes.Controls.Add(this.pictureBox3);
            this.statsDocentes.Location = new System.Drawing.Point(20, 30);
            this.statsDocentes.Name = "statsDocentes";
            this.statsDocentes.Size = new System.Drawing.Size(135, 74);
            this.statsDocentes.TabIndex = 9;
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
            this.statsNaoDocentes.ResumeLayout(false);
            this.statsNaoDocentes.PerformLayout();
            this.menuGroup.ResumeLayout(false);
            this.menuNaoDocentesPanel.ResumeLayout(false);
            this.menuNaoDocentesPanel.PerformLayout();
            this.menuDocentesPanel.ResumeLayout(false);
            this.menuDocentesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDocentesImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.statsDocentes.ResumeLayout(false);
            this.statsDocentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox statsGroup;
        private System.Windows.Forms.GroupBox menuGroup;
        private System.Windows.Forms.PictureBox menuDocentesImagem;
        private System.Windows.Forms.Panel menuDocentesPanel;
        private System.Windows.Forms.Label menuDocentesLabel;
        private System.Windows.Forms.Label statsNaoDocentesLabel;
        private System.Windows.Forms.Panel statsNaoDocentes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel menuNaoDocentesPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel statsDocentes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label statsDocentesLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

