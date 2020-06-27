namespace TrabalhandoNoConsole._4_Escola
{
    public class FabricaAluno
    {
        public static Aluno Criar(string nome, double nota1, double nota2)
        {
            return new Aluno(nome, nota1, nota2);
        }
    }
}
