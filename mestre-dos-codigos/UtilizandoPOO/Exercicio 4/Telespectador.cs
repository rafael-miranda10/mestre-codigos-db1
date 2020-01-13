using System;

namespace UtilizandoPOO.Exercicio_4
{
    public class Telespectador : ITelespectador
    {
        private ControleRemoto _controle;

        public void AumentarVolume()
        {
            if (_controle.AumentarVolume())
                Console.Write("Volume incrementado em uma unidade!");
            else
                Console.WriteLine("O som da televisão está no máximo!");
        }

        public void CanalAnterior()
        {
            _controle.CanalAnterior();
            Console.Write("Você está assistindo ao canal anterior!");
        }

        public void DiminuirVolume()
        {
            _controle.DiminuirVolume();
            Console.Write("Volume decrementado em uma unidade!");
        }

        public void IrParaCanal(int valor)
        {
            _controle.IrParaCanal(valor);
            Console.Write($"Você mudou para o canal: {valor}");
        }

        public void LigarTelevisao(int canal, int volume)
        {
            _controle = new ControleRemoto(volume, canal);
            Console.Write($"A TV está ligad!");
        }

        public void OQuesEstouAssistindo()
        {
            _controle.OQuesEstouAssistindo();
        }

        public void ProximoCanal()
        {
            _controle.ProximoCanal();
            Console.Write("Você está assistindo ao próximo canal!");
        }
    }
}
