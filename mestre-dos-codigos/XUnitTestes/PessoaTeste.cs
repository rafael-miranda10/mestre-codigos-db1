using System;
using UtilizandoPOO.Exercicio_2;
using Xunit;

namespace XUnitTestes
{
    public class PessoaTeste
    {
        [Theory]
        [InlineData("Rafael", 1.75, "03/03/1990",30)]
        [InlineData("Mariele", 1.65, "27/06/1989", 30)]
        [InlineData("Djalma Jorge", 1.82, "23/05/1980",39)]
        public void Calculo_DeveRetornarAIdadeCalculada(string Nome, double Altura, string DataNasc, int IdadeEsp)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = Nome;
            pessoa.Altura = Altura;
            pessoa.DaTaNasc = DateTime.Parse(DataNasc);

            var idade = pessoa.CalcularIdade();
            Assert.Equal(IdadeEsp, idade);
        }
    }
}
