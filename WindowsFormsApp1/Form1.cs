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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();

            if (false) //se o usuário logado é tutor
            {   // Recupera os usuários do banco            
                List<Usuario> todosUsuarios = getAllUsuarios();

                //Recupera as datas do banco
                List<Data> todasDatas = getAllDatas(todosUsuarios);
                
            }
            else //se o usuário logado é aluno
            {
                // Recupera os usuários do banco            
                List<Usuario> todosUsuarios = getAllUsuarios();               

                // Marca o usuário atual
                Usuario usuarioAtual = todosUsuarios[0];

                //Recupera as datas do banco associadas ao usuario
                List<Data> todasDatas = getAllDatas(todosUsuarios, usuarioAtual);

                createNextDatas(todasDatas, todosUsuarios);

                //usuarioAtual.marcaPresenca(todasDatas);   

            }



        }

        // Funções
        public List<Usuario> getAllUsuarios()
        {
            List<Usuario> retorno = new List<Usuario>();
            MySql.Data.MySqlClient.MySqlConnection conn;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "SELECT * FROM new_schema.usuarios;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {                    
                    retorno.Add(new Usuario(Int32.Parse(result["idUser"].ToString()), result["nome"].ToString(), result["email"].ToString(), result["senha"].ToString(), result["tutor"].ToString() == "1"));
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
        public List<Data> getAllDatas(List<Usuario> listaUsuarios, Usuario usuarioAtual = null)
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
    }
}
