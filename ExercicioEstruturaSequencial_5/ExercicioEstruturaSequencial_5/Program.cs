using System;
using System.Globalization;

namespace ExercicioEstruturaSequencial_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, quant1,quant2;
            double prec1, prec2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            quant1 = int.Parse(valores[1]);
            prec1 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            quant2 = int.Parse(valores[1]);
            prec2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = quant1 * prec1 + quant2 * prec2;

            Console.WriteLine("VALOR A PAGAR = R$" + total.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}