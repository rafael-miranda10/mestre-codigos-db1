using System;
using System.Collections.Generic;
using System.Text;

namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public interface IContaBancaria
    {
        void Sacar(double valor);
        void Depositar(double valor);
    }
}
