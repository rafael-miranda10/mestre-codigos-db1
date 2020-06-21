using System;
using TrabalhandoNoConsole._1_Calculadora;
using TrabalhandoNoConsole._2_Empresa;
using TrabalhandoNoConsole._3__NumeroMultiplo;
using TrabalhandoNoConsole._4_Escola;
using TrabalhandoNoConsole._5_Bhaskara;
using TrabalhandoNoConsole._6_ModificadorParametro;
using TrabalhandoNoConsole._7_SomaNumerosPares;
using TrabalhandoNoConsole._8_OrdenacaoDeNumeros;
using TrabalhandoNoConsole._9_BibliotecaLinq;

namespace Principal.MenusConsole
{
    public class MenuConsole
    {
        private MenuCalculadora _menuCalculadora;
        private Calculadora _calculadora;
        private MenuEmpresa _menuEmpresa;
        private MenuNumeroMultiplo _menuNumeroMultiplo;
        private MenuEscola _menuEscola;
        private MenuEquacao _menuEquacao;
        private MenuModificadorParametro _menuModificador;
        private MenuSomaNumerosPares _menuSomaNumerosPares;
        private MenuOrdenacaoNumeros _menuOrdenacaoNumeros;
        private MenuBibliotecaLinq _menuBibliotecaLinq;
        public MenuConsole()
        {
            _calculadora = new Calculadora(new Calculo());
            _menuCalculadora = new MenuCalculadora(_calculadora);
            _menuEmpresa = new MenuEmpresa(new Empresa());
            _menuNumeroMultiplo = new MenuNumeroMultiplo(new NumeroMultiplo());
            _menuEscola = new MenuEscola(new Escola());
            _menuEquacao = new MenuEquacao(new Equacao());
            _menuModificador = new MenuModificadorParametro(new ModificadorParametro());
            _menuSomaNumerosPares = new MenuSomaNumerosPares(new SomaNumeroPar());
            _menuOrdenacaoNumeros = new MenuOrdenacaoNumeros(new OrdenacaoDeNumeros());
            _menuBibliotecaLinq = new MenuBibliotecaLinq(new BibliotecaLinq());
        }

        public void ExibirMenuConsole()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuConsole();
                cki = Console.ReadKey(false); 
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _menuCalculadora.ExibirMenuCalculadora();
                        break;
                    case "2":
                        _menuEmpresa.ExibirMenuEmpresa();
                        break;
                    case "3":
                        _menuNumeroMultiplo.ExibirMenuNumeroMultiplo();
                        break;
                    case "4":
                        _menuEscola.ExibirMenuEscola();
                        break;
                    case "5":
                        _menuEquacao.ExibirMenuCalculadora();
                        break;
                    case "6":
                        _menuModificador.ExibirMenuModificadorParametro();
                        break;
                    case "7":
                        _menuSomaNumerosPares.ExibirMenuSomaNumerosPares();
                        break;
                    case "8":
                        _menuOrdenacaoNumeros.ExibirMenuOrdenacaoDeNumeros();
                        break;
                    case "9":
                        _menuBibliotecaLinq.ExibirMenubibliotecaLinq();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        public void OpcoesMenuConsole()
        {
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
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\n Escolha uma opção: ");
        }
    }
}
