using System;
using System.Globalization;

namespace ExercicioEstruturasSquencial_1
{
    class Program
    {
       static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.Write("Resultado da adição = ");
            Console.WriteLine(a + b);

            Console.Write("Resultado da subtração = ");
            Console.WriteLine(a - b);

            Console.Write("Resultado da multiplicação = ");
            Console.WriteLine(a * b);
            Console.Write("Resultado da divizão = ");
            Console.WriteLine((double)a / b);
        }
    }
}