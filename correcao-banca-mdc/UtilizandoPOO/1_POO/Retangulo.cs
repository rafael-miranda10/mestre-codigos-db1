namespace UtilizandoPOO._1_POO
{
    public class Retangulo : FormaGeometrica
    {
        public Retangulo(double lado)
        {
            Lado = lado;
        }
        public double Lado { get; private set; }

        public override double CalcularArea => Lado * Lado;
    }
}
