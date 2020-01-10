using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using TrabalhandoNoConsole.Exercicio_1.Implementacao;
using TrabalhandoNoConsole.Exercicio_1.Interface;
using TrabalhandoNoConsole.Exercicio_2.Implementacao;
using TrabalhandoNoConsole.Exercicio_2.Interface;
using TrabalhandoNoConsole.Exercicio_3.Implementacao;
using TrabalhandoNoConsole.Exercicio_3.Interface;
using TrabalhandoNoConsole.Exercicio_4.Implementacao;
using TrabalhandoNoConsole.Exercicio_4.Interface;
using TrabalhandoNoConsole.Exercicio_5.Implementacao;
using TrabalhandoNoConsole.Exercicio_5.Interface;
using TrabalhandoNoConsole.Exercicio_6.Implementacao;
using TrabalhandoNoConsole.Exercicio_6.Interface;
using TrabalhandoNoConsole.Exercicio_7.Implementacao;
using TrabalhandoNoConsole.Exercicio_7.Interface;
using TrabalhandoNoConsole.Exercicio_8.Implementacao;
using TrabalhandoNoConsole.Exercicio_8.Interface;
using TrabalhandoNoConsole.Exercicio_9.Implementacao;
using TrabalhandoNoConsole.Exercicio_9.Interface;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MenuPrincipal();
            }
        }

        private static bool MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("*** Bem-Vindo ao Mestre dos Códigos da DB1 Group - Nível Escudeiro ***\n\n");
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Trabalhando no console");
            Console.WriteLine("2) Utilizando POO");
            Console.WriteLine("3) Trabalhando com testes");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    bool ShowMenuConsole = true;
                    while (ShowMenuConsole)
                    {
                        ShowMenuConsole = MenuConsole();
                    }
                    return true;
                case "2":
                    bool ShowMenuPOO = true;
                    while (ShowMenuPOO)
                    {
                        ShowMenuPOO = MenuPOO();
                    }
                    return true;
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private static bool MenuConsole()
        {
            double valorA = 0, valorB = 0;
            bool ShowMenu = true;
            List<int> inteiros;
            List<decimal> decimais;
            ServiceProvider container = RegistrarServices();
            var _menuConsole = container.GetRequiredService<MenusConsole>();

            Console.Clear();
            Console.WriteLine("*** Mestre dos Códigos da DB1 Group - Trabalhando no Console ***\n");
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("5) Exercício 5");
            Console.WriteLine("6) Exercício 6");
            Console.WriteLine("7) Exercício 7");
            Console.WriteLine("8) Exercício 8");
            Console.WriteLine("9) Exercício 9");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CapturarInputAB(out valorA, out valorB);
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio1Console(valorA, valorB);
                    }
                    return true;
                case "2":
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio2Console();
                    }
                    return true;
                case "3":
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio3Console();
                    }
                    return true;
                case "4":
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio4Console();
                    }
                    return true;
                case "5":
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio5Console();
                    }
                    return true;
                case "6":
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio6Console();
                    }
                    return true;
                case "7":
                    inteiros = new List<int>();
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio7Console(inteiros);
                    }
                    return true;
                case "8":
                    decimais = new List<decimal>();
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio8Console(decimais);
                    }
                    return true;
                case "9":
                    inteiros = new List<int>();
                    while (ShowMenu)
                    {
                        ShowMenu = _menuConsole.MenuExercicio9Console(inteiros);
                    }
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private static bool MenuPOO()
        {
            bool ShowMenu = true;
            ServiceProvider container = RegistrarServices();
            var _menuPOO = container.GetRequiredService<MenusPOO>();

            Console.Clear();
            Console.WriteLine("*** Mestre dos Códigos da DB1 Group - Utilizando POO ***\n");
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    _menuPOO.MenuExercicio1POO();
                    return true;
                case "2":
                //while (ShowMenu)
                //{
                //    ShowMenu = _menuPOO.MenuExercicio2Console();
                //}
                //return true;
                case "3":
                    return true;
                case "4":
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private static void CapturarInputAB(out double valorA, out double valorB)
        {
            Console.Clear();
            Console.Write("Informe o valor de a: ");
            Double.TryParse(Console.ReadLine(), out valorA);
            Console.Write("Informe o valor de b: ");
            Double.TryParse(Console.ReadLine(), out valorB);
        }

        private static ServiceProvider RegistrarServices()
        {
            #region Trabalhando no Console
            var services = new ServiceCollection();
            services.AddSingleton<ICalculo, Calculo>();
            services.AddSingleton<IExercicio1, Exercicio1>();
            services.AddSingleton<IEmpresa, Empresa>();
            services.AddSingleton<IMultiplos, Multiplos>();
            services.AddSingleton<INotas, Notas>();
            services.AddSingleton<IFormula, Formula>();
            services.AddSingleton<IParametros, Parametros>();
            services.AddSingleton<ISomaPar, SomaPar>();
            services.AddSingleton<IOrdenacao, Ordencao>();
            services.AddSingleton<ILinq, Linq>();
            services.AddTransient<MenusConsole>();
            services.AddTransient<MenusPOO>();

            #endregion

            return services.BuildServiceProvider();
        }
    }
}



