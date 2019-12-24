using Flunt.Notifications;
using Flunt.Validations;

namespace TrabalhandoNoConsole.Exercicio_4.Implementacao
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
               .IsGreaterThan(Nota1, 0.0, "Aluno.Nota1", "A nota 1 do aluno deve ser maior que 0 (zero)")
               .IsGreaterThan(Nota2, 0.0, "Aluno.Nota2", "A nota 2 do aluno deve ser maior que 0 (zero)")
               .IsLowerOrEqualsThan(Nota1, 10.0, "Aluno.Nota1", "A nota 1 do aluno deve ser menor ou igual a 10")
               .IsLowerOrEqualsThan(Nota2, 10.0, "Aluno.Nota2", "A nota 2 do aluno deve ser menor ou igual a 10")
               .HasMinLen(Nome, 3, "Aluno.Nome", "O nome do aluno deve conter pelo menos 3 caracteres")
               .HasMaxLen(Nome, 50, "Aluno.Nome", "Nome do aluno deve conter até 50 caracteres")
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
