﻿using System;
using TrabalhandoNoConsole._6_ModificadorParametro;
using TrabalhandoNoConsole.RecursosDeConsole;

namespace Principal.MenusConsole
{
    public class MenuModificadorParametro
    {
        private int _valorReferencia = 5;
        private int _valorOut;
        private ModificadorParametro _modificadorParametro;
        public MenuModificadorParametro(ModificadorParametro modificadorParametro)
        {
            _modificadorParametro = modificadorParametro;
        }

        public void ExibirMenuModificadorParametro()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuModificadorParametro();
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

        private void OpcoesMenuModificadorParametro()
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