using RecursosCompartilhados;
using System;
using System.Collections.Generic;

namespace TrabalhandoNoConsole._4_Escola
{
    public class Escola : IEscola
    {
        public Escola()
        {
            Alunos = new List<Aluno>();
        }

        public List<Aluno> Alunos { get; private set; }

        public void ExibirAlunosAprovados()
        {
            if (Alunos.Count > 0)
            {
                string exibirAlunosAprovados = Constantes.AlunosAprovados;
                foreach (var aluno in Alunos)
                {
                    aluno.CalcularMedia();

                    if (aluno.Media > 7.0)
                        exibirAlunosAprovados += string.Format(Constantes.CorpoMensagemAlunosAprovados,
                                                                aluno.Nome, aluno.Nota1, aluno.Nota2, aluno.Media);
                }
                Console.WriteLine(exibirAlunosAprovados);
            }
            else
            {
                Console.WriteLine(Constantes.MsgListaAlunosVazia);
            }
        }

        public void AdicionarAluno(string nome, double nota1, double nota2)
        {
            var aluno = FabricaAluno.Criar(nome, nota1, nota2);

            if (aluno.Invalid)
            {
                foreach (var item in aluno.Notifications)
                    Console.WriteLine(Constantes.MsgValidacaoAdicionarAluno, item.Message);
                Console.ReadKey();
            }

            if (aluno.Valid)
                Alunos.Add(aluno);
        }
    }
}
