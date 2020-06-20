using System;
using TrabalhandoNoConsole._3__NumeroMultiplo;

namespace Principal.MenusConsole
{
    public class MenuNumeroMultiplo
    {
        private NumeroMultiplo _numeroMultiplo;
        public MenuNumeroMultiplo()
        {
            _numeroMultiplo = new NumeroMultiplo();
        }

        public void ExibirMenuNumeroMultiplo()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuNumeroMultiplo();
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

        private void OpcoesMenuNumeroMultiplo()
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
