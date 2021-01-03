using System;
using System.Linq;

namespace AlbumdaCopa
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeFigurinhas = int.Parse(Console.ReadLine());
            int numeroDeFigurinhasCompradas = int.Parse(Console.ReadLine());
            int totalDeFigurinhas = 0;
            int [] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];
            int fig = 0;
            
            for(int i = 0; i < albumDeFigurinha.Length; i++)
            {   
                int figurinha;
                figurinha = int.Parse(Console.ReadLine());
                albumDeFigurinha[i] = figurinha;
                fig ++;
            } 
            
            for(int i = 0; i < albumDeFigurinha.Length; i++)
            { 
                for(int x = i + 1; x < albumDeFigurinha.Length; x++)
                {
                    if(albumDeFigurinha[i] == albumDeFigurinha[x])
                    {
                        fig--;
                    }
                }
            } 

            totalDeFigurinhas = numeroDeFigurinhas;
            totalDeFigurinhas -= fig;
            Console.WriteLine(totalDeFigurinhas.ToString());
        }
    }
}

