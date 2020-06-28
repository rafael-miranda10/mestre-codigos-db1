using System.Collections.Generic;

namespace TrabalhandoNoConsole._8_OrdenacaoDeNumeros
{
    public interface IOrdenacaoDeNumeros
    {
        void AdicionarLista(List<decimal> lista);
        void OrdenacaoCrescenteComRecurso();
        void OrdenacaoDecrescenteComRecurso();
        void OrdenacaoCrescenteComRecursoDoLinq();
        void OrdenacaoDecrescenteComRecursoDoLinq();
        void OrdenacaoManualCrescente();
        void OrdenacaoManualDeCrescente();
    }
}
