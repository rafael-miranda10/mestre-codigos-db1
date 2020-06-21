namespace UtilizandoPOO._1_POO
{
    class Triangulo : FormaGeometrica
    {
        public Triangulo(double baseTriagulo, double alturaTriangulo)
        {
            BaseTriangulo = baseTriagulo;
            AlturaTriagulo = alturaTriangulo;
        }
        public double BaseTriangulo { get; private set; }
        public double AlturaTriagulo { get; private set; }

        public override double CalcularArea => (BaseTriangulo * AlturaTriagulo) / 2;
    }
}
