using System;

namespace UtilizandoPOO.Exercicio_1
{
    public class Circulo: Forma
    {
        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double Raio { get; set; }
        public override double CalcularArea => Math.Pow(Raio, 2) * Math.PI;
    }
}
