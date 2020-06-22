using System;
using UtilizandoPOO.RecursosDePOO;

namespace UtilizandoPOO._1_POO
{
    public class Empregado : IComparable<Empregado>
    {
        public double Salario { get; set; }
        public string Nome { get; set; }

        public int CompareTo(Empregado outroFuncionario)
        {
            // se o salario for igual, é comparado o nome
            if (Salario == outroFuncionario.Salario)
            {
                return Nome.CompareTo(outroFuncionario.Nome);
            }
            //ordenação padrão do sáliro descendente
            return outroFuncionario.Salario.CompareTo(Salario);
        }

        public override string ToString()
        {
            return string.Format(ConstantesPoo.MsgEmpregadoString, Nome, Salario);
        }
    }
}
