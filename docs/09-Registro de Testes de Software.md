# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

## Avaliação
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-01 - RF-06 | Verificar se o usuário consegue se cadastrar na aplicação. 
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/107289791/7970e251-dd45-4428-9727-05369ddf54da) | Data do Teste: 06/05/2023 - Resultado: Positivo - O cadastro foi realizado com sucesso. | Alta |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-02 - RF-06 | Verificar se é impossível se cadastrar duas vezes com o mesmo e-mail. 
| Registro da tela:| ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/107289791/8da95112-ba95-4e59-b604-6232effe4105) | Data do Teste: 06/05/2023 - Resultado: Positivo - Aparece uma mensagem de erro informando que o usuário ja foi cadastrado | Alta | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-03 - RF-06 | Verificar se o usuário consegue realizar o Login na aplicação. 
| Registro da tela:| ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/107289791/edd0e209-3183-46ba-b320-9cb915ce7fb5) | Data do Teste: 06/05/2023 - Resultado: Positivo - O Login foi realizado com sucesso. | Alta | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-04 - RF-06 | Verificar se o sistema impede a realização de login com campos em branco ou inválidos. 
| Registro da tela:| ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/107289791/d2227e9d-890b-4eb3-b6fc-72f184a41533) | Data do Teste: 06/05/2023 - Resultado: Positivo - Aparece uma mensagem de erro caso todos os campos obrigatórios não estejam preenchidas. | Media |  

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-05 - RF-10 | Verificar se o usuário cadastrado consegue redefinir sua senha esquecida. |    |    |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/107289791/bd900879-5a6a-439b-9fd1-b72718ea7086) | Data do Teste: 03/06/2023 - Resultado Positivo - A aplicação respondeu com um pop-up com uma mensagem "Caso o e-mail exista, você receberá um email com mais instruções em breve!" ao Clicar no Botão "Redefinir a senha". | Média |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-06 - RF-10 | Verificar se a aplicação impede a recuperação de senha com um e-mail inválido. |    |    |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/107289791/816b77a3-a593-43c8-a8ed-c4c8b757b9ef) | Data do Teste: 03/06/2023 - Resultado Positivo - A aplicação respondeu com um pop-up com uma mensagem "Caso o e-mail exista, você receberá um email com mais instruções em breve!" ao Clicar no Botão "Redefinir a senha".  | Média |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-07 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Perguntas por Eixo. |    |    |
| Registro da tela: | ![Pesquisa por Eixo](img/ct07filtroporeixo.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - Os Eixos ainda não foram inseridos para que o usuário possa selecioná-los. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/80646605-b8d8-4bc2-9f65-c983cff4613f) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A filtragem de Perguntas por Eixo ainda não está funcionando. Ação: Implementar a funcionalidade. | Grave |
| Registro da tela: | ![Pesquisa por Eixo](img/ct07rf02filtrodeperguntaporeixo.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - O usuário consegue filtrar as perguntas por Eixo. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-08 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Perguntas por este Microfundamento. |    |    |
| Registro da tela: | ![Pesquisa por Microfundamentos](img/ct08filtropormicro.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - Os Microfundamentos ainda não foram inseridos para que o usuário possa selecioná-los. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/b5b4df5f-2632-4edf-b6f5-e7b33503d68c) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A filtragem de Perguntas por Microfundamento ainda não está funcionando. Ação: Implementar a funcionalidade. | Grave |
| Registro da tela: | ![Pesquisa por Microfundamentos](img/ct08rf02filtropormicrofundamento.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - O usuário consegue filtrar as perguntas por Microfundamento. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-09 - RF-02 | Verificar se o filtro por Categoria está fazendo a busca correta de Perguntas por essa categoria. | | |
| Registro da tela: | ![Pesquisa por Categorias](img/ct09filtroporcategoria.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - As Categorias ainda não foram inseridas para que o usuário possa selecioná-las. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/96ccbec0-89e5-4da1-b505-37ceeba7d8e9) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A filtragem de Perguntas por Categoria ainda não está funcionando. Ação: Implementar a funcionalidade.| Grave |
| Registro da tela: | ![Pesquisa por Categorias](img/ct09rf02filtroporcategoria.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - O usuário consegue filtrar as perguntas por Categoria. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-10 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Interações por Eixo. |    |    |
| Registro da tela: |![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/f25098be-6b43-4393-b97c-f4fbb1d80907) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A página de Interações não pode ser acessada por uma excessão apontada, impossibilitando o teste de filtragem de Interações por Eixo. Ação: Tratar primeiro a excessão apontada e então testar se a filtragem está sendo apresentada corretamente.| Grave |
| Registro da tela:|![Filtro Eixo - Interacoes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/9477803b-cabc-4c8a-b9ca-3a7b6ebe7ac5)|Data do Teste: 26/05/2023 - Resultado: POSITIVO - A funcionalidade foi completamente implementada, sendo possivel ver as postagens pelo filtro de Eixo, e antes das postagens é apresentado qual filtro está ativo.| Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-11 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Interações por este Microfundamento. |    |    |
| Registro da tela: |![Filtro Microfundamento - Interacoes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/90fdb797-f765-4717-b934-481606d4ee29)|Data do Teste: 26/05/2023 - Resultado: POSITIVO - A funcionalidade foi completamente implementada, sendo possivel ver as postagens pelo filtro de Microfundamento, e antes das postagens é apresentado qual filtro está ativo.|Sucesso.|

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-12 - RF-02 | Verificar se o filtro por Categoria está fazendo a busca correta de Interações por essa Categoria. |    |    |
| Registro da tela: |![Filtro Cetegoria - Interacoes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/24609323-cd1e-4bc8-accd-a391b8f8f876)|Data do Teste: 26/05/2023 - Resultado: POSITIVO - A funcionalidade foi completamente implementada, sendo possivel ver as postagens pelo filtro de Categoria, e antes das postagens é apresentado qual filtro está ativo.|Sucesso|

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-13 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Indicações por Eixo. | | |
| Registro da tela: |![Tela de Pesquisa de Indicações](https://user-images.githubusercontent.com/114435981/236685939-c5de9408-3bc7-4dda-b032-ba3be5bd577e.png)|Data do Teste: 06/05/2023 - Resultado: NEGATIVO - A funcionalidade dos filtros de pesquisa ainda não foram implementada.| Alta|
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/553a8013-86d6-481c-8c9b-38bd24319aee) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A filtragem de Indicações por Eixo ainda não está funcionando. Ação: Implementar a funcionalidade.| Grave |
| Registro da tela: |![Filtro Eixo](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/23626def-75e7-45b6-a9e0-63397e2cc97d)|Data do Teste: 26/05/2023 - Resultado: POSITIVO - A funcionalidade foi completamente implementada, sendo possivel ver as postagens pelo filtro de eixo, e antes das postagens é apresentado qual filtro está ativo.| Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-14 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Indicações por Microfundamento. |    |    |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/11704e33-8d85-4222-9a93-a56d3b9ce3a9) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A filtragem de Indicações por Microfundamento ainda não está funcionando. Ação: Implementar a funcionalidade.| Grave |
| Registro da tela: |![Filtro Microfundamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/9e0b0415-80d3-4b17-b75e-61e14b61ddc5)|Data do Teste: 26/05/2023 - Resultado: POSITIVO - A funcionalidade foi completamente implementada, sendo possivel ver as postagens pelo filtro de microfundamento, e antes das postagens é apresentado qual filtro está ativo.| Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-15 - RF-02 | Verificar se o filtro por Categoria está fazendo a busca correta de Indicações por essa categoria. |    |    |
| Registro da tela:| ![Tela de Pesquisa de Indicações](https://user-images.githubusercontent.com/114435981/236685944-cbdbcf4f-9068-40f9-8def-04018985471c.png)|Data do Teste: 06/05/2023 - Resultado: NEGATIVO - A funcionalidade dos filtros de pesquisa ainda não foram implementada.| Alta|
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/ab91c200-6876-4b15-9acc-2abe70425c0b) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A filtragem de Indicações por Categoria ainda não está funcionando. Ação: Implementar a funcionalidade.| Grave |
| Registro da tela:|![Filtro Categoria](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/c64e50f3-5253-4120-b5fc-a8eb484bded6)|Data do Teste: 26/05/2023 - Resultado: POSITIVO - A funcionalidade foi completamente implementada, sendo possivel ver as postagens pelo filtro de categoria, e antes das postagens é apresentado qual filtro está ativo.| Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-16 - RF-05 | Verificar se a busca de perguntas por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |    |    |
| Registro da tela: | ![Pesquisa por Palavra Chave](img/ct16perguntabarradepesquisa.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - O botão de pesquisa não está funcionando. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/94225353-7c1e-4ade-af74-f039deab1ab7) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - Ao fazer pesquisa com palavras chaves, como por exemplo "adequadamente" a aplicação até buscou as postagens que apresentam essa palavra, no entanto buscou do banco de dados de "Interações" | Grave |
| Registro da tela: | ![Filtro Perguntas ](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/0e0d9994-3494-480d-8212-1c0bcd41d94f)| Data do Teste: 24/05/2023 - Resultado: POSITIVO -  O campo de pesquisa está funcionando perfeitamente. Foi inserido a palavra css e feito uma busca em titulo e conteudo, e foi mostrado apenas as publicações que continham o texto pesquisado. | Baixa |
| Registro da tela: | ![Pesquisa por Palavra Chave](img/ct16rf05buscadeperguntasporpalavrachave.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - O usuário consegue realizar uma pesquisa de busca por palavra chave na barra de pesquisa. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-17 - RF-05 | Verificar se a busca de interações por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |    |    |
| Registro da tela:| ![Tela de Pesquisa de Indicações](https://user-images.githubusercontent.com/114435981/236685944-cbdbcf4f-9068-40f9-8def-04018985471c.png)| Data do Teste: 06/05/2023 - Resultado: NEGATIVO - A funcionalidade dos filtros de pesquisa ainda não foram implementada.| Alta|
| Registro da tela:| ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/1b14a422-747f-4cfb-8ea0-b100a72bd040) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A página de Interações não pode ser acessada por uma excessão apontada, impossibilitando o teste de filtragem de Interações por por palavra chave. Ação: Tratar primeiro a excessão apontada e então testar se a filtragem por palavra chave.| Grave |
| Registro da tela:| ![Filtro Interações](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/bf997d97-b8f3-41c4-9c48-ac08f3ba6ceb)|Data do Teste: 24/05/2023 - Resultado: POSITIVO -  O campo de pesquisa está funcionando perfeitamente. Foi inserido a palavra teste e feito uma busca em titulo e conteudo, e foi mostrado apenas as publicações que continham o texto pesquisado.| Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-18 - RF-05 | Verificar se a busca de indicações por palavra chave digitada na barra de pesquisa está trazendo o resultado correto.   |    |    |
| Registro da tela: |![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/c3b9cfe8-8e6a-4c57-866a-156a70d0b548) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - Ao fazer pesquisa com palavras chaves, como por exemplo "Testando" a aplicação buscou todas as postagens que apresentam essa palavra, no entanto buscou do banco de dados de "Interações". Ação: Corrigir a função de busca. | Grave |
| Registro da tela: |![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/d33238dc-d244-4e69-bb03-5f567bb11845) | Data do Teste: 01/06/2023 - Resultado: POSITIVO - Ao fazer pesquisa com palavras chaves, como por exemplo "C#" a aplicação buscou todas as postagens que apresentam essa palavra, na área de "Interações". | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-19 - RF-03 | Verificar se usuário consegue postar uma pergunta. |    |    |
| Registro da tela: | ![Postagem de Pergunta](img/ct19rf03postarumapergunta.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - O usuário consegue realizar a postagem de perguntas. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-20 - RF-03 | Verificar se a aplicação impede que o usuário poste perguntas sem os campos obrigatórios, “Categoria”, “Título” e "Pergunta". |    |    |
| Registro da tela: | ![Postagem de Pergunta sem selecionar os campos "Categoria", "Eixo", "Microfundamento" e "Título".](img/ct20postagemsempreenchereixocategoriamicro.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - O usuário consegue realizar a postagem de perguntas sem selecionar os campos “Categoria”, “Eixo”, “Microfundamento” e “Título”. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/a97e8086-2418-481d-a6b8-c234761fbdf6) | Data do Teste: 21/05/2023 - Resultado: POSITIVO - O usuário não consegue realizar a postagem de perguntas. | Grave |
| Registro da tela: | ![Postagem de Pergunta sem selecionar os campos "Categoria", "Eixo", "Microfundamento" e "Título".](img/ct20rf03postarsuaperguntasemeixocategoriaoumicrofundamento.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - O usuário não consegue realizar a postagem de perguntas sem selecionar os campos “Categoria”, “Título” e "Conteúdo". | Sucesso |
| Registro da tela: | ![Postagem de Pergunta sem selecionar os campos "Categoria", "Eixo", "Microfundamento" e "Título".](ct20rf03.jpg) | Data do Teste: 02/06/2023 - Resultado: POSITIVO - O usuário não consegue realizar a postagem de perguntas sem selecionar os campos “Categoria”, “Título” e "Conteúdo", a aplicação impede que o usuário poste perguntas sem preencher todos os campos obrigatórios. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-21 - RF-04 | Verificar se as respostas serão apresentadas corretamente junto às perguntas. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/3Y0pVvF.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possível verificar se as respostas foram apresentadas corretamente.  | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/377410ed-7952-4b4b-b043-45777dd333f6) | Data do Teste: 21/05/23 - Resultado POSITIVO - Foi possível visualizar as respostas postadas anteriormente para aquela pergunta.  | - |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-22 - RF-04 | Verificar se o campo de comentários no rodapé das interações está registrando adequadamente os comentários feitos. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/EzPwijN.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possÍvel verificar se o campo de comentários está registrando adequadamente os comentários feitos. | Grave |   
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/77f284b3-b38f-45f7-accc-7f7c46a06e38) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A página de Interações não pode ser acessada por uma excessão apontada, impossibilitando a verificação se os comentários estão sendo apresentados abaixo do conteúdo publicado adequadamente. Ação: Tratar primeiro a excessão apontada e então verificar se os comentários estão sendo apresentados corretamente.| Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-23 - RF-04 | Verificar se o campo de comentários no rodapé das indicações está registrando adequadamente os comentários feitos. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/oRM1Bpo.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possível verificar se o campo de comentários das indicações está registrando adequadamente os comentários feitos. | Grave | 
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/31ddc12a-53fb-43c7-8222-b541db2947df) | Data do Teste: 21/05/23 - Resultado NEGATIVO - O registro do comentário feito no campo indicado no rodapé das indicações não foi apresentado junto aos comentários feitos anteriormente. Ação: Revisar o código e corrigí-lo | Grave | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-24 - RF-01 | Verificar se as publicações estão sendo apresentadas na "Lista de Interações". |    |    |
| Registro da tela: |![Tela de Interações](https://user-images.githubusercontent.com/114435981/236686931-25264723-ae85-46f1-8d76-7b567f4e114d.png)|Data do teste: 06/05/2023 - Resultado Positivo - As publicações de interações estão sendo apresentadas na pagina correta.|Baixa|
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/77f284b3-b38f-45f7-accc-7f7c46a06e38) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A página de Interações não pode ser acessada por uma excessão apontada, impossibilitando verificar se as postagens de interações estão sendo apresentadas na "Lista" corretamente. Ação: Tratar primeiro a excessão apontada e então verificar se as postagens são apresentadas corretamente. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/67608b06-ac43-49b2-86aa-bcfb50b72c19) | Data do Teste: 01/06/2023 - Resultado: POSITIVO - A página de Interações apresentou corretamente na sua listagem as postagens corretas. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-25 - RF-01 | Verificar se aplicação impede que o usuário poste conteúdos sem preencher todos os campos obrigatórios de “Categoria”, “Título” e "Conteúdo". |    |    |
| Registro da tela: | ![Postagem de Pergunta sem selecionar os campos “Categoria”, “Título” e "Conteúdo".](img/ct25postagemsempreenchereixocategoriamicro2.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - O usuário consegue realizar a postagem de conteúdos sem selecionar os campos “Categoria”, “Título” e "Conteúdo", a aplicação não impede que o usuário poste conteúdos sem preencher todos os campos obrigatórios. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/77f284b3-b38f-45f7-accc-7f7c46a06e38) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A página de Interações não pode ser acessada por uma excessão apontada, não sendo possível efetuar o teste de postagem de conteúdo "Interações". Ação: Tratar primeiro a excessão apontada e então verificar se está sendo possível registrar Interações mesmo sem preencher os campos obrigatórios. | Grave |
| Registro da tela: | ![Postagem de Pergunta sem selecionar os campos “Categoria”, “Título” e "Conteúdo".](img/ct25rf01postarconteúdosemeixocategoriaoumicrofundamento.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - O usuário não consegue realizar a postagem de conteúdos sem selecionar os campos “Categoria”, “Título” e "Conteúdo", aplicação impede que o usuário poste conteúdos sem preencher todos os campos obrigatórios. | Sucesso |
| Registro da tela: | ![Postagem de Pergunta sem selecionar os campos “Categoria”, “Título” e "Conteúdo".](img/ct25rf01postarconteúdosemeixocategoriatitulo.png) | Data do Teste: 01/06/2023 - Resultado: POSITIVO - O usuário não consegue realizar a postagem de conteúdos sem selecionar os campos “Categoria”, “Título” e "Conteúdo", a aplicação impede que o usuário poste conteúdos sem preencher todos os campos obrigatórios. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-26 - RF-11 | Verificar se as postagens de indicações estão sendo apresentadas na "Lista de Indicações". |    |    |
| Registro da tela: | ![image](https://user-images.githubusercontent.com/96087622/236625920-4546a3d9-c931-4a82-8b53-4249ca0130fa.png) | Resultado Positivo - As postagens foram devidamente apresentadas - Data do Teste: 06/05/2023 | Sucesso 
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/d288e297-592c-4ec8-9927-cb3a9e4f232b) | Data do Teste: 21/05/2023 - Resultado Positivo - As postagens foram apresentadas corretamente | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-27 - RF-11 | Verificar se a aplicação impede que o usuário poste conteúdos sem preencher todos os campos obrigatórios de “Categoria”, “Título” e "Conteúdo". |   |   |    
| Registro da tela: | ![image](https://user-images.githubusercontent.com/96087622/236625619-8361a81c-d85f-4f55-9607-88adbefc7595.png) | Resultado Negativo - A aplicação não permitiu a postagem da indicação, mas não retornou nenhum erro ou aviso sobre os campos obrigatórios - Data do Teste: 06/05/2023 | Baixa |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/61ba2738-f8c0-4405-9f53-f227694562f5) | Data do Teste: 21/05/2023 - Resultado Negativo - A aplicação não restringiu a postagem da indicação faltando dados obrigatórios. Ação: Implementar "Restrições" e informar o usuário da necessidade de preencher os campos obrigatórios. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/b3f80282-8b49-4fa5-b354-4edda3d28a3b) | Data do Teste: 01/06/2023 - Resultado Positivo - A aplicação restringiu a postagem da indicação faltando dados obrigatórios e apresentou um popup acusando a necessidade do preenchimento. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-28 - RF-09 | Verificar se os emojis estão sendo ativados corretamente ao reagir às Perguntas. |    |    |
| Registro da tela: | ![Reagir com Emojis](img/ct28emojisnaoativos.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - O usuário não consegue reagir às perguntas com emojis. | Grave |
| Registro da tela: | ![Captura de tela 2023-05-16 220427](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/87c4ba02-f98b-4bd3-845f-1d21d2510674)| Data do Teste: 16/05/23 - Resultado Positivo - O usuário pode reagir às Perguntas com emojis | - | 
| Registro da tela: | ![Reagir com Emojis](img/ct28rf09emojisestaosendoativadoscorretamente..jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - O usuário consegue reagir às perguntas com emojis. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-29 - RF-09 | Verificar se os emojis estão sendo ativados corretamente ao reagir às Interações. |    |    |
| Registro da tela: |![Interações](https://user-images.githubusercontent.com/114435981/236687776-74eb2daa-a0e8-4232-a2fd-0fe4b40a44c4.png)| Data do teste: 06/05/2023 - Os emojis estão sendo contabilizados corretamente, mas passará por nova validação| Média |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/77f284b3-b38f-45f7-accc-7f7c46a06e38) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A página de Interações não pode ser acessada por uma excessão apontada, não sendo possível verificar se os emojis estão sendo ativados corretamente ao reagir às "Interações". Ação: Tratar primeiro a excessão apontada e então verificar se a reação com emojis está sendo ativada corretamente. | Grave |
| Registro da tela: |![Emojis de Interacoes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/7826faa9-be8f-4bb8-b2bb-43057180a1ab)| Data do teste: 26/05/2023 - Resultado: POSITIVO - Os emojis estão sendo contabilizados corretamente, e é possivel visualizar os emojis que foram adicionados no footer da publicação.| Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-30 - RF-09 | Verificar se os emojis estão sendo ativados corretamente ao regir às Indicações. |    |    |
| Registro da tela: | ![image](https://user-images.githubusercontent.com/96087622/236626167-0ff8bc20-7530-4c99-acc1-ebc6e44f8375.png) | Data do Teste: 05/05/23 - Resultado Negativo - Foi possivel reagir a publicação, mas as unicas opções eram estrela e sorriso | Baixa |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/81dad345-65a2-4f65-b808-bcab6e7de185) | Data do Teste: 21/05/23 - Resultado POSITIVO - Foi possível reagir a publicação com o Emoji escolhido. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-31 - RF-08 | Verificar se a aplicação está apresentando todas as Perguntas com as respectivas Respostas para todos os usuários, logados ou não. |    |    |
| Registro da tela: | ![Perguntas com respectivas respostas](img/ct34enviarresposta.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - O botão "Enviar" não está funcionando, logo não é possível enviar respostas para realizar o teste. | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/dadaec90-1ba0-4831-a291-9218df907de3)| Data do Teste: 21/05/2023 - Resultado: POSITIVO - As respostas estão sendo apresentadas logo abaixo da Pergunta, tanto para o usuário logado quanto não logado. | - |
| Registro da tela: | ![Perguntas com respectivas respostas](img/ct34rf08usuariologado.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - A aplicação está apresentando todas as perguntas com os respectivos comentários para usuários "logados", e ele consegue visualizar as repostas. | Sucesso |
| Registro da tela: | ![Perguntas com respectivas respostas](img/ct34rf08usuarionaologado.jpg) | Data do Teste: 27/05/2023 - Resultado: POSITIVO - A aplicação está apresentando todas as perguntas com os respectivos comentários para usuários "não logados", e ele consegue visualizar as repostas. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-32 - RF-08 | Verificar se a aplicação está apresentando todas as interações com os respectivos comentários para todos os usuários, logados ou não. ||  |
| Registro da tela: |![Tela de Interações](https://user-images.githubusercontent.com/114435981/236688381-4dbd89c1-a14c-435d-8d75-17319a920356.png)|Data do teste: 06/05/2023 - As interações estão sendo apresentadas, no entanto os comentarios ainda não estão implementados| Grave|
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/77f284b3-b38f-45f7-accc-7f7c46a06e38) | Data do Teste: 21/05/2023 - Resultado: NEGATIVO - A página de Interações não pode ser acessada por uma excessão apontada, não sendo possível verificar se as interações com os respectivos comentários estão sendo apresentados para todos os usuários, logados ou não. Ação: Tratar primeiro a excessão apontada e então verificar se as postagem estão sendo apresentadas a todos os usuários com os seus respectivos comentários. | Grave |
| Registro da tela: |![Respostas de Interações](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114435981/ec370078-7e1e-4f0b-9701-1d7bb0889548)|Data do teste: 24/05/2023 - As interações estão sendo apresentadas, e ao clicar no titulo da interação, é possivel visualizar a respostas referente á publicação|Baixa|
| Registro da tela: |![Respostas de Interações](img/CT32RF08usuariologado.jpg)|Data do teste: 02/06/2023 - Resultado: POSITIVO - A aplicação está apresentando todas as interações com os respectivos comentários para usuários "logados", e ele consegue visualizar as repostas. | Sucesso |
| Registro da tela: |![Respostas de Interações](img/CT32RF08usuarionaologado.jpg)|Data do teste: 02/06/2023 - Resultado: POSITIVO - A aplicação está apresentando todas as interações com os respectivos comentários para usuários "não logados", e ele consegue visualizar as repostas. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-33 - RF-08 | Verificar se a aplicação está apresentando todas as indicações com os respectivos comentários para todos os usuários, logados ou não. |    |    |
| Registro da tela: | ![image](https://user-images.githubusercontent.com/96087622/236626464-aef93303-b46c-48e4-a4f4-79b987197231.png) | Resultado Negativo - Não foram apresentadas todas as respostas respectivas a indicação - Data do Teste: 06/05/2023 | Grave |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/a0719257-8a69-4d74-8684-d8f286ab9069) | Data do Teste: 21/05/2023 - Resultado Positivo - A aplicação apresentou todas as indicações com os respectivos comentários para os usuários logados.| - |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/34518b08-cf8e-4d2a-a1cf-1a21d45a3b83) | Data do Teste: 21/05/2023 - Resultado Positivo - A aplicação apresentou todas as indicações com os respectivos comentários para os usuários não logados, também.| Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-34 - RF-07 | Verificar se as interações do usuário estão sendo apresentadas corretamente na página de Perfil do usuário. |  |  |
| Registro da tela: |![Tela Histórico - Com apresentação da Funcionalidade Histórico por Post](https://user-images.githubusercontent.com/114453508/236344419-f282cc48-f13f-474c-a6a9-8d836d1bc35a.png) |Data do Teste: 04/05/23 - Resultado Negativo - A tela Histórico não apresentou todos os históricos aguardados nas devidas abas. As Perguntas e Interações, vieram corretamente, porém, ao testar o input de uma Resposta ela não veio para o Histórico. Quanto a aba Favoritos ainda não veio nenhum resultado. AÇÃO DE CORREÇÃO: Realizar revisão do código da funcionalidade Post Resposta e implementar a funcionalidade de "Favoritar" | Grave |
| Registro da tela: |![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/53580704-7f74-43b3-b6e9-e888c39c4c2d) |Data do Teste: 16/05/23 - Resultado Positivo - A tela Histórico apresentou todas as ações de Postagens e Favoritados conforme planejado nas devidas abas, com a formatação adequada e com o link no título levando o usuário ao Post na tela de origem, possibilitando sua leitura completa. Foi realizado a implementação da funcionalidade de "Favoritar" aqueles conteúdos e postagens de interesse. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-35 - RNF-01 e RNF-03 | Verificar se a aplicação está publicada na internet e acessível pelo navegador Chrome. |    |    |
| Registro da tela: | | | |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-36 - RNF-01 e RNF-03 | Verificar se a aplicação está publicada na internet e acessível pelo navegador Firefox. |    |    |
| Registro da tela: | | | |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-37 - RNF-01 e RNF-03 | Verificar se a aplicação está publicada na internet e acessível pelo navegador Edge. |    |    |
| Registro da tela: | | | |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-38 - RNF-04 | Verificar se o tempo de resposta da aplicação não será superior a 30 segundos. |    |    |
| Registro da tela: | | | |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-39 - RNF-05 | Verificar se a aplicação permanecerá acessível sem interrupções por pelo menos 95% do tempo. |    |    |
| Registro da tela: | | | |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-40 - RNF-02 - RNF-06 | Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela. |    |    |
| Registro da tela: |![image](https://user-images.githubusercontent.com/114453508/236561619-4a6477e1-e225-4cca-a872-f4fdf662ee36.png) | Data do Teste: 05/05/23 - Resultado Negativo - A tela Histórico não apresentou uma responsividade satisfatória. AÇÃO DE CORREÇÃO: Realizar revisão do CSS com a aplicação do @Media para correção da superposição das telas em dimensões menores. | Médio |
| Registro da tela: |![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/b91afb8e-3e7c-4ce7-a300-be01d15c6eaf)| Data do Teste: 16/05/23 - Resultado Positivo - A tela Histórico apresentou uma responsividade satisfatória. | Sucesso |
| Registro da tela: | ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-pmv-ads-2023-1-e2-t2-time5-study2gether/assets/114453508/27376627-b7ff-42ac-a732-cc432364b4a6) | Data do Teste: 01/06/23 - Resultado Positivo - O teste da URL foi feito no site mobile-friendly test o resultado foi de sucesso. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-41 - RNF-02 - RNF-06 | Verificar se o contraste dos elementos das telas estão com boa qualidade. |    |    |
| Registro da tela: |![image](https://user-images.githubusercontent.com/114453508/236567015-24cf3efc-453e-4309-948c-8e142ca7a0b8.png)| Data do Teste: 05/05/23 - Resultado Positivo - A Tela Editar Perfil apresentou uma qualidade satisfatória no contraste dos seus elementos. | Sucesso |

