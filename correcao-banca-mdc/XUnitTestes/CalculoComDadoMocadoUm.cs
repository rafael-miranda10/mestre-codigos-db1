using NSubstitute;
using TrabalhandoNoConsole._1_Calculadora;
using Xunit;

namespace XUnitTestes
{
    public class CalculoComDadoMocadoUm
    {
        private readonly Calculo _mock;
        public CalculoComDadoMocadoUm()
        {
            _mock = Substitute.For<Calculo>();

            _mock.Somar(10, 10).Returns(20);
            _mock.Multiplicar(10, 10).Returns(100);
            _mock.Dividir(10, 0).Returns(double.NaN);
            _mock.Subtrair(10, 100).Returns(-90);
            _mock.VerificaSeEPar(20).Returns(true);
            _mock.VerificaSeEPar(21).Returns(false);
        }

        [Fact]
        public void SomarTesteNSubstitute()
        {
            Assert.Equal(20, _mock.Somar(10, 10));
        }

        [Fact]
        public void DeveRetornarNaN()
        {
            Assert.Equal(double.NaN, _mock.Dividir(10, 0));
        }
        [Fact]
        public void MultiplicarTesteNSubstitute()
        {
            Assert.Equal(100, _mock.Multiplicar(10, 10));
        }
        [Fact]
        public void SubtrairTesteNSubstitute()
        {
            Assert.Equal(-90, _mock.Subtrair(10, 100));
        }
        [Fact]
        public void ParTesteNSubstitute()
        {
            Assert.True(_mock.VerificaSeEPar(20));
        }
        [Fact]
        public void ImparrTesteNSubstitute()
        {
            Assert.False(_mock.VerificaSeEPar(21));
        }
    }
}
