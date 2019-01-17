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
            this.data.justificativa = txtJustificativa.Text;
            DateTime novaDataEsperada = dateTimePickerData.Value.Date + dateTimePickerTime.Value.TimeOfDay;
            Console.WriteLine(novaDataEsperada);            
            /*
            if (radTodos.Checked)
            {
                
            }
            */
            // this.data.updateData();




        }
    }
}
