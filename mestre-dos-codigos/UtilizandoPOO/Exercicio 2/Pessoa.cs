using System;

namespace UtilizandoPOO.Exercicio_2
{
    public class Pessoa
    {
        private string _Nome;
        private double _Altura;
        private DateTime _DataNasc;

        public Pessoa()
        {

        }

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

        public DateTime DaTaNasc
        {
            get => _DataNasc;
            set => _DataNasc = value;
        }

        public int CalcularIdade()
        {
            //int idade = DateTime.Now.Year - _DataNasc.Year;
            //if (DateTime.Now.Month < _DataNasc.Month || (DateTime.Now.Month == _DataNasc.Month && DateTime.Now.Day < _DataNasc.Day))
            //    idade--;
            //return idade;

            return DateTime.Now.Year - _DataNasc.Year - (_DataNasc.DayOfYear < DateTime.Now.DayOfYear ? 0 : 1);
        }

        public override string ToString()
        {
            return $"Nome: {_Nome} possui a altura de : {_Altura} metros, nascida em: {_DataNasc.ToShortDateString()} com {CalcularIdade()} anos de idade.";
        }
    }
}
