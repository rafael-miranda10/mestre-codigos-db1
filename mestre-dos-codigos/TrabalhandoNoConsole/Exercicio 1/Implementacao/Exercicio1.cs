using System;
using TrabalhandoNoConsole.Exercicio_1.Interface;

namespace TrabalhandoNoConsole.Exercicio_1.Implementacao
{
    public class Exercicio1 : IExercicio1
    {
        private readonly ICalculo _calcular;

        public Exercicio1(ICalculo calcular)
        {
            _calcular = calcular;
        }

        public void Somar(double a,  double b)
        {
            Console.WriteLine($"O resultado da soma de {a} + {b} é : {_calcular.Somar(a,b)}");
        }

        public void Dividir(double a, double b)
        {
            Console.WriteLine($"O resultado da divisão de {b} / {a} é : {_calcular.Dividir(a, b)}");
        }

        public void Multiplicar(double a, double b)
        {
            Console.WriteLine($"O resultado da multiplicação de {a} * {b} é : {_calcular.Multiplicar(a, b)}");
        }

        public void Subtrair(double a, double b)
        {
            Console.WriteLine($"O resultado da subtração de {a} - {b} é : {_calcular.Subtrair(a, b)}");
        }

        public void VerificarPar(double a, double b)
        {
            var resultA = _calcular.VerificaSeEPar(a) ? $"O número {a} é par" : $"O número {a} é impar";
            var resultB = _calcular.VerificaSeEPar(b) ? $"O número {b} é par" : $"O número {b} é impar";

            Console.WriteLine(resultA);
            Console.WriteLine(resultB);
        }
    }
}
