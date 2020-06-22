using System;
using UtilizandoPOO._1_POO;

namespace Principal.MenusPOO
{
    public class MenuProgramacaoOrientadaobjeto
    {
        private ProgramacaoOrientadaObjeto _programacaoOrientadaObjeto;
        private MenuFormaGeometrica _menuFormaGeometrica;
        
        public MenuProgramacaoOrientadaobjeto(ProgramacaoOrientadaObjeto programacaoOrientadaObjeto)
        {
            _programacaoOrientadaObjeto = programacaoOrientadaObjeto;
        }

        public void ExibirMenuProgramacaoOrientadaObjeto()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuProgramacaoOrientadaObjeto();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _menuFormaGeometrica = new MenuFormaGeometrica(_programacaoOrientadaObjeto);
                        _menuFormaGeometrica.ExibirMenuFormaGeometrica();
                        Console.ReadKey();
                        break;
                    case "2":
                        _programacaoOrientadaObjeto.ExecutarDescartavel();
                        Console.ReadKey();
                        break;
                    case "3":
                        _programacaoOrientadaObjeto.ExecutarComparavel();
                        Console.ReadKey();
                        break;
                    case "4":
                        _programacaoOrientadaObjeto.ExecutarClonavel();
                        Console.ReadKey();
                        break;
                    case "5":
                        _programacaoOrientadaObjeto.ExecutarEnumeravel();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesMenuProgramacaoOrientadaObjeto()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Abstração/Polimorfismo/Encapsulamento");
            Console.WriteLine("2) IDisposable");
            Console.WriteLine("3) IComparable");
            Console.WriteLine("4) ICloneable");
            Console.WriteLine("5) INumerable");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
