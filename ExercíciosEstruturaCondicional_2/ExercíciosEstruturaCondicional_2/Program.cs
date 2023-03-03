namespace ExercíciosEstruturaCondicional_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            //Testar se o resto da divisão é igual a 0 para par.
            if (num % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

        }
    }
}