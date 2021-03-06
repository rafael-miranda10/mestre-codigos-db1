# Repositório destinado ao projeto mestre dos código promovido pela DB1 Group - Nível escudeiro

# Instruções de Uso
 O projeto foi pensado para ser intuitivo. As opções são numeradas e para selecionar uma delas basta digitar o número da opção desejada
 e assim acessa-la. 
 
 Quando estiver em um menu de opções e desejar sair ou voltar ao menu anterior basta digitar a opção 0 (zero).
 
 Quando estiver digitando uma lista de valores e desejar parar o processo de inserção basta digitar 0 (zero). Lembre-se que dessa forma
 o número zero não fará parte da lista.
 
 Quando solicitado que digite um valor e você desejar informar um valor decimal, o projeto está trabalhando com a cultura brasileira, ou
 seja, utilize virgula para a representação de valores decimais. Ex: 1,2 e/ou 5.365,45.
 
 Para executar os testes utilize a caixa de ferrameta Test Explorer do Visual Studio.
 
 Para os testes que trabalham com datas e cálculo de idade por favor fique atento com os parâmetros (pois dependendo do mês que o projeto for executado, o parâmetro "resultado esperado" pode já não ser mais o mesmo.).
 
 Alguns trechos e código comentados são para exemplificar mais de uma forma de se fazer determinada tarefa.


# Perguntas teóricas de introdução

## 1 - Em quais linguagens o C# foi inspirado?
   A Microsoft contratou o engenheiro Anders Heijlsberg (um dos principais nomes por trás do Delphi) para liderar um novo 
   projeto de linguagem de programação, inicialmente chamado de COOL (C-Like Object Oriented Language). Tal projeto teve o 
   seu design baseado em outras linguagens do mercado como Java, C, C++, Smalltalk, Delphi e VB. A ideia era estudar os problemas
   existentes e incorporar soluções. 
   Assim, no ano de 2002, o projeto COOL foi rebatizado e lançado como linguagem C# 1.0
   
## 2 - Inicialmente o C# foi criado para qual finalidade?
   Inicialmente a Microsoft tinha um projeto chamado de J++ (uma versão Java que só podia ser executado em ambinetes da empresa), porém 
   por motivos de violação de licenciamento, a microsoft foi obrigada a repensar sobre como lidar com diferentes linguagens e    tecnologias
   e assim começou a trabalhar em uma nova plataforma que seria base de todas as suas soluções, que posteriormente foi chamada de .NET.
   
   O C# surgiu com a finalidade de possibilitar a criação de soluções executáveis sobre a plataforma .NET Framework, com o intuito de
   flexibilizar o desenvolvimento de aplicativos. Dessa maneira, o desenvolvedor não cria soluções para um dispositivo 
   eletrônico específico, e sim para a plataforma .NET Framework.
   
## 3 - Quais os principais motivos para a Microsoft ter migrado para o Core?
   O Core é um framework completamente novo, é outra arquitetura. A Microsoft ampliou o alcance do .Net e tornou possível implantar
   aplicativos ASP.NET Core em um conjunto maior de ambientes com uma ampla variedade de distribuições Linux, macOS e containers.
   
   Os principais motivos para a mudança são:
   
   * Extensível: 
      Foi construído por uma série de componentes e interfaces independentes e com características bem definidas. Os
      componentes "core" implementam uma interface ou herdam de classes abstratas. É possível substituir os principais componentes ou 
      estender seus comportamentos por outros de sua própria implementação.
    
   * Testável:
     Por ter mantido sua arquitetura MVC o ASP.NET Core, a controller pode ser facilmente isolada. Facilmente testável por frameworks
     populares
    
   * Multiplataforma:
     Independente de ambiente windows e está disponível em diferentes plataformas como Linux e macOS. Pode ser desenvolvido utilizando
     o Visual Studio Code, uma IDE multiplataforma.
     
   * OpenSource:
     O Core passou a ser open source e é possível baixar o código-fonte no GitHub.
     
   * Performance:
     O pipeline de solicitação HTTP é leve e de alto desempenho.
     
   
## 4 - Cite as principais diferenças entre .Net Full Framework e .Net Core.

### .NET CORE
   O Core é um framework completamente novo, é outra arquitetura e sua característica mais marcante é ser cross-plataform, ou seja, 
   é possível implantar aplicativos em windows, linux e macOS. Ele não possui alguns dos recursos mais comuns do .Net Framework, 
   portanto, ele dificilmente poderá ser aplicado em ambientes legados e suporta ainda quatro tipos de aplicações: console, ASP.NET
   Core, cloud, e Universal Windows Platform (UWP).

### .NET FRAMEWORK
  É um framework voltado a aplicações windows e oferece uma variedade de serviços aos aplicativos em execução e prove a    
  manipulação de tais aplicativos. o framework oferece ainda  uma biblioteca de códigos testados e que podem ser reutilizados por
  desenvolvedores de software. Não é cross-plataform.

# Perguntas Utilizando POO

## 1 - O que é POO?
   A programação orientada a objetos - POO é um paradigma (padrão) baseado no conceito de objetos, tais objetos são representações do 
   mundo real onde contém comportamentos e atributos (métodos e propriedades). Em POO os programas de computadores são projetados pela
   composição de objetos que interagem uns com os outros.
   
## 2 - O que é polimorfismo?
   É um dos quatro pilares da programação orientada a objetos. A palavra polimorfismo é um substantivo masculino que se refere a
   qualidade ou estado de ser capaz de assumir diferentes formas e isso é lavado para dentro da programação. Objetos filhos herdam as
   características e ações de seus "ancestrais" e em alguns casos, é necessário que as ações para um mesmo método sejam diferentes, ou
   seja, consiste na alteração do funcionamento interno de características herdadas de um objeto pai.

## 3 - O que é abstração?
   A abstração é a forma de analisar algo retirando assim a riqueza dos detalhes ou seja, uma forma generalista de representação
   para descrever algo sem dar detalhes. uma classe abstrata é uma forma de representar isso na programação.
   
## 4 - O que é encapsulamento?
   Também é um dos quatro pilares da POO. Podemos dizer que o encapsulamento esconde a riqueza dos detalhes, e criando uma 
   "caixa  preta". Está muito ligado a abstração, uma vez que no encapsulamento eu não quero ou preciso saber os detalhes de 
   funcionamento, apenas utilizo sabendo que será executado a tarefa desejada.
   
## 5 - Quando usar uma classe abstrata e quando devo usar uma interface?
   Resumidamente utilizamos uma interface quando necessitamos  de "contratos" abstratos ou seja, não preciso saber os detalhes de 
   uma funcionalidade apenas utilizo ela sabendo será executado. Por exemplo uma interface de IRepository onde existe o método
   adicionar, eu não preciso saber como, apenas que será adicionado. Devo utilizar classe abstrata quando desejo que qualquer coisa
   que derive dela tenha um comportamento em comum (um comportamento por inferência). Por exemplo uma classe cachorro que herda de 
   animal onde cada animal deve respirar ou seja, um comportamento por inferência.
   
## 6 - O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
   * IDisposable: 
     O principal objetivo dessa interface é fornecer um mecanismo para liberar recursos não gerenciáveis. Existe um coletor de lixo que
     liberar automaticamente a memória alocada para um objeto, porém, não é possível saber quando essa liberação irá ocorrer. Assim, 
     utilize o método Dispose dessa interface para liberar o recurso quando o mesmo não for mais utilizado. O consumidor do objeto deve
     realizar essa ação.
     
   * IComparable:
     Essa interface é implementada por tipos cujos valores podem ser ordenados ou classificados. Requer que a implementação defina um
     único método "CompareTo(Object)" que indica se a ordem de classificação anterior, posterior ou igual a um segundo objeto do mesmo 
     tipo. A implementação de IComparable é chamada automaticamente por métodos Array.Sort e ArrayList.Sort. 
     
   * ICloneable: 
     Cria uma nova instância de uma classe com o mesmo valor de uma instãncia existente. Simplesmente requer a implementação do método
     Clone() para retornar  uma cópia da instância do objeto atual.
   
   * IEnumerable:
     Dá suporte a uma iteração simples em uma coleção não genérica. É uma interface que marca as classes que desejam implementá-la para
     que se saiba que ela pode ser iterável através de um iterador. O método "GetEnumerator()" é usado para obter o iterador. Na maioria 
     das vezes a implementação deste método é igual ou muito parecida.
     
     Sempre que implementar a IEnumerable terá que implementar de alguma forma, na classe ou em outro local a interface IEnumerator.
     

## 7 - Existe herança múltipla (de classes) em C#?
   Não. Herdar muitas classes concretas é um grande problema do ponto de vista do design de uma linguagem de programação. Se as
   superclasses tiverem métodos e variáveis com o mesmo nome? qual versão do método seria chamada? qual variável seria definida?
   Dessa forma, o C# preferiu deixar as coisas mais simples e permitir apenas herança simples de classes concretas.
   

# Trabalhando com testes

## 1 - Quais os principais frameworks que podemos usar no desenvolvimento de testes?
   A plataforma .NET conta com várias alternativas para a implementação de testes e muitas das opções são projetos open source de 
   grande adesão da comunidade técnica. Podemos citas os seguintes frameworks:
   
   * XUnit
   * MS Test
   * NUnit
   * Moq
   * NSubstitute
   * Fluent Assertions
   * Selenium WebDriver
   * SpecFlow
   
   Um detalhe importante é verificar a disponibilidade e compatibilidade desses frameworks para a versão da plataforma .NET utilizada, no caso dos
   frameworks citados são referentes a versão 3.0 e 3.1 do .NET CORE.
   


# Referências

### Perguntas teóricas de introdução
https://docs.microsoft.com/pt-br/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework#feedback

https://www.caelum.com.br/download/caelum-csharp-dotnet-fn13.pdf

https://www.devmedia.com.br/a-evolucao-da-linguagem-de-programacao-csharp/28639

https://docs.microsoft.com/pt-br/dotnet/standard/choosing-core-framework-server

https://www.brunobrito.net.br/asp-net-core/

https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-3.1

https://www.infoq.com/br/news/2017/11/dotnet-core-standard-difference/

https://luizpauloprado.com.br/2017/03/24/net-framework-ou-net-core/

https://www.todamateria.com.br/formula-de-bhaskara/

### Perguntas utilizando POO

https://www.devmedia.com.br/os-4-pilares-da-programacao-orientada-a-objetos/9264

https://pt.wikipedia.org/wiki/Programa%C3%A7%C3%A3o_orientada_a_objetos

https://www.devmedia.com.br/interfaces-x-classes-abstratas/13337

https://www.devmedia.com.br/polimorfismo-classes-abstratas-e-interfaces-fundamentos-da-poo-em-java/26387

https://docs.microsoft.com/pt-br/dotnet/api/system.idisposable?view=netframework-4.8

https://docs.microsoft.com/pt-br/dotnet/api/system.icloneable?view=netframework-4.8

https://docs.microsoft.com/pt-br/dotnet/api/system.collections.ienumerable?view=netframework-4.8

https://pt.stackoverflow.com/questions/191582/o-que-%C3%A9-e-pra-que-serve-ienumerable-e-ienumerator

### Trabalhando com testes

https://medium.com/@renato.groffe/testes-de-software-com-net-core-3-x-exemplos-de-utiliza%C3%A7%C3%A3o-7174560bc5e0

https://medium.com/@renato.groffe/net-core-2-0-frameworks-de-testes-exemplos-de-utiliza%C3%A7%C3%A3o-846f9e500fb6

https://www.infoq.com/br/articles/testing-aspnet-core-web-api/

https://www.devmedia.com.br/behavior-driven-development-bdd-com-specflow/29405


