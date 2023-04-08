
# Metodologia

<span>Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Para o desenvolvimento deste trabalho, adotaremos a metodologia descrita a seguir, a qual abrangerá a relação de ambientes utilizados, a gestão do código fonte, definições dos processos, ferramentas e como a equipe se organizará e fará a gestão das tarefas ao longo do tempo disponível para a realização do projeto.

<br>

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de `branches`:

- `main`: Representa a versão atualmente estável e testada do software, pronta para ser entregue ou implantada em produção;
- `develop`: Representa a versão em desenvolvimento do software, onde as funcionalidades estão sendo incorporadas e testadas continuamente;
- `feature`: Para cada nova funcionalidade a ser desenvolvida, uma nova **branch** de `feature` deve ser criada a partir da **branch** `develop`, seguindo o padrão de nomenclatura `feature-numero-do-cartao`, onde `numero-do-cartao` representa o código numérico identificador da tarefa no **Trello**.

<br>

Exemplo da nossa gestão de código:

![image](https://user-images.githubusercontent.com/107289791/230728090-bf0a77e2-cdf7-484d-8337-f5d9fd81ef40.png)
<p align="center">Figura 02 - Diagrama da representação do Controle de Versão.</p>

<br>

Quanto à gerência de `commits`, o projeto adota a seguinte convenção para etiquetas:

- `doc`: Melhorias ou adições à documentação;
- `bug`: Resolução de problemas de uma funcionalidade já existente;
- `feature`: Novas funcionalidades a serem adicionadas ao projeto;
- `enhance`: Melhorias em funcionalidades já existentes;

As tarefas serão gerenciadas no Trello e estarão organizadas da seguinte forma:

- `Backlog`: Contém todas as atividades que devem ser realizadas no projeto, desde a documentação até o desenvolvimento da aplicação.
- `To-do`: Lista as tarefas definidas previamente para a sprint atual, e deve ser atualizada com a data de início da sprint.
- `In progress`: Contém as tarefas em andamento durante a sprint atual.
- `Validating`: Contém as tarefas que precisam ser testadas.
- `Done`: Contém todas as tarefas finalizadas, independentemente da sprint.

Ao receber uma tarefa que estará listada na coluna "To-do", a pessoa estudante deverá clonar o repositório localmente e criar uma nova **branch** de `feature` para trabalhar na funcionalidade. Após concluir a implementação, o desenvolvedor deve realizar um **commit** e, em seguida, fazer o merge da **branch** `feature` criada com a **branch** `develop`. Somente após a conclusão e testes da versão do projeto é que se deve fazer o merge da `develop` com a `main` para seguir com o fluxo normal do projeto.

## Gerenciamento de Projeto

### Divisão de Papéis

 - `Scrum Master`: Ellen Caroline Trindade Gonçalves Cândido;
 - `Product Owner`: Shinji Matsumoto Fernandes;
 - `Designer`: Amanda de Lima Ventura;
 - `Equipe de Desenvolvimento`: 
   - Amanda de Lima Ventura,
   - Ellen Caroline Trindade Gonçalves Cândido,
   - Elpidio Lomeu Junior,
   - Fabrício Maia dos Santos,
   - Leonardo Correia de Sá e Silva,
   - Odair Cordeiro Marra,
   - Shinji Matsumoto Fernandes.

<br>

### Processo

O projeto será gerenciado pelo [Trello](https://trello.com), assim como a marcação das entregas.
Abaixo, a forma que nosso **Kanban** está organizado:

![image](https://user-images.githubusercontent.com/107289791/230728406-21c418c3-953b-44d2-9475-e524bdd32900.png)
<p align="center">Figura 03 - Kanban do Projeto.</p>
 
