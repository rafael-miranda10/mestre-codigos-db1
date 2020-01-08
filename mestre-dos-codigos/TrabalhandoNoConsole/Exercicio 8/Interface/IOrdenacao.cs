using System.Collections.Generic;

namespace TrabalhandoNoConsole.Exercicio_8.Interface
{
    public interface IOrdenacao
    {
        void OrdenacaoManualCrescente(List<decimal> decimais);
        void OrdenacaoManualDeCrescente(List<decimal> decimais);
        void OrdenacaoArraySortCrescente(List<decimal> decimais);
        void OrdenacaoArraySortDeCrescente(List<decimal> decimais);
        void OrdenacaoLinqCrescente(List<decimal> decimais);
        void OrdenacaoLinqDeCrescente(List<decimal> decimais);
    }
}
