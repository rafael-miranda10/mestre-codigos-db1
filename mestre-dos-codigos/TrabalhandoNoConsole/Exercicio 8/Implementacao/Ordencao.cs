﻿using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhandoNoConsole.Exercicio_8.Interface;

namespace TrabalhandoNoConsole.Exercicio_8.Implementacao
{
    public class Ordencao : IOrdenacao
    {
        public void OrdenacaoArraySortCrescente(List<decimal> decimais)
        {
            decimal[] vet = decimais.ToArray();
            Array.Sort(vet);
            ExibirVetor(vet.ToList());
        }

        public void OrdenacaoArraySortDeCrescente(List<decimal> decimais)
        {
            decimal[] vet = decimais.ToArray();
            Array.Reverse(vet);
            ExibirVetor(vet.ToList());
        }

        public void OrdenacaoLinqCrescente(List<decimal> decimais)
        {
            List<decimal> vet = decimais.OrderBy(x => x).ToList();
            ExibirVetor(vet);
        }

        public void OrdenacaoLinqDeCrescente(List<decimal> decimais)
        {
            List<decimal> vet = decimais.OrderByDescending(x => x).ToList();
            ExibirVetor(vet);
        }

        public void OrdenacaoManualCrescente(List<decimal> decimais)
        {
            decimal aux = 0;
            List<decimal> vet = decimais;

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
            ExibirVetor(vet);
        }

        public void OrdenacaoManualDeCrescente(List<decimal> decimais)
        {
            decimal aux = 0;
            List<decimal> vet = decimais;

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
            ExibirVetor(vet);
        }

        private void ExibirVetor(List<decimal> decimais)
        {
            string str = "Vetor ordenado: ";
            foreach(var item in decimais)
            {
                str += item + "| ";
            }

            Console.WriteLine(str);
        }
    }
}
