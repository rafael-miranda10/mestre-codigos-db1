using Flunt.Notifications;
using Flunt.Validations;
using RecursosCompartilhados;

namespace TrabalhandoNoConsole._4_Escola
{
    public class Aluno : Notifiable
    {
        public Aluno(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;

            AddNotifications(new Contract()
               .Requires()
               .IsGreaterThan(Nota1, 0.0, Constantes.AlunoNota1, Constantes.MsgErroValidacaoAlunoNotaUmMaiorQueZero)
               .IsGreaterThan(Nota2, 0.0, Constantes.AlunoNota2, Constantes.MsgErroValidacaoAlunoNotaDoisMaiorQueZero)
               .IsLowerOrEqualsThan(Nota1, 10.0, Constantes.AlunoNota1, Constantes.MsgErroValidacaoAlunoNotaUmMenorQueDez)
               .IsLowerOrEqualsThan(Nota2, 10.0, Constantes.AlunoNota2, Constantes.MsgErroValidacaoAlunoNotaDoisMenorQueDez)
               .HasMinLen(Nome, 3, Constantes.AlunoNome, Constantes.MsgErroValidacaoAlunoNomeMin)
               .HasMaxLen(Nome, 50, Constantes.AlunoNome, Constantes.MsgErroValidacaoAlunoNomeMax)
               );
        }

        public string Nome { get; private set; }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }
        public double Media { get; private set; }

        public void CalcularMedia()
        {
            Media = (Nota1 + Nota2) / 2;
        }
    }
}
