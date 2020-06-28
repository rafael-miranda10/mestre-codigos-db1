using RecursosCompartilhados;
using System;
using System.Collections.Generic;
using TrabalhandoNoConsole._9_BibliotecaLinq;

namespace Principal.MenusConsole
{
    public class ItemDeMenuConsultaIntegrada
    {
        private IConsultaIntegrada _consultaIntegrada;
        private List<int> _NumerosInteiros;
        public ItemDeMenuConsultaIntegrada(IConsultaIntegrada consultaIntegrada)
        {
            _consultaIntegrada = consultaIntegrada;
            _NumerosInteiros = new List<int>();
        }

        public void ExibirItemDeMenuConsultaIntegrada()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuConsultaIntegrada();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "a":
                        PreencherListaDeNumeros();
                        _consultaIntegrada.AdicionarLista(_NumerosInteiros);
                        Console.ReadKey();
                        break;
                    case "b":
                        _consultaIntegrada.ExibirOrdemCrescente();
                        Console.ReadKey();
                        break;
                    case "c":
                        _consultaIntegrada.ExibirOrdemDecrescente();
                        Console.ReadKey();
                        break;
                    case "d":
                        _consultaIntegrada.ExibirPrimeiroDaLista();
                        Console.ReadKey();
                        break;
                    case "e":
                        _consultaIntegrada.ExibirUltimoDaLista();
                        Console.ReadKey();
                        break;
                    case "f":
                        _consultaIntegrada.RemoverPrimeiroDaLista();
                        Console.ReadKey();
                        break;
                    case "g":
                        _consultaIntegrada.RemoverUltimoDaLista();
                        Console.ReadKey();
                        break;
                    case "h":
                        _consultaIntegrada.ExibirSomenteNumerosPares();
                        Console.ReadKey();
                        break;
                    case "i":
                        _consultaIntegrada.TransformarLista();
                        Console.ReadKey();
                        break;
                    case "j":
                        _consultaIntegrada.PesquisarElemento(CapturaDeDados.CapturarNumeroInteiro("\n Informe o número desejado: "));
                        Console.ReadKey();
                        break;
                    case "k":
                        _consultaIntegrada.InserirPrimeiroDaLista(CapturaDeDados.CapturarNumeroInteiro("\n Informe o número desejado: "));
                        Console.ReadKey();
                        break;
                    case "m":
                        _consultaIntegrada.InserirUltimoDaLista(CapturaDeDados.CapturarNumeroInteiro("\n Informe o número desejado: "));
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuConsultaIntegrada()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("a) Inserir N Números Inteiros");
            Console.WriteLine("b) Ordenação Crescente");
            Console.WriteLine("c) Ordenação Decrescente");
            Console.WriteLine("d) Primeiro Elemento da Lista");
            Console.WriteLine("e) Ultimo Elemento da Lista");
            Console.WriteLine("f) Remover o Primeiro elemento da Lista");
            Console.WriteLine("g) Remover o ultimo elemento da Lista");
            Console.WriteLine("h) Apenas os Números Pares da Lista");
            Console.WriteLine("i) Lista tranformada em Array");
            Console.WriteLine("j) Pesquisar um números da lista");
            Console.WriteLine("k) Inserir um número no Inicio da Lista");
            Console.WriteLine("m) Inserir um número no Final da Lista");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }

        private void PreencherListaDeNumeros()
        {
            Console.Clear();
            Console.Write("Para encerrar pressione 0 (zero) \n\n");
            int numero;
            int indice = 1;
            do
            {
                numero = CapturaDeDados.CapturarNumeroInteiro($"Informe o {indice++} número desejado: ");
                if (numero > 0)
                    _NumerosInteiros.Add(numero);
            } while (numero != 0);
        }
    }
}
