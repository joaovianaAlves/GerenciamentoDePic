using Pic2024.models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Eixo eixoEscolhido = Eixo.EixosFixos[0];

        // Criar 90 alunos e tentar inscrevê-los no eixo escolhido
        for (int i = 1; i <= 45; i++)
        {
            Aluno aluno = new Aluno
            {
                NomeCompleto = $"Aluno {i}",
                Turma = $"Turma {((i - 1) / 15) + 1}", // Divide os alunos em 6 turmas de 15
                IsHighSchool = i <= 45 // Os primeiros 45 alunos são do high school
            };

            bool inscricaoPicSucesso = aluno.InscreverPic(eixoEscolhido);

            if (inscricaoPicSucesso)
            {
                // Encontrar a turma do aluno
                Turma turmaDoAluno = null;
                foreach (Turma turma in eixoEscolhido.Turmas)
                {
                    if (turma.Alunos.Contains(aluno))
                    {
                        turmaDoAluno = turma;
                        break;
                    }
                }

                // Imprimir as informações do aluno
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Inscrição do aluno {aluno.NomeCompleto} no PIC foi bem-sucedida!");
                Console.ResetColor();
                Console.WriteLine($"Aluno: {aluno.NomeCompleto}");
                Console.WriteLine($"Turma: {aluno.Turma}");
                Console.WriteLine($"PIC: {eixoEscolhido.Nome}");
                Console.WriteLine($"Horário: {turmaDoAluno.Horario}");
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Inscrição do aluno {aluno.NomeCompleto} no PIC falhou.");
                Console.ResetColor();
            }
        }
    }
}