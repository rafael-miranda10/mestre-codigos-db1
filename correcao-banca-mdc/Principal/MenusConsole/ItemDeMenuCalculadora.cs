using System;
using System.Globalization;
using TrabalhandoNoConsole._1_Calculadora;

namespace Principal.MenusConsole
{
    public class ItemDeMenuCalculadora
    {
        private Calculadora _calculadora;
        private double _valorA;
        private double _valorB;
        public ItemDeMenuCalculadora(Calculadora calculadora)
        {
            _calculadora = calculadora;
        }

        public void ExibirItemDeMenuCalculadora()
        {
            ConsoleKeyInfo cki;
            CapturarDados();
            do
            {
                OpcoesItemDeMenuCalculadora();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _calculadora.Somar(_valorA, _valorB);
                        Console.ReadKey();
                        break;
                    case "2":
                        _calculadora.Subtrair(_valorA, _valorB);
                        Console.ReadKey();
                        break;
                    case "3":
                        _calculadora.Dividir(_valorA, _valorB);
                        Console.ReadKey();
                        break;
                    case "4":
                        _calculadora.Multiplicar(_valorA, _valorB);
                        Console.ReadKey();
                        break;
                    case "5":
                        _calculadora.VerificarSeValorDeAPar(_valorA);
                        _calculadora.VerificarSeValorDeBPar(_valorB);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuCalculadora()
        {
            Console.Clear();
            Console.WriteLine($"*** Os números informados são {_valorA} e {_valorB} ***\n\n");
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Somar");
            Console.WriteLine("2) Subtrair");
            Console.WriteLine("3) Dividir");
            Console.WriteLine("4) Multiplicar");
            Console.WriteLine("5) É Par?");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }

        private void CapturarDados()
        {
            Console.Clear();
            _valorA = CapturaDeDados.CapturarNumeroDouble("Informe o valor de A: ");
            _valorB = CapturaDeDados.CapturarNumeroDouble("Informe o valor de B: ");
        }
    }
}
