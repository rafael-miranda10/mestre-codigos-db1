using System;
using UtilizandoPOO._1_POO;

namespace Principal.MenusPOO
{
    public class MenuPOO
    {
        private MenuProgramacaoOrientadaobjeto _menuProgramacaoOrientadaobjeto;
        public MenuPOO()
        {
            _menuProgramacaoOrientadaobjeto = new MenuProgramacaoOrientadaobjeto(new ProgramacaoOrientadaObjeto());
        }

        public void ExibirMenuPOO()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuPOO();
                cki = Console.ReadKey(false);
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _menuProgramacaoOrientadaobjeto.ExibirMenuProgramacaoOrientadaObjeto();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        public void OpcoesMenuPOO()
        {
            Console.Clear();
            Console.WriteLine("*** Mestre dos Códigos da DB1 Group - Utilizando POO ***\n");
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
