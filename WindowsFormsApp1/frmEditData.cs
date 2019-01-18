﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmEditData : Form
    {
        private Data data;
        public frmEditData(Data data)
        {
            this.data = data;
            InitializeComponent();
            data.getDataEsperada();
            lblData.Text += data.getDataEsperada();

            radUnico.Text += data.Aluno.getNome();
            dateTimePickerData.Value = data.getDataEsperada();
            dateTimePickerTime.Value = data.getDataEsperada();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //A justificativa não pode ser vazia
            if (txtJustificativa.Text.Trim().Length <= 0)
                return;
            
            DateTime novaDataEsperada = dateTimePickerData.Value.Date + dateTimePickerTime.Value.TimeOfDay;                
            if (radTodos.Checked)
            {
                List<Usuario> alunos = frmTutor.TodosUsuarios.FindAll(x => !x.tutor);
                foreach (Usuario aluno in alunos)
                {                    
                    Data dataAluno = frmTutor.TodasDatas.Find(x => x.Aluno.Equals(aluno) && x.getDataEsperada().Equals(this.data.getDataEsperada()));                    
                    dataAluno.justificativa = txtJustificativa.Text;
                    dataAluno.setDataEsperada(novaDataEsperada);                                        
                    dataAluno.updateData();
                }
            }
            else
            {
                this.data.justificativa = txtJustificativa.Text;
                this.data.setDataEsperada(novaDataEsperada);
                this.data.updateData();
            }




        }
    }
}
