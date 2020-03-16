using System;
using System.Globalization;

namespace UtilizandoPOO.Exercicio_3
{
    public class Banco : IBanco
    {
        private ContaBancaria[] bancoDB1;

        public Banco()
        {
            bancoDB1  = new ContaBancaria[4];
        }

        public void CapturarInputContaBancaria()
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
                    double.TryParse(Console.ReadLine(), NumberStyles.Number, new CultureInfo("pt-BR"), out saldo);
                    var contaC = new ContaCorrente(numConta, saldo);
                    bancoDB1[i] = contaC;
                }
                if (i >= 2)
                {
                    Console.Write($"Informe o número da conta especial {i - 1}:");
                    int.TryParse(Console.ReadLine(), out numConta);
                    Console.Write($"Informe o saldo da conta especial {i - 1}:");
                    double.TryParse(Console.ReadLine(), NumberStyles.Number, new CultureInfo("pt-BR"), out saldo);
                    var contaE = new ContaEspecial(numConta, saldo);
                    bancoDB1[i] = contaE;
                }
            }
        }

        public bool EfetuarDeposito()
        {
            if (ExisteConta())
            {
                double valor = 0;
                Console.Write($"Informe o valor do depósito:");
                double.TryParse(Console.ReadLine(), NumberStyles.Number, new CultureInfo("pt-BR"), out valor);

                for (int i = 0; i < bancoDB1.Length; i++)
                {
                    bancoDB1[i].Depositar(valor);
                }
                return true;
            }
            Console.Write("Não existe nenhum conta para ser exibida!");
            return false;
        }

        public bool EfetuarSaque()
        {
            if (ExisteConta())
            {
                double valor = 0;
                Console.Write($"Informe o valor do saque:");
                double.TryParse(Console.ReadLine(), NumberStyles.Number, new CultureInfo("pt-BR"), out valor);

                for (int i = 0; i < bancoDB1.Length; i++)
                {
                    bancoDB1[i].Sacar(valor);
                }
                return true;
            }
            Console.Write("Não existe nenhum conta para ser exibida!");
            return false;
        }

        public bool ExibirContasBancarias()
        {
            if (ExisteConta())
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

        private bool ExisteConta()
        {
            return (bancoDB1[0] != null) ? true : false;
        }
    }
}
