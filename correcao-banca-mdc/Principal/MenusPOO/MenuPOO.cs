using System;
using UtilizandoPOO._1_POO;
using UtilizandoPOO._2_RepresentarPessoa;

namespace Principal.MenusPOO
{
    public class MenuPOO
    {
        private ItemDeMenuProgramacaoOrientadaobjeto _itemDeMenuProgramacaoOrientadaObjeto;
        private ProgramacaoOrientadaObjeto _programacaoOrientadaObjeto;
        private ItemDeMenuRepresentarPessoa _itemDeMenuRepresentarPessoa;
        private Individuo _individuo;

        public MenuPOO()
        {
            _programacaoOrientadaObjeto = new ProgramacaoOrientadaObjeto();
            _itemDeMenuProgramacaoOrientadaObjeto = new ItemDeMenuProgramacaoOrientadaobjeto(_programacaoOrientadaObjeto);
            _individuo = new Individuo();
            _itemDeMenuRepresentarPessoa = new ItemDeMenuRepresentarPessoa(_individuo);
        }

        public void ExibirMenuPOO()
        {
            ConsoleKeyInfo cki;
            do
            {
                OpcoesMenuPOO();
                cki = Console.ReadKey(false);
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        _itemDeMenuProgramacaoOrientadaObjeto.ExibirItemDeMenuProgramacaoOrientadaObjeto();
                        break;
                    case "2":
                        _itemDeMenuRepresentarPessoa.ExibirItemDeMenuRepresentarPessoa();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        public void OpcoesMenuPOO()
        {
            Console.Clear();
            Console.WriteLine("*** Mestre dos Códigos da DB1 Group - Utilizando POO ***\n");
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("Esc) Sair");
            Console.Write("\r\nEscolha uma opção: ");
        }
    }
}
