﻿using System;
using System.Threading.Channels;

namespace ExercicioEstruturaSequencial_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,C,D, dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            dif = A*B - C*D;

            Console.WriteLine("Diferença = " + dif);
        }
    }
}