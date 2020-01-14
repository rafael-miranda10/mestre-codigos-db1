namespace UtilizandoPOO.Exercicio_1
{
    public interface IPoo
    {
        void ExecutarIDisposable();
        void ExecutarIComparable();
        void ExecutarICloneable();
        void ExecutarINumerable();
        void CalcularAreaQuadrado(double lado);
        void CalcularAreaRetangulo(double lado);
        void CalcularAreaTriangulo(double _base, double altura);
        void CalcularAreaCirculo(double raio);
    }
}
