namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class FabricaContaBancaria 
    {
        public static ContaCorrente CriarContaCorrente(int numeroDaConta, double saldoInicial)
        {
            return new ContaCorrente(numeroDaConta, saldoInicial);
        }

        public static ContaEspecial CriarContaEspecial(int numeroDaConta, double saldoInicial)
        {
            return new ContaEspecial(numeroDaConta, saldoInicial);
        }
    }
}
