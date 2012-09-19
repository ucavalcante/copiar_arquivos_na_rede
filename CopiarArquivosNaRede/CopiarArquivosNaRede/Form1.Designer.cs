namespace CopiarArquivosNaRede
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCopiar = new System.Windows.Forms.Button();
            this.btSelecionarPasta = new System.Windows.Forms.Button();
            this.listBoxArquivos = new System.Windows.Forms.ListBox();
            this.txtBoxPastaDeOrigem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckLstCPU = new System.Windows.Forms.CheckedListBox();
            this.ckLstSetores = new System.Windows.Forms.CheckedListBox();
            this.btRemoverMaquinas = new System.Windows.Forms.Button();
            this.btAdicionarMaquinas = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btCopiar);
            this.groupBox1.Controls.Add(this.btSelecionarPasta);
            this.groupBox1.Controls.Add(this.listBoxArquivos);
            this.groupBox1.Controls.Add(this.txtBoxPastaDeOrigem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos";
            // 
            // btCopiar
            // 
            this.btCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopiar.Location = new System.Drawing.Point(209, 19);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(75, 23);
            this.btCopiar.TabIndex = 8;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // btSelecionarPasta
            // 
            this.btSelecionarPasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelecionarPasta.Location = new System.Drawing.Point(128, 17);
            this.btSelecionarPasta.Name = "btSelecionarPasta";
            this.btSelecionarPasta.Size = new System.Drawing.Size(75, 23);
            this.btSelecionarPasta.TabIndex = 5;
            this.btSelecionarPasta.Text = "Pasta";
            this.btSelecionarPasta.UseVisualStyleBackColor = true;
            this.btSelecionarPasta.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxArquivos
            // 
            this.listBoxArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxArquivos.FormattingEnabled = true;
            this.listBoxArquivos.Location = new System.Drawing.Point(6, 66);
            this.listBoxArquivos.Name = "listBoxArquivos";
            this.listBoxArquivos.Size = new System.Drawing.Size(278, 186);
            this.listBoxArquivos.TabIndex = 4;
            // 
            // txtBoxPastaDeOrigem
            // 
            this.txtBoxPastaDeOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPastaDeOrigem.Location = new System.Drawing.Point(6, 19);
            this.txtBoxPastaDeOrigem.Name = "txtBoxPastaDeOrigem";
            this.txtBoxPastaDeOrigem.Size = new System.Drawing.Size(116, 20);
            this.txtBoxPastaDeOrigem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ckLstCPU);
            this.groupBox2.Controls.Add(this.ckLstSetores);
            this.groupBox2.Controls.Add(this.btRemoverMaquinas);
            this.groupBox2.Controls.Add(this.btAdicionarMaquinas);
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maquinas de Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(247, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Todas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(97, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Todas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maquinas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Setores";
            // 
            // ckLstCPU
            // 
            this.ckLstCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ckLstCPU.FormattingEnabled = true;
            this.ckLstCPU.Location = new System.Drawing.Point(146, 68);
            this.ckLstCPU.Name = "ckLstCPU";
            this.ckLstCPU.Size = new System.Drawing.Size(138, 184);
            this.ckLstCPU.TabIndex = 6;
            // 
            // ckLstSetores
            // 
            this.ckLstSetores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ckLstSetores.FormattingEnabled = true;
            this.ckLstSetores.Location = new System.Drawing.Point(6, 68);
            this.ckLstSetores.Name = "ckLstSetores";
            this.ckLstSetores.Size = new System.Drawing.Size(134, 184);
            this.ckLstSetores.TabIndex = 5;
            this.ckLstSetores.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckLstSetores_ItemCheck);
            // 
            // btRemoverMaquinas
            // 
            this.btRemoverMaquinas.Location = new System.Drawing.Point(146, 19);
            this.btRemoverMaquinas.Name = "btRemoverMaquinas";
            this.btRemoverMaquinas.Size = new System.Drawing.Size(138, 23);
            this.btRemoverMaquinas.TabIndex = 4;
            this.btRemoverMaquinas.Text = "Remover Selecionada";
            this.btRemoverMaquinas.UseVisualStyleBackColor = true;
            this.btRemoverMaquinas.Click += new System.EventHandler(this.btRemoverMaquinas_Click);
            // 
            // btAdicionarMaquinas
            // 
            this.btAdicionarMaquinas.Location = new System.Drawing.Point(6, 19);
            this.btAdicionarMaquinas.Name = "btAdicionarMaquinas";
            this.btAdicionarMaquinas.Size = new System.Drawing.Size(134, 23);
            this.btAdicionarMaquinas.TabIndex = 2;
            this.btAdicionarMaquinas.Text = "Adicionar Maquina";
            this.btAdicionarMaquinas.UseVisualStyleBackColor = true;
            this.btAdicionarMaquinas.Click += new System.EventHandler(this.btAdicionarMaquinas_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Sobrescrever Arquivos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(174, 283);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Administrador Global";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(490, 284);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ulisses Cavalcante";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(322, 283);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 312);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(640, 320);
            this.Name = "Form1";
            this.Text = "Copiar Arquivos pela Rede";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxPastaDeOrigem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btRemoverMaquinas;
        private System.Windows.Forms.Button btAdicionarMaquinas;
        private System.Windows.Forms.ListBox listBoxArquivos;
        private System.Windows.Forms.Button btSelecionarPasta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ckLstCPU;
        private System.Windows.Forms.CheckedListBox ckLstSetores;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

