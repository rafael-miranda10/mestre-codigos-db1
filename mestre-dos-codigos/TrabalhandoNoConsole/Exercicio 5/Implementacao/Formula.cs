using System;
using TrabalhandoNoConsole.Exercicio_5.Interface;

namespace TrabalhandoNoConsole.Exercicio_5.Implementacao
{
    public class Formula : IFormula
    {
        public void CalcularBhaskara(double a, double b, double c)
        {
            var bhaskara = new Bhaskara(a, b, c);

            if (bhaskara.Invalid)
            {
                foreach (var item in bhaskara.Notifications)
                    Console.WriteLine($"Não é possível calcular a formula de Bhaskara! Motivo: {item.Message}");
            }

            if (bhaskara.Valid)
            {
                bhaskara.CalcularFormulaBhaskara();
                bhaskara.ExibirR1R2();

            }

        }

    }
}
