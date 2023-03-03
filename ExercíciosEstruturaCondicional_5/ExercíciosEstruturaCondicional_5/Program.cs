using System.Globalization;

namespace ExercíciosEstruturaCondicional_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COGIGO = 1 / CACHORRO QUENTE");
            Console.WriteLine("COGIGO = 2 / X-SALADA");
            Console.WriteLine("COGIGO = 3 / X-BACON");
            Console.WriteLine("COGIGO = 4 / TORRADA SIMPLES");
            Console.WriteLine("COGIGO = 5 / REFRIGERANTE");
            Console.WriteLine();
            Console.WriteLine("DIGITE");
            Console.WriteLine("Codigo / Quantidade");
            

            string[] tabela = Console.ReadLine().Split(' ');
            int cod = int.Parse(tabela[0]);
            int quantidade = int.Parse(tabela[1]);

            double total;

            if (cod == 1 )
            {
                total = quantidade * 4.00;
                Console.WriteLine("Cachorro Quente: ");
            }
            else if ( cod == 2)
            {
                total = quantidade * 4.50;
                Console.WriteLine("X-Salada");
            }
            else if (cod == 3)
            {
                total = quantidade * 5.00;
                Console.WriteLine("X-Bacon");
            }
            else if (cod == 4)
            {
                total = quantidade * 2.00;
                Console.WriteLine("Torrada Simples");
            }
            else
            {
                total = quantidade * 1.50;
                Console.WriteLine("Refrigerante");
            }
            Console.WriteLine("TOTAL R$ = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}