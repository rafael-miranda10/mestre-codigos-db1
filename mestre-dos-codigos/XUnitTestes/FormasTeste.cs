using System;
using UtilizandoPOO.Exercicio_1;
using Xunit;

namespace XUnitTestes
{
    public class FormasTeste
    {
        private Forma _forma;

        [Theory]
        [InlineData(5, 25)]
        [InlineData(10, 100)]
        public void Calculo_DeveRetornarAreaCalculadaDoQuadrado(double Lado, double AreaEsp)
        {
            _forma = new Quadrado(Lado);
            double area = _forma.CalcularArea;
            Assert.Equal(area, AreaEsp);
        }

        [Theory]
        [InlineData(5, 25)]
        [InlineData(10, 100)]
        public void Calculo_DeveRetornarAreaCalculadaDoRetangulo(double Lado, double AreaEsp)
        {
            _forma = new Retangulo(Lado);
            double area = _forma.CalcularArea;
            Assert.Equal(area, AreaEsp);
        }

        [Theory]
        [InlineData(6,10,30)]
        public void Calculo_DeveRetornarAreaCalculadaDoTrianguloangulo(double _Base, double Altura, double AreaEsp)
        {
            _forma = new Triangulo(_Base, Altura);
            double area = _forma.CalcularArea;
            Assert.Equal(area, AreaEsp);
        }

        [Theory]
        [InlineData(5,78.54)]
        public void Calculo_DeveRetornarAreaCalculadaDoCirculo(double Raio, double AreaEsp)
        {
            _forma = new Circulo(Raio);
            double area = _forma.CalcularArea;
            Assert.Equal(Math.Round(area,2), AreaEsp);
        }
    }
}
