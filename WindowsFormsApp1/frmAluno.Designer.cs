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
            this.justificarAusênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarCorreçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlMudarSenha.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // presençaToolStripMenuItem
            // 
            this.presençaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarHistóricoDePresençaToolStripMenuItem,
            this.justificarAusênciaToolStripMenuItem,
            this.solicitarCorreçãoToolStripMenuItem});
            this.presençaToolStripMenuItem.Name = "presençaToolStripMenuItem";
            this.presençaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.presençaToolStripMenuItem.Text = "Presença";
            // 
            // consultarHistóricoDePresençaToolStripMenuItem
            // 
            this.consultarHistóricoDePresençaToolStripMenuItem.Name = "consultarHistóricoDePresençaToolStripMenuItem";
            this.consultarHistóricoDePresençaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.consultarHistóricoDePresençaToolStripMenuItem.Text = "Consultar Histórico de Presença";
            // 
            // justificarAusênciaToolStripMenuItem
            // 
            this.justificarAusênciaToolStripMenuItem.Name = "justificarAusênciaToolStripMenuItem";
            this.justificarAusênciaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.justificarAusênciaToolStripMenuItem.Text = "Justificar Ausência";
            // 
            // solicitarCorreçãoToolStripMenuItem
            // 
            this.solicitarCorreçãoToolStripMenuItem.Name = "solicitarCorreçãoToolStripMenuItem";
            this.solicitarCorreçãoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.solicitarCorreçãoToolStripMenuItem.Text = "Solicitar Correção";
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
            this.consultarCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarCadastroToolStripMenuItem.Text = "Consultar Cadastro";
            // 
            // mudarSenhaToolStripMenuItem
            // 
            this.mudarSenhaToolStripMenuItem.Name = "mudarSenhaToolStripMenuItem";
            this.mudarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mudarSenhaToolStripMenuItem.Text = "Mudar Senha";
            this.mudarSenhaToolStripMenuItem.Click += new System.EventHandler(this.mudarSenhaToolStripMenuItem_Click);
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.Controls.Add(this.txtConfSenha);
            this.pnlMudarSenha.Controls.Add(this.txtNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.txtSenhaAntiga);
            this.pnlMudarSenha.Controls.Add(this.button1);
            this.pnlMudarSenha.Controls.Add(this.lblErro);
            this.pnlMudarSenha.Controls.Add(this.label11);
            this.pnlMudarSenha.Controls.Add(this.label12);
            this.pnlMudarSenha.Controls.Add(this.label13);
            this.pnlMudarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMudarSenha.Location = new System.Drawing.Point(0, 24);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(800, 426);
            this.pnlMudarSenha.TabIndex = 9;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(291, 184);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(134, 20);
            this.txtConfSenha.TabIndex = 15;
            this.txtConfSenha.TextChanged += new System.EventHandler(this.txtConfSenha_TextChanged);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(291, 150);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(134, 20);
            this.txtNovaSenha.TabIndex = 14;
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Location = new System.Drawing.Point(291, 112);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.Size = new System.Drawing.Size(134, 20);
            this.txtSenhaAntiga.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(347, 207);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Confirmar senha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nova senha:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Senha:";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAluno";
            this.Text = "Especialisterne - Consultor";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem presençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarHistóricoDePresençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificarAusênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarCorreçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudarSenhaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtSenhaAntiga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}