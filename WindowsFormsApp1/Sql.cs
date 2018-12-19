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
            return "server=127.0.0.1:3307;uid=root;pwd=admin;database=new_schema";
        }
    }
}
