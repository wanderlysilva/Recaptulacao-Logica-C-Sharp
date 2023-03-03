namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Bom dia!");

            if (x < 5)
            {
                Console.WriteLine("Boa tarde!");
            }
            Console.WriteLine("Boa noite!");


            Console.WriteLine("Entre com um número inteiro: ");
            int y = int.Parse(Console.ReadLine());

            if ( y % 2 == 0)
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