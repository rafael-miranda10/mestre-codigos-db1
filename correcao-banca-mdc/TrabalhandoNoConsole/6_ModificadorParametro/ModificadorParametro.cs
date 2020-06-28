using RecursosCompartilhados;
using System;

namespace TrabalhandoNoConsole._6_ModificadorParametro
{
    public class ModificadorParametro : IModificadorParametro
    {
        public ModificadorParametro()
        {

        }

        public void ExecutarExemploOut(out int valueOut)
        {
            valueOut = 50;
        }

        public void ExecutarExemploRef(ref int valueRef)
        {
            valueRef += 100;
        }

        public void ExibirExplicacao()
        {
            Console.WriteLine(Constantes.MsgExplicacaoModificadorParametro);
        }
    }
}
