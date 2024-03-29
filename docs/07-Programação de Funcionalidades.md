# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

### Funcionalidade 01: Fazer Publicações (RF-001)
A funcionalidade permite que o usuário faça uma postagem na pagina de Interações na platarforma da `Study2gether`.

![Publicação de interação](https://user-images.githubusercontent.com/114435981/236596298-7cd632ef-6ee6-4599-a987-28b4ae6e4869.png).

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Clicar em Interações.
3. Clicar em '+' (usuários já cadastrados e previamente logados).

##### Artefatos produzidos
* [Interacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Interacoes.cshtml)
* [PostsController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/PostsController.cs)

### Funcionalidade 02: Efetuar Cadastro	(RF-006)
A funcionalidade permite que o usuário realize com sucesso o cadastro na platarforma da `Study2gether`.

![Screenshot 2023-05-07 143228](https://user-images.githubusercontent.com/107289791/236693557-0f332727-bfe7-4258-a912-ece1326ff57b.png)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Clique no botão `Cadastre-se`.
3. Insira um `e-mail` com o formato `nome@sga.pucminas.br`.
4. Insira uma `senha` com ao menos 8 caracteres.
5. Clique no botão `Cadastrar`.

##### Artefatos produzidos
* [Cadastro.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Cadastro.cshtml)
* [User.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Models/User.cs)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)

### Funcionalidade 03: Efetuar Login	(RF-006) 
A funcionalidade permite que o usuário realize com sucesso o login na platarforma da `Study2gether`.

![Screenshot 2023-05-07 143223](https://user-images.githubusercontent.com/107289791/236693541-74942825-5920-4273-a7e2-b30db3eca14e.png)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Clique no botão `Login`.
3. Insira o `e-mail` e a `senha` já cadastrados previamente.
4. Clique no botão `Entrar`.

##### Artefatos produzidos
* [Login.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Login.cshtml)
* [User.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Models/User.cs)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)

### Funcionalidade 04: Visualizar publicações (RF-008)

A funcionalidade permite que os usuários visualizem as postagens de indicações, perguntas ou interações na platarforma da `Study2gether`.

![Pagina de Interações](https://user-images.githubusercontent.com/114435981/236595542-a8e16566-daaa-4e59-af18-8db9534eebd1.png)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Clicar em "Indicações", "Perguntas" ou "Interações".
3. Clicar na postagem desejada para ser visualisada.

##### Artefatos produzidos
* [Perguntas.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Perguntas.cshtml)
* [PostsController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/PostsController.cs)
* [Interacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Interacoes.cshtml)
* [Indicacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Indicacoes.cshtml)

### Funcionalidade 05: Postar Perguntas e Interações (RF-003)

A aplicação deve permitir ao usuário postar perguntas e interações na platarforma da `Study2gether`.

![Postar perguntar](img/teladeperguntas.jpg)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Clicar em "Perguntas" ou "Interações".
3. Clicar em "+" (usuários já cadastrados e previamente logados).

##### Artefatos produzidos
* [Perguntas.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Perguntas.cshtml)
* [PostsController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/PostsController.cs)
* [Interacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Interacoes.cshtml)

### Funcionalidade 06: Postar Respostas (RF-004)
A aplicação deve permitir ao usuário responder as perguntas na platarforma da `Study2gether`.

![Postar resposta](img/ct34enviarresposta.jpg)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Clicar em "Perguntas".
3. Selecionar uma Pergunta.
4. Clicar no local de inserir Respostas (usuários já cadastrados e previamente logados).
5. Digitar o texto.
6. Clicar no botão "Enviar".

##### Artefatos produzidos
* [Perguntas.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Perguntas.cshtml)
* [Respostas.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Respostas.cshtml)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)

### Funcionalidade 07: Visualizar um histórico com as próprias ações (RF-007)
A funcionalidade permite que o usuário, logado na `Study2gether`, acesse sua página de perfil e visualize um histórico com suas ações de Perguntas, Interações, respostas e seus itens favoritados.

![Página de Perfil e Histórico](https://user-images.githubusercontent.com/12260321/236688605-a3024173-1971-451e-9c82-f2dc1af67902.png)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Caso usuário não esteja com login efetuado, basta efetuar o `Login`.
3. Com o login já efetuado, clicar em seu nome de usuário no canto superior direito.
5. Na tela Perfil/Histórico, é possível interagir entre as abas para visualizar suas ações.

##### Artefatos produzidos
* [Historico.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Historico.cshtml)
* [User.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Models/User.cs)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)
* [Historico.js](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/feature-96/src/Study2gether/Study2gether/wwwroot/js/historico.js)

### Funcionalidade 08: Editar o perfil de usuário (RF-007 e RF-006)
A funcionalidade permite que o usuário, logado na `Study2gether`, acesse seu perfil de usuário e edite suas informações de perfil.

![Editar Perfil](https://user-images.githubusercontent.com/12260321/236688846-03e2b3c5-d952-4256-9dbe-6dc66fe913fd.png)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com)
2. Caso usuário não esteja com login efetuado, basta efetuar o `Login`.
3. Com o login já efetuado, clicar em seu nome de usuário no canto superior direito.
4. Na tela Perfil/Histórico, clicar em `Editar Perfil`.
5. Na tela de `Editar Perfil`, editar as informações.
6. Clicar em `Salvar Perfil`. 

##### Artefatos produzidos
* [Historico.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Historico.cshtml)
* [EditarPerfil.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/EditarPerfil.cshtml)
* [EditarPerfil.css](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/wwwroot/css/editarPerfil.css)
* [User.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Models/User.cs)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)

### Funcionalidade 09: Excluir a conta (RF-006)
A funcionalidade permite que o usuário, logado na `Study2gether`, exclua sua conta de usuário.

![Excluir Perfil](https://user-images.githubusercontent.com/12260321/236689149-b2fd74bc-7bea-4a10-9744-b04b9989d393.png)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com)
2. Caso usuário não esteja com login efetuado, basta efetuar o `Login`.
3. Com o login já efetuado, clicar em seu nome de usuário no canto superior direito.
4. Na tela Perfil/Histórico, clicar em `Editar Perfil`.
5. Na tela de `Editar Perfil`, clicar em `Excluir Perfil`.
6. Um prompt de confirmação será exibido informando que a exclusão será definitiva.
7. Caso escolha `Sim`, a conta é definitivamente excluída e o usuário poderá fazer outro cadastro com esse email futuramente.
8. Caso escolha `Cancelar`, a ação é abortada.

##### Artefatos produzidos
* [Historico.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Historico.cshtml)
* [EditarPerfil.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/EditarPerfil.cshtml)
* [EditarPerfil.css](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/wwwroot/css/editarPerfil.css)
* [User.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Models/User.cs)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)

### Funcionalidade 10: Alterar senha com usuário logado (RF-010)
A funcionalidade permite que o usuário logado na `Study2gether` acesse seu Perfil e altere sua senha.

![Alterar senha](https://user-images.githubusercontent.com/12260321/236688584-29440457-fa83-4c6e-8022-523ae1209be3.png)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Caso usuário não esteja com login efetuado, basta efetuar o `Login`.
3. Com o login já efetuado, clicar em seu nome de usuário no canto superior direito.
4. Na tela Perfil/Histórico, clicar em `Alterar senha`.
5. Na tela `Alterar Senha`, inserir qual a senha atual, qual será a senha nova e confirmar a nova senha.
6. Clicar em `Alterar Senha`.

##### Artefatos produzidos
* [Historico.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Historico.cshtml)
* [AlterarSenha.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/AlterarSenha.cshtml)
* [EditarPerfil.css](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/wwwroot/css/editarPerfil.css)
* [User.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Models/User.cs)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)

### Funcionalidade 11: Administrador inserir postagem de indicações de materiais relevantes. (RF-011)

A aplicação deve permitir ao administrador inserir postagem de indicações de materiais relevantes. `Study2gether`.

![image](https://user-images.githubusercontent.com/96087622/236625920-4546a3d9-c931-4a82-8b53-4249ca0130fa.png)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Acessar uma conta com permissão de administrador.
3. Clicar em Indicações.

##### Artefatos produzidos
* [Indicacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Indicacoes.cshtml)
* [PostsController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/PostsController.cs)

### Funcionalidade 12: Apresentar um filtro por eixos ou por microfundamentos. (RF-002)

A aplicação deve apresentar um filtro por eixos ou por microfundamentos.

![image](img/programacaodefuncionalidadesrf02.jpg)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com).
2. Clicar no filtro "Eixo" ou "Microfundamento".

##### Artefatos produzidos
* [PostsController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/PostsController.cs)
* [_Layout.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Shared/_Layout.cshtml)
* [Filters.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/develop/src/Study2gether/Study2gether/Views/Shared/Filters.cshtml)
* [ViewBagActionFilter.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/develop/src/Study2gether/Study2gether/Atributtes/ViewBagActionFilter.cs)

### Funcionalidade 13: Pesquisar por campo de texto (RF-005)

A funcionalidade permite que os usuários pesquisem por campo de texto na platarforma da `Study2gether`.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/21993438/0d1e5d2a-3d45-43a0-bfcf-e7d0f5b02829)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com)
2. Clicar na área de pesquisa localizada no topo do site, onde está escrito "Digite o texto para buscar".
3. Digite o texto que você quer procurar.
4. Clicar na lupa ao lado do texto ou dar enter para a busca ser finalizada. 

##### Artefatos produzidos
* [Indicacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Indicacoes.cshtml)
* [Perguntas.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Perguntas.cshtml)
* [Interacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Interacoes.cshtml)
* [PostsController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/PostsController.cs)


### Funcionalidade 14: A aplicação deve permitir ao usuário reagir com reações de emojis (RF-009)

A aplicação deve permitir ao usuário reagir com reações de emojis `Study2gether`.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/96087622/75f8c013-143f-4215-9b98-104d705221ee)

##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com)
2. Clicar na área de Perguntas, Indicações ou Interações.
3. Clicar no icone de reagir.
4. Inserir um reação.
5. Atualizar a pagina e ver se a reação foi adicionada. 

##### Artefatos produzidos
* [Indicacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Indicacoes.cshtml)
* [Perguntas.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Perguntas.cshtml)
* [Interacoes.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Posts/Interacoes.cshtml)
* [PostsController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/PostsController.cs)

### Funcionalidade 15: A aplicação deve permitir ao usuário recuperar a senha. (RF-010)

A aplicação deve permitir ao usuário recuperar a senha na aplicação `Study2gether`.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/107289791/e0ce2cd4-91d1-4b06-abfa-d541c83671ff)


##### Instruções de acesso
1. Acesse o site pelo [Link](http://studytwogether-001-site1.itempurl.com)
2. Clicar na área de `Login` ou `Cadastro`.
3. Clicar no botão `Recuperar Senha`.
4. Digite o e-mail que deseja recuperar no campo.
5. Clique no botão `Recuperar Senha`. 
6. Aparecerá um pop-up na tela com uma mensagem, e será enviado um e-mail para a recuperação de senha para o e-mail preenchido caso tenha sido cadastrado.

##### Artefatos produzidos
* [Login.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Login.cshtml)
* [Cadastro.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Cadastro.cshtml)
* [RecuperarSenha.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/RecuperarSenha.cshtml)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)

