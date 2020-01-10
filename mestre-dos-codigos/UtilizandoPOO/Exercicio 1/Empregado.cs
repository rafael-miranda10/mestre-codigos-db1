using System;

namespace UtilizandoPOO.Exercicio_1
{
    public class Empregado : IComparable<Empregado>
    {
        public double Salario { get; set; }
        public string Nome { get; set; }

        public int CompareTo(Empregado outro)
        {
            // se o salario for igual, é comparado o nome
            if (Salario == outro.Salario)
            {
                return Nome.CompareTo(outro.Nome);
            }
            //ordenação padrão do sáliro descendente
            return outro.Salario.CompareTo(Salario);
        }

        public override string ToString()
        {
            return $"O salário de: {Nome} é de: {Salario}"; 
        }
    }
}
