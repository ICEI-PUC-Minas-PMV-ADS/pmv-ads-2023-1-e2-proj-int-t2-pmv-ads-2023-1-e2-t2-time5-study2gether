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
|Verificar se o usuário consegue se cadastrar na aplicação.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li>Clicar em "Cadastre-se"</li><li>Preencher os campos obrigatórios (e-mail, senha, confirmação de senha)</li><li>Clicar no botão "Cadastrar-se"</li></ol> | A aplicação deve mostrar uma mensagem de erro descritiva|

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
|Verificar se é impossível se cadastrar duas vezes com o mesmo email.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li>Clicar em "Cadastre-se"</li><li>Preencher o campo email com "aluno@sga.pucminas.br</li><li>Preencher os outros campos obrigatórios (senha, confirmação de senha)</li><li>Clicar em "Cadastrar-se"</li><li>Clicar em "Desconectar"</li><li>Clicar em "Cadastre-se"</li><li>Preencher o campo e-mail com o valor "aluno@sga.pucminas.br"</li><li>Preencher os outros campos obrigatórios (senha, confirmação de senha)</li><li>Clicar no botão "Cadastrar-se"</li></ol> | A aplicação deve mostrar uma mensagem de erro descritiva|

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-02 - RF-06 | Verificar se é impossível se cadastrar duas vezes com o mesmo e-mail. |    |    |
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
|Verificar se o sistema impede a realização de login com campos em branco ou inválidos.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em “Login” ou “Entrar"</li><li>Manter campo e-mail em branco</li><li>Preencher o campo senha</li><li>Clicar em "Entrar"</li></ol> | A aplicação deve demonstrar uma mensagem de login inválido. |

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
|Verificar se o usuário cadastrado consegue redefinir sua senha esquecida.|<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em “Recuperar Senha”</li><li>Preencher os campos obrigatórios (e-mail cadastrado)</li><li>Clicar em "Redefinir Senha"</li><li>Acessar o e-mail cadastrado</li><li>Clicar no link recebido</li><li>Preencher os campos obrigatórios (nova senha, repetir nova senha)</li><li>Clicar em "Redefinir Senha"</li></ol> | O usuário consegue redefinir sua senha e acessar a aplicação. |

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
|CT-07 - Filtrar Pergunta por Eixo |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundamentos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Eixo está fazendo a busca correta de Perguntas por Eixo. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção “Perguntas”</li><li>Clicar no Filtro "Eixo"</li><li>Escolher "Eixo 2"</li><li>Clicar "Enter"</li></ol> | A aplicação filtrou corretamente as “Perguntas” que foram classificadas na postagem como sendo do Eixo 2 ou com uma mensagem que diga “A aplicação não encontrou perguntas classificada como sendo do Eixo 2, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-07 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Perguntas por Eixo. |    |    |
| Registro da tela: |

| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-08 - Filtrar Perguntas por Microfundamento |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundametos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Microfundamento está fazendo a busca correta de Perguntas por este Microfundamento. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Perguntas"</li><li>Clicar no Filtro "Microfundameto"</li><li>Escolher "Modelagem de Dados"</li><li>Clicar em "Enter"</li></ol> | A aplicação filtrou corretamente as “Perguntas” que foram classificadas na postagem como sendo do Microfundamento: Modelagem de Dados ou com uma mensagem que diga “A aplicação não encontrou perguntas classificadas como Modelagem de Dados, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-08 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Perguntas por este Microfundamento. |    |    |
| Registro da tela: |

| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-09 - Filtrar Perguntas por Microfundamento |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundametos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Categoria está fazendo a busca correta de Perguntas por essa categoria. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Perguntas"</li><li>Clicar no Filtro "Categoria"</li><li>Escolher "Fluxo de Classes"</li><li>Clicar em "Enter"</li></ol> | A aplicação filtrou corretamente as “Perguntas” que foram classificadas na postagem como sendo do Microfundamento: Modelagem de Dados ou com uma mensagem que diga “A aplicação não encontrou perguntas classificadas como Modelagem de Dados, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-09 - RF-02 | Verificar se o filtro por Categoria está fazendo a busca correta de Perguntas por essa categoria. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-10 - Filtrar Interações por Eixo |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundametos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Eixo está fazendo a busca correta de Interaçoes por Eixo. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Interações"</li><li>Clicar no Filtro "Eixo"</li><li>Escolher "Eixo 2"</li><li>Clicar em "Enter"</li></ol> | A aplicação filtrou corretamente as "Interações" que foram classificadas na postagem como sendo do Eixo 2 ou com uma mensagem que diga “A aplicação não encontrou interações classificada como sendo do Eixo 2, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-10 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Interaçoes por Eixo. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-11 - Filtrar Interações por Microfundamento |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundametos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Microfundamento está fazendo a busca correta de Interações por este Microfundamento. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Interações"</li><li>Clicar no Filtro "Microfundamento"</li><li>Escolher "Modelagem de Dados"</li><li>Clicar em "Enter"</li></ol> | A aplicação filtrou corretamente as "Interações" que foram classificadas na postagem como sendo do Microfundamento: Modelagem de Dados ou com uma mensagem que diga “A aplicação não encontrou interações classificadas como Modelagem de Dados, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-11 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Interações por este Microfundamento. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-12 - Filtrar Interações por Categoria |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundametos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Categoria está fazendo a busca correta de Interações por essa Categoria. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Interações"</li><li>Clicar no Filtro "Categoria"</li><li>Escolher "Fluxo de Classes"</li><li>Clicar em "Enter"</li></ol> | A aplicação filtrou corretamente as "Interações" que foram classificadas na postagem como sendo da Categoria: Fluxo de Classes ou com uma mensagem que diga “A aplicação não encontrou interações classificadas como Fluxo de Classes, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-12 - RF-02 | Verificar se o filtro por Categoria está fazendo a busca correta de Interações por essa Categoria. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-13 - Filtrar Indicações por Eixo |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundametos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Eixo está fazendo a busca correta de Indicações por Eixo. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Indicações"</li><li>Clicar no Filtro "Eixo"</li><li>Escolher "Eixo 2"</li><li>Clicar "Enter"</li></ol> | A aplicação filtrou corretamente as "Indicações" que foram classificadas na postagem como sendo do Eixo 2 ou com uma mensagem que diga “A aplicação não encontrou indicações classificada como sendo do Eixo 2, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-13 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Indicações por Eixo. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-14 - Filtrar Indicações por Microfundamento |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundametos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Microfundamento está fazendo a busca correta de Indicações por Microfundamento. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Indicações"</li><li>Clicar no Filtro "Microfundamento"</li><li>Escolher "Modelagem de Dados"</li><li>Clicar "Enter"</li></ol> | A aplicação filtrou corretamente as "Indicações" que foram classificadas na postagem como sendo do Microfundamento: Modelagem de Dados ou com uma mensagem que diga “A aplicação não encontrou indicações classificadas como Modelagem de Dados, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-14 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Indicações por Microfundamento. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-15 - Filtrar Indicações por Categoria |RF-02 – A aplicação deve apresentar um filtro por eixos ou por microfundametos.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o filtro por Categoria está fazendo a busca correta de Indicações por essa categoria. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Indicações"</li><li>Clicar no Filtro "Categoria"</li><li>Escolher "Fluxo de Classes"</li><li>Clicar "Enter"</li></ol> | A aplicação filtrou corretamente as "Indicações" que foram classificadas na postagem como sendo da Categoria: Fluxo de Classes ou com uma mensagem que diga “A aplicação não encontrou Indicações classificadas como Fluxo de Classes, tente com outro filtro”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-15 - RF-02 | Verificar se o filtro por Categoria está fazendo a busca correta de Indicações por essa categoria. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-16 - Pesquisar Perguntas por palavra chave na barra de pesquisa de campo de texto |RF-05 – A aplicação deve oferecer uma funcionalidade de pesquisa por campo de texto. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a busca de perguntas por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Perguntas"</li><li>Digitar "C#"</li><li>Clicar sobre a "Lupa" ou apenas clicar "Enter"</li></ol> | A aplicação apresentou corretamente as “Perguntas” que contenham a palavra chave pesquisada. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-16 - RF-05 | Verificar se a busca de perguntas por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-17 - Pesquisar Interaçoes por palavra chave na barra de pesquisa de campo de texto |RF-05 – A aplicação deve oferecer uma funcionalidade de pesquisa por campo de texto. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a busca de interações por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Interações"</li><li>Digitar "C#"</li><li>Clicar sobre a "Lupa" ou apenas clicar "Enter"</li></ol> | A aplicação apresentou corretamente as “Interações” que contenham a palavra chave pesquisada. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-17 - RF-05 | Verificar se a busca de interações por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-18 - Pesquisar Indicações por palavra chave na barra de pesquisa de campo de texto |RF-05 – A aplicação deve oferecer uma funcionalidade de pesquisa por campo de texto. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a busca de indicações por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Acessar a opção "Indicações"</li><li>Digitar "C#"</li><li>Clicar sobre a "Lupa" ou apenas clicar "Enter"</li></ol> | A aplicação apresentou corretamente as “Indicações” que contenham a palavra chave pesquisada. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-18 - RF-05 | Verificar se a busca de indicações por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-19 - Fazer Perguntas |RF-03 – A aplicação deve permitir ao usuário postar perguntas. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se usuário consegue postar uma pergunta. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Perguntas"</li><li>Clicar no ícone de "Acrescer"</li><li>Preencher os Campos: "Categoria", "Eixo", "Microfundamento", "Título da Pergunta" e então digitar a pergunta</li><li> Clicar em "Enter"</li></ol> | A aplicação apresentou esta pergunta na lista de perguntas. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-19 - RF-03 | Verificar se usuário consegue postar uma pergunta. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-20 - Fazer Perguntas |RF-03 – A aplicação deve permitir ao usuário postar perguntas. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o usuário consegue postar sua pergunta mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Perguntas"</li><li>Clicar no ícone de "Acrescer"</li><li>Não preencher os Campos: "Categoria", "Eixo", "Microfundamento"</li><li>Preencher os Campo "Título da Pergunta" e então digitar a pergunta</li><li> Clicar em "Enviar"</li></ol> | A aplicação deve retornar com o alerta de: “O preenchimento dos campos: Categoria, Título e Pergunta são obrigatórios. Já os campos: Eixo e Microfundamento são opcionais”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-20 - RF-03 | Verificar se o usuário consegue postar sua pergunta mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-21 - Responder Perguntas |RF-04 – A aplicação deve permitir ao usuário responder perguntas e publicações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se as respostas serão apresentadas corretamente junto às perguntas. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Perguntas"</li><li>Clicar no ícone de "Diálogo" abaixo da pergunta selecionada</li><li>Clicar no ícone de "Acrescer"</li><li>Digitar a resposta</li><li> Clicar em "Enviar"</li></ol> | A aplicação apresentou a resposta junto à pergunta corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-21 - RF-04 | Verificar se as respostas serão apresentadas corretamente junto às perguntas. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-22 - Responder Perguntas |RF-04 – A aplicação deve permitir ao usuário responder perguntas e publicações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o campo de comentários no rodapé das interações está registrando adequadamente os comentários feitos. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Interações"</li><li>Clicar no ícone de "Diálogo" abaixo da interação selecionada</li><li>Digitar o comentário</li><li> Clicar em "Enviar" ou "Enter"</li></ol> | A aplicação apresentou o comentário corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-22 - RF-04 | Verificar se o campo de comentários no rodapé das interações está registrando adequadamente os comentários feitos. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-23 - Comentar Indicações |RF-04 – A aplicação deve permitir ao usuário responder perguntas e publicações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o campo de comentários no rodapé das indicações está registrando adequadamente os comentários feitos. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Indicações"</li><li>Clicar no ícone de "Diálogo" abaixo da indicação selecionada</li><li>Digitar o comentário</li><li> Clicar em "Enviar" ou "Enter"</li></ol> | A aplicação apresentou o comentário corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-23 - RF-04 | Verificar se o campo de comentários no rodapé das indicações está registrando adequadamente os comentários feitos. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-24 - Publicação de Interações |RF-01 – A aplicação deve permitir ao usuário fazer publicações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se as publicações estão sendo apresentadas na "Lista de Interações". |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Interações"</li><li>Clicar no ícone de "Acrescer"</li><li>Preencher os Campos: "Categoria", "Eixo", "Microfundamento", "Título da Interação" e entāo entrar com o conteúdo a ser publicado</li><li> Clicar em "Enviar" </li></ol> | A aplicação apresentou o conteúdo na lista de interaçoes corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-24 - RF-01 | Verificar se as publicações estão sendo apresentadas na "Lista de Interações". |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-25 - Fazer Perguntas |RF-01 – A aplicação deve permitir ao usuário fazer publicações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o usuário consegue postar conteúdos mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Interações"</li><li>Clicar no ícone de "Acrescer"</li><li>Não preencher os Campos: "Categoria", "Eixo", "Microfundamento"</li><li>Preencher os Campo "Título da Publicaçāo e então incluir o conteúdo</li><li> Clicar em "Enviar"</li></ol> | A aplicação deve retornar com o alerta de: “O preenchimento dos campos: Categoria, Título e Pergunta são obrigatórios. Já os campos: Eixo e Microfundamento são opcionais”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-25 - RF-01 | Verificar se o usuário consegue postar conteúdos mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-26 - Publicação de Indicações |RF-11 – A aplicação deve permitir ao administrador inserir postagem de indicações de materiais relevantes.|

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se as postagens de indicações estão sendo apresentadas na "Lista de Indicações". |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Indicações"</li><li>Clicar no ícone de "Acrescer"</li><li>Preencher os Campos: "Categoria", "Eixo", "Microfundamento", "Título da Indicação" e entāo entrar com o conteúdo a ser publicado</li><li> Clicar em "Enviar" </li></ol> | A aplicação apresentou o conteúdo na lista de indicaçoes corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-26 - RF-11 | Verificar se as postagens de indicações estão sendo apresentadas na "Lista de Indicações". |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-27 - Publicação de Indicações sem preencher todos os campos. |RF-11 – A aplicação deve permitir ao administrador inserir postagem de indicações de materiais relevantes. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o usuário consegue postar conteúdos mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Indicações"</li><li>Clicar no ícone de "Acrescer"</li><li>Não preencher os Campos: "Categoria", "Eixo", "Microfundamento"</li><li>Preencher o Campo "Título da Publicaçāo" e então incluir o conteúdo</li><li> Clicar em "Enviar"</li></ol> | A aplicação deve retornar com o alerta de: “O preenchimento dos campos: Categoria, Título e Conteúdo são obrigatórios. Já os campos: Eixo e Microfundamento são opcionais”. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-27 - RF-11 | Verificar se o usuário consegue postar conteúdos mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |    |    |
| Registro da tela: |







