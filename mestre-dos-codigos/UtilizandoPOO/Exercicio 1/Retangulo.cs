namespace UtilizandoPOO.Exercicio_1
{
    public class Retangulo : Forma
    {
        public Retangulo(double lado)
        {
            Lado = lado;
        }
        public double Lado { get; private set; }
        public override double CalcularArea => Lado * Lado;
    }
}
