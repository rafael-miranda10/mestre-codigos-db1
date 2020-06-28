using RecursosCompartilhados;
using System;

namespace UtilizandoPOO._4_Controle
{
    public class ControleRemoto : IControleRemoto
    {
        private IControlavel _controlavel;
        private int _canal;
        private int _volume;
        public ControleRemoto(IControlavel controlavel)
        {
            _controlavel = controlavel;
        }

        public void AumentarVolumeDoControlavel()
        {
            if (EhPermitidoAumentarVolume())
            {
                _controlavel.AumentarVolume();
                Console.WriteLine(ConstantesPoo.MsgVolumeAumentado);
            }
            else
            {
                Console.WriteLine(ConstantesPoo.MsgNaoEhPermitidoAumentarVolume);
            }
        }

        public void DiminuirVolumeDoControlavel()
        {
            if (EhPermitidoDiminuirVolume())
            {
                _controlavel.DiminuirVolume();
                Console.WriteLine(ConstantesPoo.MsgVolumeDiminuido);
            }
            else
            {
                Console.WriteLine(ConstantesPoo.MsgNaoEhPermitidoDiminuirVolume);
            }
        }

        public void TrocarParaProximoCanal()
        {
            if (EhPermitidoTrocarProximoCanal())
            {
                _controlavel.MudarParaProximoCanal();
                Console.WriteLine(ConstantesPoo.MsgProximoCanal);
            }
            else
            {
                Console.WriteLine(ConstantesPoo.MsgNaoEhPermitidoProximoCanal);
            }
        }

        public void TrocarParaCanalAnterior()
        {
            if (EhPermitidoTrocarCanalanterior())
            {
                _controlavel.MudarParaCanalAnterior();
                Console.WriteLine(ConstantesPoo.MsgCanalAnterior);
            }
            else
            {
                Console.WriteLine(ConstantesPoo.MsgNaoEhPermitidoCanalAnterior);
            }
        }
        public void TrocarParaCanalEspecifico()
        {
            if (!ValidarSeControlavelExiste())
            {
                Console.WriteLine(ConstantesPoo.MsgErroCanalEspecifico);
                return;
            }

            _canal = CapturaDeDados.CapturarNumeroInteiro(ConstantesPoo.MsgCanalEspecifico);
            if (ValidarCanal())
            {
                _controlavel.IrParaCanalEspecifico(_canal);
            }
            else
            {
                Console.WriteLine(ConstantesPoo.MsgErroCanalEspecifico);
            }
        }

        public void ExibirEstadoDoControlavel()
        {
            if (ValidarSeControlavelExiste())
                Console.WriteLine(ConstantesPoo.MsgEstadoControlavel, _controlavel.RetornarCanal(), _controlavel.RetornarVolume());
            else
                Console.WriteLine(ConstantesPoo.MsgControlavelDesligado);
        }

        public void LigarControlavel()
        {
            _canal = CapturaDeDados.CapturarNumeroInteiro(ConstantesPoo.MsgCanalEspecifico);
            _volume = CapturaDeDados.CapturarNumeroInteiro(ConstantesPoo.MsgVolumeEspecifico);
            _controlavel = FabricaTelevisao.Criar();

            if (ValidarCanal() && ValidarVolume())
            {
                _controlavel.LigarControlavel(_volume, _canal);
                Console.WriteLine(ConstantesPoo.MsgEstadoControlavel, _canal, _volume);
            }
            else
            {
                _controlavel = null;
                Console.WriteLine(ConstantesPoo.MsgNaoEhPossivelLigarControlavel);
            }
        }

        private bool EhPermitidoAumentarVolume()
        {
            if (!ValidarSeControlavelExiste())
                return false;

            if (_controlavel.RetornarVolume() < _controlavel.RetornarLimiteVolume())
                return true;
            return false;
        }
        private bool EhPermitidoDiminuirVolume()
        {
            if (!ValidarSeControlavelExiste())
                return false;

            if (_controlavel.RetornarVolume() > 0)
                return true;
            return false;
        }

        private bool EhPermitidoTrocarProximoCanal()
        {
            if (!ValidarSeControlavelExiste())
                return false;

            if (_controlavel.RetornarCanal() < _controlavel.RetornarlimiteDeCanais())
                return true;
            return false;
        }
        private bool EhPermitidoTrocarCanalanterior()
        {
            if (!ValidarSeControlavelExiste())
                return false;

            if (_controlavel.RetornarCanal() > 0)
                return true;
            return false;
        }
        private bool ValidarSeControlavelExiste()
        {
            if (_controlavel != null)
                return true;
            return false;
        }

        private bool ValidarCanal()
        {
            if (_canal > 0 && _canal <= _controlavel.RetornarlimiteDeCanais())
                return true;
            return false;
        }

        private bool ValidarVolume()
        {
            if (_volume > 0 && _volume <= _controlavel.RetornarLimiteVolume())
                return true;
            return false;
        }
    }
}
