using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhandoNoConsole.Exercicio_9.Interface;

namespace TrabalhandoNoConsole.Exercicio_9.Implementacao
{
    public class Linq : ILinq
    {
        public Linq()
        {
            Inteirios = new List<int>();
        }
        public List<int> Inteirios { get; private set; }

        public void ExibirListaInteira()
        {
            ExibirLista("Lista de Inteiros: ", Inteirios);
        }

        public void ExibirOrdemCrescente()
        {
            ExibirLista("Lista de Inteiros em Ordem Crescente: ", Inteirios.OrderBy(x => x).ToList());
        }

        public void ExibirOrdemDecrescente()
        {
            ExibirLista("Lista de Inteiros em Ordem Decrescente: ", Inteirios.OrderByDescending(x => x).ToList());
        }

        public void ExibirPrimeiroDaLista()
        {
            Console.WriteLine($"O primeiro elemento da lista é: {Inteirios.ElementAt(0)}");
        }

        public void ExibirUltimoDaLista()
        {
            Console.WriteLine($"O ultimo elemento da lista é: {Inteirios.ElementAt(Inteirios.Count-1)}");
        }

        public void InserirPrimeiroDaLista(int elemento)
        {
            Inteirios.Insert(0,elemento);
            Console.Clear();
            ExibirLista("Lista com o Primeiro ELemento Adicionado: ", Inteirios);
        }

        public void InserirUltimoDaLista(int elemento)
        {
            Inteirios.Insert(Inteirios.Count, elemento);
            Console.Clear();
            ExibirLista("Lista com o Ultimo ELemento Adicionado: ", Inteirios);
        }

        public void PesquisarElemento(int chave)
        {
            //int resultado = Inteirios.Select(x => x).Where(x => x == chave).FirstOrDefault();
            int resultado = Inteirios.FirstOrDefault(x => x.Equals(chave));
            Console.Clear();
            Console.WriteLine($"Elemento pesquisado: {chave} - O Elemento encontrado: {resultado}");
        }

        public void RemoverPrimeiroDaLista()
        {
            Inteirios.RemoveAt(0);
            ExibirLista("Primeiro elemento da lista removido: ",Inteirios);
        }

        public void RemoverUltimoDaLista()
        {
            Inteirios.RemoveAt(Inteirios.Count-1);
            ExibirLista("Ultimo elemento da lista removido: ", Inteirios);
           
        }

        public void SetLista(List<int> inteiros)
        {
            Inteirios = inteiros;
        }

        public void SomenteNumerosPar()
        {
            var numerosPares = Inteirios.Select(x=>x).Where(x => x % 2 == 0).ToList();
            ExibirLista("Apenas os números pares da lista: ", numerosPares);
        }

        public void TransformarListaEmArray()
        {
            int[] _array = Inteirios.ToArray();
            string str = "A lista tranformada em Array: ";
            for(int i = 0; i< _array.Length; i++)
            {
                str += _array[i] + ";";
            }
            Console.WriteLine(str);
        }

        private void ExibirLista(string texto, List<int> lista)
        {
            string str = texto;
            foreach (var item in lista)
            {
                str += item + ";";
            }
            Console.WriteLine(str);
        }
    }
}
