namespace TrabalhandoNoConsole._1_Calculadora
{
    public class Calculo : ICalculo
    {
        public double Dividir(double a, double b) => b / a;

        public double Multiplicar(double a, double b) => a * b;

        public double Somar(double a, double b) => a + b;

        public double Subtrair(double a, double b) => a - b;

        public bool VerificaSeEPar(double x) => (x % 2 == 0);
    }
}
