using RecursosCompartilhados;
using System;
using UtilizandoPOO._2_RepresentarPessoa;

namespace Principal.MenusPOO
{
    public class ItemDeMenuRepresentarPessoa
    {
        private string _nome;
        private double _altura;
        private DateTime _dataNascimento;
        private IIndividuo _individuo;
        public ItemDeMenuRepresentarPessoa(IIndividuo individuo)
        {
            _individuo = individuo;
        }

        public void ExibirItemDeMenuRepresentarPessoa()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuRepresentarPessoa();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _nome = CapturaDeDados.CapturarTextoDigitado("Informe o nome da pessoa: ");
                        _altura = CapturaDeDados.CapturarNumeroDouble("Informe a altura da pessoa (em metros. ex: 1,80): ");
                        _dataNascimento = CapturaDeDados.CapturarData("Informe a data de nascimento (ex: 03/05/1985): ");
                        _individuo.CriarPessoa(_nome, _altura, _dataNascimento);
                        Console.ReadKey();
                        break;
                    case "2":
                        _individuo.ExibirInformacoesDoIndividuo();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuRepresentarPessoa()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Informar os dados da pessoa.");
            Console.WriteLine("2) Exibir os dados");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
