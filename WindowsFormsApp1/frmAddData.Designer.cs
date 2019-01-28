﻿namespace WindowsFormsApp1
{
    partial class frmAddData
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
            this.calInicio = new System.Windows.Forms.MonthCalendar();
            this.calFim = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxAlunos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calInicio
            // 
            this.calInicio.Location = new System.Drawing.Point(155, 72);
            this.calInicio.MaxSelectionCount = 1;
            this.calInicio.Name = "calInicio";
            this.calInicio.TabIndex = 2;
            this.calInicio.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calInicio_DateChanged);
            // 
            // calFim
            // 
            this.calFim.Location = new System.Drawing.Point(449, 72);
            this.calFim.MaxSelectionCount = 1;
            this.calFim.MinDate = new System.DateTime(2019, 1, 10, 0, 0, 0, 0);
            this.calFim.Name = "calFim";
            this.calFim.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Começar por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Até";
            // 
            // lbxAlunos
            // 
            this.lbxAlunos.FormattingEnabled = true;
            this.lbxAlunos.Location = new System.Drawing.Point(155, 276);
            this.lbxAlunos.Name = "lbxAlunos";
            this.lbxAlunos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxAlunos.Size = new System.Drawing.Size(95, 95);
            this.lbxAlunos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alunos";
            // 
            // frmAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxAlunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calFim);
            this.Controls.Add(this.calInicio);
            this.Name = "frmAddData";
            this.Text = "frmAddData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calInicio;
        private System.Windows.Forms.MonthCalendar calFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxAlunos;
        private System.Windows.Forms.Label label3;
    }
}