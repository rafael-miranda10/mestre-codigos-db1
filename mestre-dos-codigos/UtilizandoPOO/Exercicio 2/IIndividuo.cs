using System;

namespace UtilizandoPOO.Exercicio_2
{
    public interface IIndividuo
    {
        void CriarPessoa(string Nome, double Altura, DateTime DataNasc);
        void ExibirInformacoes();
    }
}
