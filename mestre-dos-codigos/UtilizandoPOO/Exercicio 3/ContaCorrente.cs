using System;

namespace UtilizandoPOO.Exercicio_3
{
    public class ContaCorrente : ContaBancaria, IContaBancaria
    {
        private const double TaxaOperacao = 1.50;

        public ContaCorrente(int numConta, double saldoInicial): base(numConta, saldoInicial)
        {

        }

        public override void Depositar(double valor)
        {
            SaldoConta += (valor - TaxaOperacao);
        }

        public  void MostraDados()
        {
            Console.Write($"A conta corrente de número: {NumeroConta} possui o saldo de : {SaldoConta.ToString("C")}\n");
        }

        public override bool Sacar(double valor)
        {
            if ((valor + TaxaOperacao) > SaldoConta)
            {
                Console.Write($"A conta corrente de número: {NumeroConta} não possui o saldo suficiente para o saque de R$: {valor}\n");
                return false;
            }

            SaldoConta -= (valor + TaxaOperacao);
            return true;
        }
    }
}
