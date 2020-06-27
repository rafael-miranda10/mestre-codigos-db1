using RecursosCompartilhados;
using System.Collections.Generic;

namespace UtilizandoPOO._1_POO
{
    public class FabricaPOO
    {
        public static Descartavel CriarDescartavel()
        {
            return new Descartavel();
        }
        public static Humano CriarHumano(string nome, string telefone, int idade)
        {
            return new Humano(nome, telefone, idade);
        }
        public static List<Empregado> GerarListaEmpregados()
        {
            var listaDeEmpregados = new List<Empregado>();
            listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoRafael, Salario = 4.652 });
            listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoDjalmaJorge, Salario = 9.365 });
            listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoTiringa, Salario = 1.852 });
            listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoZobaido, Salario = 1.265 });
            listaDeEmpregados.Add(new Empregado() { Nome = ConstantesPoo.EmpregadoAna, Salario = 1.478 });
            return listaDeEmpregados;
        }

        public static Cachorro[] GerarListaDeCachorros()
        {
            var listacachorros = new Cachorro[3];
            listacachorros[0] = new Cachorro(ConstantesPoo.CachorroNomeGreg, ConstantesPoo.CachorroRacGreg);
            listacachorros[1] = new Cachorro(ConstantesPoo.CachorroNomeBudy, ConstantesPoo.CachorroRacaBudy);
            listacachorros[2] = new Cachorro(ConstantesPoo.CachorroNomeThor, ConstantesPoo.CachorroRacaThor);
            return listacachorros;
        }

        public static Circulo CriarCirculo(double raio)
        {
            return new Circulo(raio);
        }

        public static Quadrado CriarQuadrado(double lado)
        {
            return new Quadrado(lado);
        }

        public static Retangulo CriarRetangulo(double lado)
        {
            return new Retangulo(lado);
        }

        public static Triangulo CriarTriangulo(double baseTriagulo, double alturaTriangulo)
        {
            return new Triangulo(baseTriagulo, alturaTriangulo);
        }
    }
}
