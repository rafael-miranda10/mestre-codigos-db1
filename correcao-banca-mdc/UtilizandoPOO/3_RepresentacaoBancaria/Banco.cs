using RecursosCompartilhados;
using System;

namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class Banco
    {
        private ContaBancaria[] _listaDeContasBancarias;
        private ContaCorrente _contaCorrente;
        private ContaEspecial _contaEspecial;
        private int _numeroConta;
        private double _saldoConta;
        private double _valorDeDeposito;
        private double _valorSaque;

        public Banco()
        {
            _listaDeContasBancarias = new ContaBancaria[4];
        }

        public void CriarContasBancarias()
        {
            for (int i = 0; i < _listaDeContasBancarias.Length; i++)
            {
                if (i < 2)
                {
                    _numeroConta = CapturaDeDados.CapturarNumeroInteiro($"Informe o número da conta corrente {i + 1}: ");
                    _saldoConta = CapturaDeDados.CapturarNumeroDouble($"Informe o saldo da conta corrente {i + 1}: ");
                    _contaCorrente = new ContaCorrente(_numeroConta, _saldoConta);
                    _listaDeContasBancarias[i] = _contaCorrente;
                }
                else
                {
                    _numeroConta = CapturaDeDados.CapturarNumeroInteiro($"Informe o número da conta especial {i + 1}: ");
                    _saldoConta = CapturaDeDados.CapturarNumeroDouble($"Informe o saldo da conta especial {i + 1}: ");
                    _contaEspecial = new ContaEspecial(_numeroConta, _saldoConta);
                    _listaDeContasBancarias[i] = _contaEspecial;
                }
            }
        }

        public void EfetuarDeposito()
        {
            if (ExisteConta())
            {
                _valorDeDeposito = CapturaDeDados.CapturarNumeroDouble("Informe o valor do depósito: ");

                for (int i = 0; i < _listaDeContasBancarias.Length; i++)
                {
                    _listaDeContasBancarias[i].Depositar(_valorDeDeposito);
                }
                Console.WriteLine(ConstantesPoo.MsgBancoOperacaoSucesso);
            }
            else
            {
                Console.WriteLine(ConstantesPoo.MsgBancoContaNaoExiste);
            }
        }

        public void EfetuarSaque()
        {
            if (ExisteConta())
            {
                _valorSaque = CapturaDeDados.CapturarNumeroDouble("Informe o valor do saque: ");

                for (int i = 0; i < _listaDeContasBancarias.Length; i++)
                {
                    _listaDeContasBancarias[i].Sacar(_valorSaque);
                }
                Console.WriteLine(ConstantesPoo.MsgBancoOperacaoSucesso);
            }
            else
            {
                Console.WriteLine(ConstantesPoo.MsgBancoContaNaoExiste);
            }
        }

        public void ExibirContasBancarias()
        {
            if (ExisteConta())
            {
                for (int i = 0; i < _listaDeContasBancarias.Length; i++)
                {
                    if (i < 2)
                    {
                        _contaCorrente = (ContaCorrente)_listaDeContasBancarias[i];
                        _contaCorrente.MostrarDados();
                    }
                    else
                    {
                       _contaEspecial = (ContaEspecial)_listaDeContasBancarias[i];
                        _contaEspecial.MostrarDados();
                    }
                }
            }
            else
            {
                Console.WriteLine(ConstantesPoo.MsgBancoContaNaoExiste);
            }
        }

        private bool ExisteConta()
        {
            return (_listaDeContasBancarias[0] != null) ? true : false;
        }
    }
}
