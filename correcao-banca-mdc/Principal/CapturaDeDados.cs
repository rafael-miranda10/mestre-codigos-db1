using System;
using System.Globalization;

namespace Principal
{
    public class CapturaDeDados
    {
        private static double _numeroDouble;
        private static int _numeroInteiro;
        public static double CapturarNumeroDouble(string texto)
        {
            Console.Write(texto);
            double.TryParse(Console.ReadLine(), NumberStyles.Number, new CultureInfo("pt-BR"), out _numeroDouble);
            return _numeroDouble;
        }

        public static int CapturarNumeroInteiro(string texto)
        {
            Console.Write(texto);
            int.TryParse(Console.ReadLine(), NumberStyles.Number, new CultureInfo("pt-BR"), out _numeroInteiro);
            return _numeroInteiro;
        }
    }
}
