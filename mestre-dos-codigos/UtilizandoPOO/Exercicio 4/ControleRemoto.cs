using System;

namespace UtilizandoPOO.Exercicio_4
{
    public class ControleRemoto : Televisao
    {
        public ControleRemoto(int volume, int canal) : base(volume, canal)
        {

        }
        public override void AumentarVolume()
        {
            if (Volume < LimiteVolume)
            {
                Volume++;
                Console.Write("Volume incrementado em uma unidade!");
            }
            else
            {
                Console.WriteLine("O som da televisão está no máximo!");
            }
        }

        public override void CanalAnterior()
        {
            if (Canal > 0)
            {
                Canal--;
                Console.Write("Você está assistindo ao canal anterior!");
            }
            else
            {
                Console.WriteLine("A televisão está no primeiro canal!");
            }
        }

        public override void DiminuirVolume()
        {
            if (Volume > 0)
            {
                Volume--;
                Console.Write("Volume decrementado em uma unidade!");
            }
            else
            {
                Console.WriteLine("O som da televisão está no mudo!");
            }
        }

        public override void IrParaCanal(int valor)
        {
            if (valor > 0 && valor < LimiteCanal)
            {
                Canal = valor;
                Console.Write($"Você mudou para o canal: {Canal}");
            }
            else
            {
                Console.WriteLine("O canal informado está fora do limite de canais!");
            }
        }

        public override void OQuesEstouAssistindo()
        {
            Console.WriteLine($"Você está assistindo o canal {Canal} com o volume de som de {Volume}");
        }

        public override void ProximoCanal()
        {
            if (Canal < LimiteCanal)
            {
                Canal++;
                Console.Write("Você está assistindo ao próximo canal!");
            }
            else
            {
                Console.WriteLine("A televisão está no último canal disponível!");
            }
        }

        public int RetornaCanal() => Canal;

        public int RetornaVolume() => Volume;
        
    }
}
