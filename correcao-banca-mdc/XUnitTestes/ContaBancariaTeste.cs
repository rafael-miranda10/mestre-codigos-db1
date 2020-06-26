using System;
using System.Collections.Generic;
using System.Text;
using UtilizandoPOO._3_RepresentacaoBancaria;
using Xunit;

namespace XUnitTestes
{

    public class ContaBancariaTeste
    {
        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        public void CalculoDeveRetornarAIdadeCalculada(double valor)
        {
            var contaCorrente = new ContaCorrente(123456,100);
            var valorEsperado = 100 - valor;

            contaCorrente.Sacar(valor);

            Assert.Equal(valorEsperado, contaCorrente.RetornarSaldoDaConta());
        }
    }
}
