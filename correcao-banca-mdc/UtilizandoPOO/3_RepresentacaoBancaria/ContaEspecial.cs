using RecursosCompartilhados;

namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class ContaEspecial : ContaBancaria, IImprimivel, IContaBancaria
    {
        private const double _limteCredito = 100;
        public ContaEspecial(int numConta, double saldoInicial)
                            : base(numConta, saldoInicial)
        {

        }

        public string MostrarDados() => string.Format(ConstantesPoo.MsgDadosContaEspecial,
                                                     RetornarNumeroDaConta(), 
                                                     RetornarSaldoDaConta().ToString("C"));

        public override void Sacar(double valorDoSaque)
        {
            if (PermiteSacarValor(valorDoSaque))
                base.Sacar(valorDoSaque);
        }
        private bool PermiteSacarValor(double valorDoSaque)
        {
            if (valorDoSaque > (SaldoConta + _limteCredito))
                return false;

            return true;
        }
    }
}
