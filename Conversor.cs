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
                modulo = aux % 2;//Obtengo los restos para ir acumulando hasta llegar al resultado.
                division = (int)aux / 2;//Obtengo el resultado para ir diviendo hasta llegar al resultado.

                if (modulo == 0)//If para acumular los 0.
                {
                    binarioAux = "0" + binarioAux;
                }

                if (modulo == 1)//If para acumular los 1.
                {
                    binarioAux = "1" + binarioAux;
                }

                if (division == 1 || division == 0)//If para comprobar si se puede seguir diviendo.
                {
                    Convert.ToString(division);
                    binarioAux = division + binarioAux;//Operacion para incluir el ultimo resultado de la division en el binario.
                    flag = 1;//bandera que indica que no se puede seguir diviendo.
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
                if ((auxiliar.Substring(i, 1)) == "1")//Cada vez que se encuentre un 1 en la posicion que marca i se procedera
                {                                     //a sumar las potencias segun el valor de h  
                    ConvertidoDecimal = ConvertidoDecimal + (Math.Pow(2, h));
                }
                h--;
            }

            return ConvertidoDecimal;
        }
    }
}
