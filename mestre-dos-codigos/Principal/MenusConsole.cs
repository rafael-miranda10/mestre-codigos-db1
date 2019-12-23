using System;
using TrabalhandoNoConsole.Exercicio_1.Interface;

namespace Principal
{
    public class MenusConsole 
    {
        private readonly IExercicio1 _exercicio1; 

        public MenusConsole(IExercicio1 exercicio1)
        {
            _exercicio1 = exercicio1;
        }

        public bool MenuExercicio1Console(double valorA, double valorB)
        {
            Console.Clear();
            Console.WriteLine($"*** Os números informados são {valorA} e {valorB} ***\n\n");
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Somar");
            Console.WriteLine("2) Subtrair");
            Console.WriteLine("3) Dividir");
            Console.WriteLine("4) Multiplicar");
            Console.WriteLine("5) É Par?");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    _exercicio1.Somar(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    _exercicio1.Subtrair(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    _exercicio1.Dividir(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    _exercicio1.Multiplicar(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.Clear();
                    _exercicio1.VerificarPar(valorA, valorB);
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }
    }
}
