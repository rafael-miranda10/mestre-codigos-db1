namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public interface IFabricaContaBancaria
    {
        ContaCorrente CriarContaCorrente(int numeroDaConta, double saldoInicial);
        ContaEspecial CriarContaEspecial(int numeroDaConta, double saldoInicial);
    }
}
