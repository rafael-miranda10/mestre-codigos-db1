using System;
using System.Collections.Generic;
using UtilizandoPOO.RecursosDePOO;

namespace UtilizandoPOO._1_POO
{
    public class ProgramacaoOrientadaObjeto
    {
        private FormaGeometrica _formaGeometrica;
        private List<Empregado> _listaDeEmpregados;
        private Descartavel _descartavel;
        private Humano _humano;
        private Humano _humanoClonado;
        private Cachorro[] _listacachorros;
        private Canil _listaCanil;
        private double _areaCalculada;
        public ProgramacaoOrientadaObjeto()
        {
            _descartavel = new Descartavel();
            _listaDeEmpregados = new List<Empregado>();
            _humano = new Humano(ConstantesPoo.NomeHumano, ConstantesPoo.TelefoneHumano, 54);
            _listacachorros = new Cachorro[3];
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

        public void ExecutarDescartavel()
        {
            _descartavel.ExecutarAlgo();
            _descartavel.Dispose();
        }

        public void ExecutarComparavel()
        {
            GerarListaEmpregados();

            //Utilizando a interface Icomparable
            _listaDeEmpregados.Sort();

            foreach (var empregado in _listaDeEmpregados)
            {
                Console.Write(empregado + "\n");
            }
        }

        private void GerarListaEmpregados()
        {
            _listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoRafael, Salario = 4.652 });
            _listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoDjalmaJorge, Salario = 9.365 });
            _listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoTiringa, Salario = 1.852 });
            _listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoZobaido, Salario = 1.265 });
            _listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoAna, Salario = 1.478 });
        }

        public void ExecutarClonavel()
        {
            _humanoClonado = (Humano)_humano.Clone();
            _humanoClonado.Nome = ConstantesPoo.NomeHumanoClonado;
            Console.WriteLine(_humano);
            Console.WriteLine(_humanoClonado);
        }

        public void ExecutarEnumeravel()
        {
            GerarListaDeCachorros();
            _listaCanil = new Canil(_listacachorros);
            foreach (Cachorro cachorro in _listaCanil)
                Console.WriteLine(ConstantesPoo.DadosCachorro, cachorro.Nome, cachorro.Raca);
        }

        private void GerarListaDeCachorros()
        {
            _listacachorros[0] = new Cachorro(ConstantesPoo.CachorroNomeGreg, ConstantesPoo.CachorroRacGreg);
            _listacachorros[1] = new Cachorro(ConstantesPoo.CachorroNomeBudy, ConstantesPoo.CachorroRacaBudy);
            _listacachorros[2] = new Cachorro(ConstantesPoo.CachorroNomeThor, ConstantesPoo.CachorroRacaThor);
        }
    }
}
