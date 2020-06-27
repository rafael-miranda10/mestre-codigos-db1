using System;

namespace UtilizandoPOO._2_RepresentarPessoa
{
    public class FabricaPessoa
    {
        public static Pessoa Criar()
        {
            return new Pessoa();
        }
        public static Pessoa Criar(string nome, double altura, DateTime dataNasc)
        {
            var pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Altura = altura;
            pessoa.DaTaNascimento = dataNasc;
            return pessoa;
        }
    }
}
