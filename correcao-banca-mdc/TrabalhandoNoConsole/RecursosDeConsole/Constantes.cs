namespace TrabalhandoNoConsole.RecursosDeConsole
{
    public class Constantes
    {
        #region Calculadora
        public const string OperacaoSoma = "soma";
        public const string OperacaoDivisao = "divisão";
        public const string OperacaoSubtracao = "subtração";
        public const string OperacaoMultiplicacao = "multiplicação";

        public const string MsgResultadoDoCalculo = "O resultado da {0} entre {1} e {2} é: {3}";
        public const string MsgResultadoEhPar = "O número {0} é par";
        public const string MsgResultadoEhImpar = "O número {0} é impar";
        #endregion

        #region Empresa
        public const string FuncionarioNome = "Funcionario.Nome";
        public const string FuncionarioSalario = "Funcionario.Salario";
        public const string MsgListaFuncionariosVazia = "A lista de funcionários está vazia!";

        public const string MsgValidacaoNomeTamanhoMini = "O nome do funcionário deve conter pelo menos 3 caracteres.";
        public const string MsgValidacaoNomeTamanhoMax = "Nome do funcionário deve conter até 50 caracteres.";
        public const string MsgValidacaoSalario = "O salário do funcionário deve ser maior que 0 (zero).";
        public const string MsgErroValidacaoFuncionario = "Não é possível adicionar o funcionário! Motivo: {0}";
        public const string MsgFuncionarioMaiorSalario = "O funcionário: {0} tem o maior salário: {1}";
        public const string MsgFuncionarioMenorSalario = "O funcionário: {0} tem o menor salário: {1}";

        #endregion

        #region NumerosMultiplos
        public const string MsgNumerosMultiplosPorProgressao = "O primeiro múltiplo de um número sempre será ele mesmo. Para descobrir os outros valores múltiplos de um número,\nbasta apenas somar o mesmo ao valor inicial, formando uma progressão aritmética.\n\n";
        public const string MsgNumerosMultiplosPorDivisao = "Os múltiplos de um determinado número são todos os valores que, quando divididos por aquele número, resultam em uma divisão exata e sem resto.\n\n";
        public const string MsgNumerosMultiplos = "O números multiplos de 3 entre 1 e 100 são: ";
        #endregion
    }
}
