using System;
using System.Collections.Generic;

namespace UtilizandoPOO.Exercicio_1
{
    public class Poo : IPoo
    {
        private ClasseBaseDispose objDisposable;
        private List<Empregado> listaEmpregado;
        private Humano p1, p2;
        private Cachorro[] dogArray;
        private Forma forma;

        public Poo()
        {
            objDisposable = new ClasseBaseDispose();
            listaEmpregado = new List<Empregado>();
            p1 = new Humano("Rafael", "(18) 99654-8521", 29);
            dogArray = new Cachorro[3];
        }

        public void CalcularAreaCirculo(double raio)
        {
            forma = new Circulo(raio);
            ExibirAreaForma(forma, "círculo");
        }

        public void CalcularAreaQuadrado(double lado)
        {
            forma = new Quadrado(lado);
            ExibirAreaForma(forma, "quadrado");
        }

        public void CalcularAreaRetangulo(double lado)
        {
            forma = new Retangulo(lado);
            ExibirAreaForma(forma, "retângulo");
        }

        public void CalcularAreaTriangulo(double _base, double altura)
        {
            forma = new Triangulo(_base, altura);
            ExibirAreaForma(forma, "tringulo");
        }

        public void ExecutarICloneable()
        {
            p2 = (Humano)p1.Clone();
            p2.Nome = "Djalma Jorge";
            Console.Write(p1 + "\n");
            Console.Write(p2);
        }

        public void ExecutarIComparable()
        {
            listaEmpregado.Add(new Empregado() { Nome = "Rafael", Salario = 4.500 });
            listaEmpregado.Add(new Empregado() { Nome = "Djalma Jorge", Salario = 9.365 });
            listaEmpregado.Add(new Empregado() { Nome = "Tiringa", Salario = 1.852 });
            listaEmpregado.Add(new Empregado() { Nome = "Zobaido", Salario = 1.265 });
            listaEmpregado.Add(new Empregado() { Nome = "Ana", Salario = 1.265 });

            //Utilizando a interface Icomparable
            listaEmpregado.Sort();

            foreach (var empregado in listaEmpregado)
            {
                Console.Write(empregado + "\n");
            }
        }

        public void ExecutarIDisposable()
        {
            objDisposable.ExecutarAlgo();
            objDisposable.Dispose();
        }

        public void ExecutarINumerable()
        {
            dogArray[0] = new Cachorro("Greg", "Shitzu");
            dogArray[1] = new Cachorro("Budy", "Golden");
            dogArray[2] = new Cachorro("Thor", "PitBull");
            Canil canilList = new Canil(dogArray);
            foreach (Cachorro c in canilList)
                Console.Write($"Nome do cachorro: {c.Nome}, raça do cachorro: {c.Raca} \n");
        }

        private void ExibirAreaForma(Forma forma, string escolha)
        {
            Console.Clear();
            Console.Write($"A área do {escolha} é: {forma.CalcularArea}");
            Console.ReadKey();
        }
    }
}
