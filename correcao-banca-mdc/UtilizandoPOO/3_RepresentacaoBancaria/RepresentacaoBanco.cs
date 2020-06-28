using RecursosCompartilhados;
using System;
using System.Linq;

namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class RepresentacaoBanco : IRepresentacaoBanco
    {
        private ContaBancaria[] _listaDeContasBancarias;
        private int _numeroConta;
        private double _saldoConta;
        public RepresentacaoBanco()
        {
            _listaDeContasBancarias = new ContaBancaria[4];
        }

        public void CriarContasBancarias()
        {
            int tamanho = _listaDeContasBancarias.Length;
            int posicao = 0;

            while (posicao < tamanho)
            {
                AbrirContaCorrente(posicao);
                AbrirContaEspecial(++posicao);
                posicao++;
            }
        }

        public void ExibirContasBancarias()
        {
            if (!ExisteConta())
            {
                Console.WriteLine(ConstantesPoo.MsgBancoContaNaoExiste);
                return;
            }

            for (int posicao = 0; posicao < _listaDeContasBancarias.Length; posicao++)
            {
                if (_listaDeContasBancarias[posicao] is ContaCorrente)
                    ExibirContaCorrente(posicao);
                else
                    ExibirContaEspecial(posicao);
            }
        }

        public void EfetuarSaque()
        {
            if (!ExisteConta())
            {
                Console.WriteLine(ConstantesPoo.MsgBancoContaNaoExiste);
                return;
            }
            double valorSaque = CapturaDeDados.CapturarNumeroDouble(ConstantesPoo.MsgBancoInformeValorDeSaque);
            for (int i = 0; i < _listaDeContasBancarias.Length; i++)
            {
                _listaDeContasBancarias[i].Sacar(valorSaque);
            }
            Console.WriteLine(ConstantesPoo.MsgBancoOperacaoPermitidaSucesso);
        }
        public void EfetuarDeposito()
        {
            if (!ExisteConta())
            {
                Console.WriteLine(ConstantesPoo.MsgBancoContaNaoExiste);
                return;
            }
            double valorDeDeposito = CapturaDeDados.CapturarNumeroDouble(ConstantesPoo.MsgBancoInformeValorDeSaque);
            for (int i = 0; i < _listaDeContasBancarias.Length; i++)
            {
                _listaDeContasBancarias[i].Depositar(valorDeDeposito);
            }
            Console.WriteLine(ConstantesPoo.MsgBancoOperacaoSucesso);
        }

        private void AbrirContaCorrente(int posicao)
        {
            _numeroConta = CapturaDeDados.CapturarNumeroInteiro(
                string.Format(ConstantesPoo.MsgInformarNumeroContaCorrente, posicao + 1));
            _saldoConta = CapturaDeDados.CapturarNumeroDouble(
                string.Format(ConstantesPoo.MsgInformarSaldoContaCorrente, posicao + 1));
            _listaDeContasBancarias[posicao] = FabricaContaBancaria.CriarContaCorrente(_numeroConta, _saldoConta);
        }
        private void AbrirContaEspecial(int posicao)
        {
            _numeroConta = CapturaDeDados.CapturarNumeroInteiro(
                string.Format(ConstantesPoo.MsgInformarNumeroContaEspecial, posicao));
            _saldoConta = CapturaDeDados.CapturarNumeroDouble(
                string.Format(ConstantesPoo.MsgInformarSaldoContaEspecial, posicao));
            _listaDeContasBancarias[posicao] = FabricaContaBancaria.CriarContaEspecial(_numeroConta, _saldoConta);
        }
        private bool ExisteConta()
        {
            return _listaDeContasBancarias.Any(x => x != null);
        }
        private void ExibirContaCorrente(int posicao)
        {
            var contaCorrente = (ContaCorrente)_listaDeContasBancarias[posicao];
            Console.WriteLine(contaCorrente.MostrarDados());
        }

        private void ExibirContaEspecial(int posicao)
        {
            var contaEspecial = (ContaEspecial)_listaDeContasBancarias[posicao];
            Console.WriteLine(contaEspecial.MostrarDados());
        }
    }
}
