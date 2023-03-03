using System;

namespace EntradaDeDados_1
{
    class Program
    {
        static void main(string[] args)
        {

            string frase = Console.ReadLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);

            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            string[] vet1 = Console.ReadLine().Split(" ");
            string x1 = vet1[0];
            string x2 = vet1[1];
            string x3 = vet1[2];

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
        }
    }
}