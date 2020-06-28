using System.Collections.Generic;

namespace TrabalhandoNoConsole._7_SomaNumerosPares
{
    public interface ISomaNumeroPar
    {
        void AdicionarLista(List<int> lista);
        void SomarNumerosParesPorDivisaoSimples();
        void SomarNumerosParesPorDivisaoExata();
        void SomarNumerosParesComLinq();
    }
}
