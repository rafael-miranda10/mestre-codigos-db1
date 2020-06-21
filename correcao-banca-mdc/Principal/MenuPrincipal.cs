using Principal.MenusConsole;
using Principal.MenusPOO;
using System;

namespace Principal
{
    public class MenuPrincipal
    {
        private MenuConsole _menuConsole;
        private MenuPOO _menuPoo;
        public MenuPrincipal()
        {
            _menuConsole = new MenuConsole();
            _menuPoo = new MenuPOO();
        }

        public void ExibirMenuPrincipal()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuPrincipal();
                cki = Console.ReadKey(false);
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _menuConsole.ExibirMenuConsole();
                        break;
                    case "2":
                        _menuPoo.ExibirMenuPOO();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        public void OpcoesMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("*** Bem-Vindo ao Mestre dos Códigos da DB1 Group - Nível Escudeiro ***\n\n");
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine(" 1) Trabalhando no console");
            Console.WriteLine(" 2) Utilizando POO");
            Console.WriteLine(" Esc) Sair");
            Console.Write("\r\n Escolha uma opção: ");
        }
    }
}
