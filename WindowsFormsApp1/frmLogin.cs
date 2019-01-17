using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using ObjectDumper;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();                       
        }

        // Funções
        public Usuario getUsuario(string nome)
        {
            Usuario retorno = null;
            MySql.Data.MySqlClient.MySqlConnection conn;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "SELECT * FROM new_schema.usuarios ";
                sql += "WHERE nome = '" + nome + "'";
                sql += ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    retorno = new Usuario(result);
                    retorno.DebugUsuario();
                }
                result.Close();
                return retorno;


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write(ex);
                return retorno;
            }
        }        
        public Boolean createNextDatas(List<Data> listaData, List<Usuario> listaUsuarios, int dias = 7)
        {
            List<Data> novasDatas = new List<Data>();


            DateTime hoje = DateTime.Now;
            TimeSpan manha = new TimeSpan(9, 0, 0);
            TimeSpan tarde = new TimeSpan(13, 30, 0);
            for (int i = 1; i <= dias; i++)
            {
                DateTime novaData = hoje.AddDays(i);
                novaData = novaData.Date + manha;
                if (novaData.DayOfWeek != DayOfWeek.Saturday && novaData.DayOfWeek != DayOfWeek.Sunday)
                {                    
                    foreach (Usuario usuario in listaUsuarios)
                    {
                        if (!usuario.tutor) {
                            //Se é aluno
                            Data insert = new Data(novaData.Date + manha, usuario);
                            insert.insertNewData();
                            if (novaData.DayOfWeek != DayOfWeek.Monday && novaData.DayOfWeek != DayOfWeek.Friday)
                            {
                                insert = new Data(novaData.Date + tarde, usuario);
                                insert.insertNewData();
                                listaData.Add(insert);


                            }

                        }
                        // Else com horários para tutores?
                    }
                }

            }
            foreach (Data d in novasDatas) {
                d.DebugData();
            }
            return true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {         
            MySqlConnection sqlcon = new MySqlConnection(Sql.Conection());
            Usuario usuario = getUsuario(txtNome.Text.Trim());
            if (usuario != null && usuario.comparaSenha(txtSenha.Text.Trim()))
            {
                
                if (usuario.tutor)
                {
                    this.Hide();
                    //abre dash dos tutores se o usuario for tutor(a).
                    frmTutor frmTutor = new frmTutor(usuario);                    
                    frmTutor.Show();

                }
                else {
                    List<Usuario> usuariosNaMemoria = Consulta.getUsuarios(true);
                    usuariosNaMemoria.Add(usuario);
                    List<Data> datas = Consulta.getDatas(usuariosNaMemoria, usuario);
                    if (usuario.marcaPresenca(datas))
                    {
                        MessageBox.Show("Presença confirmada!\n" + DateTime.Now.ToString());
                    }                    
                    //exibe lista de datas
                    foreach (Data data in datas)
                        data.DebugData();
                    


                }
            }
            else{
                MessageBox.Show("Usuário ou senha inválidos");

            }
            return;            
                                                 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
