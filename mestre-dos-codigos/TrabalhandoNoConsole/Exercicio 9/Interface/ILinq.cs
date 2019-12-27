using System.Collections.Generic;

namespace TrabalhandoNoConsole.Exercicio_9.Interface
{
    public interface ILinq
    {
        void SetLista(List<int> inteiros);
        void ExibirListaInteira();
        void ExibirOrdemCrescente();
        void ExibirOrdemDecrescente();
        void ExibirPrimeiroDaLista();
        void ExibirUltimoDaLista();
        void RemoverPrimeiroDaLista();
        void RemoverUltimoDaLista();
        void SomenteNumerosPar();
        void TransformarListaEmArray();
        void PesquisarElemento(int chave);
        void InserirPrimeiroDaLista(int elemento);
        void InserirUltimoDaLista(int elemento);
    }
}
