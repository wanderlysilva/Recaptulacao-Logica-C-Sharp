using System;
using System.Globalization;

namespace ExercicioEstruturaSequencial_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Numero do funcionario: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Digite quantas horas trabalhadas: ");
            int hora = int.Parse(Console.ReadLine());

            Console.Write("Valor por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = hora * valorHora; 

            Console.Write("NUMERO = " + number);
            Console.WriteLine();
            Console.Write("SALÁRIO = " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}