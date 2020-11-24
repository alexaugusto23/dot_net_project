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
                        foreach(var pessoa in alunos)
                        {
                            if(!string.IsNullOrEmpty(pessoa.Nome))
                            {
                                Console.WriteLine($"ALUNO: {pessoa.Nome} NOTA: {pessoa.Nota}");
                            }
                        }
                        break;

                    case "3":
                        //Todo: Calcular Média 
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for(int i=0; i< alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal/nrAlunos;
                        Conceito conceitoGeral;

                        if(mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if(mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }
                        
                        Console.WriteLine($"Média Geral: {mediaGeral} - Conceito Geral:  {conceitoGeral}");
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
