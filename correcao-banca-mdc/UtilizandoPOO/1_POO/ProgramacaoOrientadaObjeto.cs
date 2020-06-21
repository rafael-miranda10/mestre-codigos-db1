using System;
using UtilizandoPOO.RecursosDePOO;

namespace UtilizandoPOO._1_POO
{
    public class ProgramacaoOrientadaObjeto
    {
        private FormaGeometrica _formaGeometrica;
        private double _areaCalculada;
        public ProgramacaoOrientadaObjeto()
        {

        }

        public void CalcularAreaCirculo(double raio)
        {
            _formaGeometrica = new Circulo(raio);
            _areaCalculada = _formaGeometrica.CalcularArea;
            ExibirAreaForma(_areaCalculada, ConstantesPoo.NomeCirculo);
        }

        public void CalcularAreaQuadrado(double lado)
        {
            _formaGeometrica = new Quadrado(lado);
            _areaCalculada = _formaGeometrica.CalcularArea;
            ExibirAreaForma(_areaCalculada, ConstantesPoo.NomeQuadrado);
        }

        public void CalcularAreaRetangulo(double lado)
        {
            _formaGeometrica = new Retangulo(lado);
            _areaCalculada = _formaGeometrica.CalcularArea;
            ExibirAreaForma(_areaCalculada, ConstantesPoo.NomeRetangulo);
        }

        public void CalcularAreaTriangulo(double baseTriagulo, double alturaTriangulo)
        {
            _formaGeometrica = new Triangulo(baseTriagulo, alturaTriangulo);
            _areaCalculada = _formaGeometrica.CalcularArea;
            ExibirAreaForma(_areaCalculada, ConstantesPoo.NomeTriangulo);
        }

        private void ExibirAreaForma(double area, string escolha)
        {
            Console.Clear();
            Console.Write(ConstantesPoo.MsgExibirForma, escolha, area);
            Console.ReadKey();
        }

    }
}
