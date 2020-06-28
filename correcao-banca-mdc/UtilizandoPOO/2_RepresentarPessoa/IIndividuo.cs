using System;

namespace UtilizandoPOO._2_RepresentarPessoa
{
    public interface IIndividuo
    {
        void CriarPessoa(string nome, double altura, DateTime dataNasc);
        void ExibirInformacoesDoIndividuo();
    }
}
