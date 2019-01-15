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

            dataGridView.ColumnCount = 4;

            dataGridView.Columns[0].Name = "Data";
            dataGridView.Columns[0].ValueType = typeof(DateTime);

            dataGridView.Columns[1].Name = "Aluno";

            dataGridView.Columns[2].Name = "Presente?";

            dataGridView.Columns[3].Name = "No horário?";

            foreach (Data data in TodasDatas)
            {                
                int index = dataGridView.Rows.Add();
                dataGridView.Rows[index].Cells[0].Value = data.getDataEsperada();
                dataGridView.Rows[index].Cells[1].Value = data.Aluno.getNome();
                dataGridView.Rows[index].Cells[2].Value = data.presente;
                dataGridView.Rows[index].Cells[3].Value = data.noHorario;


            }
            //panel1.Hide();

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
