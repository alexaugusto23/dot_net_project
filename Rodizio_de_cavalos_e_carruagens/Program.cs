using System;
using System.Linq;

namespace Rodizio_de_cavalos_e_carruagens
{
    class Program
    {
            static void Main(string[] args)
            {
                int quantidadeTestes = int.Parse(Console.ReadLine());
                string[] Placas = new string[quantidadeTestes];

                for (int i = 0; i < quantidadeTestes; i++) 
                {
                    Placas[i] = Console.ReadLine();
                }

                for (int i = 0; i < quantidadeTestes; i++) {
                if (ValidarPlaca(Placas[i]) == true) {
                    int dig = PegarUltimo(Placas[i]);
                    string rod = CalcularRod(dig);
                    Console.WriteLine(rod);
                } else {
                    Console.WriteLine("FALHA");
                }
            }
        }


        public static bool ValidarPlaca(string placa) 
        { 
            string[] campos = placa.Split("-");
            if (campos.Length == 2) {
                string letras = campos[0];
                string nums = campos[1];
                if (letras.Length == 3 && nums.Length == 4) 
                {
                    if (letras.All(char.IsLetter) && letras.All(char.IsUpper) && nums.All(char.IsDigit)) 
                    {
                        return true;
                    } else {return false;}
                } else {return false;}
            } else {return false;}
        }


        public static int PegarUltimo(string placa) 
        {
            return int.Parse(placa.Substring(placa.Length -1));
        }


        public static string CalcularRod(int digito) 
        {
            if (digito == 1 || digito == 2) 
                {
                    return "SEGUNDA";
                } 
            else if (digito == 3 || digito == 4) 
                {
                    return "TERCA";
                } 
            else if (digito == 5 || digito == 6) 
                {
                    return "QUARTA";
                } 
            else if (digito == 7 || digito == 8) 
                {
                    return "QUINTA";
                } 
            else if (digito == 9 || digito == 0) 
                {
                    return "SEXTA";
                } 
            else 
                {
                    return "FALHA";
                }
        }
    }
    
}