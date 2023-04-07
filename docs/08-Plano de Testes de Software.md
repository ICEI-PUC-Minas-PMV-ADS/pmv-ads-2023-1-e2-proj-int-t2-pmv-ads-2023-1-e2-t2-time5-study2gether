# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Para a realização dos Testes de Software, adotaremos os seguintes requisitos:
 * Site publicado na Internet;
 * Navegador da Internet - Chrome, Firefox ou Edge;
 * Conectividade de Internet para acesso às plataformas.

Os Casos de Testes serão realizados utilizando dados Válidos e Inválidos, conforme descritos a seguir:

| **Caso de Teste** | CT-01 - Cadastre-se |
| **Requisito Associado** 	| RF-06 - A aplicação deve permitir ao usuário se cadastrar e realizar o login. |
|--|--|

| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-01 - Cadastre-se |RF-06 – A aplicação deve permitir ao usuário se cadastrar e realizar o login.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o usuário consegue se cadastrar na aplicação.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li>Clicar em "Cadastre-se"</li><li>Preencher os campos obrigatórios (e-mail, senha, confirmação de senha)</li><li>Clicar no botão "Cadastre-se"</li></ol> | A aplicação deve mostrar uma mensagem de erro descritiva|

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-01 - RF-06 | Verificar se o usuário consegue se cadastrar na aplicação. |    |    |
| Registro da tela | | 


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-02 - Cadastre-se |RF-06 – A aplicação deve permitir ao usuário se cadastrar e realizar o login.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se é impossível se cadastrar duas vezes com o mesmo email.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li>Clicar em "Cadastre-se"</li><li>Preencher o campo email com "aluno@sga.pucminas.br</li><li>Preencher os outros campos obrigatórios (senha, confirmação de senha)</li><li>Clicar em "Cadastrar-se"</li><li>Clicar em "Desconectar"</li><li>Clicar em "Cadastre-se"</li><li>Preencher o campo e-mail com o valor "aluno@sga.pucminas.br"</li><li>Preencher os outros campos obrigatórios (senha, confirmação de senha)</li><li>Clicar no botão "Cadastre-se"</li></ol> | A aplicação deve mostrar uma mensagem de erro descritiva|

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-02 - RF-06 | Verificar se é impossível se cadastrar duas vezes com o mesmo email. |    |    |
| Registro da tela: | 
 
 

> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
