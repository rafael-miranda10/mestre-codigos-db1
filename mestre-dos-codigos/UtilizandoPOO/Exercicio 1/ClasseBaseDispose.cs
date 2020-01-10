using System;

namespace UtilizandoPOO.Exercicio_1
{
    public class ClasseBaseDispose : IDisposable
    {
        // boleano para controlar se o método já foi chamado
        bool disposed = false;

        public ClasseBaseDispose()
        {

        }

         // Destrutor chamado pelo GC
        ~ClasseBaseDispose()
        {
            Dispose(false);
        }

        public void ExecutarAlgo()
        {
            Console.Write("Execução de métodos da classe e consumindo instância do objeto!\n");
        }


        public void Dispose()
        {
            Console.Write("Método dispose chamado!");
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
