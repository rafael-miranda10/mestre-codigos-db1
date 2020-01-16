using System;

namespace UtilizandoPOO.Exercicio_4
{
    public class Telespectador : ITelespectador
    {
        private ControleRemoto _controle;

        public void AumentarVolume()
        {
            if (ExisteTV())
                _controle.AumentarVolume();
            else
                Console.Write("A TV não está conectada na tomada!");

        }

        public void CanalAnterior()
        {
            if (ExisteTV())
                _controle.CanalAnterior();
            else
                Console.Write("A TV não está conectada na tomada!");
        }

        public void DiminuirVolume()
        {
            if (ExisteTV())
                _controle.DiminuirVolume();
            else
                Console.Write("A TV não está conectada na tomada!");
        }

        public void IrParaCanal(int valor)
        {
            if (ExisteTV())
                _controle.IrParaCanal(valor);
            else
                Console.Write("A TV não está conectada na tomada!");
        }

        public void LigarTelevisao(int canal, int volume)
        {
            if (ValidarTV(canal, volume))
            {
                _controle = new ControleRemoto(volume, canal);
                Console.Write($"A TV está ligada!");
            }
            else
            {
                Console.Write($"Não foi possivel ligar a TV, verifique as informações!");
            }
        }

        private bool ValidarTV(int canal, int volume)
        {
            if (canal > 0 && canal <= 30)
                if (volume >= 0 && volume <= 100)
                    return true;
            return false;
        }
        private bool ExisteTV()
        {
            if (_controle != null)
                return true;
            return false;
        }

        public void OQuesEstouAssistindo()
        {
            if (ExisteTV())
                _controle.OQuesEstouAssistindo();
            else
                Console.Write("A TV não está conectada na tomada!");
        }

        public void ProximoCanal()
        {
            if (ExisteTV())
                _controle.ProximoCanal();
            else
                Console.Write("A TV não está conectada na tomada!");
        }
        public int RetornaCanal() => _controle.RetornaCanal();

        public int RetornaVolume() => _controle.RetornaVolume();

    }
}
