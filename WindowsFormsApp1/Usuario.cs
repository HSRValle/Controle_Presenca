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
    }
}
