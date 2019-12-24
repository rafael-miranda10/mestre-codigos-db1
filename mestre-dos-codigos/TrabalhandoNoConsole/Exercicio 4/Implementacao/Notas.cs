using System;
using System.Collections.Generic;
using TrabalhandoNoConsole.Exercicio_4.Interface;

namespace TrabalhandoNoConsole.Exercicio_4.Implementacao
{
    public class Notas : INotas
    {
        public Notas()
        {
            alunos = new List<Aluno>();
        }

        public List<Aluno> alunos { get; private set; }

        public void ExibirAprovados()
        {
            if (alunos.Count > 0)
            {
                string aprovados = "Os alunos aprovados com média superior a 7 são: \n\n";
                foreach (var item in alunos)
                {
                    item.CalcularMedia();

                    if (item.Media > 7.0)
                        aprovados += $"Nome: {item.Nome} Nota 1: {item.Nota1} Nota 2: {item.Nota2} Média: {item.Media}\n";
                }
                Console.WriteLine(aprovados);
            }
            else
            {
                Console.WriteLine($"A lista de alunos está vazia!");
            }

        }

        public void IncluirAluno(string Nome, double Nota1, double Nota2)
        {
            var aluno = new Aluno(Nome, Nota1, Nota2);

            if (aluno.Invalid)
            {
                foreach (var item in aluno.Notifications)
                    Console.WriteLine($"Não é possível adicionar o aluno! Motivo: {item.Message}");

                Console.ReadKey();
            }

            if (aluno.Valid)
                alunos.Add(aluno);
        }
    }
}
