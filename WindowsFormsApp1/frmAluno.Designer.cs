namespace WindowsFormsApp1
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calendárioDePresençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarHistóricoDePresençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificarAusênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarCorreçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlJustificar = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJustificativa = new System.Windows.Forms.TextBox();
            this.btnSalvarJust = new System.Windows.Forms.Button();
            this.pnlPresenca = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlMudarSenha.SuspendLayout();
            this.pnlJustificar.SuspendLayout();
            this.pnlPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.calendárioDePresençaToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // calendárioDePresençaToolStripMenuItem
            // 
            this.calendárioDePresençaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarHistóricoDePresençaToolStripMenuItem,
            this.justificarAusênciaToolStripMenuItem,
            this.solicitarCorreçãoToolStripMenuItem});
            this.calendárioDePresençaToolStripMenuItem.Name = "calendárioDePresençaToolStripMenuItem";
            this.calendárioDePresençaToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.calendárioDePresençaToolStripMenuItem.Text = "Calendário de Presença";
            // 
            // consultarHistóricoDePresençaToolStripMenuItem
            // 
            this.consultarHistóricoDePresençaToolStripMenuItem.Name = "consultarHistóricoDePresençaToolStripMenuItem";
            this.consultarHistóricoDePresençaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.consultarHistóricoDePresençaToolStripMenuItem.Text = "Consultar Histórico de Presença";
            this.consultarHistóricoDePresençaToolStripMenuItem.Click += new System.EventHandler(this.consultarHistóricoDePresençaToolStripMenuItem_Click);
            // 
            // justificarAusênciaToolStripMenuItem
            // 
            this.justificarAusênciaToolStripMenuItem.Name = "justificarAusênciaToolStripMenuItem";
            this.justificarAusênciaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.justificarAusênciaToolStripMenuItem.Text = "Justificar Ausência";
            this.justificarAusênciaToolStripMenuItem.Click += new System.EventHandler(this.justificarAusênciaToolStripMenuItem_Click);
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
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.Controls.Add(this.pnlJustificar);
            this.pnlMudarSenha.Controls.Add(this.txtConfSenha);
            this.pnlMudarSenha.Controls.Add(this.txtNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.txtSenhaAntiga);
            this.pnlMudarSenha.Controls.Add(this.btnSalvar);
            this.pnlMudarSenha.Controls.Add(this.lblErro);
            this.pnlMudarSenha.Controls.Add(this.label3);
            this.pnlMudarSenha.Controls.Add(this.label2);
            this.pnlMudarSenha.Controls.Add(this.label1);
            this.pnlMudarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMudarSenha.Location = new System.Drawing.Point(0, 24);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(638, 325);
            this.pnlMudarSenha.TabIndex = 1;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(249, 140);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(134, 20);
            this.txtConfSenha.TabIndex = 7;
            this.txtConfSenha.TextChanged += new System.EventHandler(this.txtConfSenha_TextChanged);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(249, 106);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(134, 20);
            this.txtNovaSenha.TabIndex = 6;
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Location = new System.Drawing.Point(249, 68);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.Size = new System.Drawing.Size(134, 20);
            this.txtSenhaAntiga.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(308, 192);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(305, 163);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha:";
            // 
            // pnlJustificar
            // 
            this.pnlJustificar.Controls.Add(this.btnSalvarJust);
            this.pnlJustificar.Controls.Add(this.txtJustificativa);
            this.pnlJustificar.Controls.Add(this.label5);
            this.pnlJustificar.Controls.Add(this.label4);
            this.pnlJustificar.Controls.Add(this.dateTimePicker1);
            this.pnlJustificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJustificar.Location = new System.Drawing.Point(0, 0);
            this.pnlJustificar.Name = "pnlJustificar";
            this.pnlJustificar.Size = new System.Drawing.Size(638, 325);
            this.pnlJustificar.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dia da falta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Justificativa:";
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Location = new System.Drawing.Point(207, 138);
            this.txtJustificativa.Multiline = true;
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Size = new System.Drawing.Size(239, 44);
            this.txtJustificativa.TabIndex = 3;
            // 
            // btnSalvarJust
            // 
            this.btnSalvarJust.Location = new System.Drawing.Point(370, 194);
            this.btnSalvarJust.Name = "btnSalvarJust";
            this.btnSalvarJust.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarJust.TabIndex = 4;
            this.btnSalvarJust.Text = "Enviar";
            this.btnSalvarJust.UseVisualStyleBackColor = true;
            // 
            // pnlPresenca
            // 
            this.pnlPresenca.Controls.Add(this.dataGridView1);
            this.pnlPresenca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPresenca.Location = new System.Drawing.Point(0, 24);
            this.pnlPresenca.Name = "pnlPresenca";
            this.pnlPresenca.Size = new System.Drawing.Size(638, 325);
            this.pnlPresenca.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 349);
            this.Controls.Add(this.pnlPresenca);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAluno";
            this.Text = "frmAluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.pnlJustificar.ResumeLayout(false);
            this.pnlJustificar.PerformLayout();
            this.pnlPresenca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calendárioDePresençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarHistóricoDePresençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificarAusênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarCorreçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtSenhaAntiga;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlJustificar;
        private System.Windows.Forms.Button btnSalvarJust;
        private System.Windows.Forms.TextBox txtJustificativa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlPresenca;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}