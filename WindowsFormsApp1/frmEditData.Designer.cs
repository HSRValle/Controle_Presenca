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
            this.radUnico = new System.Windows.Forms.RadioButton();
            this.radTodos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Location = new System.Drawing.Point(250, 211);
            this.txtJustificativa.Multiline = true;
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Size = new System.Drawing.Size(331, 124);
            this.txtJustificativa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Justificativa:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(247, 69);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(72, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data original: ";
            // 
            // radUnico
            // 
            this.radUnico.AutoSize = true;
            this.radUnico.Location = new System.Drawing.Point(250, 157);
            this.radUnico.Name = "radUnico";
            this.radUnico.Size = new System.Drawing.Size(87, 17);
            this.radUnico.TabIndex = 4;
            this.radUnico.TabStop = true;
            this.radUnico.Text = "apenas para ";
            this.radUnico.UseVisualStyleBackColor = true;
            this.radUnico.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radTodos
            // 
            this.radTodos.AutoSize = true;
            this.radTodos.Location = new System.Drawing.Point(458, 157);
            this.radTodos.Name = "radTodos";
            this.radTodos.Size = new System.Drawing.Size(123, 17);
            this.radTodos.TabIndex = 5;
            this.radTodos.TabStop = true;
            this.radTodos.Text = "para todos os alunos";
            this.radTodos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alterar para:";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(249, 131);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerData.TabIndex = 7;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(482, 131);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerTime.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radTodos);
            this.Controls.Add(this.radUnico);
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
        private System.Windows.Forms.RadioButton radUnico;
        private System.Windows.Forms.RadioButton radTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Button button1;
    }
}