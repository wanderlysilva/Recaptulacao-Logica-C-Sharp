﻿using System;
using System.Globalization;
using System.Threading.Channels;

namespace ExercicioFixacaoModulo3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu últimol nome, idade e altura: ");

            string[] vet = Console.ReadLine().Split(' ');
            string ultmoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine(name);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2" , CultureInfo.InvariantCulture));

            Console.WriteLine(ultmoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}