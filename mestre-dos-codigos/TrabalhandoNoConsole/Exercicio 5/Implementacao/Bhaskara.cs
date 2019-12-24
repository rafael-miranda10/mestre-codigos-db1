using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace TrabalhandoNoConsole.Exercicio_5.Implementacao
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
             .IsGreaterThan(A, 0.0, "Bhaskara.A", "O valor de A deve ser diferente de 0 para que seja uma equação do 2º Grau."));
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
            CalcularR1R2();
        }

        private void CalcularR1R2()
        {
            R1 = ((-(B)) + Raiz) / (2 * A);
            R2 = ((-(B)) - Raiz) / (2 * A);
        }

        private double CalcularRaiz()
        {
            return Math.Sqrt(Delta);
        }
        public void ExibirR1R2()
        {
            Console.WriteLine($"A formula de Bhaskara calculada com A: {A} B: {B} e C: {C} apresenta o resultado:\n");
            Console.WriteLine($"R1: {R1}");
            Console.WriteLine($"R2: {R2}");
        }
    }

}
