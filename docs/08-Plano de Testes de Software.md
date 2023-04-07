# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Para a realização dos Testes de Software, adotaremos os seguintes requisitos:
 * Site publicado na Internet;
 * Navegador da Internet - Chrome, Firefox ou Edge;
 * Conectividade de Internet para acesso às plataformas.

Os Casos de Testes serão realizados utilizando dados Válidos e Inválidos, conforme descritos a seguir:
 
| **Caso de Teste** 	| **CT-01 – Cadastre-se** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-06 - RF-06 – A aplicação deve permitir ao usuário se cadastrar e realizar o login. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site (https://study2gether.com/src/index.html)<br> - Clicar em "Cadastre-se" <br> - Preencher os campos obrigatórios (e-mail, senha, confirmação de senha) <br> - Clicar no botão "Cadastre-se" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-01 | Verificar se o usuário consegue se cadastrar na aplicação. |    |    |
| Registro de tela | |
 
 

| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |


# Cadaster-se
|Caso de teste|Requisitos Associados|
|--|--|
|CT-01|RF-06 – A aplicação deve permitir ao usuário se cadastrar e realizar o login.|

|Objetivo do teste| Passos | Criterios de exito|
|-|-|-|
|Verificar se o usuário consegue se cadastrar na aplicação.|<ol><li>Acessar o navegador</li><li>informar o endereço do site [<](https://study2gether.com/src/index.html)/li><li>clicar em cadastre-se</li><li>preencher campos</li><li>clicar em cadastre-se</li></ol> | O cadastro foi realizado com sucesso|
|Verificar se o usuário consegue se cadastrar na aplicação.|<ol><li>Acessar o navegador</li><li>informar o endereço do site</li><li>clicar em cadastre-se</li><li>preencher campos</li><li>clicar em cadastre-se</li></ol> | O cadastro foi realizado com sucesso|

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
