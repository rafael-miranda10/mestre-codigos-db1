using System;
using System.Collections.Generic;
using System.Text;
using UtilizandoPOO._3_RepresentacaoBancaria;

namespace Principal.MenusPOO
{
    public class ItemDeMenuBanco
    {
        private Banco _banco;

        public ItemDeMenuBanco(Banco banco)
        {
            _banco = banco;
        }
        public void ExibirItemDeMenuBanco()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuBanco();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _banco.CriarContasBancarias();
                        Console.ReadKey();
                        break;
                    case "2":
                        _banco.EfetuarSaque();
                        Console.ReadKey();
                        break;
                    case "3":
                        _banco.EfetuarDeposito();
                        Console.ReadKey();
                        break;
                    case "4":
                        _banco.ExibirContasBancarias();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuBanco()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Informar os dados das contas bancarias");
            Console.WriteLine("2) Realizar Saque da conta");
            Console.WriteLine("3) Realizar Depósito na conta");
            Console.WriteLine("4) Exibir extrato");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
