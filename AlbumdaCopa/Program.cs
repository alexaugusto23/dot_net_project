using System;

namespace AlbumdaCopa
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
            int totalDeFigurinhas = 0;
            int [] albumDeFigurinha = new int[numeroDeFigurinhas];
            int countfig = 0;

            for(int i = 0; i < albumDeFigurinha.Length; i++)
            {
                int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
                albumDeFigurinha[i] = numeroDeFigurinhasCompradas;
                if(albumDeFigurinha[i] > 0)
                {countfig++;}

                //Console.WriteLine(albumDeFigurinha[i]);
            }

            for (int i = 0; i < countfig; i++)
            {
                for( int j=1; j < countfig; j++)
                {
                    //Console.Write(albumDeFigurinha[i] + " ");
                    //Console.WriteLine(albumDeFigurinha[j]);
                    if(albumDeFigurinha[0] == albumDeFigurinha[j])
                    {
                        countfig -= 1;
                    } 
                }

            }
            //Console.WriteLine($"countfig: {countfig}");

            totalDeFigurinhas = numeroDeFigurinhas;
            totalDeFigurinhas -= countfig;
            //Console.WriteLine($"Total de figurinhas: {totalDeFigurinhas - countfig}");
            Console.WriteLine(totalDeFigurinhas);
        }
    }
}
