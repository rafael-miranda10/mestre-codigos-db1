namespace UtilizandoPOO.Exercicio_1
{
    public class Quadrado : Forma
    {
        public Quadrado(double lado)
        {
            Lado = lado;
        }
        public double Lado { get; private set; }
        public override double CalcularArea => Lado * Lado;
    }
}
