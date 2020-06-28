using System;
using TrabalhandoNoConsole._3__NumeroMultiplo;

namespace Principal.MenusConsole
{
    public class ItemDeMenuNumeroMultiplo
    {
        private INumeroMultiplo _numeroMultiplo;
        public ItemDeMenuNumeroMultiplo(INumeroMultiplo numeroMultiplo)
        {
            _numeroMultiplo = numeroMultiplo;
        }

        public void ExibirItemDeMenuNumeroMultiplo()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuNumeroMultiplo();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _numeroMultiplo.ExibirNumerosMultiplosDeTresPorDivisao();
                        Console.ReadKey();
                        break;
                    case "2":
                        _numeroMultiplo.ExibirNumerosMultiplosDeTresPorProgressao();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuNumeroMultiplo()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Exibir Multiplos de 3 Por Divisão Exata");
            Console.WriteLine("2) Exibir Multiplos de 3 Por Progressão Aritimética");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
