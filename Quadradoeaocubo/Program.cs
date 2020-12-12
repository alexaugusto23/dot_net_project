using System;

namespace Quadradoeaocubo
{
    class Program
    {
        static void Main(string[] args)
        {
            float n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                Console.Write(i*i + " ");
                Console.Write(i*i*i);
                Console.Write("\n");

            }
        }
    }
}
