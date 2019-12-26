using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhandoNoConsole.Exercicio_7.Interface;

namespace TrabalhandoNoConsole.Exercicio_7.Implementacao
{
    public class SomaPar : ISomaPar
    {
        public void SomarParDivisao(List<int> inteiros)
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

        public void SomarParDivisaoExata(List<int> inteiros)
        {
            int soma = 0;
            foreach (var item in inteiros)
            {
                if (item % 2 == 0)
                    soma += item;
            }
            Console.WriteLine($"A soma dos números pares é: {soma}");
        }

        public void SomarParLinq(List<int> inteiros)
        {
            Console.WriteLine($"A soma dos números pares é: {inteiros.Where(x => x % 2 == 0).Sum()}");
        }
    }
}
