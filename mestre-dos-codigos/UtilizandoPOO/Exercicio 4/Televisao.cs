namespace UtilizandoPOO.Exercicio_4
{
    public abstract class Televisao
    {
        protected int Volume { get; set; }
        protected int Canal { get; set; }

        public const int LimiteVolume = 100;
        public const int LimiteCanal = 30;

        public Televisao(int volume, int canal)
        {
            Volume = volume;
            Canal = canal;
        }

        public abstract bool AumentarVolume();
        public abstract void DiminuirVolume();
        public abstract void ProximoCanal();
        public abstract void CanalAnterior();
        public abstract void IrParaCanal(int valor);
        public abstract void OQuesEstouAssistindo();
    }
}
