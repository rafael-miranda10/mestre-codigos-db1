using RecursosCompartilhados;
using System;

namespace TrabalhandoNoConsole._5_Bhaskara
{
    public class Equacao
    {
        private Bhaskara _bhaskara;
        public Equacao()
        {
        }

        public void CalcularEquacao(double a, double b, double c)
        {
            _bhaskara = FabricaBhaskara.Criar(a, b, c);

            if (_bhaskara.Invalid)
            {
                foreach (var item in _bhaskara.Notifications)
                    Console.WriteLine(Constantes.MsgValidacaoCalcularEquacao, item.Message);
            }

            if (_bhaskara.Valid)
            {
                _bhaskara.CalcularFormulaBhaskara();
                _bhaskara.ExibirValoresDeR1eR2();
            }
        }
    }
}
