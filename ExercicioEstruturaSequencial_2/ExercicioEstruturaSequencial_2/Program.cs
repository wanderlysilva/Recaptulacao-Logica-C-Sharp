﻿using System;
using System.Globalization;

namespace ExercicioEstruturaSequencial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, pi = 3.14159;
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A = " + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}