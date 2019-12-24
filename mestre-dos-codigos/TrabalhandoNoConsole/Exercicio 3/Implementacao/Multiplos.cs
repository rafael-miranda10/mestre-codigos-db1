using System;
using TrabalhandoNoConsole.Exercicio_3.Interface;

namespace TrabalhandoNoConsole.Exercicio_3.Implementacao
{
    public class Multiplos : IMultiplos
    {
        public void Multiplo3Divisao()
        {
            Console.Clear();
            Console.WriteLine("Os múltiplos de um determinado número são todos os valores que, quando divididos por aquele número, resultam em uma divisão exata e sem resto.\n\n");

            int index = 1;
            string multiplos = "O números multiplos de 3 entre 1 e 100 são: ";

            while (index <= 100)
            {
                if (index % 3 == 0)
                {
                    multiplos += $"{index};";
                }
                index++;
            }

            Console.WriteLine(multiplos);
        }

        public void Multiplo3Progressao()
        {
            Console.Clear();
            Console.WriteLine("O primeiro múltiplo de um número sempre será ele mesmo. Para descobrir os outros valores múltiplos de um número,\nbasta apenas somar o mesmo ao valor inicial, formando uma progressão aritmética.\n\n");

            int index = 0;
            string multiplos = "O números multiplos de 3 entre 1 e 100 são: ";
            index += 3;

            while (index <= 100)
            {
                multiplos += $"{index};";
                index += 3;
            }

            Console.WriteLine(multiplos);
        }
    }
}
