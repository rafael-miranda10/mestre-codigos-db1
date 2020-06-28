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
        private ItemDeMenuCalculadora _itemDeMenuCalculadora;
        private Calculadora _calculadora;
        private ItemDeMenuEmpresa _itemDeMenuEmpresa;
        private ItemDeMenuNumeroMultiplo _menuNumeroMultiplo;
        private ItemDeMenuEscola _itemDeMenuEscola;
        private ItemDeMenuEquacao _itemDeMenuEquacao;
        private ItemDeMenuModificadorParametro _itemDeMenuModificador;
        private ItemDeMenuSomaNumerosPares _itemDeMenuSomaNumerosPares;
        private ItemDeMenuOrdenacaoNumeros _itemDeMenuOrdenacaoNumeros;
        private ItemDeMenuConsultaIntegrada _itemDeMenuConsultaIntegrada;
        public MenuConsole()
        {
            _calculadora = new Calculadora(new Calculo());
            _itemDeMenuCalculadora = new ItemDeMenuCalculadora(_calculadora);
            _itemDeMenuEmpresa = new ItemDeMenuEmpresa(new Empresa());
            _menuNumeroMultiplo = new ItemDeMenuNumeroMultiplo(new NumeroMultiplo());
            _itemDeMenuEscola = new ItemDeMenuEscola(new Escola());
            _itemDeMenuEquacao = new ItemDeMenuEquacao(new Equacao());
            _itemDeMenuModificador = new ItemDeMenuModificadorParametro(new ModificadorParametro());
            _itemDeMenuSomaNumerosPares = new ItemDeMenuSomaNumerosPares(new SomaNumeroPar());
            _itemDeMenuOrdenacaoNumeros = new ItemDeMenuOrdenacaoNumeros(new OrdenacaoDeNumeros());
            _itemDeMenuConsultaIntegrada = new ItemDeMenuConsultaIntegrada(new ConsultaIntegrada());
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
                        _itemDeMenuCalculadora.ExibirItemDeMenuCalculadora();
                        break;
                    case "2":
                        _itemDeMenuEmpresa.ExibirItemDeMenuEmpresa();
                        break;
                    case "3":
                        _menuNumeroMultiplo.ExibirItemDeMenuNumeroMultiplo();
                        break;
                    case "4":
                        _itemDeMenuEscola.ExibirItemDeMenuEscola();
                        break;
                    case "5":
                        _itemDeMenuEquacao.ExibirItemDeMenuCalculadora();
                        break;
                    case "6":
                        _itemDeMenuModificador.ExibirItemDeMenuModificadorParametro();
                        break;
                    case "7":
                        _itemDeMenuSomaNumerosPares.ExibirItemDeMenuSomaNumerosPares();
                        break;
                    case "8":
                        _itemDeMenuOrdenacaoNumeros.ExibirItemDeMenuOrdenacaoDeNumeros();
                        break;
                    case "9":
                        _itemDeMenuConsultaIntegrada.ExibirItemDeMenuConsultaIntegrada();
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
