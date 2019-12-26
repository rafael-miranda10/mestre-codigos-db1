using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhandoNoConsole.Exercicio_8.Interface;

namespace TrabalhandoNoConsole.Exercicio_8.Implementacao
{
    public class Ordencao : IOrdenacao
    {
        public void OrdenacaoArraySortCrescente(List<int> inteiros)
        {
            int[] vet = inteiros.ToArray();
            Array.Sort(vet);
            ExibirVetor(vet.ToList());
        }

        public void OrdenacaoArraySortDeCrescente(List<int> inteiros)
        {
            int[] vet = inteiros.ToArray();
            Array.Reverse(vet);
            ExibirVetor(vet.ToList());
        }

        public void OrdenacaoLinqCrescente(List<int> inteiros)
        {
            List<int> vet = inteiros.OrderBy(x => x).ToList();
            ExibirVetor(vet);
        }

        public void OrdenacaoLinqDeCrescente(List<int> inteiros)
        {
            List<int> vet = inteiros.OrderByDescending(x => x).ToList();
            ExibirVetor(vet);
        }

        public void OrdenacaoManualCrescente(List<int> inteiros)
        {
            int aux = 0;
            List<int> vet = inteiros;

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

        public void OrdenacaoManualDeCrescente(List<int> inteiros)
        {
            int aux = 0;
            List<int> vet = inteiros;

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

        private void ExibirVetor(List<int> inteiros)
        {
            string str = "Vetor ordenado: ";
            foreach(var item in inteiros)
            {
                str += item + ";";
            }

            Console.WriteLine(str);
        }
    }
}
