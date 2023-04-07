# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Para a realização dos Testes de Software, adotaremos os seguintes requisitos:
 * Site publicado na Internet;
 * Navegador da Internet - Chrome, Firefox ou Edge;
 * Conectividade de Internet para acesso às plataformas.

Os Casos de Testes serão realizados utilizando dados Válidos e Inválidos, conforme descritos a seguir:

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
 
 
| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-03 - Fazer Login |RF-06 – A aplicação deve permitir ao usuário se cadastrar e realizar o login.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o usuário consegue realizar o Login na aplicação.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em “Login” ou “Entrar"</li><li>Preencher os campos obrigatórios (e-mail e senha)</li><li>Clicar em "Entrar"</li></ol> | O login foi realizado com sucesso. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-03 - RF-06 | Verificar se o usuário consegue realizar o Login na aplicação. |    |    |
| Registro da tela: |  


 
| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-04 - Fazer Login |RF-06 – A aplicação deve permitir ao usuário se cadastrar e realizar o login.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o sistema impede a realização de login com campos em branco ou inválidos.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em “Login” ou “Entrar"</li><li>Manter campo e-mail em branco</li><li>Preencher o campo senha</li>Clicar em "Entrar"</li></ol> | A aplicação deve demonstrar uma mensagem de login inválido. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-04 - RF-06 | Verificar se o sistema impede a realização de login com campos em branco ou inválidos. |    |    |
| Registro da tela: |  

| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-05 - Fazer Login |RF-10 – A aplicação deve permitir ao usuário recuperar sua senha.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o usuário cadastrado consegue redefinir sua senha esquecida.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em “Recuperar Senha”</li><li>Preencher os campos obrigatórios (e-mail cadastrado)</li><li>Clicar em "Redefinir Senha"</li><li>Acessar o e-mail cadastrado</><li>Clicar no link recebido</li><li>Preencher os campos obrigatórios (nova senha, repetir nova senha)</li><li>Clicar em "Redefinir Senha"</li></ol> | O usuário consegue redefinir sua senha e acessar a aplicação. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-05 - RF-10 | Verificar se o usuário cadastrado consegue redefinir sua senha esquecida. |    |    |
| Registro da tela: |

| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-06 - Fazer Login |RF-10 – A aplicação deve permitir ao usuário recuperar sua senha.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a aplicação impede a recuperação de senha com um e-mail inválido |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em “Recuperar Senha”</li><li>Preencher o campo e-mail com o valor "funcionário@gmail.com"</li><li>Clicar em "Redefinir Senha"</li></ol> | A aplicação deve mostrar uma mensagem de descritiva informando que o email não está cadastrado. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-06 - RF-10 | Verificar se a aplicação impede a recuperação de senha com um e-mail inválido. |    |    |
| Registro da tela: |

| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-07 - Fazer Login |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundamentos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Eixo está fazendo a busca correta de Perguntas por Eixo. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção “Perguntas”</li><li>Clicar no Filtro "Eixo"</li><li>Escolher "Eixo 2"</li><li>Clicar "Enter"</li></ol> | A aplicação filtrou corretamente as “Perguntas” que foram classificadas na postagem como sendo do Eixo 2 ou com uma mensagem que diga “A aplicação não encontrou perguntas classificada como sendo do Eixo 2, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-07 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Perguntas por Eixo. |    |    |
| Registro da tela: |







