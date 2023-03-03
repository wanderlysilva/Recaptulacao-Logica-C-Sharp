using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador OU - uma das condições tem que ser verdadeiras
            bool c1 = 2 > 3 || 4 != 7;

            Console.WriteLine(c1);

            //Operador NÃO - inverte a condição de falso para verdadeiro 
            bool c2 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c2);
        }
    }
}