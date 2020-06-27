using System;
using UtilizandoPOO._2_RepresentarPessoa;
using Xunit;

namespace XUnitTestes
{
    public class PessoaTeste
    {
        [Theory]
        [InlineData("Rafael", 1.75, "03/03/1990", 30)]
        [InlineData("Mariele", 1.65, "27/06/1989", 31)]
        [InlineData("Djalma Jorge", 1.82, "23/05/1980", 40)]
        public void CalculoDeveRetornarAIdadeCalculada(string nome, double altura, string dataNascimento, int idadeEsperada)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Altura = altura;
            pessoa.DaTaNascimento = DateTime.Parse(dataNascimento);

            var idade = pessoa.CalcularIdade();
            Assert.Equal(idadeEsperada, idade);
        }
    }
}
