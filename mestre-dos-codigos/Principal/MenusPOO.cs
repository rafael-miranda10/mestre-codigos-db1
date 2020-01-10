﻿using System;
using System.Collections.Generic;
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
                    listaEmpregado.Add(new Empregado() { Nome = "Rafael", Salario=4.500});
                    listaEmpregado.Add(new Empregado() { Nome = "Djalma Jorge", Salario = 9.365 });
                    listaEmpregado.Add(new Empregado() { Nome = "Tiringa", Salario = 1.852 });
                    listaEmpregado.Add(new Empregado() { Nome = "Zobaido", Salario = 1.265 });
                    listaEmpregado.Add(new Empregado() { Nome = "Ana", Salario = 1.265 });

                    //Utilizando a interface Icomparable
                    listaEmpregado.Sort();

                    foreach (var empregado in listaEmpregado)
                    {
                        Console.Write(empregado+"\n");
                    }
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Clear();
                    Humano p1 = new Humano("Rafael", "(18) 99654-8521", 29);
                    Humano p2 = (Humano)p1.Clone();
                    p2.Nome = "Djalma Jorge";
                    Console.Write(p1+"\n");
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
                    foreach(Cachorro c in canilList)
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
