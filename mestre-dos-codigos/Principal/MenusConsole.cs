using System;
using TrabalhandoNoConsole.Exercicio_1.Interface;
using TrabalhandoNoConsole.Exercicio_2.Interface;
using TrabalhandoNoConsole.Exercicio_3.Interface;

namespace Principal
{
    public class MenusConsole 
    {
        private readonly IExercicio1 _exercicio1;
        private readonly IEmpresa _exercicio2;
        private readonly IMultiplos _exercicio3;

        public MenusConsole(IExercicio1 exercicio1, IEmpresa exercicio2, IMultiplos exercicio3)
        {
            _exercicio1 = exercicio1;
            _exercicio2 = exercicio2;
            _exercicio3 = exercicio3;
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

        private void CapturarInputFuncionario(out string Nome, out double Salario)
        {
            Console.Clear();
            Console.Write("Informe o nome do funcionário: ");
            Nome = Console.ReadLine();
            Console.Write("Informe o salário do funcionário: ");
            var aux = Console.ReadLine();
            if (!string.IsNullOrEmpty(aux))
                Salario = Convert.ToDouble(aux);
            else
                Salario = 0;
        }
    }
}
