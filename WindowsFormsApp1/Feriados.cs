using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Feriados
    {
        private static DateTime[] feriados = {            
            new DateTime(2019, 01, 25), // Aniversário da cidade
            new DateTime(2019, 03, 04), // Carnaval
            new DateTime(2019, 03, 05), // Carnaval
            new DateTime(2019, 03, 06), // Carnaval                        
            new DateTime(2019, 04, 19), // Sexta-feira santa
            new DateTime(2019, 04, 21), // Tiradentes
            new DateTime(2019, 05, 01), // Dia do trabalho
            new DateTime(2019, 06, 20), // Corpus Christi
            new DateTime(2019, 09, 07), // Independência
            new DateTime(2019, 10, 12), // Nossa Senhora Aparecida
            new DateTime(2019, 11, 02), // Finados
            new DateTime(2019, 11, 15), // Proclamação da República
            new DateTime(2019, 11, 20)  // Dia da consiência Negra
        };
        public static Boolean verificar(DateTime data)
        {
            return feriados.Contains(data);
        }
    }
}
