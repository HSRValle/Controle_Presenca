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
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarHistóricoDePresençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificarAusênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarCorreçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.ClientSize = new System.Drawing.Size(638, 349);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAluno";
            this.Text = "frmAluno";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}