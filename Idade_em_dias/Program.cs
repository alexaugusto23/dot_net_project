using System;

namespace Idade_em_dias
{
    class Program
    {
        static void Main(string[] args)
        {
                var idadeEmDias = int.Parse(Console.ReadLine());
                var anos = idadeEmDias/365; 
                var meses = (idadeEmDias%365)/30;  
                var dias =  (idadeEmDias-(365*anos))%30; 

                Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
        }
    }
}
