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


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-28 - Reagir às Perguntas. |RF-09 – A aplicação deve permitir ao usuário reagir com emojis. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se os emojis estão sendo ativados corretamente. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Perguntas"</li><li>Clicar no ícone de "Emojis" abaixo da pergunta e ecolher um "Emoji" de reação.</li></ol> | A aplicação apresentou o emoji corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-28 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-29 - Reagir às Respostas. |RF-09 – A aplicação deve permitir ao usuário reagir com emojis. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se os emojis estão sendo ativados corretamente. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Perguntas"</li><li>Clicar no ícone de "Diálogo" para ver as respostas de uma pergunta</li><li>Clicar no ícone de "Emojis" abaixo da Resposta e ecolha um "Emoji" de reação.</li></ol> | A aplicação apresentou o emoji corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-29 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-30 - Reagir às Interações. |RF-09 – A aplicação deve permitir ao usuário reagir com emojis. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se os emojis estão sendo ativados corretamente. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Interações"</li><li>Clicar no ícone de "Emojis" abaixo do Conteúdo selecionado e ecolha um "Emoji" de reação.</li></ol> | A aplicação apresentou o emoji corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-30 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-31 - Reagir aos Comentários das Interações. |RF-09 – A aplicação deve permitir ao usuário reagir com emojis. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se os emojis estão sendo ativados corretamente. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Interações"</li><li>Escolher um conteúdo na lista de interações </li><li>Escolher o primeiro comentário no rodapé do conteúdo </li><li> Clicar no ícone de "Emojis" e escolha um "Emoji" de reação.</li></ol> | A aplicação apresentou o emoji corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-31 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-32 - Reagir às Indicações. |RF-09 – A aplicação deve permitir ao usuário reagir com emojis. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se os emojis estão sendo ativados corretamente. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Indicações"</li><li>Clicar no ícone de "Emojis" abaixo do Conteúdo selecionado e ecolha um "Emoji" de reação.</li></ol> | A aplicação apresentou o emoji corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-32 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-33 - Reagir aos Comentários das Indicações. |RF-09 – A aplicação deve permitir ao usuário reagir com emojis. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se os emojis estão sendo ativados corretamente. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Fazer o Login</li><li>Clicar em "Indicações"</li><li>Escolher um conteúdo na lista de indicações </li><li>Escolher o primeiro comentário no rodapé do conteúdo </li><li> Clicar no ícone de "Emojis" e escolha um "Emoji" de reação.</li></ol> | A aplicação apresentou o emoji corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-33 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-34 - Visualização de todas as Perguntas com respectivas respostas. |RF-08 – A aplicação deve permitir visualizar todas as publicações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a aplicação está apresentando todas as Perguntas com as respectivas Respostas para todos os usuários, logados ou não. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em "Perguntas"</li><li>Escolher a primeira da listagem"</li><li>Clicar no ícone de "Diálogo" abaixo do título da pergunta para ver as respostas.</li></ol> | A aplicação apresentou os conteúdos para visualização sem limitações. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-34 - RF-08 | Verificar se a aplicação está apresentando todas as Perguntas com as respectivas Respostas para todos os usuários, logados ou não. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-35 - Visualização de todas as Interações com respectivos comentários. |RF-08 – A aplicação deve permitir visualizar todas as publicações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a aplicação está apresentando todas as interações com os respectivos comentários para todos os usuários, logados ou não. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em "Interações"</li><li>Clicar na primeira interação da listagem"</li><li>Visualizar os comentários no rodapé do conteúdo publicado.</li></ol> | A aplicação apresentou os conteúdos para visualização sem limitações. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-35 - RF-08 | Verificar se a aplicação está apresentando todas as interações com os respectivos comentários para todos os usuários, logados ou não. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-36 - Visualização de todas as Indicações com respectivos comentários. |RF-08 – A aplicação deve permitir visualizar todas as publicações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a aplicação está apresentando todas as indicações com os respectivos comentários para todos os usuários, logados ou não. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li> Clicar em "Indicações"</li><li>Clicar na primeira indicação da listagem"</li><li>Visualizar os comentários no rodapé do conteúdo publicado.</li></ol> | A aplicação apresentou os conteúdos para visualização sem limitações. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-36 - RF-08 | Verificar se a aplicação está apresentando todas as indicações com os respectivos comentários para todos os usuários, logados ou não. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-37 - Acesso ao feed com o histórico de interações feitas pelo usuário cadastrado. | RF-07 – A aplicação deve permitir ao usuário acesso a um feed com seu próprio histórico de interações. |

|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se as interações do usuário estão sewndo apresentadas corretamente na página de Perfil do usuário. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li>Fazer o Login </li><li> Clicar no ícone de usuário logado "no canto superior direito" para acessar o Perfil do Usuário</li><li>Na página do Perfil, clicar em "Perguntas", "Respostas", "Favoritos" para acessar o Histórico de interações</li><li>Verificar se as postagens feitas nos testes de publicação foram registradas no histórico.</li></ol> | A aplicação apresentou o Histórico corretamente. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-37 - RF-07 | Verificar se as interações do usuário estão sewndo apresentadas corretamente na página de Perfil do usuário. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-38 - Teste de Publicização. | RNF-01 – A aplicação deve ser publicada em um ambiente acessível publicamente na Internet. RNF-03 - A aplicação deve ser compatível com os principais navegadores do mercado.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a aplicação está publicada na internet e acessível pelo navegador Chrome. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li>Fazer o teste usando o navegador Chrome.</li></ol> | A aplicação foi acessada corretamente no navegador. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-38 - RNF-01 - RNF-03 | Verificar se a aplicação está publicada na internet e acessível pelo navegador Chrome. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-39 - Teste de Publicização. | RNF-01 – A aplicação deve ser publicada em um ambiente acessível publicamente na Internet. RNF-03 - A aplicação deve ser compatível com os principais navegadores do mercado.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a aplicação está publicada na internet e acessível pelo navegador Firefox. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li>Fazer o teste usando o navegador Firefox.</li></ol> | A aplicação foi acessada corretamente no navegador. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-39 - RNF-01 - RNF-03 | Verificar se a aplicação está publicada na internet e acessível pelo navegador Firefox. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-40 - Teste de Publicização. | RNF-01 – A aplicação deve ser publicada em um ambiente acessível publicamente na Internet. RNF-03 - A aplicação deve ser compatível com os principais navegadores do mercado.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a aplicação está publicada na internet e acessível pelo navegador Edge. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://study2gether.com/src/index.html)</li><li>Fazer o teste usando o navegador Edge.</li></ol> | A aplicação foi acessada corretamente no navegador. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-40 - RNF-01 - RNF-03 | Verificar se a aplicação está publicada na internet e acessível pelo navegador Edge. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-41 - Teste de Tempo de Resposta. | RNF-04 – O tempo de resposta do sistema não deve ser maior do que 30 segundos.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se o tempo de resposta da aplicação não será superior a 30 segundos. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://pagespeed.web.dev)</li><li>Inserir o endereço da tela de perguntas</li><li>Verificar o tempo de carregamento do conteúdo completo.</li></ol> | A aplicação atendeu os requisitos e a página carregou em menos de 30 segundos. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-41 - RNF-04 | Verificar se o tempo de resposta da aplicação não será superior a 30 segundos. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-42 - Teste de Acessibilidade. | RNF-05 - A aplicação deve estar acessível e sem interrupções por pelo menos 95% do tempo, apresentando um tempo de inatividade mínimo.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se a aplicação permanecerá acessível sem interrupções por pelo menos 95% do tempo. |<ol><li>Acessar o navegador</li><li>Acessar o provedor de Host da aplicação</li><li>Verificar o Uptime da aplicação.</li></ol> | A aplicação atendeu os requisitos e teve um uptime igual ou superior a 95%. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-42 - RNF-05 | Verificar se a aplicação permanecerá acessível sem interrupções por pelo menos 95% do tempo. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-43 - Teste de Responsividade e Contraste. | RNF-02 – A aplicação deverá ser responsiva permitindo a visualização em diversos dispositivos de forma adequada. RNF-06 - A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela e se o contraste dos elementos das telas estão com boa qualidade. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://search.google.com/test/mobile-friendly)</li><li>Inserir o endereço da tela inicial "Home-Page" da aplicação </li><li> Verificar se a página recebeu um resultado positivo e é compatível com dispositivos móveis </li><li>Informar o endereço da tela "Home-Page" </li><li> Verificar se contraste está dentro dos padrões.</li></ol> | As páginas apresentaram responsividade e bom contraste. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-43 - RNF-02 - RNF-06 | Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela e se o contraste dos elementos das telas estão com boa qualidade. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-44 - Teste de Responsividade e Contraste. | RNF-02 – A aplicação deverá ser responsiva permitindo a visualização em diversos dispositivos de forma adequada. RNF-06 - A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela e se o contraste dos elementos das telas estão com boa qualidade. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://search.google.com/test/mobile-friendly)</li><li>Inserir o endereço da tela de inicial da aplicação </li><li> Verificar se a página recebeu um resultado positivo e é compatível com dispositivos móveis </li><li>Informar o endereço da tela de "Perguntas" </li><li> Verificar se contraste está dentro dos padrões.</li></ol> | As páginas apresentaram responsividade e bom contraste. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-44 - RNF-02 - RNF-06 | Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela e se o contraste dos elementos das telas estão com boa qualidade. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-45 - Teste de Responsividade e Contraste. | RNF-02 – A aplicação deverá ser responsiva permitindo a visualização em diversos dispositivos de forma adequada. RNF-06 - A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela e se o contraste dos elementos das telas estão com boa qualidade. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://search.google.com/test/mobile-friendly)</li><li>Inserir o endereço da tela de Login da aplicação </li><li> Verificar se a página recebeu um resultado positivo e é compatível com dispositivos móveis </li><li>Informar o endereço da tela de "Login" </li><li> Verificar se contraste está dentro dos padrões.</li></ol> | As páginas apresentaram responsividade e bom contraste. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-45 - RNF-02 - RNF-06 | Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela e se o contraste dos elementos das telas estão com boa qualidade. |    |    |
| Registro da tela: |


| **Caso de teste** | **Requisitos Associados**|
|--|--|
|CT-46 - Teste de Responsividade e Contraste. | RNF-02 – A aplicação deverá ser responsiva permitindo a visualização em diversos dispositivos de forma adequada. RNF-06 - A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade.|


|Objetivo do teste| Passos | Critérios de êxito|
|-|-|-|
|Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela e se o contraste dos elementos das telas estão com boa qualidade. |<ol><li>Acessar o navegador</li><li>Informar o endereço do site (https://search.google.com/test/mobile-friendly)</li><li>Inserir o endereço da tela de registro da aplicação </li><li> Verificar se a página recebeu um resultado positivo e é compatível com dispositivos móveis </li><li>Informar o endereço da tela de "registro" </li><li> Verificar se contraste está dentro dos padrões.</li></ol> | As páginas apresentaram responsividade e bom contraste. |

Registro:
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-46 - RNF-02 - RNF-06 | Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela e se o contraste dos elementos das telas estão com boa qualidade. |    |    |
| Registro da tela: |
