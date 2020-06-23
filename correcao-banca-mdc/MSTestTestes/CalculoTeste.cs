using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrabalhandoNoConsole._1_Calculadora;

namespace MSTestTestes
{
    [TestClass]
    public class CalculoTeste
    {
        private Calculo _calculo;

        public CalculoTeste()
        {
            _calculo = new Calculo();
        }


        [DataTestMethod]
        [DataRow(10.5, 55.2, 65.7)]
        [DataRow(15, 75, 90)]
        [DataRow(-10, 10, 0)]
        [DataRow(-15, 10, -5)]
        public void Calcular_DeveRetornarASoma(double a, double b, double resultadoEsp)
        {
            var resultado = _calculo.Somar(a, b);
            Assert.AreEqual(resultado, resultadoEsp);
        }

        [DataTestMethod]
        [DataRow(5, 6, 30)]
        [DataRow(-5, 6, -30)]
        [DataRow(1.33, 7.8, 10.37)]
        public void Calcular_DeveRetornarAMultiplicacao(double a, double b, double resultadoEsp)
        {
            var resultado = _calculo.Multiplicar(a, b);
            Assert.AreEqual(Math.Round(resultado, 2), resultadoEsp);
        }

        [DataTestMethod]
        [DataRow(78, 13, 65)]
        [DataRow(110, 13, 97)]
        [DataRow(-5, 13, -18)]
        public void Calcular_DeveRetornarASubtracao(double a, double b, double resultadoEsp)
        {
            var resultado = _calculo.Subtrair(a, b);
            Assert.AreEqual(resultado, resultadoEsp);
        }

        [DataTestMethod]
        [DataRow(12, 6, 0.5)]
        [DataRow(17, 8, 0.47)]
        [DataRow(14, 25, 1.79)]
        public void Calcular_DeveRetornarADivisao(double a, double b, double resultadoEsp)
        {
            var resultado = _calculo.Dividir(a, b);
            Assert.AreEqual(Math.Round(resultado, 2), resultadoEsp);
        }
        [DataTestMethod]
        [DataRow(12, 6, 0.5)]
        [DataRow(17, 8, 0.47)]
        [DataRow(14, 25, 1.79)]
        public void Calcular_DeveRetornarSePar(double a, double b, double resultadoEsp)
        {
            var resultado = _calculo.Dividir(a, b);
            Assert.AreEqual(Math.Round(resultado, 2), resultadoEsp);
        }

    }
}
