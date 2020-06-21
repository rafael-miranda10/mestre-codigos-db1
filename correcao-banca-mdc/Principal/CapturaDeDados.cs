using System;
using System.Globalization;

namespace Principal
{
    public class CapturaDeDados
    {
        public static double CapturarNumeroDouble(string texto)
        {
            double numero;
            Console.Clear();
            Console.Write(texto);
            double.TryParse(Console.ReadLine(), NumberStyles.Number, new CultureInfo("pt-BR"), out numero);
            return numero;
        }
    }
}
