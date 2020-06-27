using Moq;
using UtilizandoPOO._3_RepresentacaoBancaria;
using Xunit;

namespace XUnitTestes
{
    public class ContaBancariaMocadaTeste
    {
        private readonly Mock<IContaBancaria> _mock;
        private const int VALOR_DEPOSITO = 20;
        private const int VALOR_SAQUE = 30;
        public ContaBancariaMocadaTeste()
        {
            _mock = new Mock<IContaBancaria>();

            _mock.Setup(x => x.Sacar(It.IsAny<double>())).Verifiable();
            _mock.Setup(x => x.Depositar(It.IsAny<double>())).Verifiable();
        }

        [Fact]
        public void RealizarSaque()
        {
            _mock.Object.Sacar(VALOR_SAQUE);
            _mock.Verify(s => s.Sacar(It.IsAny<double>()), Times.Once);
        }

        [Fact]
        public void RealizarDeposito()
        {
            _mock.Object.Depositar(VALOR_DEPOSITO);
            _mock.Verify(s => s.Depositar(It.IsAny<double>()), Times.Once);
        }
    }
}
