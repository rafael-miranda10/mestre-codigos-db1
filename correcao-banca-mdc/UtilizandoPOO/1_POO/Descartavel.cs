using RecursosCompartilhados;
using System;

namespace UtilizandoPOO._1_POO
{
    public class Descartavel : IDisposable
    {
        // boleano para controlar se o método já foi chamado
        bool disposed = false;

        public Descartavel()
        {
        }
        // Destrutor chamado pelo GC
        ~Descartavel()
        {
            Dispose(false);
        }

        public void ExecutarAlgo()
        {
            Console.Write(ConstantesPoo.MsgDescartavelExecutarAlgo);
        }

        public void Dispose()
        {
            Console.Write(ConstantesPoo.MsgDescartavelMetodoChamado);
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //liberando recursos gerenciados
                }

                //indica que os recursos já foram liberados
                disposed = true;
            }
        }

    }
}
