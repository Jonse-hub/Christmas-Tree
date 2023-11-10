using System;

namespace juletræ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            juletræ(10);
        }

        private static void juletræ(int højde)
        {

            for (int i = 0; i < højde; i++)
            {
                for (int c = højde - i; c > 0; c--)
                {
                    Console.Write(" ");
                }
                for (int b = 0; b < i*2; b++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
