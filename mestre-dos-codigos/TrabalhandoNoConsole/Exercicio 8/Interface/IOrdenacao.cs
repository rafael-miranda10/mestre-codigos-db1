using System.Collections.Generic;

namespace TrabalhandoNoConsole.Exercicio_8.Interface
{
    public interface IOrdenacao
    {
        void OrdenacaoManualCrescente();
        void OrdenacaoManualDeCrescente();
        void OrdenacaoArraySortCrescente();
        void OrdenacaoArraySortDeCrescente();
        void OrdenacaoLinqCrescente();
        void OrdenacaoLinqDeCrescente();
        void Setlista(List<decimal> lista);
    }
}
