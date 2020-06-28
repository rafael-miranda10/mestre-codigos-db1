using System.Collections.Generic;

namespace TrabalhandoNoConsole._9_BibliotecaLinq
{
    public interface IConsultaIntegrada
    {
        void AdicionarLista(List<int> lista);
        void ExibirListaInteira();
        void ExibirOrdemCrescente();
        void ExibirOrdemDecrescente();
        void ExibirPrimeiroDaLista();
        void ExibirUltimoDaLista();
        void InserirPrimeiroDaLista(int elemento);
        void InserirUltimoDaLista(int elemento);
        void PesquisarElemento(int chave);
        void RemoverPrimeiroDaLista();
        void RemoverUltimoDaLista();
        void ExibirSomenteNumerosPares();
        void TransformarLista();
    }
}
