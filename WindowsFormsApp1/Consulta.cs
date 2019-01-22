using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    static class Consulta
    {
        public static List<Usuario> getUsuarios(Boolean tutores = false)
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
                    sql += "WHERE tutor = 1 ";
                }
                sql += "ORDER BY nome;";
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
        public static List<Data> getDatas(List<Usuario> listaUsuarios, Usuario usuarioAtual = null)
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
    }
}
