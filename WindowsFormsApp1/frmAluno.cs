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
            this.Controls.Clear();
            this.InitializeComponent();
        }

        public frmAluno()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            pnlMudarSenha.Hide();
            pnlJustificar.Hide();
            pnlPresenca.Show();
            pnlPresenca.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void mudarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlMudarSenha.Show();
            pnlMudarSenha.BringToFront();
        }

        private void justificarAusênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlJustificar.Show();
            pnlJustificar.BringToFront();
        }

        private void consultarHistóricoDePresençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlPresenca.Show();
            pnlPresenca.BringToFront();
        }
    }
}
