using System;
using System.Collections.Generic;
using TrabalhandoNoConsole.Exercicio_2.Interface;

namespace TrabalhandoNoConsole.Exercicio_2.Implementacao
{
    public class Empresa : IEmpresa
    {
        public Empresa()
        {
            funcionarios = new List<Funcionarios>();
        }

        public List<Funcionarios> funcionarios { get; private set; }

        public void AdicionarFuncionario(string Nome, double Salario)
        {
            var funcionario = new Funcionarios(Nome, Salario);

            if (funcionario.Notifications.Count > 0)
            {
                foreach (var item in funcionario.Notifications)
                    Console.WriteLine($"Não é possível adicionar o funcionário! Motivo: {item.Message}");

                Console.ReadKey();
            }

            if (funcionario.Valid)
                funcionarios.Add(funcionario);
        }

        public void MaiorMenorBubbleSort()
        {
            int tamanho = funcionarios.Count;

            if (tamanho <= 0)
                Console.WriteLine($"A lista de funcionários está vazia!");

            if (tamanho > 0)
            {
                for (int i = 1; i < tamanho; i++)
                {
                    for (int j = 0; j < (tamanho - i); j++)
                    {
                        if (funcionarios[j].Salario > funcionarios[j + 1].Salario)
                        {
                            Funcionarios temp = funcionarios[j];
                            funcionarios[j] = funcionarios[j + 1];
                            funcionarios[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine($"O funcionário: {funcionarios[0].Nome} tem o menor salário: {funcionarios[0].Salario}");
                Console.WriteLine($"O funcionário: {funcionarios[tamanho-1].Nome} tem o maior salário: {funcionarios[tamanho-1].Salario}");
            }
        }

        public void MaiorMenorFor()
        {
            int indexMenor = 0, indexMaior = 0;
            int tamanho = funcionarios.Count;
            double menor = 99999999, maior = 0;

            if (tamanho <= 0)
                Console.WriteLine($"A lista de funcionários está vazia!");

            if (tamanho > 0)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    if (funcionarios[i].Salario < menor)
                    {
                        indexMenor = i;
                        menor = funcionarios[i].Salario;
                    }
                    if (funcionarios[i].Salario > maior)
                    {
                        indexMaior = i;
                        maior = funcionarios[i].Salario;
                    }
                }
                Console.WriteLine($"O funcionário: {funcionarios[indexMenor].Nome} tem o menor salário: {funcionarios[indexMenor].Salario}");
                Console.WriteLine($"O funcionário: {funcionarios[indexMaior].Nome} tem o maior salário: {funcionarios[indexMaior].Salario}");
            }

        }

        public void MaiorMenorWhile()
        {
            int indexMenor = 0, indexMaior = 0, i = 0;
            int tamanho = funcionarios.Count;
            double menor = 99999999, maior = 0;

            if (tamanho <= 0)
                Console.WriteLine($"A lista de funcionários está vazia!");

            if (tamanho > 0)
            {
                while (i < tamanho)
                {
                    if (funcionarios[i].Salario < menor)
                    {
                        indexMenor = i;
                        menor = funcionarios[i].Salario;
                    }
                    if (funcionarios[i].Salario > maior)
                    {
                        indexMaior = i;
                        maior = funcionarios[i].Salario;
                    }
                    i++;
                }
                Console.WriteLine($"O funcionário: {funcionarios[indexMenor].Nome} tem o menor salário: {funcionarios[indexMenor].Salario}");
                Console.WriteLine($"O funcionário: {funcionarios[indexMaior].Nome} tem o maior salário: {funcionarios[indexMaior].Salario}");
            }

        }
    }
}
