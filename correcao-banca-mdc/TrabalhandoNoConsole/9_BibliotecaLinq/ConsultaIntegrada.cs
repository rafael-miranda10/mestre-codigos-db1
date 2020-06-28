using RecursosCompartilhados;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsole._9_BibliotecaLinq
{
    public class ConsultaIntegrada : IConsultaIntegrada
    {
        public ConsultaIntegrada()
        {
            NumerosInteiros = new List<int>();
        }

        public List<int> NumerosInteiros { get; private set; }

        public void AdicionarLista(List<int> lista)
        {
            NumerosInteiros = lista;
        }

        private void ExibirLista(string texto, List<int> lista)
        {
            Console.WriteLine(texto);
            Console.WriteLine(string.Join("| ", lista));
        }
        public void ExibirListaInteira()
        {
            ExibirLista(Constantes.MsgLINQListaDeinteiros, NumerosInteiros);
        }
        public void ExibirOrdemCrescente()
        {
            ExibirLista(Constantes.MsgLINQListaEmOrdemCrescente, NumerosInteiros.OrderBy(x => x).ToList());
        }
        public void ExibirOrdemDecrescente()
        {
            ExibirLista(Constantes.MsgLINQListaEmOrdemDecrescente, NumerosInteiros.OrderByDescending(x => x).ToList());
        }
        public void ExibirPrimeiroDaLista()
        {
            Console.WriteLine(Constantes.MsgLINQPrimeiroElemento, NumerosInteiros.ElementAt(0));
        }
        public void ExibirUltimoDaLista()
        {
            Console.WriteLine(Constantes.MsgLINQUltimoElemento, NumerosInteiros.ElementAt(NumerosInteiros.Count - 1));
        }
        public void InserirPrimeiroDaLista(int elemento)
        {
            NumerosInteiros.Insert(0, elemento);
            Console.Clear();
            ExibirLista(Constantes.MsgLINQInserirNoInicio, NumerosInteiros);
        }
        public void InserirUltimoDaLista(int elemento)
        {
            NumerosInteiros.Insert(NumerosInteiros.Count, elemento);
            Console.Clear();
            ExibirLista(Constantes.MsgLINQInserirNoFinal, NumerosInteiros);
        }
        public void PesquisarElemento(int chave)
        {
            int resultado = NumerosInteiros.FirstOrDefault(x => x.Equals(chave));
            Console.Clear();
            Console.WriteLine(Constantes.MsgLINQPesquisaElemento, chave, resultado);
        }
        public void RemoverPrimeiroDaLista()
        {
            NumerosInteiros.RemoveAt(0);
            ExibirLista(Constantes.MsgLINQRemoverPrimeiroElemento, NumerosInteiros);
        }
        public void RemoverUltimoDaLista()
        {
            NumerosInteiros.RemoveAt(NumerosInteiros.Count - 1);
            ExibirLista(Constantes.MsgLINQRemoverUltimoElemento, NumerosInteiros);
        }
        public void ExibirSomenteNumerosPares()
        {
            var numerosPares = NumerosInteiros.Select(x => x).Where(x => x % 2 == 0).ToList();
            ExibirLista(Constantes.MsgLINQApenasNumerosPares, numerosPares);
        }
        public void TransformarLista()
        {
            int[] numerosInteriosTrasformados = NumerosInteiros.ToArray();
            Console.WriteLine(Constantes.MsgLINQTransformadaArray);
            Console.WriteLine(string.Join("| ", numerosInteriosTrasformados));
        }
    }
}
