using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;



namespace WindowsFormsApp1
{
    public class Data
    {
        private int id;
        private readonly DateTime dataEsperada;
        private DateTime dataReal;
        public Boolean presente;
        public Boolean noHorario;
        public String justificativa;
        public Usuario Aluno;
        public Usuario Tutor;

        public Data(DateTime dataEsperada, Usuario Aluno)
        {
            this.dataEsperada = dataEsperada;
            this.Aluno = Aluno;
        }
        public Data(int id, DateTime dataEsperada, DateTime dataReal, Boolean presente, Usuario Aluno, String justificativa, Usuario Tutor)
        {
            this.dataEsperada = dataEsperada;
            this.dataReal = dataReal;
            this.presente = presente;
            this.Aluno = Aluno;
            this.justificativa = justificativa;
            this.Tutor = Tutor;
        }
        public Data(MySqlDataReader retornoSql, List<Usuario> listaUsuarios)
        {
            this.id = Int32.Parse(retornoSql["iddata"].ToString());

            if (!Convert.IsDBNull(retornoSql["dataEsperada"]))
                this.dataEsperada = DateTime.Parse(retornoSql["dataEsperada"].ToString());
            if (!Convert.IsDBNull(retornoSql["dataReal"]))
                this.dataReal = DateTime.Parse(retornoSql["dataReal"].ToString());

            if (!Convert.IsDBNull(retornoSql["presente"]))
                if (retornoSql["presente"].ToString() == "1")
                    this.presente = true;
                else if (retornoSql["presente"].ToString() == "0")
                    this.presente = false;
            if (!Convert.IsDBNull(retornoSql["idAluno"]))
            {
                this.Aluno = listaUsuarios.Find(x => x.id == Int32.Parse(retornoSql["idAluno"].ToString()));
            }
            this.justificativa = retornoSql["justificativa"].ToString();
            if (!Convert.IsDBNull(retornoSql["idTutor"]))
            {
                this.Tutor = listaUsuarios.Find(x => x.id == Int32.Parse(retornoSql["idTutor"].ToString()));
            }
        }

        public void adicionaJustificativa(string mensagem, Usuario responsavel) {
            this.justificativa = mensagem;
            this.Tutor = responsavel;
        }
        public DateTime getDataEsperada()
        {
            return dataEsperada;
        }
        public DateTime getDataReal()
        {
            return dataReal;
        }
        public Boolean marcaPresenca()
        // Chamada quando o usuário loga. Compara a hora atual com a hora esperada e marca presença como true ou false
        {
            dataReal = DateTime.Now;
            this.presente = true;
            if (dataReal < dataEsperada.AddMinutes(15))
            {
                this.noHorario = true;
            }
            else
            {
                this.noHorario = false;
            }
            return updateData();
        }
        public String DebugData()
        {
            using (var writer = new System.IO.StringWriter())
            {
                ObjectDumper.Dumper.Dump(this, "Object Dumper", writer);
                Console.Write(writer.ToString());
                return writer.ToString();
            };            
        }
        public String SalvaMySql()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;           
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();
                return "Ok";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return ex.Message;
            }

        }        
        public Boolean updateData()
        {           
            MySql.Data.MySqlClient.MySqlConnection conn;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "UPDATE new_schema.datas ";

                sql += " SET dataEsperada = '" + this.dataEsperada.ToString("yyyy-MM-dd HH:mm:ss") + "',";
                if (this.isRealSet())
                    sql += " dataReal = '" + this.dataReal.ToString("yyyy-MM-dd HH:mm:ss") + "',";
                sql += " presente = " + this.presente + ",";
                sql += " noHorario = " + this.noHorario + ",";
                sql += " justificativa = '" + this.justificativa + "',";
                if (this.Tutor != null)
                    sql += " idTutor = " + this.Tutor.id + ",";
                sql += " idAluno = " + this.Aluno.id;

                sql += " WHERE iddata = " + this.id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public void insertNewData()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = Sql.Conection();
                conn.Open();

                string sql = "INSERT INTO new_schema.datas (dataEsperada, idAluno)";
                sql += " Values ('" + this.dataEsperada.ToString("yyyy-MM-dd HH:mm:ss") + "',";
                sql += " " + this.Aluno.id + ");";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        public Boolean isRealSet(){
            return this.dataReal.Year > 2;
        }

    }
}
