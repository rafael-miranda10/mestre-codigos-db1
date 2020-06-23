namespace UtilizandoPOO._4_Controle
{
    public class Televisao : IControlavel
    {
        private const int _limiteVolume = 100;
        private const int _limteCanal = 30;

        public Televisao()
        {
        }

        public int Volume { get; private set; }
        public int Canal { get; private set; }

        public void AumentarVolume()
        {
            Volume++;
        }
        public void DiminuirVolume()
        {
            Volume--;
        }
        public void MudarParaProximoCanal()
        {
            Canal++;
        }
        public void MudarParaCanalAnterior()
        {
            Canal--;
        }
        public void IrParaCanalEspecifico(int canalEspecifico)
        {
            Canal = canalEspecifico;
        }

        public int RetornarlimiteDeCanais()
        {
            return _limteCanal;
        }
        public int RetornarLimiteVolume()
        {
            return _limiteVolume;
        }

        public int RetornarVolume()
        {
            return Volume;
        }
        public int RetornarCanal()
        {
            return Canal;
        }
        public void LigarControlavel(int volume, int canal)
        {
            Volume = volume;
            Canal = canal;
        }
    }
}
