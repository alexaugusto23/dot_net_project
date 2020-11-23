using System;

namespace Revisao
{
    class Program
    {

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Todo: Adicionar aluno 
                        Console.WriteLine("Informe o nome do Aluno:");
                        //Aluno aluno = new Aluno();
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Informe a nota do Aluno:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
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
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar os alunos");
            Console.WriteLine("3 - Calculdar média geral");
            Console.WriteLine("X - Sair da Aplicação");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
