using Flunt.Notifications;
using Flunt.Validations;

namespace TrabalhandoNoConsole.Exercicio_2.Implementacao
{
    public class Funcionarios : Notifiable
    {
        public Funcionarios(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;

            AddNotifications(new Contract()
               .Requires()
               .IsGreaterThan(Salario, 0, "Funcionario.Salario", "O salário do funcionário deve ser maior que 0 (zero)")
               .HasMinLen(Nome, 3, "Funcionario.Nome", "O nome do funcionário deve conter pelo menos 3 caracteres")
               .HasMaxLen(Nome, 50, "Funcionario.Nome", "Nome do funcionário deve conter até 50 caracteres")
               );
        }

        public string Nome { get; private set; }
        public double Salario { get; private set; }
    }
}
