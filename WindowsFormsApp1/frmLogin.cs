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
            

            if (false) //se o usuário logado é tutor
            {   // Recupera os usuários do banco            
                List<Usuario> todosUsuarios = getUsuarios();

                //Recupera as datas do banco
                List<Data> todasDatas = getDatas(todosUsuarios);
                
            }
            else //se o usuário logado é aluno
            {
                // Não precisa obter os outros alunos. Apenas o aluno e os tutores serão utilizados:
                
                List<Usuario> usuariosNaMemoria = getUsuarios(true); //obtém os tutores do banco

                //usuariosNaMemoria.Add();  Adiciona o usuário atual na lista.                                 
                Usuario usuarioAtual = usuariosNaMemoria[0]; //remover quando a linha acima for concluída

                //Recupera as datas do banco associadas ao usuario
                List<Data> todasDatas = getDatas(usuariosNaMemoria, usuarioAtual);

                //createNextDatas(todasDatas, todosUsuarios);

                //usuarioAtual.marcaPresenca(todasDatas);   
                /*
                 * Exemplo de busca dentro da lista
                 * List<Data> temp = todasDatas.FindAll(x => x.Aluno.Equals(usuarioAtual) && x.presente);                
                */

            }



        }

        // Funções
        public List<Usuario> getUsuarios(Boolean tutores = false)
        {
            List<Usuario> retorno = new List<Usuario>();
            MySql.Data.MySqlClient.MySqlConnection conn;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "SELECT * FROM new_schema.usuarios ";
                if (tutores)
                {
                    sql += "WHERE tutor = 1";
                }
                sql += ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {                    
                    retorno.Add(
                        new Usuario(result)
                        );
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
        public List<Data> getDatas(List<Usuario> listaUsuarios, Usuario usuarioAtual = null)
        {
            List<Data> retorno = new List<Data>();
            MySql.Data.MySqlClient.MySqlConnection conn;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "SELECT * FROM new_schema.datas";
                if (usuarioAtual != null)
                    sql += " WHERE idAluno = " + usuarioAtual.id;
                sql += " ORDER BY dataEsperada DESC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    retorno.Add(new Data(result, listaUsuarios));
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
            string query = "Select * from new_schema.usuarios where nome= '" + txtNome.Text.Trim() + "' and senha = '" + txtSenha.Text.Trim() + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            string qtutor = "Select * from new_schema.usuarios where tutor=@tutor";
            MySqlDataAdapter sda2 = new MySqlDataAdapter(qtutor, sqlcon);
            bool tutor = Convert.ToBoolean("true");
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Sucesso!");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Senha ou nome incorretos!");
            }
            if (tutor == true)
            {
                frmTutor frmTutor = new frmTutor();
                frmTutor.Show();
            }
            else
                MessageBox.Show("Git gud");

                                
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
