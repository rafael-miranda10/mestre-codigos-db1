namespace UtilizandoPOO.Exercicio_4
{
    public interface ITelespectador
    {
        void LigarTelevisao(int canal, int volume);
        void AumentarVolume();
        void DiminuirVolume();
        void ProximoCanal();
        void CanalAnterior();
        void IrParaCanal(int valor);
        void OQuesEstouAssistindo();
    }
}
