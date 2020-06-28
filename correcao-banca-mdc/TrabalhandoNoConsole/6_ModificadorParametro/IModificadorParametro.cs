namespace TrabalhandoNoConsole._6_ModificadorParametro
{
    public interface IModificadorParametro
    {
        void ExecutarExemploOut(out int valueOut);
        void ExecutarExemploRef(ref int valueRef);
        void ExibirExplicacao();
    }
}
