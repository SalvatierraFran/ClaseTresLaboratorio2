using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTresLaboratorio2_01
{
    class Conversor
    {
        public static string DecimalBinario(double aux)
        { 
            int flag = 0;
            double modulo;
            int division;
            string binarioAux = "";
            do
            {
                modulo = aux % 2;
                division = aux / 2;

                if (modulo == 0)
                {
                    binarioAux = "0" + binarioAux;
                }

                if (modulo == 1)
                {
                    binarioAux = "1" + binarioAux;
                }

                if (division == 1 || division == 0)
                {
                    Convert.ToString(division);
                    binarioAux = division + binarioAux;
                    flag = 1;
                }
            } while (flag == 0);

            return binarioAux;
        }
    }
}
