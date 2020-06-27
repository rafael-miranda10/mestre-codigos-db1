namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class FabricaContaBancaria : IFabricaContaBancaria
    {
        public ContaCorrente CriarContaCorrente(int numeroDaConta, double saldoInicial)
        {
            return new ContaCorrente(numeroDaConta, saldoInicial);
        }

        public ContaEspecial CriarContaEspecial(int numeroDaConta, double saldoInicial)
        {
            return new ContaEspecial(numeroDaConta, saldoInicial);
        }
    }
}
