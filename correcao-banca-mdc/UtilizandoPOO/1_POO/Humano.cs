using System;
using UtilizandoPOO.RecursosDePOO;

namespace UtilizandoPOO._1_POO
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
            return string.Format(ConstantesPoo.DadosHumano, Nome, Idade, Telefone);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
