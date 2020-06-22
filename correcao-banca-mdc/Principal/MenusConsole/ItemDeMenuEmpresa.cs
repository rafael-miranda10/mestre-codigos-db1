using System;
using TrabalhandoNoConsole._2_Empresa;

namespace Principal.MenusConsole
{
    public class ItemDeMenuEmpresa
    {
        private Empresa _empresa;
        private string _nome;
        private double _salario;

        public ItemDeMenuEmpresa(Empresa empresa)
        {
            _empresa = empresa;
        }

        public void ExibirItemDeMenuEmpresa()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuEmpresa();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        CapturarDadosFuncionario();
                        _empresa.AdicionarFuncionario(_nome, _salario);
                        Console.ReadKey();
                        break;
                    case "2":
                        _empresa.ExibirMaiorMenorComFor();
                        Console.ReadKey();
                        break;
                    case "3":
                        _empresa.ExibirMaiorMenorComWhile();
                        Console.ReadKey();
                        break;
                    case "4":
                        _empresa.ExibirMaiorMenorComOrdencaoBolha();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuEmpresa()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Adicionar Funcionário");
            Console.WriteLine("2) Exibir Maior e Menor com FOR");
            Console.WriteLine("3) Exibir Maior e Menor com WHILE");
            Console.WriteLine("4) Exibir Maior e Menor com BublleSort");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }

        private void CapturarDadosFuncionario()
        {
            Console.Clear();
            _nome = CapturaDeDados.CapturarTextoDigitado("Informe o nome do funcionário: ");
            _salario = CapturaDeDados.CapturarNumeroDouble("Informe o salário do funcionário: ");
        }
    }
}
