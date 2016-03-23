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
                division = (int)aux / 2;

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

                aux = division;

            } while (flag == 0);

            return binarioAux;
        }

        public static double BinarioDecimal(string auxiliar)
        {
            double ConvertidoDecimal = 0;

            int h = auxiliar.Length - 1;

            for (int i = 0; i < auxiliar.Length; i++)
            {
                if ((auxiliar.Substring(i, 1)) == "1")
                {
                    ConvertidoDecimal = ConvertidoDecimal + (Math.Pow(2, h));
                }
                h--;
            }

            return ConvertidoDecimal;
        }
    }
}
