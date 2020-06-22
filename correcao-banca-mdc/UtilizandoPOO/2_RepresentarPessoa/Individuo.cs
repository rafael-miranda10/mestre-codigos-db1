using System;
using System.Text.RegularExpressions;
using UtilizandoPOO.RecursosDePOO;

namespace UtilizandoPOO._2_RepresentarPessoa
{
    public class Individuo
    {
        private Pessoa _pessoa;
        public Individuo()
        {
        }
        public void CriarPessoa(string nome, double altura, DateTime dataNasc)
        {
            if (ValidaPessoa(nome, altura, dataNasc))
            {
                _pessoa = new Pessoa();
                _pessoa.Nome = nome;
                _pessoa.Altura = altura;
                _pessoa.DaTaNascimento = dataNasc;
            }
        }

        private bool ValidaPessoa(string nome, double altura, DateTime dataNasc)
        {
            if (string.IsNullOrEmpty(nome) || altura <= 0 || !ValidarData(dataNasc.ToString()))
            {
                Console.WriteLine(ConstantesPoo.MsgErroValidacaoPessoa);
                return false;
            }

            return true;
        }
        private bool ValidarData(string data)
        {
            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4} \d{2}:\d{2}:\d{2})");
            return r.Match(data).Success;
        }

        public void ExibirInformacoesDoIndividuo()
        {
            if (_pessoa != null)
                Console.WriteLine(_pessoa);
            else
                Console.WriteLine(ConstantesPoo.MsgPessoaNaoNasceu);
        }
    }
}
