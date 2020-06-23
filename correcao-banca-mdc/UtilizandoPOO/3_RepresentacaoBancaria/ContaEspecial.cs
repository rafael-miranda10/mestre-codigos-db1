using RecursosCompartilhados;
using System;

namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class ContaEspecial : ContaBancaria, IContaBancaria
    {
        private const double _limteCredito = 100;
        public ContaEspecial(int numConta, double saldoInicial) 
                            : base(numConta, saldoInicial)
        {

        }
        public override void Depositar(double valor)
        {
            SaldoConta += valor;
        }

        public void MostrarDados()
        {
            Console.WriteLine(ConstantesPoo.MsgDadosContaEspecial, NumeroConta, SaldoConta.ToString("C"));
        }

        public override bool Sacar(double valor)
        {
            if (valor > (SaldoConta + _limteCredito))
            {
                Console.Write(ConstantesPoo.MsgSemSaldoContaBancaria, "especial", NumeroConta, valor);
                return false;
            }

            SaldoConta -= valor;
            return true;
        }
    }
}
