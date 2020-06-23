using RecursosCompartilhados;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsole._8_OrdenacaoDeNumeros
{
    public class OrdenacaoDeNumeros
    {
        public OrdenacaoDeNumeros()
        {
            NumerosDecimais = new List<decimal>();
        }

        public List<decimal> NumerosDecimais { get; private set; }

        public void AdicionarLista(List<decimal> lista)
        {
            NumerosDecimais = lista;
        }

        public void OrdenacaoCrescenteComRecurso()
        {
            decimal[] vet = NumerosDecimais.ToArray();
            Array.Sort(vet);
            AdicionarLista(vet.ToList());
            ExibirLista();
        }
        public void OrdenacaoDecrescenteComRecurso()
        {
            decimal[] vet = NumerosDecimais.ToArray();
            Array.Reverse(vet);
            AdicionarLista(vet.ToList());
            ExibirLista();
        }

        public void OrdenacaoCrescenteComRecursoDoLinq()
        {
            AdicionarLista(NumerosDecimais.OrderBy(x => x).ToList());
            ExibirLista();
        }
        public void OrdenacaoDecrescenteComRecursoDoLinq()
        {
            AdicionarLista(NumerosDecimais.OrderByDescending(x => x).ToList());
            ExibirLista();
        }

        public void OrdenacaoManualCrescente()
        {
            decimal aux = 0;
            List<decimal> vet = NumerosDecimais;

            for (int i = 0; i < vet.Count; i++)
            {
                for (int j = 0; j < vet.Count; j++)
                {
                    if (vet[i] < vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            AdicionarLista(vet);
            ExibirLista();
        }

        public void OrdenacaoManualDeCrescente()
        {
            decimal aux = 0;
            List<decimal> vet = NumerosDecimais;

            for (int i = 0; i < vet.Count; i++)
            {
                for (int j = 0; j < vet.Count; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            AdicionarLista(vet);
            ExibirLista();
        }

        private void ExibirLista()
        {
            if (NumerosDecimais.Count > 0)
            {
                string ordenacaoParaExibir = Constantes.MsgOrdenacaoNumerosOrdenada;
                foreach (var numero in NumerosDecimais)
                {
                    ordenacaoParaExibir += numero + "| ";
                }

                Console.WriteLine(ordenacaoParaExibir);
            }
            else
            {
                Console.WriteLine(Constantes.MsgOrdenacaoNumerosListaVazia);
            }
        }
    }
}
