using System;
using System.Globalization;

namespace Principal
{
    public class CapturaDeDados
    {
        private static double _numeroDouble;
        private static int _numeroInteiro;
        private static decimal _numeroDecimal;
        private static string _textoDigitado;
        private static DateTime _data;
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
        public static decimal CapturarNumeroDecimal(string texto)
        {
            Console.Write(texto);
            decimal.TryParse(Console.ReadLine(), NumberStyles.Number, new CultureInfo("pt-BR"), out _numeroDecimal);
            return _numeroDecimal;
        }

        public static DateTime CapturarData(string texto)
        {
            Console.Write(texto);
            DateTime.TryParse(Console.ReadLine(), new CultureInfo("pt-BR"), DateTimeStyles.None, out _data);
            return _data;
        }
        public static string CapturarTextoDigitado(string texto)
        {
            Console.Write(texto);
            _textoDigitado = Console.ReadLine();
            return _textoDigitado;
        }
    }
}
