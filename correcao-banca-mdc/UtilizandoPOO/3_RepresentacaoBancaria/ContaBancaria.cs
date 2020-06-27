namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    /*
    A escolha da interface se da pois existe métodos que são igauis na classe concreta, e implementando os métodos na classe abstrata eu consigo 
    garantir a implementação IContaBancaria e minhas classes concretas que implementam a minha interface IContaBancaria devido a herderam da minha 
    classe abstrata conta bancaria já implementam o método depositar que existe na interface conta bancaria
    */
    public abstract class ContaBancaria : IContaBancaria
    {
        protected int NumeroConta { get; set; }
        protected double SaldoConta { get; set; }

        public ContaBancaria(int conta, double saldo)
        {
            NumeroConta = conta;
            SaldoConta = saldo;
        }

        public virtual void Sacar(double valorDoSaque)
        {
            SaldoConta -= valorDoSaque;
        }
        public void Depositar(double valorDoDeposito)
        {
            SaldoConta += valorDoDeposito;
        }

        public int RetornarNumeroDaConta()
        {
            return NumeroConta;
        }
        public double RetornarSaldoDaConta()
        {
            return SaldoConta;
        }

    }
}
