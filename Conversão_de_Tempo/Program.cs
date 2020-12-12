using System;

namespace Conversão_de_Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            int tempo = int.Parse(entrada);
            double horas = horas = (tempo / 3600);
            double minutos = (tempo%3600) / 60;
            double segundos = (tempo%3600)%60; 

            Console.Write(horas + ":" + minutos + ":" + segundos);
        }
    }
}
