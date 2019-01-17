namespace WindowsFormsApp1
{
    partial class frmTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.presençaDosAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presençaDoAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datasPassadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datasFuturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDosAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlCadastroNovo = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCadastroPesquisa = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProcNome = new System.Windows.Forms.TextBox();
            this.txtProcNCadastro = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlCadastroNovo.SuspendLayout();
            this.pnlCadastroPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presençaDosAlunosToolStripMenuItem,
            this.presençaDoAlunosToolStripMenuItem,
            this.cadastroDosAlunosToolStripMenuItem,
            this.menuPessoalToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // presençaDosAlunosToolStripMenuItem
            // 
            this.presençaDosAlunosToolStripMenuItem.Name = "presençaDosAlunosToolStripMenuItem";
            this.presençaDosAlunosToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // presençaDoAlunosToolStripMenuItem
            // 
            this.presençaDoAlunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datasPassadasToolStripMenuItem,
            this.datasFuturasToolStripMenuItem});
            this.presençaDoAlunosToolStripMenuItem.Name = "presençaDoAlunosToolStripMenuItem";
            this.presençaDoAlunosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.presençaDoAlunosToolStripMenuItem.Text = "Presença do Alunos";
            // 
            // datasPassadasToolStripMenuItem
            // 
            this.datasPassadasToolStripMenuItem.Name = "datasPassadasToolStripMenuItem";
            this.datasPassadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datasPassadasToolStripMenuItem.Text = "Datas Passadas";
            this.datasPassadasToolStripMenuItem.Click += new System.EventHandler(this.datasPassadasToolStripMenuItem_Click);
            // 
            // datasFuturasToolStripMenuItem
            // 
            this.datasFuturasToolStripMenuItem.Name = "datasFuturasToolStripMenuItem";
            this.datasFuturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datasFuturasToolStripMenuItem.Text = "Datas Futuras";
            this.datasFuturasToolStripMenuItem.Click += new System.EventHandler(this.datasFuturasToolStripMenuItem_Click);
            // 
            // cadastroDosAlunosToolStripMenuItem
            // 
            this.cadastroDosAlunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procurarCadastroToolStripMenuItem,
            this.novoCadastroToolStripMenuItem,
            this.editarCadastroToolStripMenuItem,
            this.excluirCadastroToolStripMenuItem});
            this.cadastroDosAlunosToolStripMenuItem.Name = "cadastroDosAlunosToolStripMenuItem";
            this.cadastroDosAlunosToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.cadastroDosAlunosToolStripMenuItem.Text = "Cadastro dos Alunos";
            // 
            // procurarCadastroToolStripMenuItem
            // 
            this.procurarCadastroToolStripMenuItem.Name = "procurarCadastroToolStripMenuItem";
            this.procurarCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.procurarCadastroToolStripMenuItem.Text = "Procurar Cadastro";
            this.procurarCadastroToolStripMenuItem.Click += new System.EventHandler(this.procurarCadastroToolStripMenuItem_Click);
            // 
            // novoCadastroToolStripMenuItem
            // 
            this.novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            this.novoCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoCadastroToolStripMenuItem.Text = "Novo Cadastro";
            this.novoCadastroToolStripMenuItem.Click += new System.EventHandler(this.novoCadastroToolStripMenuItem_Click);
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarCadastroToolStripMenuItem.Text = "Editar Cadastro";
            // 
            // excluirCadastroToolStripMenuItem
            // 
            this.excluirCadastroToolStripMenuItem.Name = "excluirCadastroToolStripMenuItem";
            this.excluirCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirCadastroToolStripMenuItem.Text = "Excluir Cadastro";
            // 
            // menuPessoalToolStripMenuItem
            // 
            this.menuPessoalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checarCadastroToolStripMenuItem,
            this.editarCadastroToolStripMenuItem1,
            this.editarSenhaToolStripMenuItem});
            this.menuPessoalToolStripMenuItem.Name = "menuPessoalToolStripMenuItem";
            this.menuPessoalToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.menuPessoalToolStripMenuItem.Text = "Menu Pessoal";
            // 
            // checarCadastroToolStripMenuItem
            // 
            this.checarCadastroToolStripMenuItem.Name = "checarCadastroToolStripMenuItem";
            this.checarCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checarCadastroToolStripMenuItem.Text = "Checar Cadastro";
            // 
            // editarCadastroToolStripMenuItem1
            // 
            this.editarCadastroToolStripMenuItem1.Name = "editarCadastroToolStripMenuItem1";
            this.editarCadastroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editarCadastroToolStripMenuItem1.Text = "Editar Cadastro";
            // 
            // editarSenhaToolStripMenuItem
            // 
            this.editarSenhaToolStripMenuItem.Name = "editarSenhaToolStripMenuItem";
            this.editarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarSenhaToolStripMenuItem.Text = "Editar Senha";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.pnlCadastroNovo);
            this.pnlConsulta.Controls.Add(this.dataGridView);
            this.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsulta.Location = new System.Drawing.Point(0, 24);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(699, 464);
            this.pnlConsulta.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 15);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(643, 437);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // pnlCadastroNovo
            // 
            this.pnlCadastroNovo.Controls.Add(this.pnlCadastroPesquisa);
            this.pnlCadastroNovo.Controls.Add(this.btnLimpar);
            this.pnlCadastroNovo.Controls.Add(this.btnSalvar);
            this.pnlCadastroNovo.Controls.Add(this.txtEmail);
            this.pnlCadastroNovo.Controls.Add(this.label6);
            this.pnlCadastroNovo.Controls.Add(this.txtConfirmSenha);
            this.pnlCadastroNovo.Controls.Add(this.label5);
            this.pnlCadastroNovo.Controls.Add(this.txtSenha);
            this.pnlCadastroNovo.Controls.Add(this.label4);
            this.pnlCadastroNovo.Controls.Add(this.txtNCadastro);
            this.pnlCadastroNovo.Controls.Add(this.label3);
            this.pnlCadastroNovo.Controls.Add(this.txtNome);
            this.pnlCadastroNovo.Controls.Add(this.label2);
            this.pnlCadastroNovo.Controls.Add(this.label1);
            this.pnlCadastroNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastroNovo.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroNovo.Name = "pnlCadastroNovo";
            this.pnlCadastroNovo.Size = new System.Drawing.Size(699, 464);
            this.pnlCadastroNovo.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(368, 329);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(210, 329);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(260, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "E-mail:";
            // 
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.Location = new System.Drawing.Point(260, 213);
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.PasswordChar = '*';
            this.txtConfirmSenha.Size = new System.Drawing.Size(172, 20);
            this.txtConfirmSenha.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Confirmar Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(260, 172);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(172, 20);
            this.txtSenha.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Senha:";
            // 
            // txtNCadastro
            // 
            this.txtNCadastro.Location = new System.Drawing.Point(260, 131);
            this.txtNCadastro.Name = "txtNCadastro";
            this.txtNCadastro.Size = new System.Drawing.Size(172, 20);
            this.txtNCadastro.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nº Cadastro:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(260, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Novo Cadastro";
            // 
            // pnlCadastroPesquisa
            // 
            this.pnlCadastroPesquisa.Controls.Add(this.lblResultado);
            this.pnlCadastroPesquisa.Controls.Add(this.btnProcurar);
            this.pnlCadastroPesquisa.Controls.Add(this.txtProcNCadastro);
            this.pnlCadastroPesquisa.Controls.Add(this.txtProcNome);
            this.pnlCadastroPesquisa.Controls.Add(this.label10);
            this.pnlCadastroPesquisa.Controls.Add(this.label9);
            this.pnlCadastroPesquisa.Controls.Add(this.label8);
            this.pnlCadastroPesquisa.Controls.Add(this.label7);
            this.pnlCadastroPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastroPesquisa.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroPesquisa.Name = "pnlCadastroPesquisa";
            this.pnlCadastroPesquisa.Size = new System.Drawing.Size(699, 464);
            this.pnlCadastroPesquisa.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pesquisa de Cadastro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nº de Cadastro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Procurar por";
            // 
            // txtProcNome
            // 
            this.txtProcNome.Location = new System.Drawing.Point(268, 115);
            this.txtProcNome.Name = "txtProcNome";
            this.txtProcNome.Size = new System.Drawing.Size(137, 20);
            this.txtProcNome.TabIndex = 4;
            // 
            // txtProcNCadastro
            // 
            this.txtProcNCadastro.Location = new System.Drawing.Point(268, 144);
            this.txtProcNCadastro.Name = "txtProcNCadastro";
            this.txtProcNCadastro.Size = new System.Drawing.Size(137, 20);
            this.txtProcNCadastro.TabIndex = 5;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(330, 198);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(310, 242);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "...";
            // 
            // frmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 488);
            this.Controls.Add(this.pnlConsulta);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialisterne - Tutor";
            this.Load += new System.EventHandler(this.frmTutor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlCadastroNovo.ResumeLayout(false);
            this.pnlCadastroNovo.PerformLayout();
            this.pnlCadastroPesquisa.ResumeLayout(false);
            this.pnlCadastroPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem presençaDosAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDosAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPessoalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presençaDoAlunosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem datasPassadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datasFuturasToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCadastroNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCadastroPesquisa;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtProcNCadastro;
        private System.Windows.Forms.TextBox txtProcNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}