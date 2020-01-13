using System;

namespace UtilizandoPOO.Exercicio_4
{
    public class ControleRemoto : Televisao
    {
        public ControleRemoto(int volume, int canal) : base(volume, canal)
        {

        }
        public override bool AumentarVolume()
        {
            if (Volume < LimiteVolume)
            {
                Volume++;
                return true;
            }
            return false;
        }

        public override void CanalAnterior()
        {
            if (Canal > 0)
                Canal--;
            else
                Console.WriteLine("A televisão está no primeiro canal!");
        }

        public override void DiminuirVolume()
        {
            if (Volume > 0)
                Volume--;
            else
                Console.WriteLine("O som da televisão está no mudo!");
        }

        public override void IrParaCanal(int valor)
        {
            if (valor > 0 && valor < LimiteCanal)
                Canal = valor;
            else
                Console.WriteLine("O canal informado está fora do limite de canais!");
        }

        public override void OQuesEstouAssistindo()
        {
            Console.WriteLine($"Você está assistindo o canal {Canal} com o volume de som de {Volume}");
        }

        public override void ProximoCanal()
        {
            if (Canal < LimiteCanal)
                Canal++;
            else
                Console.WriteLine("A televisão está no último canal disponível!");
        }
    }
}
