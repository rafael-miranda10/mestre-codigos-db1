using System;
using UtilizandoPOO.RecursosDePOO;

namespace UtilizandoPOO._2_RepresentarPessoa
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        private string _Nome;
        private double _Altura;
        private DateTime _DaTaNascimento;

        public string Nome
        {
            get => _Nome;
            set => _Nome = value;
        }

        public double Altura
        {
            get => _Altura;
            set => _Altura = value;
        }

        public DateTime DaTaNascimento
        {
            get => _DaTaNascimento;
            set => _DaTaNascimento = value;
        }

        public int CalcularIdade()
        {
            return DateTime.Now.Year - _DaTaNascimento.Year - (_DaTaNascimento.DayOfYear < DateTime.Now.DayOfYear ? 0 : 1);
        }

        public override string ToString()
        {
            return string.Format(ConstantesPoo.ExibirDadosPessoa, _Nome, _Altura,
                                _DaTaNascimento.ToShortDateString(), CalcularIdade());
        }
    }
}
