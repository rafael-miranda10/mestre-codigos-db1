using System;

namespace UtilizandoPOO._1_POO
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public double Raio { get; private set; }
        public override double CalcularArea => Math.Pow(Raio, 2) * Math.PI;
    }
}
