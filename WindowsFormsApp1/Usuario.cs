using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class Usuario
    {
        public int id;
        private String nome;
        private String email;
        private String senha;
        public Boolean tutor;
        public Usuario(int id)
        {
            this.id = id;
        }

        public Usuario(string nome, string email, string senha, Boolean tutor = false)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.tutor = tutor;
        }
        public Usuario(MySqlDataReader retornoSql)
        {
            this.id = Int32.Parse(retornoSql["idUser"].ToString());
            this.nome = retornoSql["nome"].ToString();
            this.email = retornoSql["email"].ToString();
            this.senha = retornoSql["senha"].ToString();
            this.tutor = retornoSql["tutor"].ToString() == "1";
        }
        public String getNome()
        {
            return this.nome;
        }

        public string DebugUsuario()
        {
            using (var writer = new System.IO.StringWriter())
            {
                ObjectDumper.Dumper.Dump(this, "Object Dumper", writer);
                Console.Write(writer.ToString());
                return writer.ToString();
            };

        }
        public void marcaPresenca(List<Data> listaDatas)
        {
            DateTime dataAtual = DateTime.Now;

            foreach (Data data in listaDatas)
            {
                if (dataAtual > data.getDataEsperada().AddMinutes(-10) && dataAtual < data.getDataEsperada().AddHours(3))
                    // Se o item da lista é a data mais próxima da data atual
                    if (!data.isRealSet())
                        data.marcaPresenca();
            }

        }
        public void updateUsuario(String nome, String email, Boolean tutor)
        {
            this.nome = nome;
            this.email = email;
            this.tutor = tutor;
            MySql.Data.MySqlClient.MySqlConnection conn;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "UPDATE new_schema.usuarios ";

                sql += " SET nome = '" + this.nome + "',";
                sql += " email = '" + this.email + "',";
                if (this.tutor)
                    sql += " tutor = 1,";
                else
                    sql += " tutor = 0,";
                sql += " senha = '" + this.senha + "'";

                sql += " WHERE idUser = " + this.id;


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void insertNewUsuario()
        {
            /*if(this.id != null) { 
             * se usuario já existe, gera uma mensagem de erro
            }*/
            MySql.Data.MySqlClient.MySqlConnection conn;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "INSERT INTO new_schema.usuarios (nome, email, senha, tutor)";
                sql += " Values ('" + this.nome + "',";
                sql += " '" + this.email + "', ";
                sql += " '" + this.senha + "', ";
                if (this.tutor)
                    sql += " 1 ";
                else
                    sql += " 0 ";
                sql += ");";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
