using System;

namespace ValaidacaodeNota
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cont = 0;
            double soma = 0;
            double media = 0;
            while (cont < 2)
            {
                Double nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    soma += nota;
                    cont++;

                }
                
            }
            media = soma/cont;
            //Console.WriteLine($"Contador {cont}");
            //Console.WriteLine($"Soma {soma}");
            Console.WriteLine($"media = {media.ToString("N2")}");

        }
    }
}
