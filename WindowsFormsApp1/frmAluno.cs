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
    public partial class frmAluno : Form
    {
        private Usuario Aluno;
        private void RefreshForm()
        {
            //esconder todos os painéis
           
            pnlMudarSenha.Hide();
            pnlPresenca.Hide();
            pnlCorrecao.Hide();
            pnlJustificativa.Hide();
        }

        public frmAluno(Usuario aluno)
        {
            InitializeComponent();
            this.Aluno = aluno;
        }

        private void txtConfSenha_TextChanged(object sender, EventArgs e)
        {
            string NovaSenha = txtNovaSenha.ToString();
            string ConfSenha = txtConfSenha.ToString();
            if (NovaSenha != ConfSenha)
            {
                lblErro.Text = "Senhas não correspondem.";
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void mudarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlMudarSenha.Show();
            pnlMudarSenha.BringToFront();
        }

        private void consultarHistóricoDePresençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlPresenca.Show();
            pnlPresenca.BringToFront();

            List<Data> listaDatas = Consulta.getDatas(Consulta.getUsuarios(), this.Aluno);

            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView.ColumnCount = 7;

            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].ValueType = typeof(int);

            dataGridView.Columns[1].Name = "Dia";
            dataGridView.Columns[1].ValueType = typeof(DateTime);
            dataGridView.Columns[1].FillWeight = 10;

            dataGridView.Columns[2].Name = "Hora";
            dataGridView.Columns[2].ValueType = typeof(DateTime);
            dataGridView.Columns[2].FillWeight = 9;
            

            dataGridView.Columns[3].Name = "Presente?";
            dataGridView.Columns[3].FillWeight = 13;

            dataGridView.Columns[4].Name = "No horário?";
            dataGridView.Columns[4].FillWeight = 13;

            dataGridView.Columns[5].Name = "Justificativa";
            dataGridView.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.Columns[5].FillWeight = 26;

            dataGridView.Columns[6].Name = "Tutor";
            dataGridView.Columns[6].FillWeight = 13;

            foreach (Data data in listaDatas)
            {
                int index = dataGridView.Rows.Add();

                dataGridView.Rows[index].Cells[0].Value = data.getId();

                dataGridView.Rows[index].Cells[1].Value = data.getDataEsperada().Date;
                dataGridView.Rows[index].Cells[2].Value = data.getDataEsperada().TimeOfDay;

                if (data.presente)
                {
                    dataGridView.Rows[index].Cells[3].Value = "Sim";
                    dataGridView.Rows[index].Cells[3].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[3].Value = "Não";
                    dataGridView.Rows[index].Cells[3].Style.BackColor = Color.IndianRed;
                }

                if (data.noHorario)
                {
                    dataGridView.Rows[index].Cells[4].Value = "Sim";
                    dataGridView.Rows[index].Cells[4].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[4].Value = "Não";
                    if (data.isRealSet())
                    {
                        dataGridView.Rows[index].Cells[4].Value += " (" + data.getDataReal().TimeOfDay + ")";
                    }
                    dataGridView.Rows[index].Cells[4].Style.BackColor = Color.IndianRed;
                }
                if (data.justificativa != null && data.justificativa.Length > 0)
                {
                    dataGridView.Rows[index].Cells[5].Value = data.justificativa;
                }

                if (data.Tutor != null)
                {
                    dataGridView.Rows[index].Cells[6].Value = data.Tutor.getNome();
                }
            }
        }

        private void justificarAusênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlJustificativa.Show();
            pnlJustificativa.BringToFront();
        }

        private void solicitarCorreçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlCorrecao.Show();
            pnlCorrecao.BringToFront();
        }

        
    }
}
