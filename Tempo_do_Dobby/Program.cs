using System;

namespace Tempo_do_Dobby
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            string[] minutos = Console.ReadLine().Split(" ");
            int presente1 = int.Parse(minutos[0]), presente2 = int.Parse(minutos[1]) ;
            int soma = presente1 + presente2;

            if(tempo < soma)
            {
                Console.Write("Deixa para amanha!");
            }
            else
            {
                Console.Write("Farei hoje!");
            }
        }
    }
}
