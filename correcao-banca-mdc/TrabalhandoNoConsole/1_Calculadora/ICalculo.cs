using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoNoConsole._1_Calculadora
{
    public interface ICalculo
    {
        double Dividir(double a, double b);
        double Multiplicar(double a, double b);
        double Somar(double a, double b);
        double Subtrair(double a, double b);
        bool VerificaSeEPar(double x);

    }
}
