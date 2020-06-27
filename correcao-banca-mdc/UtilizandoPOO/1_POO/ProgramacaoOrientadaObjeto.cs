using RecursosCompartilhados;
using System;
using System.Collections.Generic;

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
            _descartavel = FabricaPOO.CriarDescartavel();
            _humano = FabricaPOO.CriarHumano(ConstantesPoo.NomeHumano, ConstantesPoo.TelefoneHumano, 54);
            _listacachorros = FabricaPOO.GerarListaDeCachorros();
        }

        public void CalcularAreaCirculo(double raio)
        {
            _formaGeometrica = FabricaPOO.CriarCirculo(raio);
            _areaCalculada = _formaGeometrica.CalcularArea;
            ExibirAreaForma(_areaCalculada, ConstantesPoo.NomeCirculo);
        }

        public void CalcularAreaQuadrado(double lado)
        {
            _formaGeometrica = FabricaPOO.CriarQuadrado(lado);
            _areaCalculada = _formaGeometrica.CalcularArea;
            ExibirAreaForma(_areaCalculada, ConstantesPoo.NomeQuadrado);
        }
        public void CalcularAreaRetangulo(double lado)
        {
            _formaGeometrica = FabricaPOO.CriarRetangulo(lado);
            _areaCalculada = _formaGeometrica.CalcularArea;
            ExibirAreaForma(_areaCalculada, ConstantesPoo.NomeRetangulo);
        }

        public void CalcularAreaTriangulo(double baseTriagulo, double alturaTriangulo)
        {
            _formaGeometrica = FabricaPOO.CriarTriangulo(baseTriagulo, alturaTriangulo);
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
            _listaDeEmpregados = FabricaPOO.GerarListaEmpregados();
            //Utilizando a interface Icomparable
            _listaDeEmpregados.Sort();

            foreach (var empregado in _listaDeEmpregados)
            {
                Console.Write(empregado + "\n");
            }
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
            _listaCanil = new Canil(_listacachorros);
            foreach (Cachorro cachorro in _listaCanil)
                Console.WriteLine(ConstantesPoo.DadosCachorro, cachorro.Nome, cachorro.Raca);
        }
    }
}
