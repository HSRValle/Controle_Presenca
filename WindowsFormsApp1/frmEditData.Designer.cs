namespace WindowsFormsApp1
{
    partial class frmEditData
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
            this.txtJustificativa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Location = new System.Drawing.Point(249, 261);
            this.txtJustificativa.Multiline = true;
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Size = new System.Drawing.Size(262, 124);
            this.txtJustificativa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Justificativa";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(246, 70);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data: ";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(247, 105);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(40, 13);
            this.lblAluno.TabIndex = 3;
            this.lblAluno.Text = "Aluno: ";
            // 
            // frmEditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJustificativa);
            this.Name = "frmEditData";
            this.Text = "frmEditData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJustificativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAluno;
    }
}