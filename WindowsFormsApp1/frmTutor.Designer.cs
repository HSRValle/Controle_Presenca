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
            this.verDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDosAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPresenca = new System.Windows.Forms.Panel();
            this.nudFiltroGrupo = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.chbFaltas = new System.Windows.Forms.CheckBox();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlCadastroNovo = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.nudGrupo = new System.Windows.Forms.NumericUpDown();
            this.lblErroNovo = new System.Windows.Forms.Label();
            this.chbTutor = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCadastroPesquisa = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtProcNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.btnEditarSenha = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlExcluir = new System.Windows.Forms.Panel();
            this.lblExcluirErro = new System.Windows.Forms.Label();
            this.btnExcluirConfirmar = new System.Windows.Forms.Button();
            this.txtExcluirSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbExcluirUsuario = new System.Windows.Forms.ComboBox();
            this.pnlEditarCadastro = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvarEditar = new System.Windows.Forms.Button();
            this.txtEmailEditar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNomeEditar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlEditarOutroCadastro = new System.Windows.Forms.Panel();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.pnlEditarControles = new System.Windows.Forms.Panel();
            this.lblErroEditarOutroUsuario = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nudEditarGrupo = new System.Windows.Forms.NumericUpDown();
            this.txtEditarOutroConfirmacao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEditarOutroSenha = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnEditarOutrosLimpar = new System.Windows.Forms.Button();
            this.btnSalvarOutroUsuario = new System.Windows.Forms.Button();
            this.txtEditarEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEditarNome = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblEditarCadastro = new System.Windows.Forms.Label();
            this.cmbEditarUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbFiltroDatas = new System.Windows.Forms.ComboBox();
            this.criarDatasFuturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiltroGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlCadastroNovo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrupo)).BeginInit();
            this.pnlCadastroPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlMudarSenha.SuspendLayout();
            this.pnlExcluir.SuspendLayout();
            this.pnlEditarCadastro.SuspendLayout();
            this.pnlEditarOutroCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.pnlEditarControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarGrupo)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
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
            this.verDatasToolStripMenuItem,
            this.criarDatasFuturasToolStripMenuItem});
            this.presençaDoAlunosToolStripMenuItem.Name = "presençaDoAlunosToolStripMenuItem";
            this.presençaDoAlunosToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.presençaDoAlunosToolStripMenuItem.Text = "Presença dos Alunos";
            // 
            // verDatasToolStripMenuItem
            // 
            this.verDatasToolStripMenuItem.Name = "verDatasToolStripMenuItem";
            this.verDatasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verDatasToolStripMenuItem.Text = "Ver Datas";
            this.verDatasToolStripMenuItem.Click += new System.EventHandler(this.verDatasToolStripMenuItem_Click);
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
            this.editarCadastroToolStripMenuItem.Click += new System.EventHandler(this.editarCadastroToolStripMenuItem_Click);
            // 
            // excluirCadastroToolStripMenuItem
            // 
            this.excluirCadastroToolStripMenuItem.Name = "excluirCadastroToolStripMenuItem";
            this.excluirCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirCadastroToolStripMenuItem.Text = "Excluir Cadastro";
            this.excluirCadastroToolStripMenuItem.Click += new System.EventHandler(this.excluirCadastroToolStripMenuItem_Click);
            // 
            // menuPessoalToolStripMenuItem
            // 
            this.menuPessoalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarCadastroToolStripMenuItem1,
            this.editarSenhaToolStripMenuItem});
            this.menuPessoalToolStripMenuItem.Name = "menuPessoalToolStripMenuItem";
            this.menuPessoalToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.menuPessoalToolStripMenuItem.Text = "Menu Pessoal";
            // 
            // editarCadastroToolStripMenuItem1
            // 
            this.editarCadastroToolStripMenuItem1.Name = "editarCadastroToolStripMenuItem1";
            this.editarCadastroToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.editarCadastroToolStripMenuItem1.Text = "Editar Cadastro";
            this.editarCadastroToolStripMenuItem1.Click += new System.EventHandler(this.editarCadastroToolStripMenuItem1_Click);
            // 
            // editarSenhaToolStripMenuItem
            // 
            this.editarSenhaToolStripMenuItem.Name = "editarSenhaToolStripMenuItem";
            this.editarSenhaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editarSenhaToolStripMenuItem.Text = "Mudar Senha";
            this.editarSenhaToolStripMenuItem.Click += new System.EventHandler(this.editarSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pnlPresenca
            // 
            this.pnlPresenca.Controls.Add(this.cmbFiltroDatas);
            this.pnlPresenca.Controls.Add(this.nudFiltroGrupo);
            this.pnlPresenca.Controls.Add(this.label23);
            this.pnlPresenca.Controls.Add(this.chbFaltas);
            this.pnlPresenca.Controls.Add(this.cmbAluno);
            this.pnlPresenca.Controls.Add(this.btnAtualizar);
            this.pnlPresenca.Controls.Add(this.dataGridView);
            this.pnlPresenca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPresenca.Location = new System.Drawing.Point(0, 24);
            this.pnlPresenca.Name = "pnlPresenca";
            this.pnlPresenca.Size = new System.Drawing.Size(879, 489);
            this.pnlPresenca.TabIndex = 1;
            // 
            // nudFiltroGrupo
            // 
            this.nudFiltroGrupo.Location = new System.Drawing.Point(438, 10);
            this.nudFiltroGrupo.Name = "nudFiltroGrupo";
            this.nudFiltroGrupo.Size = new System.Drawing.Size(55, 20);
            this.nudFiltroGrupo.TabIndex = 7;
            this.nudFiltroGrupo.ValueChanged += new System.EventHandler(this.nudFiltroGrupo_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(355, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Filtrar por grupo";
            // 
            // chbFaltas
            // 
            this.chbFaltas.AutoSize = true;
            this.chbFaltas.Location = new System.Drawing.Point(719, 13);
            this.chbFaltas.Name = "chbFaltas";
            this.chbFaltas.Size = new System.Drawing.Size(90, 17);
            this.chbFaltas.TabIndex = 5;
            this.chbFaltas.Text = "Apenas faltas";
            this.chbFaltas.UseVisualStyleBackColor = true;
            this.chbFaltas.CheckedChanged += new System.EventHandler(this.chbFaltas_CheckedChanged);
            // 
            // cmbAluno
            // 
            this.cmbAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbAluno.Location = new System.Drawing.Point(191, 9);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(152, 21);
            this.cmbAluno.TabIndex = 4;
            this.cmbAluno.Text = "Filtrar por aluno";
            this.cmbAluno.SelectedIndexChanged += new System.EventHandler(this.cmbAluno_SelectedIndexChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(514, 8);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(35, 37);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(774, 440);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // pnlCadastroNovo
            // 
            this.pnlCadastroNovo.Controls.Add(this.label15);
            this.pnlCadastroNovo.Controls.Add(this.nudGrupo);
            this.pnlCadastroNovo.Controls.Add(this.lblErroNovo);
            this.pnlCadastroNovo.Controls.Add(this.chbTutor);
            this.pnlCadastroNovo.Controls.Add(this.btnLimpar);
            this.pnlCadastroNovo.Controls.Add(this.btnSalvar);
            this.pnlCadastroNovo.Controls.Add(this.txtEmail);
            this.pnlCadastroNovo.Controls.Add(this.label6);
            this.pnlCadastroNovo.Controls.Add(this.txtConfirmSenha);
            this.pnlCadastroNovo.Controls.Add(this.label5);
            this.pnlCadastroNovo.Controls.Add(this.txtSenha);
            this.pnlCadastroNovo.Controls.Add(this.label4);
            this.pnlCadastroNovo.Controls.Add(this.txtNome);
            this.pnlCadastroNovo.Controls.Add(this.label2);
            this.pnlCadastroNovo.Controls.Add(this.label1);
            this.pnlCadastroNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastroNovo.Location = new System.Drawing.Point(0, 24);
            this.pnlCadastroNovo.Name = "pnlCadastroNovo";
            this.pnlCadastroNovo.Size = new System.Drawing.Size(879, 489);
            this.pnlCadastroNovo.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(403, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Grupo:";
            // 
            // nudGrupo
            // 
            this.nudGrupo.Location = new System.Drawing.Point(455, 166);
            this.nudGrupo.Name = "nudGrupo";
            this.nudGrupo.Size = new System.Drawing.Size(57, 20);
            this.nudGrupo.TabIndex = 29;
            // 
            // lblErroNovo
            // 
            this.lblErroNovo.AutoSize = true;
            this.lblErroNovo.Location = new System.Drawing.Point(400, 411);
            this.lblErroNovo.Name = "lblErroNovo";
            this.lblErroNovo.Size = new System.Drawing.Size(0, 13);
            this.lblErroNovo.TabIndex = 28;
            // 
            // chbTutor
            // 
            this.chbTutor.AutoSize = true;
            this.chbTutor.Location = new System.Drawing.Point(421, 313);
            this.chbTutor.Name = "chbTutor";
            this.chbTutor.Size = new System.Drawing.Size(51, 17);
            this.chbTutor.TabIndex = 27;
            this.chbTutor.Text = "Tutor";
            this.chbTutor.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(494, 355);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(336, 355);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(386, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "E-mail:";
            // 
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.Location = new System.Drawing.Point(386, 239);
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.PasswordChar = '*';
            this.txtConfirmSenha.Size = new System.Drawing.Size(172, 20);
            this.txtConfirmSenha.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Confirmar Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(386, 198);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(172, 20);
            this.txtSenha.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(386, 136);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Novo Cadastro";
            // 
            // pnlCadastroPesquisa
            // 
            this.pnlCadastroPesquisa.Controls.Add(this.groupBox1);
            this.pnlCadastroPesquisa.Controls.Add(this.btnProcurar);
            this.pnlCadastroPesquisa.Controls.Add(this.txtProcNome);
            this.pnlCadastroPesquisa.Controls.Add(this.label10);
            this.pnlCadastroPesquisa.Controls.Add(this.label9);
            this.pnlCadastroPesquisa.Controls.Add(this.label7);
            this.pnlCadastroPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastroPesquisa.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroPesquisa.Name = "pnlCadastroPesquisa";
            this.pnlCadastroPesquisa.Size = new System.Drawing.Size(879, 513);
            this.pnlCadastroPesquisa.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Location = new System.Drawing.Point(292, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 178);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(15, 24);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(452, 217);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtProcNome
            // 
            this.txtProcNome.Location = new System.Drawing.Point(390, 134);
            this.txtProcNome.Name = "txtProcNome";
            this.txtProcNome.Size = new System.Drawing.Size(137, 20);
            this.txtProcNome.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Procurar por";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pesquisa de Cadastro";
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.Controls.Add(this.txtConfSenha);
            this.pnlMudarSenha.Controls.Add(this.txtNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.txtSenhaAntiga);
            this.pnlMudarSenha.Controls.Add(this.btnEditarSenha);
            this.pnlMudarSenha.Controls.Add(this.lblErro);
            this.pnlMudarSenha.Controls.Add(this.label11);
            this.pnlMudarSenha.Controls.Add(this.label12);
            this.pnlMudarSenha.Controls.Add(this.label13);
            this.pnlMudarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMudarSenha.Location = new System.Drawing.Point(0, 0);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(879, 513);
            this.pnlMudarSenha.TabIndex = 8;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(403, 246);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '•';
            this.txtConfSenha.Size = new System.Drawing.Size(134, 20);
            this.txtConfSenha.TabIndex = 15;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(403, 212);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '•';
            this.txtNovaSenha.Size = new System.Drawing.Size(134, 20);
            this.txtNovaSenha.TabIndex = 14;
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Location = new System.Drawing.Point(403, 174);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.PasswordChar = '•';
            this.txtSenhaAntiga.Size = new System.Drawing.Size(134, 20);
            this.txtSenhaAntiga.TabIndex = 13;
            // 
            // btnEditarSenha
            // 
            this.btnEditarSenha.Location = new System.Drawing.Point(426, 301);
            this.btnEditarSenha.Name = "btnEditarSenha";
            this.btnEditarSenha.Size = new System.Drawing.Size(75, 23);
            this.btnEditarSenha.TabIndex = 12;
            this.btnEditarSenha.Text = "Salvar";
            this.btnEditarSenha.UseVisualStyleBackColor = true;
            this.btnEditarSenha.Click += new System.EventHandler(this.btnEditarSenha_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(371, 280);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Confirmar senha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(329, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nova senha:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(356, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Senha:";
            // 
            // pnlExcluir
            // 
            this.pnlExcluir.Controls.Add(this.lblExcluirErro);
            this.pnlExcluir.Controls.Add(this.btnExcluirConfirmar);
            this.pnlExcluir.Controls.Add(this.txtExcluirSenha);
            this.pnlExcluir.Controls.Add(this.label8);
            this.pnlExcluir.Controls.Add(this.label3);
            this.pnlExcluir.Controls.Add(this.cmbExcluirUsuario);
            this.pnlExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExcluir.Location = new System.Drawing.Point(0, 24);
            this.pnlExcluir.Name = "pnlExcluir";
            this.pnlExcluir.Size = new System.Drawing.Size(879, 489);
            this.pnlExcluir.TabIndex = 28;
            // 
            // lblExcluirErro
            // 
            this.lblExcluirErro.AutoSize = true;
            this.lblExcluirErro.Location = new System.Drawing.Point(397, 303);
            this.lblExcluirErro.Name = "lblExcluirErro";
            this.lblExcluirErro.Size = new System.Drawing.Size(0, 13);
            this.lblExcluirErro.TabIndex = 12;
            // 
            // btnExcluirConfirmar
            // 
            this.btnExcluirConfirmar.Enabled = false;
            this.btnExcluirConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirConfirmar.Location = new System.Drawing.Point(386, 331);
            this.btnExcluirConfirmar.Name = "btnExcluirConfirmar";
            this.btnExcluirConfirmar.Size = new System.Drawing.Size(90, 31);
            this.btnExcluirConfirmar.TabIndex = 4;
            this.btnExcluirConfirmar.Text = "Confirmar";
            this.btnExcluirConfirmar.UseVisualStyleBackColor = true;
            this.btnExcluirConfirmar.Click += new System.EventHandler(this.btnExcluirConfirmar_Click);
            // 
            // txtExcluirSenha
            // 
            this.txtExcluirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcluirSenha.Location = new System.Drawing.Point(359, 264);
            this.txtExcluirSenha.Name = "txtExcluirSenha";
            this.txtExcluirSenha.PasswordChar = '•';
            this.txtExcluirSenha.Size = new System.Drawing.Size(153, 22);
            this.txtExcluirSenha.TabIndex = 3;
            this.txtExcluirSenha.TextChanged += new System.EventHandler(this.txtExcluirSenha_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Digite sua senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecione o cadastro a ser excluído";
            // 
            // cmbExcluirUsuario
            // 
            this.cmbExcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExcluirUsuario.FormattingEnabled = true;
            this.cmbExcluirUsuario.Location = new System.Drawing.Point(359, 163);
            this.cmbExcluirUsuario.Name = "cmbExcluirUsuario";
            this.cmbExcluirUsuario.Size = new System.Drawing.Size(153, 24);
            this.cmbExcluirUsuario.TabIndex = 0;
            // 
            // pnlEditarCadastro
            // 
            this.pnlEditarCadastro.Controls.Add(this.button1);
            this.pnlEditarCadastro.Controls.Add(this.btnSalvarEditar);
            this.pnlEditarCadastro.Controls.Add(this.txtEmailEditar);
            this.pnlEditarCadastro.Controls.Add(this.label14);
            this.pnlEditarCadastro.Controls.Add(this.txtNomeEditar);
            this.pnlEditarCadastro.Controls.Add(this.label17);
            this.pnlEditarCadastro.Controls.Add(this.label18);
            this.pnlEditarCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditarCadastro.Location = new System.Drawing.Point(0, 24);
            this.pnlEditarCadastro.Name = "pnlEditarCadastro";
            this.pnlEditarCadastro.Size = new System.Drawing.Size(879, 489);
            this.pnlEditarCadastro.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEditar
            // 
            this.btnSalvarEditar.Location = new System.Drawing.Point(356, 260);
            this.btnSalvarEditar.Name = "btnSalvarEditar";
            this.btnSalvarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEditar.TabIndex = 38;
            this.btnSalvarEditar.Text = "Salvar";
            this.btnSalvarEditar.UseVisualStyleBackColor = true;
            this.btnSalvarEditar.Click += new System.EventHandler(this.btnSalvarEditar_Click);
            // 
            // txtEmailEditar
            // 
            this.txtEmailEditar.Location = new System.Drawing.Point(406, 193);
            this.txtEmailEditar.Name = "txtEmailEditar";
            this.txtEmailEditar.Size = new System.Drawing.Size(172, 20);
            this.txtEmailEditar.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "E-mail:";
            // 
            // txtNomeEditar
            // 
            this.txtNomeEditar.Location = new System.Drawing.Point(406, 152);
            this.txtNomeEditar.Name = "txtNomeEditar";
            this.txtNomeEditar.Size = new System.Drawing.Size(172, 20);
            this.txtNomeEditar.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Nome:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(443, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Editar Cadastro";
            // 
            // pnlEditarOutroCadastro
            // 
            this.pnlEditarOutroCadastro.Controls.Add(this.nudId);
            this.pnlEditarOutroCadastro.Controls.Add(this.pnlEditarControles);
            this.pnlEditarOutroCadastro.Controls.Add(this.lblEditarCadastro);
            this.pnlEditarOutroCadastro.Controls.Add(this.cmbEditarUsuarios);
            this.pnlEditarOutroCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditarOutroCadastro.Location = new System.Drawing.Point(0, 24);
            this.pnlEditarOutroCadastro.Name = "pnlEditarOutroCadastro";
            this.pnlEditarOutroCadastro.Size = new System.Drawing.Size(879, 489);
            this.pnlEditarOutroCadastro.TabIndex = 31;
            this.pnlEditarOutroCadastro.Visible = false;
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(407, 100);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(120, 20);
            this.nudId.TabIndex = 54;
            this.nudId.Visible = false;
            // 
            // pnlEditarControles
            // 
            this.pnlEditarControles.Controls.Add(this.lblErroEditarOutroUsuario);
            this.pnlEditarControles.Controls.Add(this.label20);
            this.pnlEditarControles.Controls.Add(this.nudEditarGrupo);
            this.pnlEditarControles.Controls.Add(this.txtEditarOutroConfirmacao);
            this.pnlEditarControles.Controls.Add(this.label21);
            this.pnlEditarControles.Controls.Add(this.txtEditarOutroSenha);
            this.pnlEditarControles.Controls.Add(this.label22);
            this.pnlEditarControles.Controls.Add(this.btnEditarOutrosLimpar);
            this.pnlEditarControles.Controls.Add(this.btnSalvarOutroUsuario);
            this.pnlEditarControles.Controls.Add(this.txtEditarEmail);
            this.pnlEditarControles.Controls.Add(this.label16);
            this.pnlEditarControles.Controls.Add(this.txtEditarNome);
            this.pnlEditarControles.Controls.Add(this.label19);
            this.pnlEditarControles.Location = new System.Drawing.Point(249, 113);
            this.pnlEditarControles.Name = "pnlEditarControles";
            this.pnlEditarControles.Size = new System.Drawing.Size(437, 282);
            this.pnlEditarControles.TabIndex = 53;
            this.pnlEditarControles.Visible = false;
            // 
            // lblErroEditarOutroUsuario
            // 
            this.lblErroEditarOutroUsuario.AutoSize = true;
            this.lblErroEditarOutroUsuario.Location = new System.Drawing.Point(148, 268);
            this.lblErroEditarOutroUsuario.Name = "lblErroEditarOutroUsuario";
            this.lblErroEditarOutroUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblErroEditarOutroUsuario.TabIndex = 53;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(164, 98);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Grupo:";
            // 
            // nudEditarGrupo
            // 
            this.nudEditarGrupo.Location = new System.Drawing.Point(216, 96);
            this.nudEditarGrupo.Name = "nudEditarGrupo";
            this.nudEditarGrupo.Size = new System.Drawing.Size(57, 20);
            this.nudEditarGrupo.TabIndex = 51;
            // 
            // txtEditarOutroConfirmacao
            // 
            this.txtEditarOutroConfirmacao.Location = new System.Drawing.Point(147, 169);
            this.txtEditarOutroConfirmacao.Name = "txtEditarOutroConfirmacao";
            this.txtEditarOutroConfirmacao.PasswordChar = '*';
            this.txtEditarOutroConfirmacao.Size = new System.Drawing.Size(172, 20);
            this.txtEditarOutroConfirmacao.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(31, 169);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "Confirmar Senha:";
            // 
            // txtEditarOutroSenha
            // 
            this.txtEditarOutroSenha.Location = new System.Drawing.Point(147, 126);
            this.txtEditarOutroSenha.Name = "txtEditarOutroSenha";
            this.txtEditarOutroSenha.PasswordChar = '*';
            this.txtEditarOutroSenha.Size = new System.Drawing.Size(172, 20);
            this.txtEditarOutroSenha.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(49, 131);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Nova Senha:";
            // 
            // btnEditarOutrosLimpar
            // 
            this.btnEditarOutrosLimpar.Location = new System.Drawing.Point(237, 230);
            this.btnEditarOutrosLimpar.Name = "btnEditarOutrosLimpar";
            this.btnEditarOutrosLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnEditarOutrosLimpar.TabIndex = 46;
            this.btnEditarOutrosLimpar.Text = "Limpar";
            this.btnEditarOutrosLimpar.UseVisualStyleBackColor = true;
            this.btnEditarOutrosLimpar.Click += new System.EventHandler(this.btnEditarOutrosLimpar_Click);
            // 
            // btnSalvarOutroUsuario
            // 
            this.btnSalvarOutroUsuario.Location = new System.Drawing.Point(79, 230);
            this.btnSalvarOutroUsuario.Name = "btnSalvarOutroUsuario";
            this.btnSalvarOutroUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarOutroUsuario.TabIndex = 45;
            this.btnSalvarOutroUsuario.Text = "Salvar";
            this.btnSalvarOutroUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarOutroUsuario.Click += new System.EventHandler(this.btnSalvarOutroUsuario_Click);
            // 
            // txtEditarEmail
            // 
            this.txtEditarEmail.Location = new System.Drawing.Point(147, 62);
            this.txtEditarEmail.Name = "txtEditarEmail";
            this.txtEditarEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEditarEmail.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "E-mail:";
            // 
            // txtEditarNome
            // 
            this.txtEditarNome.Location = new System.Drawing.Point(147, 21);
            this.txtEditarNome.Name = "txtEditarNome";
            this.txtEditarNome.Size = new System.Drawing.Size(172, 20);
            this.txtEditarNome.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(81, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Nome:";
            // 
            // lblEditarCadastro
            // 
            this.lblEditarCadastro.AutoSize = true;
            this.lblEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCadastro.Location = new System.Drawing.Point(383, 43);
            this.lblEditarCadastro.Name = "lblEditarCadastro";
            this.lblEditarCadastro.Size = new System.Drawing.Size(62, 16);
            this.lblEditarCadastro.TabIndex = 1;
            this.lblEditarCadastro.Text = "Editando";
            // 
            // cmbEditarUsuarios
            // 
            this.cmbEditarUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbEditarUsuarios.FormattingEnabled = true;
            this.cmbEditarUsuarios.Location = new System.Drawing.Point(47, 117);
            this.cmbEditarUsuarios.Name = "cmbEditarUsuarios";
            this.cmbEditarUsuarios.Size = new System.Drawing.Size(121, 280);
            this.cmbEditarUsuarios.TabIndex = 0;
            this.cmbEditarUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbEditarUsuarios_SelectedIndexChanged);
            // 
            // cmbFiltroDatas
            // 
            this.cmbFiltroDatas.FormattingEnabled = true;
            this.cmbFiltroDatas.Items.AddRange(new object[] {
            "anteriores",
            "futuras",
            "todas"});
            this.cmbFiltroDatas.Location = new System.Drawing.Point(31, 9);
            this.cmbFiltroDatas.Name = "cmbFiltroDatas";
            this.cmbFiltroDatas.Size = new System.Drawing.Size(137, 21);
            this.cmbFiltroDatas.TabIndex = 8;
            this.cmbFiltroDatas.Text = "Filtrar por datas";
            this.cmbFiltroDatas.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroDatas_SelectedIndexChanged);
            // 
            // criarDatasFuturasToolStripMenuItem
            // 
            this.criarDatasFuturasToolStripMenuItem.Name = "criarDatasFuturasToolStripMenuItem";
            this.criarDatasFuturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarDatasFuturasToolStripMenuItem.Text = "Criar Datas Futuras";
            // 
            // frmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 513);
            this.Controls.Add(this.pnlPresenca);
            this.Controls.Add(this.pnlExcluir);
            this.Controls.Add(this.pnlEditarOutroCadastro);
            this.Controls.Add(this.pnlCadastroNovo);
            this.Controls.Add(this.pnlEditarCadastro);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.pnlCadastroPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialisterne - Tutor";
            this.Load += new System.EventHandler(this.frmTutor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPresenca.ResumeLayout(false);
            this.pnlPresenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiltroGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlCadastroNovo.ResumeLayout(false);
            this.pnlCadastroNovo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrupo)).EndInit();
            this.pnlCadastroPesquisa.ResumeLayout(false);
            this.pnlCadastroPesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.pnlExcluir.ResumeLayout(false);
            this.pnlExcluir.PerformLayout();
            this.pnlEditarCadastro.ResumeLayout(false);
            this.pnlEditarCadastro.PerformLayout();
            this.pnlEditarOutroCadastro.ResumeLayout(false);
            this.pnlEditarOutroCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.pnlEditarControles.ResumeLayout(false);
            this.pnlEditarControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarGrupo)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presençaDoAlunosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPresenca;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem verDatasToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCadastroNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCadastroPesquisa;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtProcNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtSenhaAntiga;
        private System.Windows.Forms.Button btnEditarSenha;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckBox chbTutor;
        private System.Windows.Forms.Label lblErroNovo;
        private System.Windows.Forms.Panel pnlEditarCadastro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalvarEditar;
        private System.Windows.Forms.TextBox txtEmailEditar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNomeEditar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbExcluirUsuario;
        private System.Windows.Forms.Button btnExcluirConfirmar;
        private System.Windows.Forms.TextBox txtExcluirSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblExcluirErro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudGrupo;
        private System.Windows.Forms.Panel pnlEditarOutroCadastro;
        private System.Windows.Forms.ComboBox cmbEditarUsuarios;
        private System.Windows.Forms.Label lblEditarCadastro;
        private System.Windows.Forms.Button btnEditarOutrosLimpar;
        private System.Windows.Forms.Button btnSalvarOutroUsuario;
        private System.Windows.Forms.TextBox txtEditarEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEditarNome;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnlEditarControles;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudEditarGrupo;
        private System.Windows.Forms.TextBox txtEditarOutroConfirmacao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtEditarOutroSenha;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblErroEditarOutroUsuario;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.CheckBox chbFaltas;
        private System.Windows.Forms.NumericUpDown nudFiltroGrupo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbFiltroDatas;
        private System.Windows.Forms.ToolStripMenuItem criarDatasFuturasToolStripMenuItem;
    }
}