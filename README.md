# Repositório destinado ao projeto mestre dos código promovido pela DB1 Group - Nível escudeiro

# Perguntas teóricas de introdução

## 1 - Em quais linguagens o C# foi inspirado?
   A microsoft contratou o engenheiro Anders Heijlsberg (um dos principais nomes por trás do Delphi) para liderar um novo 
   projeto de linguagem de programação, inicialmente chamado de COOL (C-Like Object Oriented Language). Tal projeto teve o 
   seu design baseado em outras liguagens do mercado como Java, C, C++, Smalltalk, Delphi e VB. A ideia era estudar os problemas
   existentes e incorporar soluções. 
   Assim, no ano de 2002, o projeto COOL foi rebatizado e lançado como linguagem C# 1.0
   
## 2 - Inicialmente o C# foi criado para qual finalidade?
   Inicialmente a microsoft tinha um projeto chamado de J++ (uma versão Java que só podia ser executado no ambiente microsoft), porém 
   por motivos de violação de licenciamento, a microsoft foi obrigada a repensar sobre como lidar com diferentes linguagens e tecnologias
   e assim começou a trabalhar em uma nova plataforma que seria base de todas as suas soluções, que posteriormente foi chamada de .NET.
   
   O C# surgiu com a finalidade de possibilitar a criação de soluções executáveis sobre a plataforma .NET Framework, com o intuito de
   flexibilizar o desenvolvimento de aplicativos. Dessa maneira, o desenvolvedor não cria soluções para um dispositivo 
   eletrônico específico, e sim para a plataforma .NET Framework.
   
## 3 - Quais os principais motivos para a Microsoft ter migrado para o Core?
   O Core é um framework completamente novo, é outra arquitetura. A microsoft ampliou o alcance do .Net e tornou possível implantar
   aplicativos ASP.NET Core em um conjunto maior de ambientes com uma ampla variedade de distribuições Linux, macOS e containers.
   
   Os principais motivos para a mudança são:
   
   * Extensível: 
      Foi construido por uma série de componentes e interfaces independentes e com características bem definidas. Os
      componentes core implementam uma interface ou herdam de classes abstratas. É possível substituir os principais componentes ou 
      extender seu comportamentos por outros de sua própria implementação.
    
   * Testável:
     Por ter mantido sua arquitetura MVC o ASP.NET Core, a controller pode ser facilmente isolada. Facilmente testável por frameworks
     populares
    
   * Multiplataforma:
     Independente de ambiente windows e está disponível em diferentes plataformas como Linus e macOS. Pode ser desenvolvido utilizando
     o Visual Studio Code, uma IDE multiplataforma.
     
   * OpenSource:
     O Core passou a ser open source e é possível baixar o código-fonte no GitHub.
     
   * Performance:
     O pipeline de solicitação HTTP é leve e de alto desenpenho.
     
   
## 4 - Cite as principais diferenças entre .Net Full Framework e .Net Core.

### .NET CORE
   O Core é um framework completamente novo, é outra arquitetura e sua caracteristica mais marcante é ser cross-plataform, ou seja, 
   é possível implantar aplicativos em windows, linux e macOS. Ele não possui alguns dos recursos mais comuns do .Net Framework, 
   portanto, ele dificilmente poderá ser aplicado em ambinetes legados e suporta ainda quatro tipos de aplicações: console, ASP.NET
   Core, cloud, e Universal Windows Platform (UWP).

### .NET STANDARD
   A Microsoft padronizou as APIs de runtime da plataforma .NET para possibilitar que um código seja compatível com diferentes runtimes.
   O nome .net standard é referente as biliotecas do .net e elas garantem uma sintonia maior entre .net core e .net framework. Nem todas
   as classes existentes foram padronizadas para esse suporte e é ai que o .net standard.
   
   Cada implementação do framework tem sua própria coleção de bibliotecas de classes (BCL - Base Class libraries) e o .net standard é
   é uma especificação para implementar a BCL. A relação entre o .NET Standard e uma implementação .NET é a mesma entre a especificação
   HTML e um navegador. O segundo é uma implementação da primeira.

# Perguntas Utilizando POO

## 1 - O que é POO?
## 2 - O que é polimorfismo?
## 3 - O que é abstração?
## 4 - O que é encapsulamento?
## 5 - Quando usar uma classe abstrata e quando devo usar uma interface?
## 6 - O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
## 7 - Existe herança múltipla (de classes) em C#?



# Referências

### Perguntas teóricas de introdução
https://docs.microsoft.com/pt-br/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework#feedback

https://www.caelum.com.br/download/caelum-csharp-dotnet-fn13.pdf

https://www.devmedia.com.br/a-evolucao-da-linguagem-de-programacao-csharp/28639

https://www.brunobrito.net.br/asp-net-core/

https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-3.1

https://www.infoq.com/br/news/2017/11/dotnet-core-standard-difference/

https://luizpauloprado.com.br/2017/03/24/net-framework-ou-net-core/

### Perguntas utilizando POO
