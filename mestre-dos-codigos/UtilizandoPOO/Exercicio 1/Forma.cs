namespace UtilizandoPOO.Exercicio_1
{
    /*
    As classes círculo, quadrado, retângulo, triangulo são exemplos de POO e abstração onde exemplificam objetos reais, suas características e seus comportamentos. Neste conjunto de classes também é 
    exemplificado a abstração, polimorfismo e o encapsulamento. A classe Forma é a abstração, nas classes restante é representado o polimorfismo onde cada forma tem o seu comportamento específico e o 
    encapsulamento representado nos modificadores de propriedade private. Poderia ainda em cada forma declarar um método para "setar" os valores nos atributos de cada classe, no entanto, optei pode deixar 
    apenas no construtor e assim para instanciar cada forma o construtor é responsável em definir o objeto em sua forma válida e as propriedades não são acessíveis de fora da classe.
    */
    public abstract class Forma
    {
        public abstract double CalcularArea { get; }
    }
}
