Estudo/case

##### Construindo um projeto de uma API.NET integrada ao MongoDB (resumo)

**Parte1 - Objetivos**

- entender a relação entre back end e front end
- Banco de dados
- mongoDB
- criar uma api com .net e mongoDB
- Entender a relação frontend e backend



**Parte 2 - Conceitos Básicos**

**Front end** 

basicamente é a parte visual que o usuário final consegue interagir -normalmente quem trabalha com frontend usa as tecnologias base da Web ( HTML, CSS e Javascript ).Algumas pessoas podem confundir um pouco esse trabalho com o que um designer faz (no passado existia uma entidade chamada **Webmaster** que fazia tudo isso e mais um pouco), mas a diferença aqui é que o designer vai utilizar alguma ferramenta visual para **desenhar a interface**, do Photoshop ao Sketch, e quem faz front-end estará mais próxima do código em si, que irá rodar em um navegador Web como Chrome, Firefox ou Safari.

**Back end**

Como o próprio nome diz, vem da ideia do que roda por trás de uma aplicação como:

- banco de dados
- integrações
- cache
- processamentos paralelos, em batch, etc
- mensageria
- serviços, cloud
- regras de negócios
- etc...

**API**

As apis proporcionam a integração entre sistema que possuem linguagem totalmente distintas de maneira ágil e segura. Em outras formas de integração de sistemas, o profissional que realiza a trabalho precisa, muitas vezes, instalar recursos compatíveis com o sistema no qual se busca efetuar a integração.

**vantagens do NoSQL**  -- MongoDB

-  performance 
-  escalabilidade 
-  flexibilidade 
-  agilidade de desenvolvimento

existem atualmente mais de 200 bancos noSQL, e 4 classes, que são:

-chave/valor - ex: redis

-Colunas- ex: cassandra

-Documento - ex: **MongoDB**

-grafos - ex: neo4J - trabalha ex: malha de contatos de redes sociais, rotas de viagem , etc..

**Parte 3 - Mão na massa**

1. Criação do projeto MongoDB atlas
2. Criação da apai .net -- // dotnet new api -n nomeDaAPI
3. instalação de plugins C# no visual code
4. configuração Startup.
5. Configura acesso ao mongoDB
6. criação classe infectado - data collections
7. configuração do mongo
8. mapeamento de classes
9. criação das models
10. Configurando as controllers  -- usando Http metodos
11. Configurando e entendendo a injeção de dependência
12. entendendo as forma de criação de instancia 
13. usando postman para realizar requisições api



o que foi feito a mais ou diferente:

- acrescenta - id na model
- acrescenta - metodo delete - atualizar
- atualiza e deleta pelo id e não pela data de nascimento
- uso do insominia para realizar requisições api

