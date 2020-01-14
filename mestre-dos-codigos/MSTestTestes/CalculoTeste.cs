using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhandoNoConsole.Exercicio_1.Implementacao;

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
        [DataRow(10.5,55.2,65.7)]
        public void Calcular_DeveRetornarASoma(double a, double b, double resultadoEsp)
        {
            var resultado = _calculo.Somar(a, b);
            Assert.AreEqual(resultado, resultadoEsp);
        }
    }
}
