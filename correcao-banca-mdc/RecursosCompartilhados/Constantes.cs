﻿namespace RecursosCompartilhados
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

        #region Escola
        public const string AlunoNome = "Aluno.Nome";
        public const string AlunoNota1 = "Aluno.Nota1";
        public const string AlunoNota2 = "Aluno.Nota2";
        public const string MsgListaAlunosVazia = "A lista de alunos está vazia!";
        public const string AlunosAprovados = "Os alunos aprovados com média superior a 7 são: \n\n";
        public const string CorpoMensagemAlunosAprovados = "Nome: {0} Nota 1: {1} Nota 2: {2} Média: {3}\n";
        public const string MsgValidacaoAdicionarAluno = "Não é possível adicionar o aluno! Motivo: {0}";

        public const string MsgErroValidacaoAlunoNotaUmMaiorQueZero = "A nota 1 do aluno deve ser maior que 0 (zero)";
        public const string MsgErroValidacaoAlunoNotaDoisMaiorQueZero = "A nota 2 do aluno deve ser maior que 0 (zero)";
        public const string MsgErroValidacaoAlunoNotaUmMenorQueDez = "A nota 1 do aluno deve ser menor que 10";
        public const string MsgErroValidacaoAlunoNotaDoisMenorQueDez = "A nota 2 do aluno deve ser menor que 10 ";
        public const string MsgErroValidacaoAlunoNomeMin = "O nome do aluno deve conter pelo menos 3 caracteres";
        public const string MsgErroValidacaoAlunoNomeMax = "Nome do aluno deve conter até 50 caracteres";
        #endregion

        #region Equação
        public const string BaskaraA = "Bhaskara.A";
        public const string MsgValidacaoValorA = "O valor de A deve ser diferente de 0 para que seja uma equação do 2º Grau.";
        public const string MsgExibirResultadoFormula = "A formula de Bhaskara calculada com A: {0} B: {1} e C: {2} apresenta o resultado:\n";
        public const string MsgExibirR = "R{0}: {1}";
        public const string MsgValidacaoCalcularEquacao = "Não é possível calcular a formula de Bhaskara! Motivo: {0}";
        #endregion

        #region Modificador de Parametro
        public const string MsgExplicacaoModificadorParametro = "As palavras reservadas ref e out são usadas para passar argumento/parâmetro para um método ou função. Indica que um argumento/parâmetro é passado por referência.\n" +
                "Simplificadamente um parâmetro normal tem um sentido, ele só vai, o valor do argumento só é enviado para o parâmetro. O out também só tem um sentido, mas contrário, ele só passa o valor do parâmetro(o que está dentro do método) para o argumento.\n" +
                "O ref faz nos dois sentidos. Ele manda um valor do argumento para o parâmetro e devolve o valor do parâmetro para o argumento.\n" +
                "Ambos, argumento e parâmetro devem conter o modificador.\n\n" +
                "PALAVRA RESERVADA REF\n\n" +
                "Transmite argumentos como referência. Na pratica isso significa que quaisquer alterações feitas nesse argumento no método serão refletidas nessa variável quando o controle retornar ao método de chamada.\n\n" +
                "PALAVRA RESERVADA OUT\n\n" +
                "Indica que o argumento a ser passado receberá um valor dentro do método. Ou seja, é uma referência também, mas não é passado nenhum valor para o parâmetro, é apenas uma forma de dar saída para um valor. Isto normalmente é necessário porque o return só pode ter um valor.\n" +
                "Usando ele o argumento não precisa ter um valor mas o parâmetro precisa receber um valor antes de encerrar a execução do método. Ele é mais rápido em alguns cenários.";
        public const string MsgExecucaoRef = "O valor da variavel foi alterada pelo modificador 'Ref' recebendo um número inteiro, cujo valor é: {0}";
        public const string MsgExecucaoOut = "O valor da variavel foi alterada pelo modificador 'Out' recebendo um número inteiro, cujo valor é: {0}";
        #endregion

        #region Soma de Números Pares
        public const string MsgSomaNumerosPares = "A soma dos números pares é: {0}";
        public const string MsgNumerosParesListaVazia = "A lista de números inteiros está vazia!";
        #endregion

        #region Ordenação de Números
        public const string MsgOrdenacaoNumerosListaVazia = "A lista de números decimais está vazia!";
        public const string MsgOrdenacaoNumerosOrdenada = "Lista de números decimais ordenada  ";
        #endregion

        #region Biblioteca Linq
        public const string MsgLINQListaDeinteiros = "Lista de números inteiros: ";
        public const string MsgLINQListaEmOrdemCrescente = "Lista de Inteiros em Ordem Crescente: ";
        public const string MsgLINQListaEmOrdemDecrescente = "Lista de Inteiros em Ordem Decrescente: ";
        public const string MsgLINQPrimeiroElemento = "O primeiro elemento da lista é: {0}";
        public const string MsgLINQUltimoElemento = "O ultimo elemento da lista é: {0}";
        public const string MsgLINQInserirNoInicio = "Lista com o primeiro eLemento adicionado: ";
        public const string MsgLINQInserirNoFinal = "Lista com o ultimo eLemento adicionado: ";
        public const string MsgLINQPesquisaElemento = "Elemento pesquisado: {0} - O Elemento encontrado: {1}";
        public const string MsgLINQRemoverPrimeiroElemento = "Primeiro elemento da lista removido: ";
        public const string MsgLINQRemoverUltimoElemento = "Ultimo elemento da lista removido: ";
        public const string MsgLINQApenasNumerosPares = "Apenas os números pares da lista: ";
        public const string MsgLINQTransformadaArray = "A lista tranformada em Array: ";
        #endregion
    }
}
