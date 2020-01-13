using System;

namespace UtilizandoPOO.Exercicio_3
{
    public class Banco : IBanco
    {
        public void CapturarInputContaBancaria(ContaBancaria[] bancoDB1)
        {
            int numConta = 0;
            double saldo = 0;

            for (int i = 0; i < bancoDB1.Length; i++)
            {
                if (i < 2)
                {
                    Console.Write($"Informe o número da conta corrente {i + 1}:");
                    int.TryParse(Console.ReadLine(), out numConta);
                    Console.Write($"Informe o saldo da conta corrente {i + 1}:");
                    double.TryParse(Console.ReadLine(), out saldo);
                    var contaC = new ContaCorrente(numConta, saldo);
                    bancoDB1[i] = contaC;
                }
                if (i >= 2)
                {
                    Console.Write($"Informe o número da conta especial {i - 1}:");
                    int.TryParse(Console.ReadLine(), out numConta);
                    Console.Write($"Informe o saldo da conta especial {i - 1}:");
                    double.TryParse(Console.ReadLine(), out saldo);
                    var contaE = new ContaEspecial(numConta, saldo);
                    bancoDB1[i] = contaE;
                }
            }
        }

        public bool EfetuarDeposito(ContaBancaria[] bancoDB1)
        {
            if (ExisteConta(bancoDB1))
            {
                double valor = 0;
                Console.Write($"Informe o valor do depósito:");
                double.TryParse(Console.ReadLine(), out valor);

                for (int i = 0; i < bancoDB1.Length; i++)
                {
                    bancoDB1[i].Depositar(valor);
                }
                return true;
            }
            Console.Write("Não existe nenhum conta para ser exibida!");
            return false;
        }

        public bool EfetuarSaque(ContaBancaria[] bancoDB1)
        {
            if (ExisteConta(bancoDB1))
            {
                double valor = 0;
                Console.Write($"Informe o valor do saque:");
                double.TryParse(Console.ReadLine(), out valor);

                for (int i = 0; i < bancoDB1.Length; i++)
                {
                    bancoDB1[i].Sacar(valor);
                }
                return true;
            }
            Console.Write("Não existe nenhum conta para ser exibida!");
            return false;
        }

        public bool ExibirContasBancarias(ContaBancaria[] bancoDB1)
        {
            if (ExisteConta(bancoDB1))
            {
                for (int i = 0; i < bancoDB1.Length; i++)
                {
                    if (i < 2)
                    {
                        var contaC = (ContaCorrente)bancoDB1[i];
                        contaC.MostraDados();
                    }
                    if (i >= 2)
                    {
                        var contaE = (ContaEspecial)bancoDB1[i];
                        contaE.MostraDados();
                    }
                }
                return true;
            }

            Console.Write("Não existe nenhum conta para ser exibida!");
            return false;
        }

        private bool ExisteConta(ContaBancaria[] bancoDB1)
        {
            return (bancoDB1[0] != null) ? true : false;
        }
    }
}
