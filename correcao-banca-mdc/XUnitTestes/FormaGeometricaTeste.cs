using System;
using UtilizandoPOO._1_POO;
using Xunit;

namespace XUnitTestes
{
    public class FormaGeometricaTeste
    {
        private FormaGeometrica _formaGeometrica;

        [Theory]
        [InlineData(5, 25)]
        [InlineData(10, 100)]
        public void Calculo_DeveRetornarAreaCalculadaDoQuadrado(double lado, double AreaEsperada)
        {
            _formaGeometrica = FabricaPOO.CriarQuadrado(lado); 
            double area = _formaGeometrica.CalcularArea;
            Assert.Equal(area, AreaEsperada);
        }

        [Theory]
        [InlineData(5, 25)]
        [InlineData(10, 100)]
        public void Calculo_DeveRetornarAreaCalculadaDoRetangulo(double lado, double AreaEsperada)
        {
            _formaGeometrica = FabricaPOO.CriarRetangulo(lado);
            double area = _formaGeometrica.CalcularArea;
            Assert.Equal(area, AreaEsperada);
        }

        [Theory]
        [InlineData(6, 10, 30)]
        public void Calculo_DeveRetornarAreaCalculadaDoTrianguloangulo(double baseTriangulo, double alturaTriangulo, double AreaEsperada)
        {
            _formaGeometrica = FabricaPOO.CriarTriangulo(baseTriangulo, alturaTriangulo); 
            double area = _formaGeometrica.CalcularArea;
            Assert.Equal(area, AreaEsperada);
        }

        [Theory]
        [InlineData(5, 78.54)]
        public void Calculo_DeveRetornarAreaCalculadaDoCirculo(double raio, double AreaEsperada)
        {
            _formaGeometrica = FabricaPOO.CriarCirculo(raio);
            double area = _formaGeometrica.CalcularArea;
            Assert.Equal(Math.Round(area, 2), AreaEsperada);
        }
    }
}
