using RecursosCompartilhados;

namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class ContaCorrente : ContaBancaria, IImprimivel, IContaBancaria
    {
        private const double _taxaOperacao = 1.50;
        public ContaCorrente(int numConta, double saldoInicial)
                            : base(numConta, saldoInicial)
        {
        }

        public string MostrarDados() => string.Format(ConstantesPoo.MsgDadosContaCorrente,
                                                      RetornarNumeroDaConta(),
                                                      RetornarSaldoDaConta().ToString("C"));
        //{
        //    //return string.Format(ConstantesPoo.MsgDadosContaCorrente, RetornarNumeroDaConta(), RetornarSaldoDaConta().ToString("C"));

        //}

        public override void Sacar(double valorDoSaque)
        {
            if (PermiteSacarValor(valorDoSaque))
                base.Sacar(valorDoSaque);
        }

        private bool PermiteSacarValor(double valorDoSaque)
        {
            if ((valorDoSaque + _taxaOperacao) > SaldoConta)
                return false;

            return true;
        }
    }
}
