using System;
using TrabalhandoNoConsole.RecursosDeConsole;

namespace TrabalhandoNoConsole._3__NumeroMultiplo
{
    public class NumeroMultiplo 
    {
        private int _index;
        private string _numerosMultiplosParaExibir;
        public NumeroMultiplo()
        {
        }
        public void ExibirNumerosMultiplosDeTresPorDivisao()
        {
            Console.WriteLine(Constantes.MsgNumerosMultiplosPorDivisao);

            _index = 1;
            _numerosMultiplosParaExibir = Constantes.MsgNumerosMultiplos;

            while (_index <= 100)
            {
                if (_index % 3 == 0)
                {
                    _numerosMultiplosParaExibir += $"{_index};";
                }
                _index++;
            }

            Console.WriteLine(_numerosMultiplosParaExibir);
        }

        public void ExibirNumerosMultiplosDeTresPorProgressao()
        {
            Console.WriteLine(Constantes.MsgNumerosMultiplosPorProgressao);
            _numerosMultiplosParaExibir = Constantes.MsgNumerosMultiplos;
            _index = 3;

            while (_index <= 100)
            {
                _numerosMultiplosParaExibir += $"{_index};";
                _index += 3;
            }

            Console.WriteLine(_numerosMultiplosParaExibir);
        }
    }
}
