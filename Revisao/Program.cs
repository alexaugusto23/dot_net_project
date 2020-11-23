using System;

namespace Revisao
{
    class Program
    {
        Aluno[] alunos = new Aluno[5];
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Todo: Adicionar aluno 
                        Console.WriteLine("Informe o nme do Aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
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
                opcaoUsuario = ObterOpcaoUsuario();
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
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
