using System;

namespace UtilizandoPOO.Exercicio_1
{
    public class Humano : ICloneable
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }

        public Humano(string nome, string telefone, int idade)
        {
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Idade: {Idade} - Telefone: {Telefone}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
