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



namespace WindowsFormsApp1
{
    public partial class frmTutor : Form
    {
        private List<Usuario> TodosUsuarios;
        private List<Data> TodasDatas;
        private void RefreshForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
        } 

        public frmTutor()
        {
            this.TodosUsuarios = Consulta.getUsuarios();
            this.TodasDatas = Consulta.getDatas(this.TodosUsuarios);
            InitializeComponent();
     

            //Filtra apenas as datas passadas
            List<Data> filtro = TodasDatas.FindAll(x => x.getDataEsperada().CompareTo(DateTime.Now) < 0);

            preencherDataGridView(filtro);
            //panel1.Hide();

        }
        private void preencherDataGridView(List<Data> listaDatas)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.ColumnCount = 6;

            dataGridView.Columns[0].Name = "Data";
            dataGridView.Columns[0].ValueType = typeof(DateTime);

            dataGridView.Columns[1].Name = "Aluno";

            dataGridView.Columns[2].Name = "Presente?";

            dataGridView.Columns[3].Name = "No horário?";

            dataGridView.Columns[4].Name = "Justificativa";

            dataGridView.Columns[5].Name = "Tutor";

            foreach (Data data in listaDatas)
            {
                int index = dataGridView.Rows.Add();
                dataGridView.Rows[index].Cells[0].Value = data.getDataEsperada();
                dataGridView.Rows[index].Cells[1].Value = data.Aluno.getNome();

                if (data.presente)
                {
                    dataGridView.Rows[index].Cells[2].Value = "Sim";
                    dataGridView.Rows[index].Cells[2].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[2].Value = "Não";
                    dataGridView.Rows[index].Cells[2].Style.BackColor = Color.IndianRed;
                }

                if (data.noHorario)
                {
                    dataGridView.Rows[index].Cells[3].Value = "Sim";
                    dataGridView.Rows[index].Cells[3].Style.BackColor = Color.ForestGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[3].Value = "Não";
                    dataGridView.Rows[index].Cells[3].Style.BackColor = Color.IndianRed;
                }
                if (data.justificativa.Length > 0)
                {
                    dataGridView.Rows[index].Cells[4].Value = data.justificativa;
                }

                if (data.Tutor != null)
                {
                    dataGridView.Rows[index].Cells[5].Value = data.Tutor.getNome();
                }
            }
        }

        private void frmTutor_Load(object sender, EventArgs e)
        {
            
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
        }
    }
}
