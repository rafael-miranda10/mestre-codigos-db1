namespace UtilizandoPOO.Exercicio_1
{
    public class Triangulo : Forma
    {
        public Triangulo(double _base, double altura)
        {
            Base = _base;
            Altura = altura;
        }
        public double Base { get; private set; }
        public double Altura { get; private set; }
        public override double CalcularArea => (Base * Altura) / 2;
    }
}
