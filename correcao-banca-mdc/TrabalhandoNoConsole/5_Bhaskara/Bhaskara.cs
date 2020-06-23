using Flunt.Notifications;
using Flunt.Validations;
using RecursosCompartilhados;
using System;

namespace TrabalhandoNoConsole._5_Bhaskara
{
    public class Bhaskara : Notifiable
    {
        public Bhaskara(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            AddNotifications(new Contract()
             .Requires()
             .IsGreaterThan(A, 0.0, Constantes.BaskaraA, Constantes.MsgValidacaoValorA));
        }

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double Delta { get; private set; }
        public double Raiz { get; private set; }
        public double R1 { get; private set; }
        public double R2 { get; private set; }

        private double CalcularDelta()
        {
            return Math.Pow(B, 2) - (4 * A * C);
        }

        public void CalcularFormulaBhaskara()
        {
            Delta = CalcularDelta();
            Raiz = CalcularRaiz();
            CalcularR1eR2();
        }

        private void CalcularR1eR2()
        {
            R1 = ((-(B)) + Raiz) / (2 * A);
            R2 = ((-(B)) - Raiz) / (2 * A);
        }

        private double CalcularRaiz()
        {
            return Math.Sqrt(Delta);
        }
        public void ExibirValoresDeR1eR2()
        {
            Console.WriteLine(Constantes.MsgExibirResultadoFormula, A, B, C);
            Console.WriteLine(Constantes.MsgExibirR, 1, R1);
            Console.WriteLine(Constantes.MsgExibirR, 2, R2);
        }
    }
}
