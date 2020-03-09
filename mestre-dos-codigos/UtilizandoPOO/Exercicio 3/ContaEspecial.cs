using System;

namespace UtilizandoPOO.Exercicio_3
{
    public class ContaEspecial : ContaBancaria, IContaBancaria
    {
        private const double LimteCredito = 100;

        public ContaEspecial(int numConta, double saldoInicial) : base(numConta, saldoInicial)
        {

        }

        public override void Depositar(double valor)
        {
            SaldoConta += valor;
        }

        public void MostraDados()
        {
            Console.Write($"A conta especial de número: {NumeroConta} possui o saldo de : {SaldoConta.ToString("C")}\n");
        }

        public override bool Sacar(double valor)
        {
            if (valor > (SaldoConta + LimteCredito))
            {
                Console.Write($"A conta especial de número: {NumeroConta} possui um limite de crédito de R$: {LimteCredito}, no entanto, não possui o saldo suficiente para o saque de R$: {valor}\n");
                return false;
            }

            SaldoConta -= valor;
            return true;
        }
    }
}
