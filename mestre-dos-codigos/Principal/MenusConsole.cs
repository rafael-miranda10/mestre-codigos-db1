using System;
using System.Collections.Generic;
using TrabalhandoNoConsole.Exercicio_1.Interface;
using TrabalhandoNoConsole.Exercicio_2.Interface;
using TrabalhandoNoConsole.Exercicio_3.Interface;
using TrabalhandoNoConsole.Exercicio_4.Interface;
using TrabalhandoNoConsole.Exercicio_5.Interface;
using TrabalhandoNoConsole.Exercicio_6.Interface;
using TrabalhandoNoConsole.Exercicio_7.Interface;
using TrabalhandoNoConsole.Exercicio_8.Interface;
using TrabalhandoNoConsole.Exercicio_9.Interface;

namespace Principal
{
    public class MenusConsole
    {
        private readonly IExercicio1 _exercicio1;
        private readonly IEmpresa _exercicio2;
        private readonly IMultiplos _exercicio3;
        private readonly INotas _exercicio4;
        private readonly IFormula _exercicio5;
        private readonly IParametros _exercicio6;
        private readonly ISomaPar _exercicio7;
        private readonly IOrdenacao _exercicio8;
        private readonly ILinq _exercicio9;

        public MenusConsole(IExercicio1 exercicio1, IEmpresa exercicio2, IMultiplos exercicio3, INotas exercicio4,
                           IFormula exercicio5, IParametros exercicio6, ISomaPar exercicio7, IOrdenacao exercicio8,
                           ILinq exercicio9)
        {
            _exercicio1 = exercicio1;
            _exercicio2 = exercicio2;
            _exercicio3 = exercicio3;
            _exercicio4 = exercicio4;
            _exercicio5 = exercicio5;
            _exercicio6 = exercicio6;
            _exercicio7 = exercicio7;
            _exercicio8 = exercicio8;
            _exercicio9 = exercicio9;
        }

        public bool MenuExercicio1Console(double valorA, double valorB)
        {
            Console.Clear();
            Console.WriteLine($"*** Os números informados são {valorA} e {valorB} ***\n\n");
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Somar");
            Console.WriteLine("2) Subtrair");
            Console.WriteLine("3) Dividir");
            Console.WriteLine("4) Multiplicar");
            Console.WriteLine("5) É Par?");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    _exercicio1.Somar(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    _exercicio1.Subtrair(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    _exercicio1.Dividir(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    _exercicio1.Multiplicar(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.Clear();
                    _exercicio1.VerificarPar(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio2Console()
        {
            string Nome = ""; double Salario = 0;
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Adicionar Funcionário");
            Console.WriteLine("2) Exibir Maior e Menor com FOR");
            Console.WriteLine("3) Exibir Maior e Menor com WHILE");
            Console.WriteLine("4) Exibir Maior e Menor com BublleSort");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputFuncionario(out Nome, out Salario);
                    _exercicio2.AdicionarFuncionario(Nome, Salario);
                    return true;
                case "2":
                    Console.Clear();
                    _exercicio2.MaiorMenorFor();
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    _exercicio2.MaiorMenorWhile();
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    _exercicio2.MaiorMenorBubbleSort();
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio3Console()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Exibir Multiplos de 3 Por Divisão Exata");
            Console.WriteLine("2) Exibir Multiplos de 3 Por Progressão Aritimética");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    _exercicio3.Multiplo3Divisao();
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    _exercicio3.Multiplo3Progressao();
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio4Console()
        {
            string Nome = ""; double Nota1 = 0, Nota2 = 0;
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Adicionar Aluno");
            Console.WriteLine("2) Exibir Alunos Com Média Superior a 7");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputAluno(out Nome, out Nota1, out Nota2);
                    _exercicio4.IncluirAluno(Nome, Nota1, Nota2);
                    return true;
                case "2":
                    Console.Clear();
                    _exercicio4.ExibirAprovados();
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio5Console()
        {
            double a = 0, b = 0, c = 0;
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Informar os valores de A, B, C para calcular a formula de Bhaskara");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputBhaskara(out a, out b, out c);
                    Console.Clear();
                    _exercicio5.CalcularBhaskara(a, b, c);
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio6Console()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Exibir Texto Teorico");
            Console.WriteLine("2) Exemplo com Ref");
            Console.WriteLine("3) Exemplo Out");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    _exercicio6.ExibirExplicacao();
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    int valueR = 5;
                    _exercicio6.ExemploRef(ref valueR);
                    Console.WriteLine($"O valor da variavel foi alterada pelo modificador 'Ref' recebendo um número inteiro, cujo valor é:  {valueR}");
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    int valueO;
                    _exercicio6.ExemploOut(out valueO);
                    Console.WriteLine($"O valor da variavel foi alterada pelo modificador 'Out' recebendo um número inteiro, cujo valor é:  {valueO}");
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio7Console()
        {
            List<int> inteiros = new List<int>();
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Inserir 4 Números Inteiros");
            Console.WriteLine("2) Calcular os Números Pares por Divisão Exata");
            Console.WriteLine("3) Calcular os Números Pares por Divisão");
            Console.WriteLine("4) Calcular os Números Pares com Linq");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputListInteiros(inteiros, 4);
                    _exercicio7.SetLista(inteiros);
                    return true;
                case "2":
                    Console.Clear();
                    _exercicio7.SomarParDivisaoExata();
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    _exercicio7.SomarParDivisao();
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    _exercicio7.SomarParLinq();
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio8Console()
        {
            List<decimal> decimais = new List<decimal>();
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Inserir N Números Decimais");
            Console.WriteLine("2) Ordenação Manual Crescente");
            Console.WriteLine("3) Ordenação Manual Decrescente");
            Console.WriteLine("4) Ordenação Array Sort Crescente");
            Console.WriteLine("5) Ordenação Array Sort Decrescente");
            Console.WriteLine("6) Ordenação Linq Crescente");
            Console.WriteLine("7) Ordenação Linq Decrescente");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputListDecimais(decimais, 9999);
                    _exercicio8.Setlista(decimais);
                    return true;
                case "2":
                    Console.Clear();
                    _exercicio8.OrdenacaoManualCrescente();
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    _exercicio8.OrdenacaoManualDeCrescente();
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    _exercicio8.OrdenacaoArraySortCrescente();
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.Clear();
                    _exercicio8.OrdenacaoArraySortDeCrescente();
                    Console.ReadKey();
                    return true;
                case "6":
                    Console.Clear();
                    _exercicio8.OrdenacaoLinqCrescente();
                    Console.ReadKey();
                    return true;
                case "7":
                    Console.Clear();
                    _exercicio8.OrdenacaoLinqDeCrescente();
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio9Console()
        {
            int value;
            List<int> inteiros = new List<int>();
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Inserir N Números Inteiros");
            Console.WriteLine("2) Ordenação Crescente");
            Console.WriteLine("3) Ordenação Decrescente");
            Console.WriteLine("4) Primeiro Elemento da Lista");
            Console.WriteLine("5) Ultimo Elemento da Lista");
            Console.WriteLine("6) Remover o Primeiro elemento da Lista");
            Console.WriteLine("7) Remover o ultimo elemento da Lista");
            Console.WriteLine("8) Apenas os Números Pares da Lista");
            Console.WriteLine("9) Lista tranformada em Array");
            Console.WriteLine("10) Pesquisar um números da lista");
            Console.WriteLine("11) Inserir um número no Inicio da Lista");
            Console.WriteLine("12) Inserir um número no Final da Lista");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputListInteiros(inteiros, 9999);
                    _exercicio9.SetLista(inteiros);
                    return true;
                case "2":
                    Console.Clear();
                    _exercicio9.ExibirOrdemCrescente();
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    _exercicio9.ExibirOrdemDecrescente();
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    _exercicio9.ExibirPrimeiroDaLista();
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.Clear();
                    _exercicio9.ExibirUltimoDaLista();
                    Console.ReadKey();
                    return true;
                case "6":
                    Console.Clear();
                    _exercicio9.RemoverPrimeiroDaLista();
                    Console.ReadKey();
                    return true;
                case "7":
                    Console.Clear();
                    _exercicio9.RemoverUltimoDaLista();
                    Console.ReadKey();
                    return true;
                case "8":
                    Console.Clear();
                    _exercicio9.SomenteNumerosPar();
                    Console.ReadKey();
                    return true;
                case "9":
                    Console.Clear();
                    _exercicio9.TransformarListaEmArray();
                    Console.ReadKey();
                    return true;
                case "10":
                    Console.Clear();
                    CapturarInputInteiro(out value);
                    _exercicio9.PesquisarElemento(value);
                    Console.ReadKey();
                    return true;
                case "11":
                    Console.Clear();
                    CapturarInputInteiro(out value);
                    _exercicio9.InserirPrimeiroDaLista(value);
                    Console.ReadKey();
                    return true;
                case "12":
                    Console.Clear();
                    CapturarInputInteiro(out value);
                    _exercicio9.InserirUltimoDaLista(value);
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private void CapturarInputFuncionario(out string Nome, out double Salario)
        {
            Console.Clear();
            Console.Write("Informe o nome do funcionário: ");
            Nome = Console.ReadLine();
            Console.Write("Informe o salário do funcionário: ");
            Double.TryParse(Console.ReadLine(), out Salario);
        }

        private void CapturarInputAluno(out string Nome, out double Nota1, out double Nota2)
        {
            // deve-se informar os valores de nota com virgula , para a correta conversão para double
            Console.Clear();
            Console.Write("Informe o nome do aluno: ");
            Nome = Console.ReadLine();
            Console.Write($"Informe o nota 1 do {Nome}: ");
            // Nota1 = Convert.ToDouble(Console.ReadLine());
            var aux1 = Console.ReadLine();
            Nota1 = string.IsNullOrEmpty(aux1) ? 0 : Convert.ToDouble(aux1);
            Console.Write($"Informe o nota 2 do {Nome}: ");
            var aux2 = Console.ReadLine();
            Nota2 = string.IsNullOrEmpty(aux2) ? 0 : Convert.ToDouble(aux2);
        }

        private void CapturarInputBhaskara(out double a, out double b, out double c)
        {
            // deve-se informar os valores de nota com virgula , para a correta conversão para double
            Console.Clear();
            Console.Write("Informe o valor de A: ");
            var auxA = Console.ReadLine();
            a = string.IsNullOrEmpty(auxA) ? 0 : Convert.ToDouble(auxA);
            Console.Write("Informe o valor de B: ");
            var auxB = Console.ReadLine();
            b = string.IsNullOrEmpty(auxB) ? 0 : Convert.ToDouble(auxB);
            Console.Write("Informe o valor de C: ");
            var auxC = Console.ReadLine();
            c = string.IsNullOrEmpty(auxC) ? 0 : Convert.ToDouble(auxC);

        }

        private void CapturarInputListInteiros(List<int> inteiros, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                int resultado;
                do
                {
                    Console.WriteLine($"Informe o {i + 1} números inteiro: ");
                }
                while (!int.TryParse(Console.ReadLine(), out resultado));

                if (resultado == 0)
                {
                    i = tamanho;
                }
                else
                {
                    inteiros.Add(resultado);
                }

            }

        }

        private void CapturarInputListDecimais(List<decimal> decimais, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                decimal resultado;
                do
                {
                    Console.WriteLine($"Informe o {i + 1} número decimal: ");
                }
                while (!Decimal.TryParse(Console.ReadLine(), out resultado));

                if (resultado == 0)
                {
                    i = tamanho;
                }
                else
                {
                    decimais.Add(resultado);
                }

            }

        }

        private void CapturarInputInteiro(out int value)
        {
            do
            {
                Console.WriteLine("Informe o número desejado: ");
            }
            while (!int.TryParse(Console.ReadLine(), out value));
        }
    }
}
