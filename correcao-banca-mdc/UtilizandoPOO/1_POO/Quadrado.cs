namespace UtilizandoPOO._1_POO
{
    public class Quadrado : FormaGeometrica
    {
        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public double Lado { get; private set; }
        public override double CalcularArea => Lado * Lado;
    }
}
