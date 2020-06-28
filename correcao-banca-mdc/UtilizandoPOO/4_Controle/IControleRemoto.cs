namespace UtilizandoPOO._4_Controle
{
    public interface IControleRemoto
    {
        void AumentarVolumeDoControlavel();
        void DiminuirVolumeDoControlavel();
        void TrocarParaProximoCanal();
        void TrocarParaCanalAnterior();
        void TrocarParaCanalEspecifico();
        void ExibirEstadoDoControlavel();
        void LigarControlavel();

    }
}
