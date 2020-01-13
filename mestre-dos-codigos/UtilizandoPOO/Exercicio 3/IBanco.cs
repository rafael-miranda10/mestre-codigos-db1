namespace UtilizandoPOO.Exercicio_3
{
    public interface IBanco
    {
        bool EfetuarSaque(ContaBancaria[] bancoDB1);
        bool EfetuarDeposito(ContaBancaria[] bancoDB1);
        bool ExibirContasBancarias(ContaBancaria[] bancoDB1);
        void CapturarInputContaBancaria(ContaBancaria[] bancoDB1);
    }
}
