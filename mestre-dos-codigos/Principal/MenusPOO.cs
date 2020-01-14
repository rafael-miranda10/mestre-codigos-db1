﻿using System;
using System.Collections.Generic;
using UtilizandoPOO.Exercicio_1;
using UtilizandoPOO.Exercicio_2;
using UtilizandoPOO.Exercicio_3;
using UtilizandoPOO.Exercicio_4;

namespace Principal
{
    public class MenusPOO
    {
        private readonly IBanco _banco;
        private readonly ITelespectador _telespectador;
        private readonly IIndividuo _individuo;

        public MenusPOO(IBanco banco, ITelespectador telespectador, IIndividuo individuo)
        {
            _banco = banco;
            _telespectador = telespectador;
            _individuo = individuo;
        }
        public bool MenuExercicio1POO()
        {
            bool ShowMenu = true;
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Abstração/Polimorfismo/Encapsulamento");
            Console.WriteLine("2) IDisposeble");
            Console.WriteLine("3) IComparable");
            Console.WriteLine("4) ICloneable");
            Console.WriteLine("5) INumerable");
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
                    ClasseBaseDispose obj = new ClasseBaseDispose();
                    obj.ExecutarAlgo();
                    obj.Dispose();
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    List<Empregado> listaEmpregado = new List<Empregado>();
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
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    Humano p1 = new Humano("Rafael", "(18) 99654-8521", 29);
                    Humano p2 = (Humano)p1.Clone();
                    p2.Nome = "Djalma Jorge";
                    Console.Write(p1 + "\n");
                    Console.Write(p2);
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.Clear();
                    Cachorro[] dogArray = new Cachorro[3];
                    dogArray[0] = new Cachorro("Greg", "Shitzu");
                    dogArray[1] = new Cachorro("Budy", "Golden");
                    dogArray[2] = new Cachorro("Thor", "PitBull");
                    Canil canilList = new Canil(dogArray);
                    foreach (Cachorro c in canilList)
                        Console.Write($"Nome do cachorro: {c.Nome}, raça do cachorro: {c.Raca} \n");
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

        public bool MenuExercicio2POO()
        {
            string Nome;
            DateTime Datanasc;
            double Altura;
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Informar os dados da pessoa.");
            Console.WriteLine("2) Exibir os dados");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputPessoa(out Nome, out Altura, out Datanasc);
                    _individuo.CriarPessoa(Nome, Altura, Datanasc);
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    _individuo.ExibirInformacoes();
                    Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio3POO()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Informar os dados das contas bancarias");
            Console.WriteLine("2) Realizar Saque da conta");
            Console.WriteLine("3) Realizar Depósito na conta");
            Console.WriteLine("4) Exibir extrato");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    _banco.CapturarInputContaBancaria();
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    if (_banco.EfetuarSaque())
                        Console.Write("Operação realizada! Por favor consulte o extrato");
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    if (_banco.EfetuarDeposito())
                        Console.Write("Operação realizada! Por favor consulte o extrato");
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    _banco.ExibirContasBancarias();
                   Console.ReadKey();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        public bool MenuExercicio4POO()
        {
            int canal = 0, volume = 0;
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Ligar a Televisão");
            Console.WriteLine("2) Aumentar Volume");
            Console.WriteLine("3) Diminuir Volune");
            Console.WriteLine("4) Proximo Canal");
            Console.WriteLine("5) Canal Anterior");
            Console.WriteLine("6) Ir Para o Canal");
            Console.WriteLine("7) O Que Estou Assistindo?");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    CapturarInputTelevisao(out canal, out volume);
                    _telespectador.LigarTelevisao( canal, volume);
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.Clear();
                    _telespectador.AumentarVolume();
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Clear();
                    _telespectador.DiminuirVolume();
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    _telespectador.ProximoCanal();
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.Clear();
                    _telespectador.CanalAnterior();
                    Console.ReadKey();
                    return true;
                case "6":
                    Console.Clear();
                    CapturarInputCanal(out canal);
                    _telespectador.IrParaCanal(canal);
                    Console.ReadKey();
                    return true;
                case "7":
                    Console.Clear();
                    _telespectador.OQuesEstouAssistindo();
                    Console.ReadKey();
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

        private void CapturarInputTelevisao(out int canal, out int volume)
        {
            Console.Write("A televisão possui 30 canais e o volume máximo de 100. \n");
            Console.Write("Para ligar a televisão informe o canal e o valume. \n");
            Console.Write("Informe o canal: ");
            int.TryParse(Console.ReadLine(), out canal);
            Console.Write("Informe o volume: ");
            int.TryParse(Console.ReadLine(), out volume);
        }

        private void CapturarInputCanal(out int canal)
        {
            Console.Write("Informe o canal: ");
            int.TryParse(Console.ReadLine(), out canal);
        }

        private void ExibirAreaForma(Forma forma, string escolha)
        {
            Console.Clear();
            Console.Write($"A área do {escolha} é: {forma.CalcularArea}");
            Console.ReadKey();
        }

        private void CapturarInputPessoa(out string Nome, out double Altura, out DateTime DataNasc)
        {
            Console.Clear();
            Console.Write("Informe o nome da pessoa: ");
            Nome = Console.ReadLine();
            Console.Write("Informe a altura da pessoa (em metros. ex: 1,80): ");
            Double.TryParse(Console.ReadLine(), out Altura);
            Console.Write("Informe a data de nascimento (ex: 03/05/1985): ");
            DateTime.TryParse(Console.ReadLine(), out DataNasc);
        }

    }
}
