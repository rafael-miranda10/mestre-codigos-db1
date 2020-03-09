using System;
using TrabalhandoNoConsole.Exercicio_6.Interface;

namespace TrabalhandoNoConsole.Exercicio_6.Implementacao
{
    public class Parametros : IParametros
    {
        public void ExemploOut(out int valueOut)
        {
            valueOut = 50;
        }

        public void ExemploRef(ref int valueRef)
        {
            valueRef += 100;
        }

        public void ExibirExplicacao()
        {
            Console.WriteLine("As palavras reservadas ref e out são usadas para passar argumento/parâmetro para um método ou função. Indica que um argumento/parâmetro é passado por referência.\n" +
                "Simplificadamente um parâmetro normal tem um sentido, ele só vai, o valor do argumento só é enviado para o parâmetro. O out também só tem um sentido, mas contrário, ele só passa o valor do parâmetro(o que está dentro do método) para o argumento.\n"+
                "O ref faz nos dois sentidos. Ele manda um valor do argumento para o parâmetro e devolve o valor do parâmetro para o argumento.\n"+
                "Ambos, argumento e parâmetro devem conter o modificador.\n\n"+
                "PALAVRA RESERVADA REF\n\n"+
                "Transmite argumentos como referência. Na pratica isso significa que quaisquer alterações feitas nesse argumento no método serão refletidas nessa variável quando o controle retornar ao método de chamada.\n\n"+
                "PALAVRA RESERVADA OUT\n\n"+
                "Indica que o argumento a ser passado receberá um valor dentro do método. Ou seja, é uma referência também, mas não é passado nenhum valor para o parâmetro, é apenas uma forma de dar saída para um valor. Isto normalmente é necessário porque o return só pode ter um valor.\n"+
                "Usando ele o argumento não precisa ter um valor mas o parâmetro precisa receber um valor antes de encerrar a execução do método. Ele é mais rápido em alguns cenários.");
        }
    }
}
