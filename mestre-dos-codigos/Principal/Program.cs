using Microsoft.Extensions.DependencyInjection;
using System;
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
                    // RemoveWhitespace();
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
            Console.Clear();
            Console.WriteLine("*** Mestre dos Códigos da DB1 Group - Trabalhando no Console ***\n");
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("5) Exercício 5");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CapturarInputAB(out valorA, out valorB);
                    using (ServiceProvider container = RegistrarServices())
                    {
                        bool ShowMenuConsoleEx1 = true;
                        var _menuEx1Console = container.GetRequiredService<MenusConsole>();
                        while (ShowMenuConsoleEx1)
                        {
                            ShowMenuConsoleEx1 = _menuEx1Console.MenuExercicio1Console(valorA, valorB);
                        }
                    }
                    return true;
                case "2":
                    using (ServiceProvider container = RegistrarServices())
                    {
                        bool ShowMenuConsoleEx2 = true;
                        var _menuEx1Console = container.GetRequiredService<MenusConsole>();
                        while (ShowMenuConsoleEx2)
                        {
                            ShowMenuConsoleEx2 = _menuEx1Console.MenuExercicio2Console();
                        }
                    }
                    return true;
                case "3":
                    using (ServiceProvider container = RegistrarServices())
                    {
                        bool ShowMenuConsoleEx3 = true;
                        var _menuEx1Console = container.GetRequiredService<MenusConsole>();
                        while (ShowMenuConsoleEx3)
                        {
                            ShowMenuConsoleEx3 = _menuEx1Console.MenuExercicio3Console();
                        }
                    }
                    return true;
                case "4":
                    using (ServiceProvider container = RegistrarServices())
                    {
                        bool ShowMenuConsoleEx4 = true;
                        var _menuEx1Console = container.GetRequiredService<MenusConsole>();
                        while (ShowMenuConsoleEx4)
                        {
                            ShowMenuConsoleEx4 = _menuEx1Console.MenuExercicio4Console();
                        }
                    }
                    return true;
                case "5":
                    using (ServiceProvider container = RegistrarServices())
                    {
                        bool ShowMenuConsoleEx5 = true;
                        var _menuEx1Console = container.GetRequiredService<MenusConsole>();
                        while (ShowMenuConsoleEx5)
                        {
                            ShowMenuConsoleEx5 = _menuEx1Console.MenuExercicio5Console();
                        }
                    }
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
            valorA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor de b: ");
            valorB = Convert.ToDouble(Console.ReadLine());
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
            services.AddTransient<MenusConsole>();

            #endregion

            return services.BuildServiceProvider();
        }
    }
}



