using System;

namespace QuantaMandioca
{
    class Program
    {
        static void Main(string[] args)
        {

            int chico = 300 * Int32.Parse(Console.ReadLine());
            int bento = 1500 * Int32.Parse(Console.ReadLine());
            int bernardo = 600 * Int32.Parse(Console.ReadLine());
            int marina = 1000 * Int32.Parse(Console.ReadLine());
            int iara = 150 * Int32.Parse(Console.ReadLine());
            int marlene = 225;
            int total = chico + 
                        bento +
                        bernardo +
                        marina +
                        iara +
                        marlene; // Digite aqui o calculo total

            Console.WriteLine(total);

        }
    }
}
