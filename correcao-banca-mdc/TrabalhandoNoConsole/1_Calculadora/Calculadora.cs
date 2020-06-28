using RecursosCompartilhados;
using System;

namespace TrabalhandoNoConsole._1_Calculadora
{
    public class Calculadora : ICalculadora
    {
        private readonly Calculo _calculo;
        public Calculadora(Calculo calculo)
        {
            _calculo = calculo;
        }

        public void Somar(double a, double b)
        {
            Console.WriteLine(Constantes.MsgResultadoDoCalculo,
                              Constantes.OperacaoSoma, a, b, _calculo.Somar(a, b));
        }

        public void Dividir(double a, double b)
        {
            Console.WriteLine(Constantes.MsgResultadoDoCalculo,
                              Constantes.OperacaoDivisao, b, a, _calculo.Dividir(a, b));
        }

        public void Multiplicar(double a, double b)
        {
            Console.WriteLine(Constantes.MsgResultadoDoCalculo,
                               Constantes.OperacaoMultiplicacao, a, b, _calculo.Multiplicar(a, b));
        }

        public void Subtrair(double a, double b)
        {
            Console.WriteLine(Constantes.MsgResultadoDoCalculo,
                               Constantes.OperacaoSubtracao, a, b, _calculo.Subtrair(a, b));
        }

        public void VerificarSeValorDeAPar(double a)
        {
            if (_calculo.VerificaSeEPar(a))
                Console.WriteLine(Constantes.MsgResultadoEhPar, a);
            else
                Console.WriteLine(Constantes.MsgResultadoEhImpar, a);
        }

        public void VerificarSeValorDeBPar(double b)
        {
            if (_calculo.VerificaSeEPar(b))
                Console.WriteLine(Constantes.MsgResultadoEhPar, b);
            else
                Console.WriteLine(Constantes.MsgResultadoEhImpar, b);
        }
    }
}
