using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Sql
    {
        public static String Conection(){
            //Henrique
            //return "server=127.0.0.1;uid=root;pwd=admin;database=new_schema";
            //Natalia
            return "server=127.0.0.1;port=3307;uid=root;pwd=senhasecreta;database=new_schema";
        }
    }
}
