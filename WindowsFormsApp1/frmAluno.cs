using System;
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
        private void RefreshForm()
        {
            //esconder todos os painéis
           
            pnlMudarSenha.Hide();
        }

        public frmAluno()
        {
            InitializeComponent();
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
    }
}
