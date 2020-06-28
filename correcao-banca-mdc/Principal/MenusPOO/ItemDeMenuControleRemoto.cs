using System;
using UtilizandoPOO._4_Controle;

namespace Principal.MenusPOO
{
    public class ItemDeMenuControleRemoto
    {
        private IControleRemoto _controleRemoto;

        public ItemDeMenuControleRemoto(IControleRemoto controleRemoto)
        {
            _controleRemoto = controleRemoto;
        }
        public void ExibirItemDeMenuControleRemoto()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuControleRemoto();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _controleRemoto.LigarControlavel();
                        Console.ReadKey();
                        break;
                    case "2":
                        _controleRemoto.AumentarVolumeDoControlavel();
                        Console.ReadKey();
                        break;
                    case "3":
                        _controleRemoto.DiminuirVolumeDoControlavel();
                        Console.ReadKey();
                        break;
                    case "4":
                        _controleRemoto.TrocarParaProximoCanal();
                        Console.ReadKey();
                        break;
                    case "5":
                        _controleRemoto.TrocarParaCanalAnterior();
                        Console.ReadKey();
                        break;
                    case "6":
                        _controleRemoto.TrocarParaCanalEspecifico();
                        Console.ReadKey();
                        break;
                    case "7":
                        _controleRemoto.ExibirEstadoDoControlavel();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuControleRemoto()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Ligar a Televisão");
            Console.WriteLine("2) Aumentar Volume");
            Console.WriteLine("3) Diminuir Volune");
            Console.WriteLine("4) Proximo Canal");
            Console.WriteLine("5) Canal Anterior");
            Console.WriteLine("6) Ir Para o Canal");
            Console.WriteLine("7) O Que Estou Assistindo?");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
