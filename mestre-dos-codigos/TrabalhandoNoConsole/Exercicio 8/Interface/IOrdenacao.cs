using System.Collections.Generic;

namespace TrabalhandoNoConsole.Exercicio_8.Interface
{
    public interface IOrdenacao
    {
        void OrdenacaoManualCrescente(List<int> inteiros);
        void OrdenacaoManualDeCrescente(List<int> inteiros);
        void OrdenacaoArraySortCrescente(List<int> inteiros);
        void OrdenacaoArraySortDeCrescente(List<int> inteiros);
        void OrdenacaoLinqCrescente(List<int> inteiros);
        void OrdenacaoLinqDeCrescente(List<int> inteiros);
    }
}
