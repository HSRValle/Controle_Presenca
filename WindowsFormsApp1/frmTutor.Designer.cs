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
            this.cadastroDosAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presençaDosAlunosToolStripMenuItem,
            this.cadastroDosAlunosToolStripMenuItem,
            this.menuPessoalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // presençaDosAlunosToolStripMenuItem
            // 
            this.presençaDosAlunosToolStripMenuItem.Name = "presençaDosAlunosToolStripMenuItem";
            this.presençaDosAlunosToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.presençaDosAlunosToolStripMenuItem.Text = "Presença dos Alunos";
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
            this.procurarCadastroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.procurarCadastroToolStripMenuItem.Text = "Procurar Cadastro";
            // 
            // novoCadastroToolStripMenuItem
            // 
            this.novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            this.novoCadastroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.novoCadastroToolStripMenuItem.Text = "Novo Cadastro";
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editarCadastroToolStripMenuItem.Text = "Editar Cadastro";
            // 
            // excluirCadastroToolStripMenuItem
            // 
            this.excluirCadastroToolStripMenuItem.Name = "excluirCadastroToolStripMenuItem";
            this.excluirCadastroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
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
            this.checarCadastroToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.checarCadastroToolStripMenuItem.Text = "Checar Cadastro";
            // 
            // editarCadastroToolStripMenuItem1
            // 
            this.editarCadastroToolStripMenuItem1.Name = "editarCadastroToolStripMenuItem1";
            this.editarCadastroToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.editarCadastroToolStripMenuItem1.Text = "Editar Cadastro";
            // 
            // editarSenhaToolStripMenuItem
            // 
            this.editarSenhaToolStripMenuItem.Name = "editarSenhaToolStripMenuItem";
            this.editarSenhaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editarSenhaToolStripMenuItem.Text = "Editar Senha";
            // 
            // frmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 215);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialisterne - Tutor";
            this.Load += new System.EventHandler(this.frmTutor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}