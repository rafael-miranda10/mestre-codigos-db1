using Moq;
using TrabalhandoNoConsole._1_Calculadora;
using Xunit;

namespace XUnitTestes
{
    public class CalculoComDadoMocadoDois
    {
        private readonly Mock<Calculo> _mock;
        public CalculoComDadoMocadoDois()
        {
            _mock = new Mock<Calculo>();

            _mock.Setup(x => x.Somar(2, 2)).Returns(4);
            _mock.Setup(x => x.Somar(2, 7)).Returns(9);
            _mock.Setup(x => x.Subtrair(15, 3)).Returns(12);
            _mock.Setup(x => x.Multiplicar(3, 7)).Returns(21);
            _mock.Setup(x => x.Dividir(3, 60)).Returns(20);
            _mock.Setup(x => x.VerificaSeEPar(10)).Returns(true);
            _mock.Setup(x => x.VerificaSeEPar(7)).Returns(false);
        }

        [Fact]
        public void SomarTesteMoq()
        {
            Assert.Equal(4, _mock.Object.Somar(2, 2));
        }

        [Fact]
        public void DeveRetornarValorDiferente()
        {
            Assert.NotEqual(4, _mock.Object.Somar(2, 7));
        }

        [Fact]
        public void SubtrairTesteMoq()
        {
            Assert.Equal(12, _mock.Object.Subtrair(15, 3));
        }

        [Fact]
        public void MultiplicarTesteMoq()
        {
            Assert.Equal(21, _mock.Object.Multiplicar(3, 7));
        }

        [Fact]
        public void DividirTesteMoq()
        {
            Assert.Equal(20, _mock.Object.Dividir(3, 60));
        }

        [Fact]
        public void ParTesteMoq()
        {
            Assert.True(_mock.Object.VerificaSeEPar(10));
        }
        [Fact]
        public void ImparTesteMoq()
        {
            Assert.False(_mock.Object.VerificaSeEPar(7));
        }




    }
}
