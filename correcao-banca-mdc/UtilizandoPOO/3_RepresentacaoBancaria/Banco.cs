using RecursosCompartilhados;

namespace UtilizandoPOO._3_RepresentacaoBancaria
{
    public class Banco
    {
        private ContaBancaria[] _listaDeContasBancarias;
        private int _numeroConta;
        private double _saldoConta;

        public Banco()
        {
            _listaDeContasBancarias = new ContaBancaria[4];
        }

        public void CriarContasBancarias()
        {
            for ( int i =0; i< _listaDeContasBancarias.Length; i++)
            {
                if (i < 2)
                {
                    _saldoConta = CapturaDeDados.CapturarNumeroDouble("Informe a altura da pessoa (em metros. ex: 1,80): ");
                }
            }
        }
    }
}
