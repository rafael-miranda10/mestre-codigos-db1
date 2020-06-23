using RecursosCompartilhados;
using System;

namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class ContaCorrente : ContaBancaria, IContaBancaria
    {
        private const double _taxaOperacao = 1.50;
        public ContaCorrente(int numConta, double saldoInicial)
                            : base(numConta, saldoInicial)
        {
        }
        public override void Depositar(double valor)
        {
            SaldoConta += (valor - _taxaOperacao);
        }

        public void MostrarDados()
        {
            Console.WriteLine(ConstantesPoo.MsgDadosContaCorrente, NumeroConta, SaldoConta.ToString("C"));
        }

        public override bool Sacar(double valor)
        {
            if ((valor + _taxaOperacao) > SaldoConta)
            {
                Console.Write(ConstantesPoo.MsgSemSaldoContaBancaria, "corrente", NumeroConta, valor);
                return false;
            }

            SaldoConta -= (valor + _taxaOperacao);
            return true;
        }
    }
}
