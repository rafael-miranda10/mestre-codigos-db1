namespace TrabalhandoNoConsole._2_Empresa
{
    public class FabricaFuncionario
    {
        public static Funcionario Criar(string nome, double salario)
        {
            return new Funcionario(nome, salario);
        }
    }
}
