using RecursosCompartilhados;
using System;

namespace UtilizandoPOO._2_RepresentarPessoa
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        private string _nome;
        private double _altura;
        private DateTime _daTaNascimento;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public double Altura
        {
            get => _altura;
            set => _altura = value;
        }

        public DateTime DaTaNascimento
        {
            get => _daTaNascimento;
            set => _daTaNascimento = value;
        }

        public int CalcularIdade()
        {
            return DateTime.Now.Year - _daTaNascimento.Year - (_daTaNascimento.DayOfYear < DateTime.Now.DayOfYear ? 0 : 1);
        }

        public override string ToString()
        {
            return string.Format(ConstantesPoo.ExibirDadosPessoa, _nome, _altura,
                                _daTaNascimento.ToShortDateString(), CalcularIdade());
        }
    }
}
