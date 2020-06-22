using System;
using TrabalhandoNoConsole._4_Escola;

namespace Principal.MenusConsole
{
    public class ItemDeMenuEscola
    {
        private Escola _escola;
        private string _nome;
        private double _nota1;
        private double _nota2;
        public ItemDeMenuEscola(Escola escola)
        {
            _escola = escola;
        }

        public void ExibirItemDeMenuEscola()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesItemDeMenuEscola();
                cki = Console.ReadKey(false);
                Console.Clear();
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        CapturarDadosDoAluno();
                        _escola.AdicionarAluno(_nome, _nota1, _nota2);
                        Console.ReadKey();
                        break;
                    case "2":
                        _escola.ExibirAlunosAprovados();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        private void OpcoesItemDeMenuEscola()
        {
            Console.Clear();
            Console.WriteLine("*** Menu ***\n");
            Console.WriteLine("1) Adicionar Aluno");
            Console.WriteLine("2) Exibir Alunos Com Média Superior a 7");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
        private void CapturarDadosDoAluno()
        {
            Console.Clear();
            _nome = CapturaDeDados.CapturarTextoDigitado("Informe o nome do aluno: ");
            _nota1 = CapturaDeDados.CapturarNumeroDouble($"Informe o nota 1 do {_nome}: ");
            _nota2 = CapturaDeDados.CapturarNumeroDouble($"Informe o nota 2 do {_nome}: ");
        }
    }
}
