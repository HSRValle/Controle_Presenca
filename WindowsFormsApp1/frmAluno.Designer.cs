﻿namespace WindowsFormsApp1
{
    partial class frmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.presençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarHistóricoDePresençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.btnMudarSenha = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlPresenca = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlJustificativa = new System.Windows.Forms.Panel();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.nudIdData = new System.Windows.Forms.NumericUpDown();
            this.btnSalvarJust = new System.Windows.Forms.Button();
            this.txtJustificativa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.pnlCorrecao = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.btnLimparEdicao = new System.Windows.Forms.Button();
            this.btnSalvarEditar = new System.Windows.Forms.Button();
            this.txtEmailEditar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNomeEditar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlMudarSenha.SuspendLayout();
            this.pnlPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlJustificativa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdData)).BeginInit();
            this.pnlCorrecao.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presençaToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // presençaToolStripMenuItem
            // 
            this.presençaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarHistóricoDePresençaToolStripMenuItem});
            this.presençaToolStripMenuItem.Name = "presençaToolStripMenuItem";
            this.presençaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.presençaToolStripMenuItem.Text = "Presença";
            // 
            // consultarHistóricoDePresençaToolStripMenuItem
            // 
            this.consultarHistóricoDePresençaToolStripMenuItem.Name = "consultarHistóricoDePresençaToolStripMenuItem";
            this.consultarHistóricoDePresençaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.consultarHistóricoDePresençaToolStripMenuItem.Text = "Consultar Histórico de Presença";
            this.consultarHistóricoDePresençaToolStripMenuItem.Click += new System.EventHandler(this.consultarHistóricoDePresençaToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCadastroToolStripMenuItem,
            this.mudarSenhaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // consultarCadastroToolStripMenuItem
            // 
            this.consultarCadastroToolStripMenuItem.Name = "consultarCadastroToolStripMenuItem";
            this.consultarCadastroToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultarCadastroToolStripMenuItem.Text = "Consultar Cadastro";
            this.consultarCadastroToolStripMenuItem.Click += new System.EventHandler(this.consultarCadastroToolStripMenuItem_Click);
            // 
            // mudarSenhaToolStripMenuItem
            // 
            this.mudarSenhaToolStripMenuItem.Name = "mudarSenhaToolStripMenuItem";
            this.mudarSenhaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mudarSenhaToolStripMenuItem.Text = "Mudar Senha";
            this.mudarSenhaToolStripMenuItem.Click += new System.EventHandler(this.mudarSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.Controls.Add(this.txtConfSenha);
            this.pnlMudarSenha.Controls.Add(this.txtNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.txtSenhaAntiga);
            this.pnlMudarSenha.Controls.Add(this.btnMudarSenha);
            this.pnlMudarSenha.Controls.Add(this.lblErro);
            this.pnlMudarSenha.Controls.Add(this.label11);
            this.pnlMudarSenha.Controls.Add(this.label12);
            this.pnlMudarSenha.Controls.Add(this.label13);
            this.pnlMudarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMudarSenha.Location = new System.Drawing.Point(0, 0);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(729, 354);
            this.pnlMudarSenha.TabIndex = 9;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(331, 183);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '•';
            this.txtConfSenha.Size = new System.Drawing.Size(134, 20);
            this.txtConfSenha.TabIndex = 15;
            this.txtConfSenha.TextChanged += new System.EventHandler(this.txtConfSenha_TextChanged);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(331, 149);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '•';
            this.txtNovaSenha.Size = new System.Drawing.Size(134, 20);
            this.txtNovaSenha.TabIndex = 14;
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Location = new System.Drawing.Point(331, 111);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.PasswordChar = '•';
            this.txtSenhaAntiga.Size = new System.Drawing.Size(134, 20);
            this.txtSenhaAntiga.TabIndex = 13;
            // 
            // btnMudarSenha
            // 
            this.btnMudarSenha.Location = new System.Drawing.Point(331, 245);
            this.btnMudarSenha.Name = "btnMudarSenha";
            this.btnMudarSenha.Size = new System.Drawing.Size(75, 23);
            this.btnMudarSenha.TabIndex = 12;
            this.btnMudarSenha.Text = "Salvar";
            this.btnMudarSenha.UseVisualStyleBackColor = true;
            this.btnMudarSenha.Click += new System.EventHandler(this.btnMudarSenha_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(331, 217);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Confirmar senha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nova senha:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Senha:";
            // 
            // pnlPresenca
            // 
            this.pnlPresenca.Controls.Add(this.dataGridView);
            this.pnlPresenca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPresenca.Location = new System.Drawing.Point(0, 0);
            this.pnlPresenca.Name = "pnlPresenca";
            this.pnlPresenca.Size = new System.Drawing.Size(729, 354);
            this.pnlPresenca.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(46, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(636, 258);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // pnlJustificativa
            // 
            this.pnlJustificativa.Controls.Add(this.dateTimePickerTime);
            this.pnlJustificativa.Controls.Add(this.nudIdData);
            this.pnlJustificativa.Controls.Add(this.btnSalvarJust);
            this.pnlJustificativa.Controls.Add(this.txtJustificativa);
            this.pnlJustificativa.Controls.Add(this.label2);
            this.pnlJustificativa.Controls.Add(this.label1);
            this.pnlJustificativa.Controls.Add(this.dateTimePickerDate);
            this.pnlJustificativa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJustificativa.Location = new System.Drawing.Point(0, 0);
            this.pnlJustificativa.Name = "pnlJustificativa";
            this.pnlJustificativa.Size = new System.Drawing.Size(729, 354);
            this.pnlJustificativa.TabIndex = 11;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(442, 59);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerTime.TabIndex = 9;
            // 
            // nudIdData
            // 
            this.nudIdData.Location = new System.Drawing.Point(316, 322);
            this.nudIdData.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudIdData.Name = "nudIdData";
            this.nudIdData.Size = new System.Drawing.Size(120, 20);
            this.nudIdData.TabIndex = 6;
            this.nudIdData.Visible = false;
            // 
            // btnSalvarJust
            // 
            this.btnSalvarJust.Location = new System.Drawing.Point(334, 251);
            this.btnSalvarJust.Name = "btnSalvarJust";
            this.btnSalvarJust.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarJust.TabIndex = 5;
            this.btnSalvarJust.Text = "Enviar";
            this.btnSalvarJust.UseVisualStyleBackColor = true;
            this.btnSalvarJust.Click += new System.EventHandler(this.btnSalvarJust_Click);
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Location = new System.Drawing.Point(231, 125);
            this.txtJustificativa.Multiline = true;
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Size = new System.Drawing.Size(290, 87);
            this.txtJustificativa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Justificativa:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(231, 59);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // pnlCorrecao
            // 
            this.pnlCorrecao.Controls.Add(this.btnEnviar);
            this.pnlCorrecao.Controls.Add(this.textBox2);
            this.pnlCorrecao.Controls.Add(this.label4);
            this.pnlCorrecao.Controls.Add(this.label3);
            this.pnlCorrecao.Controls.Add(this.dateTimePicker2);
            this.pnlCorrecao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorrecao.Location = new System.Drawing.Point(0, 0);
            this.pnlCorrecao.Name = "pnlCorrecao";
            this.pnlCorrecao.Size = new System.Drawing.Size(729, 354);
            this.pnlCorrecao.TabIndex = 12;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(407, 192);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(247, 136);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 42);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correção a ser feita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dia:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(247, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(235, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.btnLimparEdicao);
            this.pnlCadastro.Controls.Add(this.btnSalvarEditar);
            this.pnlCadastro.Controls.Add(this.txtEmailEditar);
            this.pnlCadastro.Controls.Add(this.label14);
            this.pnlCadastro.Controls.Add(this.txtNomeEditar);
            this.pnlCadastro.Controls.Add(this.label17);
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastro.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(729, 354);
            this.pnlCadastro.TabIndex = 13;
            // 
            // btnLimparEdicao
            // 
            this.btnLimparEdicao.Location = new System.Drawing.Point(418, 216);
            this.btnLimparEdicao.Name = "btnLimparEdicao";
            this.btnLimparEdicao.Size = new System.Drawing.Size(75, 23);
            this.btnLimparEdicao.TabIndex = 46;
            this.btnLimparEdicao.Text = "Limpar";
            this.btnLimparEdicao.UseVisualStyleBackColor = true;
            this.btnLimparEdicao.Click += new System.EventHandler(this.btnLimparEdicao_Click);
            // 
            // btnSalvarEditar
            // 
            this.btnSalvarEditar.Location = new System.Drawing.Point(260, 216);
            this.btnSalvarEditar.Name = "btnSalvarEditar";
            this.btnSalvarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEditar.TabIndex = 45;
            this.btnSalvarEditar.Text = "Salvar";
            this.btnSalvarEditar.UseVisualStyleBackColor = true;
            this.btnSalvarEditar.Click += new System.EventHandler(this.btnSalvarEditar_Click);
            // 
            // txtEmailEditar
            // 
            this.txtEmailEditar.Location = new System.Drawing.Point(310, 149);
            this.txtEmailEditar.Name = "txtEmailEditar";
            this.txtEmailEditar.Size = new System.Drawing.Size(172, 20);
            this.txtEmailEditar.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "E-mail:";
            // 
            // txtNomeEditar
            // 
            this.txtNomeEditar.Location = new System.Drawing.Point(310, 108);
            this.txtNomeEditar.Name = "txtNomeEditar";
            this.txtNomeEditar.Size = new System.Drawing.Size(172, 20);
            this.txtNomeEditar.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(244, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Nome:";
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 354);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlPresenca);
            this.Controls.Add(this.pnlJustificativa);
            this.Controls.Add(this.pnlCorrecao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAluno";
            this.Text = "Specialisterne - Consultor";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.pnlPresenca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlJustificativa.ResumeLayout(false);
            this.pnlJustificativa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdData)).EndInit();
            this.pnlCorrecao.ResumeLayout(false);
            this.pnlCorrecao.PerformLayout();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem presençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudarSenhaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtSenhaAntiga;
        private System.Windows.Forms.Button btnMudarSenha;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPresenca;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel pnlJustificativa;
        private System.Windows.Forms.Button btnSalvarJust;
        private System.Windows.Forms.TextBox txtJustificativa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Panel pnlCorrecao;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown nudIdData;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Button btnLimparEdicao;
        private System.Windows.Forms.Button btnSalvarEditar;
        private System.Windows.Forms.TextBox txtEmailEditar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNomeEditar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem consultarHistóricoDePresençaToolStripMenuItem;
    }
}