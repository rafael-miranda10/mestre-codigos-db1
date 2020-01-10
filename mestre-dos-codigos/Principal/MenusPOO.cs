using System;
using UtilizandoPOO.Exercicio_1;

namespace Principal
{
    public class MenusPOO
    {
        public MenusPOO()
        {

        }
        public bool MenuExercicio1POO()
        {
            bool ShowMenu = true;
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Abstração/Polimorfismo/Encapsulamento");
            Console.WriteLine("2) Encapsulamento");
            Console.WriteLine("3) Polimorfismo");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    while (ShowMenu)
                    {
                        ShowMenu = MenuCalcularArea();
                    }
                    return true;
                case "2":
                    Console.Clear();
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private bool MenuCalcularArea()
        {
            Forma forma = null;
            double lado = 0, altura = 0, _base = 0, raio = 0;
            Console.Clear();
            Console.WriteLine("*** Calcular Área ***\n");
            Console.WriteLine("1) Quadrado");
            Console.WriteLine("2) Retângulo");
            Console.WriteLine("3) Triângulo");
            Console.WriteLine("4) Círculo");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputDouble("Informe o lado do quadrado: ", out lado);
                    forma = new Quadrado(lado);
                    ExibirAreaForma(forma, "quadrado");
                    return true;
                case "2":
                    Console.Clear();
                    CapturarInputDouble("Informe o lado do retângulo: ", out lado);
                    forma = new Retangulo(lado);
                    ExibirAreaForma(forma, "retângulo");
                    return true;
                case "3":
                    Console.Clear();
                    CapturarInputDouble("Informe a base do triângulo: ", out _base);
                    CapturarInputDouble("Informe a altura do triângulo: ", out altura);
                    forma = new Triangulo(_base, altura);
                    ExibirAreaForma(forma, "tringulo");
                    return true;
                case "4":
                    Console.Clear();
                    CapturarInputDouble("Informe o raio do círculo: ", out raio);
                    forma = new Circulo(raio);
                    ExibirAreaForma(forma, "círculo");
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private void CapturarInputDouble(string prompt, out double valor)
        {
            do
            {
                Console.WriteLine(prompt);
            }
            while (!double.TryParse(Console.ReadLine(), out valor));
        }

        private void ExibirAreaForma(Forma forma, string escolha)
        {
            Console.Clear();
            Console.Write($"A área do {escolha} é: {forma.CalcularArea}");
            Console.ReadKey();
        }
    }
}
