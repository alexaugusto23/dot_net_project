using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Todo: Adicionar aluno 
                        break;


                    case "2":
                        //Todo: Listar alunos 
                        break;

                    case "3":
                        //Todo: Calcular Média 
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar os alunos");
            Console.WriteLine("3 - Calculdar média geral");
            Console.WriteLine("X - Sair da Aplicação");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
