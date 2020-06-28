using RecursosCompartilhados;
using System;
using UtilizandoPOO._1_POO;

namespace Principal.MenusPOO
{
    public class ItemDeMenuFormaGeometrica
    {
        private double _lado;
        private double _raio;
        private double _alturaTriangulo;
        private double _baseTriangulo;
        private IProgramacaoOrientadaObjeto _programacaoOrientadaObjeto;
        public ItemDeMenuFormaGeometrica(IProgramacaoOrientadaObjeto programacaoOrientadaObjeto)
        {
            _programacaoOrientadaObjeto = programacaoOrientadaObjeto;
        }

        public void ExibirItemDeMenuFormaGeometrica()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuFormaGeometrica();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _lado = CapturaDeDados.CapturarNumeroDouble("Informe o lado do quadrado: ");
                        _programacaoOrientadaObjeto.CalcularAreaQuadrado(_lado);
                        Console.ReadKey();
                        break;
                    case "2":
                        _lado = CapturaDeDados.CapturarNumeroDouble("Informe o lado do retângulo: ");
                        _programacaoOrientadaObjeto.CalcularAreaRetangulo(_lado);
                        Console.ReadKey();
                        break;
                    case "3":
                        _baseTriangulo = CapturaDeDados.CapturarNumeroDouble("Informe a base do triângulo: ");
                        _alturaTriangulo = CapturaDeDados.CapturarNumeroDouble("Informe a altura do triângulo: ");
                        _programacaoOrientadaObjeto.CalcularAreaTriangulo(_baseTriangulo, _alturaTriangulo);
                        Console.ReadKey();
                        break;
                    case "4":
                        _raio = CapturaDeDados.CapturarNumeroDouble("Informe o raio do círculo: ");
                        _programacaoOrientadaObjeto.CalcularAreaCirculo(_raio);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuFormaGeometrica()
        {
            Console.Clear();
            Console.WriteLine("*** Calcular Área ***\n");
            Console.WriteLine("1) Quadrado");
            Console.WriteLine("2) Retângulo");
            Console.WriteLine("3) Triângulo");
            Console.WriteLine("4) Círculo");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
