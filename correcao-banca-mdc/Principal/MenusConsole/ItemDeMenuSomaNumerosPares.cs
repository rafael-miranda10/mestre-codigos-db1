using System;
using System.Collections.Generic;
using System.Globalization;
using TrabalhandoNoConsole._7_SomaNumerosPares;

namespace Principal.MenusConsole
{
    public class ItemDeMenuSomaNumerosPares
    {
        private SomaNumeroPar _somaNumeroPar;
        private List<int> _numerosInteiros;
        private int _tamanhoDaLista = 4;
        public ItemDeMenuSomaNumerosPares(SomaNumeroPar somaNumeroPar)
        {
            _somaNumeroPar = somaNumeroPar;
            _numerosInteiros = new List<int>();
        }

        public void ExibirItemDeMenuSomaNumerosPares()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuSomaNumerosPares();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        PreencherListaDeNumeros();
                        _somaNumeroPar.AdicionarLista(_numerosInteiros);
                        Console.ReadKey();
                        break;
                    case "2":
                        _somaNumeroPar.SomarNumerosParesPorDivisaoExata();
                        Console.ReadKey();
                        break;
                    case "3":
                        _somaNumeroPar.SomarNumerosParesPorDivisaoSimples();
                        Console.ReadKey();
                        break;
                    case "4":
                        _somaNumeroPar.SomarNumerosParesComLinq();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuSomaNumerosPares()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Inserir 4 Números Inteiros");
            Console.WriteLine("2) Calcular os Números Pares por Divisão Exata");
            Console.WriteLine("3) Calcular os Números Pares por Divisão");
            Console.WriteLine("4) Calcular os Números Pares com Linq");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }

        private void PreencherListaDeNumeros()
        {
            for (int i = 0; i < _tamanhoDaLista; i++)
            {
                _numerosInteiros.Add(CapturaDeDados.CapturarNumeroInteiro("Informe o número inteiro desejado: "));
            }
        }
    }
}
