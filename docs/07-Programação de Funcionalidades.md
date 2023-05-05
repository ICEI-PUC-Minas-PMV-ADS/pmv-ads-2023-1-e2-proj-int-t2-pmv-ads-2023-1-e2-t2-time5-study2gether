# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

### Funcionalidade 01: Efetuar Cadastro	(RF-006)
A funcionalidade permite que o usuário realize com o cadastro na platarforma da `Study2gether`.

![image](https://user-images.githubusercontent.com/107289791/236481283-d9019ff0-20fd-4877-824b-591f0c52fa27.png)

##### Intruções de acesso
1. Acesse o site pelo [Link](a definir);
2. Clique no botão `Cadastre-se`;
3. Insira um `e-mail` com o formato `nome@sga.pucminas.br`;
4. Insira uma `senha` com ao menos 8 caracteres;
5. Clique no botão `Cadastrar`.

##### Artefatos produzidos
* [Cadastro.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Login.cshtml)
* [User.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Models/User.cs)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)


### Funcionalidade 02: Efetuar Login	(RF-006)
A funcionalidade permite que o usuário realize com sucesso o login na platarforma da `Study2gether`.

![image](https://user-images.githubusercontent.com/107289791/236481848-2788d278-4b83-44b6-951e-0d2e6676061d.png)

##### Intruções de acesso
1. Acesse o site pelo [Link](a definir);
2. Clique no botão "Login";
3. Insira e-mail e senha já cadastrados previamente;
4. Clique em "Login".

##### Artefatos produzidos
* [Login.cshtml](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Views/Users/Login.cshtml)
* [User.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Models/User.cs)
* [UsersController.cs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/blob/main/src/Study2gether/Study2gether/Controllers/UsersController.cs)
