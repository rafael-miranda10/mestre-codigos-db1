using System;

namespace Principal.MenusConsole
{
    public class MenuConsole
    {
        private MenuCalculadora _menuCalculadora;
        private MenuEmpresa _menuEmpresa;
        private MenuNumeroMultiplo _menuNumeroMultiplo;
        public MenuConsole()
        {
            _menuCalculadora = new MenuCalculadora();
            _menuEmpresa = new MenuEmpresa();
            _menuNumeroMultiplo = new MenuNumeroMultiplo();
        }

        public void ExibirMenuConsole()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuConsole();
                cki = Console.ReadKey(false); 
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _menuCalculadora.ExibirMenuCalculadora();
                        break;
                    case "2":
                        _menuEmpresa.ExibirMenuEmpresa();
                        break;
                    case "3":
                        _menuNumeroMultiplo.ExibirMenuNumeroMultiplo();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        public void OpcoesMenuConsole()
        {
            Console.Clear();
            Console.WriteLine("*** Mestre dos Códigos da DB1 Group - Trabalhando no Console ***\n");
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("5) Exercício 5");
            Console.WriteLine("6) Exercício 6");
            Console.WriteLine("7) Exercício 7");
            Console.WriteLine("8) Exercício 8");
            Console.WriteLine("9) Exercício 9");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\n Escolha uma opção: ");
        }
    }
}
