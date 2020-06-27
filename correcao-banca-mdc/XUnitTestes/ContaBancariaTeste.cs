using UtilizandoPOO._3_RepresentacaoBancaria;
using Xunit;

namespace XUnitTestes
{
    public class ContaBancariaTeste
    {
        private const int NUMERO_CONTA_VALIDO_1 = 123;
        private const int NUMERO_CONTA_VALIDO_2 = 852;
        private const int NUMERO_CONTA_VALIDO_3 = 951;
        private const double VALOR_SALDO_INICIAL_VALIDO_1 = 100;
        private const double VALOR_SALDO_INICIAL_VALIDO_2 = 200;
        private const double VALOR_SALDO_INICIAL_VALIDO_3 = 300;
        private const double TAXA_OPERACAO_SAQUE = 1.50;
        private const double LIMITE_ESPECIAL = 100;

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        public void DeveRealizarSaqueEmContaCorrente(double valorDoSaque)
        {
            var contaCorrente = FabricaContaBancaria.CriarContaCorrente(NUMERO_CONTA_VALIDO_1, VALOR_SALDO_INICIAL_VALIDO_1);
            var valorEsperado = (VALOR_SALDO_INICIAL_VALIDO_1 - valorDoSaque) - TAXA_OPERACAO_SAQUE;

            contaCorrente.Sacar(valorDoSaque);

            Assert.Equal(valorEsperado, contaCorrente.RetornarSaldoDaConta());
        }

        [Fact]
        public void NaoDeveRealizarSaqueEmContaCorrente()
        {
            double valorDoSaque = 300;
            var contaCorrente = FabricaContaBancaria.CriarContaCorrente(NUMERO_CONTA_VALIDO_2, VALOR_SALDO_INICIAL_VALIDO_2);

            contaCorrente.Sacar(valorDoSaque);

            Assert.Equal(VALOR_SALDO_INICIAL_VALIDO_2, contaCorrente.RetornarSaldoDaConta());
        }

        [Theory]
        [InlineData(310)]
        [InlineData(320)]
        [InlineData(330)]
        public void DeveRealizarSaqueEmContaEspecial(double valorDoSaque)
        {
            var contaEspecial = FabricaContaBancaria.CriarContaEspecial(NUMERO_CONTA_VALIDO_3, VALOR_SALDO_INICIAL_VALIDO_3);
            var valorEsperado = VALOR_SALDO_INICIAL_VALIDO_3  - valorDoSaque;

            contaEspecial.Sacar(valorDoSaque);

            Assert.Equal(valorEsperado, contaEspecial.RetornarSaldoDaConta());
        }

        [Fact]
        public void NaoDeveRealizarSaqueEmContaEspecial()
        {
            double valorDoSaque = 310;
            var contaCorrente = FabricaContaBancaria.CriarContaEspecial(NUMERO_CONTA_VALIDO_2, VALOR_SALDO_INICIAL_VALIDO_2);

            contaCorrente.Sacar(valorDoSaque);

            Assert.Equal(VALOR_SALDO_INICIAL_VALIDO_2, contaCorrente.RetornarSaldoDaConta());
        }
    }
}
