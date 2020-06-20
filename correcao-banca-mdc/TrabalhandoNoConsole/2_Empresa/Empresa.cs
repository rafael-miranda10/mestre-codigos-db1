using System;
using System.Collections.Generic;
using System.Globalization;
using TrabalhandoNoConsole.RecursosDeConsole;

namespace TrabalhandoNoConsole._2_Empresa
{
    public class Empresa 
    {
        private int _indexMenor;
        private int _indexMaior;
        private int _tamanho;
        private double _menor;
        private double _maior;

        public Empresa()
        {
            Funcionarios = new List<Funcionario>();
        }

        public List<Funcionario> Funcionarios { get; private set; }
        public int PosMenor { get; private set; }
        public int PosMaior { get; private set; }

        public void AdicionarFuncionario(string nome, double salario)
        {
            var funcionario = new Funcionario(nome, salario);

            if (funcionario.Notifications.Count > 0)
            {
                foreach (var item in funcionario.Notifications)
                    Console.WriteLine(Constantes.MsgErroValidacaoFuncionario, item.Message);
            }

            if (funcionario.Valid)
                Funcionarios.Add(funcionario);
        }

        private void Inicializar()
        {
            _indexMaior = 0;
            _indexMenor = 0;
            _maior = 0;
            _menor = 99999999;
            _tamanho = Funcionarios.Count;
        }

        public void ExibirMaiorMenorComFor()
        {
            Inicializar();

            if (_tamanho <= 0)
                Console.WriteLine(Constantes.MsgListaFuncionariosVazia);

            if (_tamanho > 0)
            {
                for (int i = 0; i < _tamanho; i++)
                {
                    if (Funcionarios[i].Salario < _menor)
                    {
                        _indexMenor = i;
                        _menor = Funcionarios[i].Salario;
                    }
                    if (Funcionarios[i].Salario > _maior)
                    {
                        _indexMaior = i;
                        _maior = Funcionarios[i].Salario;
                    }
                }
                Console.WriteLine(Constantes.MsgFuncionarioMenorSalario, Funcionarios[_indexMenor].Nome, 
                                  FormatarStringSalario(Funcionarios[_indexMenor].Salario));
                Console.WriteLine(Constantes.MsgFuncionarioMaiorSalario, Funcionarios[_indexMaior].Nome, 
                                  FormatarStringSalario(Funcionarios[_indexMaior].Salario));
            }
            PosMaior = _indexMaior;
            PosMenor = _indexMenor;
        }

        public void ExibirMaiorMenorComOrdencaoBolha()
        {
            Inicializar();

            if (_tamanho <= 0)
                Console.WriteLine(Constantes.MsgListaFuncionariosVazia);

            if (_tamanho > 0)
            {
                for (int i = 1; i < _tamanho; i++)
                {
                    for (int j = 0; j < (_tamanho - i); j++)
                    {
                        if (Funcionarios[j].Salario > Funcionarios[j + 1].Salario)
                        {
                            Funcionario temp = Funcionarios[j];
                            Funcionarios[j] = Funcionarios[j + 1];
                            Funcionarios[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine(Constantes.MsgFuncionarioMenorSalario, Funcionarios[0].Nome,
                                  FormatarStringSalario(Funcionarios[0].Salario));
                Console.WriteLine(Constantes.MsgFuncionarioMaiorSalario, Funcionarios[_tamanho - 1].Nome,
                                  FormatarStringSalario(Funcionarios[_tamanho - 1].Salario));
            }
            PosMaior = _tamanho - 1;
            PosMenor = 0;
        }

        public void ExibirMaiorMenorComWhile()
        {
            Inicializar();
            int i = 0;

            if (_tamanho <= 0)
                Console.WriteLine(Constantes.MsgListaFuncionariosVazia);

            if (_tamanho > 0)
            {
                while (i < _tamanho)
                {
                    if (Funcionarios[i].Salario < _menor)
                    {
                        _indexMenor = i;
                        _menor = Funcionarios[i].Salario;
                    }
                    if (Funcionarios[i].Salario > _maior)
                    {
                        _indexMaior = i;
                        _maior = Funcionarios[i].Salario;
                    }
                    i++;
                }
                Console.WriteLine(Constantes.MsgFuncionarioMenorSalario, Funcionarios[_indexMenor].Nome,
                                  FormatarStringSalario(Funcionarios[_indexMenor].Salario));
                Console.WriteLine(Constantes.MsgFuncionarioMaiorSalario, Funcionarios[_indexMaior].Nome, 
                                  FormatarStringSalario(Funcionarios[_indexMaior].Salario));
            }
            PosMaior = _indexMaior;
            PosMenor = _indexMenor;
        }

        private string FormatarStringSalario(double Salario)
        {
            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Salario);
        }
    }
}
