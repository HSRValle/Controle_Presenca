using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

/** lblResultado existe para que o resultado possa ser imprimido nessa label, mudar caso ache um metódo mais eficiente **/

namespace WindowsFormsApp1
{
    public partial class frmTutor : Form
    {
        private List<Usuario> TodosUsuarios;
        private List<Data> TodasDatas;
        private void RefreshForm()
        {
            //esconder todos os painéis
            pnlCadastroNovo.Hide();
            pnlPresenca.Hide();
            pnlCadastroPesquisa.Hide();
            pnlMudarSenha.Hide();
        } 

        public frmTutor()
        {
            this.TodosUsuarios = Consulta.getUsuarios();
            this.TodasDatas = Consulta.getDatas(this.TodosUsuarios);
            InitializeComponent();

            datasPassadasToolStripMenuItem_Click();

        }
        private void preencherDataGridView(List<Data> listaDatas)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.ColumnCount = 7;

            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].ValueType = typeof(int);

            dataGridView.Columns[1].Name = "Data";
            dataGridView.Columns[1].ValueType = typeof(DateTime);

            dataGridView.Columns[2].Name = "Aluno";

            dataGridView.Columns[3].Name = "Presente?";

            dataGridView.Columns[4].Name = "No horário?";

            dataGridView.Columns[5].Name = "Justificativa";

            dataGridView.Columns[6].Name = "Tutor";

            foreach (Data data in listaDatas)
            {
                int index = dataGridView.Rows.Add();

                dataGridView.Rows[index].Cells[0].Value = data.getId();

                dataGridView.Rows[index].Cells[1].Value = data.getDataEsperada();
                dataGridView.Rows[index].Cells[2].Value = data.Aluno.getNome();

                if (data.presente)
                {
                    dataGridView.Rows[index].Cells[3].Value = "Sim";
                    dataGridView.Rows[index].Cells[3].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[3].Value = "Não";
                    dataGridView.Rows[index].Cells[3].Style.BackColor = Color.IndianRed;
                }

                if (data.noHorario)
                {
                    dataGridView.Rows[index].Cells[4].Value = "Sim";
                    dataGridView.Rows[index].Cells[4].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[4].Value = "Não";
                    dataGridView.Rows[index].Cells[4].Style.BackColor = Color.IndianRed;
                }
                if (data.justificativa.Length > 0)
                {
                    dataGridView.Rows[index].Cells[5].Value = data.justificativa;
                }

                if (data.Tutor != null)
                {
                    dataGridView.Rows[index].Cells[6].Value = data.Tutor.getNome();
                }
            }
        }

        private void frmTutor_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        /**
        private void presençaDosAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection(Sql.Conection());
            sqlcon.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from new_schema.usuarios", sqlcon);
            DataSet ds = new DataSet();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(ds);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
            dataGridView1.Show();

        } **/

        private void procurarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlCadastroPesquisa.Show();
            pnlCadastroPesquisa.BringToFront();
        }

        private void datasFuturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Data> filtro = TodasDatas.FindAll(x => x.getDataEsperada().CompareTo(DateTime.Now) > 0);
            preencherDataGridView(filtro);
        }

        private void datasPassadasToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            List<Data> filtro = TodasDatas.FindAll(x => x.getDataEsperada().CompareTo(DateTime.Now) < 0);        
            preencherDataGridView(filtro);
            pnlPresenca.Show();
            pnlPresenca.BringToFront();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = int.Parse(dataGridView.Rows[index].Cells[0].Value.ToString());
            Data d = TodasDatas.Find(x => x.getId() == id);
            d.DebugData();
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /**fazer o painel relevante aparecer e o trazer para frente, 
            para ter certeza que não está escondio atrás de outro painel**/
            RefreshForm(); 
            pnlCadastroNovo.Show();
            pnlCadastroNovo.BringToFront();
        }

        private void editarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlMudarSenha.Show();
            pnlMudarSenha.BringToFront();
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
    }
}
