using System;

namespace Calculodeviagem
{
    class Program
    {
        static void Main(string[] args)
        {
                string [] entrada = Console.ReadLine().Split(" ");
                float qtd = Int32.Parse(entrada[0]) * Int32.Parse(entrada[1]);
                float valor = qtd/12;
                Console.WriteLine(valor.ToString("N3"));
        }
    }
}