using System;

namespace CardapioAereo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] L1 = Console.ReadLine().Split(" ");
            int Pizza = int.Parse(L1[0]), Salada = int.Parse(L1[1]), Massa = int.Parse(L1[2]);

            string[] L2 = Console.ReadLine().Split(" ");
            int PizzaRef = int.Parse(L2[0]), SaladaRef = int.Parse(L2[1]), MassaRef = int.Parse(L2[2]);
            
            int soma = 0;

            int index0 = PizzaRef - Pizza;
            int index1 = SaladaRef - Salada;
            int index2 = MassaRef - Massa;

            Console.WriteLine(index0.ToString() + " " + index1.ToString() + " " + index2.ToString() + " ");
            
            if(PizzaRef >= Pizza)
            {
                soma += index0;
            }
            if(SaladaRef >= Salada)
            {
                soma += index1;
            }
            if(MassaRef>= Massa)
            {
                soma += index2;
            }
            Console.Write(soma);
        }
    }
}

/*

            Console.WriteLine("--------For--------");
            for (int i = 0; i< L1.Length ;i++)
            {
                Console.Write(L1[i] + " ");
            }
            Console.WriteLine("");

            for (int i = 0; i< L2.Length ;i++)
            {
                Console.Write(L2[i] + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("--------Foreach--------");
            
            foreach(string comida in L1)
            {
                Console.Write(comida + " ");
            }
            Console.WriteLine("");

            foreach(string pedido in L2)
            {
                Console.Write(pedido + " ");
            }
            Console.WriteLine("\n");
            
            Console.WriteLine("--------ConsolePrint--------");

            Console.WriteLine($"L1: {L1[0]+L1[1]+L1[2]}");
            Console.WriteLine($"L2: {L2[0]+L2[1]+L2[2]}");
            Console.WriteLine("");
            Console.Write(Pizza+ " " + Salada +  " " + Massa);
            Console.WriteLine("");
            Console.Write(PizzaRef+ " " + SaladaRef +  " " + MassaRef);

*/
