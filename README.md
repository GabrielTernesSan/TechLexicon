# TechLexicon
O objetivo deste projeto é consolidar e organizar o conhecimento acumulado ao longo dos meus anos de trabalho e estudos. Ele funcionará como um repositório de informações, ferramentas e práticas, servindo como um guia de referência pessoal e uma vitrine do meu progresso profissional.

# Quais tecnologias foram usadas?
<p align="center">
  <a href="https://skillicons.dev">
    <img src="https://skillicons.dev/icons?i=git,postgres,cs,dotnet,docker,kubernetes,azure,ts,js,react" />
  </a>
</p>

# Arquitetura
## Backend
Para o backend, decidi usar uma variação da arquitetura em camadas combinada com o conceito de DDD (Domain-Driven Design) para estruturar o projeto de forma clara, organizada e alinhada às regras de negócio. 

A arquitetura em camadas ajuda a separar as responsabilidades da aplicação, dividindo-a em módulos como *Application*, *Domain*, *Infraestrutura* e *Web*. Essa abordagem não apenas promove uma separação de responsabilidades, mas também reforça o alinhamento entre a modelagem do domínio e a implementação técnica. Cada camada desempenha um papel específico:

### Camada de Aplicação (Application Layer)
Gerencia o fluxo de dados e orquestra as operações dentro do sistema. Ela coordena a execução das regras de negócio contidas no domínio e interage com outras camadas, mas não contém lógica de negócios por si só. É onde ficam os casos de uso específicos do sistema.

### Camada de Domínio (Domain Layer)
O coração do sistema, responsável pela lógica central do negócio. É aqui que conceitos como Entidades, Objetos de Valor, Agregados, Serviços de Domínio e Repositórios são implementados, representando diretamente o domínio do problema que o sistema busca resolver. Essa camada é independente de detalhes técnicos como frameworks ou bancos de dados.

### Camada de Infraestrutura (Infrastructure Layer)
Lida com as preocupações técnicas, como persistência de dados, comunicação com APIs externas, mensagens, logs e configuração de serviços. Ela fornece implementações concretas para interfaces definidas na camada de domínio, garantindo que o domínio permaneça isolado dos detalhes técnicos.

### Camada Web (Web Layer)
A Camada Web atua como um ponto de entrada para o sistema, processando solicitações externas e retornando respostas apropriadas. Esta camada é projetada para interagir com a Camada de Aplicação, delegando a ela a orquestração das operações.

<p align="center">
  <a href="https://imgur.com/a/qDtAjrD">
    <img src="https://i.imgur.com/qDtAjrD.jpg" alt="Descrição da imagem" />
  </a>
</p>

Já o DDD complementa essa abordagem, focando no entendimento profundo do domínio do problema. Por meio da aplicação de conceitos como entidades, objetos de valor, agregados, repositórios e serviços de domínio, é possível modelar o sistema de forma a refletir as regras e processos reais do negócio. O uso do DDD também promove a criação de uma linguagem ubíqua, permitindo que todos os membros do time compartilhem um entendimento comum sobre o sistema.

Essa combinação de arquitetura em camadas e DDD proporciona uma base sólida para o desenvolvimento do backend, com vantagens como alta manutenibilidade, fácil escalabilidade e um alinhamento forte entre a solução técnica e as necessidades do negócio.

## Frontend
Já para o frontend decidi usar a Arquitetura Baseada em Componentes (CBA - Component-Based Architecture) que é uma abordagem de design de software onde o sistema é construído a partir de componentes independentes e modulares. Esses componentes encapsulam tanto o estado quanto o comportamento necessário para realizar uma função específica no sistema. Essa arquitetura é amplamente utilizada em aplicativos modernos devido à sua flexibilidade, reutilização e facilidade de manutenção.

### Características da Arquitetura Baseada em Componentes
**Modularidade:** Cada componente é uma unidade independente que pode ser projetada, desenvolvida e testada separadamente. Componentes têm responsabilidades bem definidas.

**Encapsulamento:** Os detalhes internos do componente, como dados e implementação, estão ocultos do resto do sistema. O componente expõe apenas uma interface clara para interação.

**Reutilização:** Componentes podem ser reutilizados em diferentes partes do sistema ou até em outros projetos.

**Interoperabilidade:** Componentes se comunicam entre si por meio de interfaces bem definidas, como APIs ou eventos. Essa comunicação é geralmente desacoplada, reduzindo dependências rígidas.

**Flexibilidade:** É fácil adicionar, substituir ou remover componentes sem impactar significativamente o restante do sistema.

