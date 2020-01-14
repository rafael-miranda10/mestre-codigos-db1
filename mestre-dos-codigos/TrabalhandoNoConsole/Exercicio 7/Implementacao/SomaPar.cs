using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhandoNoConsole.Exercicio_7.Interface;

namespace TrabalhandoNoConsole.Exercicio_7.Implementacao
{
    public class SomaPar : ISomaPar
    {
        private List<int> inteiros;

        public SomaPar()
        {
            inteiros = new List<int>();
        }

        public void SetLista(List<int> lista)
        {
            inteiros = lista;
        }

        public void SomarParDivisao()
        {
            int soma = 0;
            foreach (var item in inteiros)
            {
                var aux = item / 2;
                if (aux * 2 == item)
                    soma += item;
            }
            Console.WriteLine($"A soma dos números pares é: {soma}");
        }

        public void SomarParDivisaoExata()
        {
            int soma = 0;
            foreach (var item in inteiros)
            {
                if (item % 2 == 0)
                    soma += item;
            }
            Console.WriteLine($"A soma dos números pares é: {soma}");
        }

        public void SomarParLinq()
        {
            Console.WriteLine($"A soma dos números pares é: {inteiros.Where(x => x % 2 == 0).Sum()}");
        }
    }
}
