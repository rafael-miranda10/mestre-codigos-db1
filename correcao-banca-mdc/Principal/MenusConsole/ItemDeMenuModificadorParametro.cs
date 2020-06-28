using RecursosCompartilhados;
using System;
using TrabalhandoNoConsole._6_ModificadorParametro;

namespace Principal.MenusConsole
{
    public class ItemDeMenuModificadorParametro
    {
        private int _valorReferencia = 5;
        private int _valorOut;
        private IModificadorParametro _modificadorParametro;
        public ItemDeMenuModificadorParametro(IModificadorParametro modificadorParametro)
        {
            _modificadorParametro = modificadorParametro;
        }

        public void ExibirItemDeMenuModificadorParametro()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuModificadorParametro();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _modificadorParametro.ExibirExplicacao();
                        Console.ReadKey();
                        break;
                    case "2":
                        _modificadorParametro.ExecutarExemploRef(ref _valorReferencia);
                        Console.WriteLine(Constantes.MsgExecucaoRef, _valorReferencia);
                        Console.ReadKey();
                        break;
                    case "3":
                        _modificadorParametro.ExecutarExemploOut(out _valorOut);
                        Console.WriteLine(Constantes.MsgExecucaoOut, _valorOut);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuModificadorParametro()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Exibir Texto Teorico");
            Console.WriteLine("2) Exemplo com Ref");
            Console.WriteLine("3) Exemplo Out");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
