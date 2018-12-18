﻿using System;
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

        public Usuario(int id, string nome, string email, string senha, Boolean tutor = false)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.tutor = tutor;
        }
        public String getNome(){
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

            foreach(Data data in listaDatas)
            {
                if (dataAtual > data.getDataEsperada().AddMinutes(-10) && dataAtual < data.getDataEsperada().AddHours(3))
                    // Se o item da lista é a data mais próxima da data atual
                    if (!data.isRealSet())
                        data.marcaPresenca();                        
            }

        }
        public String getUsuario(int id)
        //Outro lugar?
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            
            try
            {                
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "SELECT * FROM new_schema.usuarios WHERE idUser = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader result = cmd.ExecuteReader();
                if (!result.HasRows)
                {
                    return "Nenhum resultado encontrado";
                }

                string retorno = "";
                while (result.Read())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        retorno += (result[i] + " -- ");
                    }
                }
                result.Close();
                return retorno;


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return ex.Message;
            }
        }
        public List<Usuario> getUsuarios()
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
                    retorno.Add(new Usuario(Int32.Parse(result["idUser"].ToString()), result["nome"].ToString(), result["email"].ToString(), result["senha"].ToString()));   
                }
                result.Close();
                return retorno;


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return retorno;
            }
        }
    }
}
