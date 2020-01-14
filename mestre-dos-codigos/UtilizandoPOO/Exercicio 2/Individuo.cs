using System;
using System.Text.RegularExpressions;

namespace UtilizandoPOO.Exercicio_2
{
    public class Individuo : IIndividuo
    {
        private Pessoa _pessoa;

        public Individuo()
        {
        }

        public void CriarPessoa(string Nome, double Altura, DateTime DataNasc)
        {
            if (ValidaPessoa(Nome, Altura, DataNasc))
            {
                _pessoa = new Pessoa();
                _pessoa.Nome = Nome;
                _pessoa.Altura = Altura;
                _pessoa.DaTaNasc = DataNasc;
            }
        }

        public void ExibirInformacoes()
        {
            if(_pessoa != null)
                Console.WriteLine(_pessoa);
            else
                Console.WriteLine("A pessoa ainda não nasceu!");
        }

        private bool ValidaPessoa(string Nome, double Altura, DateTime DataNasc)
        {
            if (string.IsNullOrEmpty(Nome) || Altura <= 0 || !ValidarData(DataNasc.ToString()))
            {
                Console.Write("Dados da pessoa incorretos! Volte oa menu e insira novamente!");
                return false;
            }

            return true;
        }

        private bool ValidarData(string data)
        {
            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4} \d{2}:\d{2}:\d{2})");
            return r.Match(data).Success;
        }
    }
}
