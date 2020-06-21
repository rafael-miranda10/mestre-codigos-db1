using System;
using TrabalhandoNoConsole._5_Bhaskara;

namespace Principal.MenusConsole
{
    public class MenuEquacao
    {
        private double _a;
        private double _b;
        private double _c;
        private Equacao _equacao;
        public MenuEquacao(Equacao equacao)
        {
            _equacao = equacao;
        }

        public void ExibirMenuCalculadora()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuEquacao();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        CapturarDadosEquacao();
                        Console.Clear();
                        _equacao.CalcularEquacao(_a, _b,_c);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesMenuEquacao()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Informar os valores de A, B, C para calcular a formula de Bhaskara");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }

        private void CapturarDadosEquacao()
        {
            Console.Clear();
            _a = CapturaDeDados.CapturarNumeroDouble("Informe o valor de A: ");
            _b = CapturaDeDados.CapturarNumeroDouble("Informe o valor de B: ");
            _c = CapturaDeDados.CapturarNumeroDouble("Informe o valor de C: ");
        }
    }
}
