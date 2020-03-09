namespace UtilizandoPOO.Exercicio_3
{
    public abstract class ContaBancaria 
    {
        protected int NumeroConta { get; set; }
        protected double SaldoConta { get; set; }
        protected string TipoConta { get; set; }

        public ContaBancaria(int conta, double saldo)
        {
            NumeroConta = conta;
            SaldoConta = saldo;
        }

        public abstract bool Sacar(double valor);
        public abstract void Depositar(double valor);
    }
}
