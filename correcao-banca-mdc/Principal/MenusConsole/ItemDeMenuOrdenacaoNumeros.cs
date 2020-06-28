using RecursosCompartilhados;
using System;
using System.Collections.Generic;
using TrabalhandoNoConsole._8_OrdenacaoDeNumeros;

namespace Principal.MenusConsole
{
    public class ItemDeMenuOrdenacaoNumeros
    {
        private IOrdenacaoDeNumeros _ordenacaoNumeros;
        private List<decimal> _numerosDecimais;
        public ItemDeMenuOrdenacaoNumeros(IOrdenacaoDeNumeros ordenacaoNumeros)
        {
            _ordenacaoNumeros = ordenacaoNumeros;
            _numerosDecimais = new List<decimal>();
        }

        public void ExibirItemDeMenuOrdenacaoDeNumeros()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuOrdenacao();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        PreencherListaDeNumeros();
                        _ordenacaoNumeros.AdicionarLista(_numerosDecimais);
                        Console.ReadKey();
                        break;
                    case "2":
                        _ordenacaoNumeros.OrdenacaoManualCrescente();
                        Console.ReadKey();
                        break;
                    case "3":
                        _ordenacaoNumeros.OrdenacaoManualDeCrescente();
                        Console.ReadKey();
                        break;
                    case "4":
                        _ordenacaoNumeros.OrdenacaoCrescenteComRecurso();
                        Console.ReadKey();
                        break;
                    case "5":
                        _ordenacaoNumeros.OrdenacaoDecrescenteComRecurso();
                        Console.ReadKey();
                        break;
                    case "6":
                        _ordenacaoNumeros.OrdenacaoCrescenteComRecursoDoLinq();
                        Console.ReadKey();
                        break;
                    case "7":
                        _ordenacaoNumeros.OrdenacaoDecrescenteComRecursoDoLinq();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuOrdenacao()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Inserir N Números Decimais");
            Console.WriteLine("2) Ordenação Manual Crescente");
            Console.WriteLine("3) Ordenação Manual Decrescente");
            Console.WriteLine("4) Ordenação Array Sort Crescente");
            Console.WriteLine("5) Ordenação Array Sort Decrescente");
            Console.WriteLine("6) Ordenação Linq Crescente");
            Console.WriteLine("7) Ordenação Linq Decrescente");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }

        private void PreencherListaDeNumeros()
        {
            Console.Clear();
            Console.Write("Para encerrar pressione 0 (zero) - Infome números decimais por exemplo : 2,1 \n\n");
            decimal numero;
            int indice = 1;
            do
            {
                numero = CapturaDeDados.CapturarNumeroDecimal($"Informe o {indice++} número desejado: ");
                if(numero > 0)
                _numerosDecimais.Add(numero);
            } while (numero != 0);
        }
    }
}
