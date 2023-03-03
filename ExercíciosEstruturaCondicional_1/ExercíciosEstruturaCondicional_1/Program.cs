namespace ExercíciosEstruturaCondicional_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if ( num < 0 ) 
            {
                Console.WriteLine("Negativo");
            }
            else 
            { 
                Console.WriteLine("Não Negativo"); 
            }
        }
    }
}