using System;
using TrabalhandoNoConsole.RecursosDeConsole;

namespace TrabalhandoNoConsole._1_Calculadora
{
    public class Calculadora
    {
        private readonly ICalculo _calcular;
        public Calculadora(ICalculo calcular)
        {
            _calcular = calcular;
        }

        public void Somar(double a, double b)
        {
            Console.WriteLine(Constantes.MsgResultadoDoCalculo,
                              Constantes.OperacaoSoma, a, b, _calcular.Somar(a, b));
        }

        public void Dividir(double a, double b)
        {
            Console.WriteLine(Constantes.MsgResultadoDoCalculo,
                              Constantes.OperacaoDivisao, b, a, _calcular.Dividir(a, b));
        }

        public void Multiplicar(double a, double b)
        {
            Console.WriteLine(Constantes.MsgResultadoDoCalculo,
                               Constantes.OperacaoMultiplicacao, a, b, _calcular.Multiplicar(a, b));
        }

        public void Subtrair(double a, double b)
        {
            Console.WriteLine(Constantes.MsgResultadoDoCalculo,
                               Constantes.OperacaoSubtracao, a, b, _calcular.Subtrair(a, b));
        }

        public void VerificarSeValorDeAPar(double a)
        {
            if (_calcular.VerificaSeEPar(a))
                Console.WriteLine(Constantes.MsgResultadoEhPar, a);
            else
                Console.WriteLine(Constantes.MsgResultadoEhImpar, a);
        }

        public void VerificarSeValorDeBPar(double b)
        {
            if (_calcular.VerificaSeEPar(b))
                Console.WriteLine(Constantes.MsgResultadoEhPar, b);
            else
                Console.WriteLine(Constantes.MsgResultadoEhImpar, b);
        }
    }
}
