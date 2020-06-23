namespace UtilizandoPOO._4_Controle
{
    public interface IControlavel
    {
        void AumentarVolume();
        void DiminuirVolume();
        void MudarParaProximoCanal();
        void MudarParaCanalAnterior();
        void IrParaCanalEspecifico(int canalEspecifico);
        int RetornarlimiteDeCanais();
        int RetornarVolume();
        int RetornarCanal();
        int RetornarLimiteVolume();
        void LigarControlavel(int volume, int canal);
    }
}
