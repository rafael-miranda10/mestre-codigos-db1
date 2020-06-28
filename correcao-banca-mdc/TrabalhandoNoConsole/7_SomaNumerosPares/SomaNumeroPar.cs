using RecursosCompartilhados;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsole._7_SomaNumerosPares
{
    public class SomaNumeroPar : ISomaNumeroPar
    {
        private int _soma;
        public SomaNumeroPar()
        {
            NumerosInteros = new List<int>();
        }

        public List<int> NumerosInteros { get; private set; }

        public void AdicionarLista(List<int> lista)
        {
            NumerosInteros = lista;
        }

        private bool VerificarSeListaEhVazia()
        {
            return NumerosInteros?.Count == 0 ? true : false;
        }

        public void SomarNumerosParesPorDivisaoSimples()
        {
            if (!VerificarSeListaEhVazia())
            {
                _soma = 0;
                foreach (var item in NumerosInteros)
                {
                    var aux = item / 2;
                    if (aux * 2 == item)
                        _soma += item;
                }
                Console.WriteLine(Constantes.MsgSomaNumerosPares, _soma);
            }
            else
            {
                Console.WriteLine(Constantes.MsgNumerosParesListaVazia);
            }
        }

        public void SomarNumerosParesPorDivisaoExata()
        {
            if (!VerificarSeListaEhVazia())
            {
                _soma = 0;
                foreach (var item in NumerosInteros)
                {
                    if (item % 2 == 0)
                        _soma += item;
                }
                Console.WriteLine(Constantes.MsgSomaNumerosPares, _soma);
            }
            else
            {
                Console.WriteLine(Constantes.MsgNumerosParesListaVazia);
            }
        }

        public void SomarNumerosParesComLinq()
        {
            if (!VerificarSeListaEhVazia())
            {
                Console.WriteLine(Constantes.MsgSomaNumerosPares, NumerosInteros.Where(x => x % 2 == 0).Sum());
            }
            else
            {
                Console.WriteLine(Constantes.MsgNumerosParesListaVazia);
            }
        }
    }
}
