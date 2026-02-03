# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## 🧠 Conceitos de POO Aplicados

Neste desafio, estruturei o sistema seguindo os pilares da Programação Orientada a Objetos com C#:

* **Abstração:** Criação da classe abstrata `Smartphone` para servir de molde para diferentes tipos de celulares, definindo propriedades essenciais e métodos obrigatórios.
* **Encapsulamento:** Utilização do modificador de acesso `protected` para os campos `Modelo`, `Imei` e `Memoria`. Isso permite que as classes filhas acessem esses dados para exibição, mas impede que sejam alterados externamente, garantindo a integridade dos dados.
* **Herança:** As classes `Nokia` e `Iphone` herdam da classe `Smartphone`, reutilizando o comportamento de ligar e receber ligações, além de compartilharem a mesma estrutura de construtor através do comando `base`.
* **Polimorfismo:** Implementação do método `InstalarAplicativo` usando `override`. Cada classe filha define sua própria lógica de instalação, demonstrando como um mesmo método pode ter comportamentos distintos.

---
