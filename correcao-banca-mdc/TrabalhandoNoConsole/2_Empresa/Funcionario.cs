using Flunt.Notifications;
using Flunt.Validations;
using RecursosCompartilhados;

namespace TrabalhandoNoConsole._2_Empresa
{
    public class Funcionario : Notifiable
    {
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;

            AddNotifications(new Contract()
               .Requires()
               .IsGreaterThan(Salario, 0, Constantes.FuncionarioSalario, Constantes.MsgValidacaoSalario)
               .HasMinLen(Nome, 3, Constantes.FuncionarioNome, Constantes.MsgValidacaoNomeTamanhoMini)
               .HasMaxLen(Nome, 50, Constantes.FuncionarioNome, Constantes.MsgValidacaoNomeTamanhoMax)
               );
        }

        public string Nome { get; private set; }
        public double Salario { get; private set; }
    }
}
