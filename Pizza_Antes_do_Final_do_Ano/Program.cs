using System;

namespace Pizza_Antes_do_Final_do_Ano
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ");
            int N = int.Parse(line[0]);
            int D = int.Parse(line[1]);
            string data = "";
            int qtd = 0;
            bool achou = false;

            for (int dt=0; dt<D; dt++){
            qtd = 0;
            string[] dados = Console.ReadLine().Split(" ");
            data =  dados[0];
            for (int p=1; p<N+1; p++){
                qtd += int.Parse( dados[p] );
            } //for  p
            achou = ( qtd == N);
            if (achou) { break; }
            } //for dt

            if (achou) { Console.Write(data); }
            else { Console.Write("Pizza antes de FdA");}
        }
    }
}


/*
entrada:
4 4
1/6/2016 0 0 1 0
12/7/2016 1 1 1 0
5/10/2016 1 1 1 1
25/12/2016 0 0 0 0

saída:
5/10/2016

entrada:
5 3
20/9/2016 0 1 1 1 1
30/9/2016 1 0 1 1 1
1/10/2016 1 1 0 1 1

saída:
Pizza antes de FdA

*/