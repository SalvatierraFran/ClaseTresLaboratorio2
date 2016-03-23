using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTresLaboratorio2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double Decimal;
            string Binario = "";

            string binario2 = "";
            double Decimal2;

            Console.WriteLine("Ingrese numero entero: ");
            Decimal = double.Parse(Console.ReadLine());

            Binario = Conversor.DecimalBinario(Decimal);

            Console.WriteLine(Binario);

            Console.WriteLine("Ingrese numero binario: ");
            binario2 = Console.ReadLine();

            Decimal2 = Conversor.BinarioDecimal(binario2);

            Console.WriteLine(Decimal2);

            Console.ReadKey();
        }
    }
}
