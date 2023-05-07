# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

## Avaliação
| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-01 - RF-06 | Verificar se o usuário consegue se cadastrar na aplicação. 
| Registro da tela: | ![image](https://user-images.githubusercontent.com/107289791/236533227-cf14162d-223f-4da5-a286-7bf8397fcac7.png) | Data do Teste: 06/05/2023 - Resultado: Positivo - O cadastro foi realizado com sucesso. | Alta |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-02 - RF-06 | Verificar se é impossível se cadastrar duas vezes com o mesmo e-mail. 
| Registro da tela:|  ![image](https://user-images.githubusercontent.com/107289791/236537356-19dff8b1-498d-44a1-95ec-30676545ca2e.png) | Data do Teste: 06/05/2023 - Resultado: Positivo - Aparece uma mensagem de erro informando que o usuário ja foi cadastrado | Alta | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-03 - RF-06 | Verificar se o usuário consegue realizar o Login na aplicação. 
| Registro da tela:| ![image](https://user-images.githubusercontent.com/107289791/236533227-cf14162d-223f-4da5-a286-7bf8397fcac7.png) | Data do Teste: 06/05/2023 - Resultado: Positivo - O Login foi realizado com sucesso. | Alta | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-04 - RF-06 | Verificar se o sistema impede a realização de login com campos em branco ou inválidos. 
| Registro da tela:| ![image](https://user-images.githubusercontent.com/107289791/236538716-f2d96097-497d-48c5-89a0-6759ebc4efac.png) | Data do Teste: 06/05/2023 - Resultado: Positivo - Aparece uma mensagem de erro caso todos os campos obrigatórios não estejam preenchidas. | Alta |  

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-05 - RF-10 | Verificar se o usuário cadastrado consegue redefinir sua senha esquecida. |    |    |
| Registro da tela: |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-06 - RF-10 | Verificar se a aplicação impede a recuperação de senha com um e-mail inválido. |    |    |
| Registro da tela: |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-07 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Perguntas por Eixo. |    |    |
| Registro da tela: | ![Pesquisa por Eixo](img/ct07filtroporeixo.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - Os Eixos ainda não foram inseridos para que o usuário possa selecioná-los. | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-08 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Perguntas por este Microfundamento. |    |    |
| Registro da tela: | ![Pesquisa por Microfundamentos](img/ct08filtropormicro.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - Os Microfundamentos ainda não foram inseridos para que o usuário possa selecioná-los. | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-09 - RF-02 | Verificar se o filtro por Categoria está fazendo a busca correta de Perguntas por essa categoria. |    |    |
| Registro da tela: | ![Pesquisa por Categorias](img/ct09filtroporcategoria.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - As Categorias ainda não foram inseridas para que o usuário possa selecioná-las. | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-11 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Interações por este Microfundamento. |    |    |
| Registro da tela: |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-13 - RF-02 | Verificar se o filtro por Eixo está fazendo a busca correta de Indicações por Eixo. | ||
| Registro da tela: |![Tela de Pesquisa de Indicações](https://user-images.githubusercontent.com/114435981/236685939-c5de9408-3bc7-4dda-b032-ba3be5bd577e.png)|Data do Teste: 06/05/2023 - Resultado: NEGATIVO - A funcionalidade dos filtros de pesquisa ainda não foram implementada.| Alta|

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-14 - RF-02 | Verificar se o filtro por Microfundamento está fazendo a busca correta de Indicações por Microfundamento. |    |    |
| Registro da tela: |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-15 - RF-02 | Verificar se o filtro por Categoria está fazendo a busca correta de Indicações por essa categoria. |    |    |
| Registro da tela:| ![Tela de Pesquisa de Indicações](https://user-images.githubusercontent.com/114435981/236685944-cbdbcf4f-9068-40f9-8def-04018985471c.png)|Data do Teste: 06/05/2023 - Resultado: NEGATIVO - A funcionalidade dos filtros de pesquisa ainda não foram implementada.| Alta|

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-16 - RF-05 | Verificar se a busca de perguntas por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |    |    |
| Registro da tela: | ![Pesquisa por Palavra Chave](img/ct16perguntabarradepesquisa.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - O botão de pesquisa não está funcionando. | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-17 - RF-05 | Verificar se a busca de interações por palavra chave digitada na barra de pesquisa está trazendo o resultado correto. |    |    |
| Registro da tela:| ![Tela de Pesquisa de Indicações](https://user-images.githubusercontent.com/114435981/236685944-cbdbcf4f-9068-40f9-8def-04018985471c.png)|Data do Teste: 06/05/2023 - Resultado: NEGATIVO - A funcionalidade dos filtros de pesquisa ainda não foram implementada.| Alta|

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-19 - RF-03 | Verificar se usuário consegue postar uma pergunta. |    |    |
| Registro da tela: | ![Postagem de Pergunta](img/ct19postagemdeperguntaconcluida.jpg) | Data do Teste: 06/05/2023 - Resultado: POSITIVO - O usuário consegue realizar a postagem de perguntas. | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-20 - RF-03 | Verificar se o usuário consegue postar sua pergunta mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |    |    |
| Registro da tela: | ![Postagem de Pergunta sem selecionar os campos "Categoria", "Eixo", "Microfundamento" e "Título".](img/ct20postagemsempreenchereixocategoriamicro.jpg) | Data do Teste: 06/05/2023 - Resultado: POSITIVO - O usuário consegue realizar a postagem de perguntas sem selecionar os campos “Categoria”, “Eixo”, “Microfundamento” e “Título”. | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-21 - RF-04 | Verificar se as respostas serão apresentadas corretamente junto às perguntas. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/3Y0pVvF.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possivel verificar se as respostas foram apresentadas corretamente.  | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-22 - RF-04 | Verificar se o campo de comentários no rodapé das interações está registrando adequadamente os comentários feitos. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/EzPwijN.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possivel verificar se o campo de comentários está registrando adequadamente os comentários feitos. | Grave |   

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-23 - RF-04 | Verificar se o campo de comentários no rodapé das indicações está registrando adequadamente os comentários feitos. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/oRM1Bpo.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possivel verificar se o campo de comentários das indicações está registrando adequadamente os comentários feitos. | Grave | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-24 - RF-01 | Verificar se as publicações estão sendo apresentadas na "Lista de Interações". |    |    |
| Registro da tela: |![Tela de Interações](https://user-images.githubusercontent.com/114435981/236686931-25264723-ae85-46f1-8d76-7b567f4e114d.png)|Data do teste: 06/05/2023 - Resultado Positivo - As publicações de interações estão sendo apresentadas na pagina correta.|Baixa|

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-25 - RF-01 | Verificar se o usuário consegue postar conteúdos mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |    |    |
| Registro da tela: | ![Postagem de Pergunta sem selecionar os campos "Categoria", "Eixo", "Microfundamento" e "Título".](img/ct25postagemsempreenchereixocategoriamicro2.jpg) | Data do Teste: 06/05/2023 - Resultado: POSITIVO - O usuário consegue realizar a postagem de conteúdos sem selecionar os campos “Categoria”, “Eixo”, “Microfundamento” e “Título”. | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-26 - RF-11 | Verificar se as postagens de indicações estão sendo apresentadas na "Lista de Indicações". |    |    |
| Registro da tela: | ![image](https://user-images.githubusercontent.com/96087622/236625920-4546a3d9-c931-4a82-8b53-4249ca0130fa.png) | Resultado Positivo - As postagens foram devidamente apresentadas - Data do Teste: 06/05/2023 | Sucesso |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-27 - RF-11 | Verificar se o usuário consegue postar conteúdos mesmo sem preencher todos os campos de “Categoria”, “Eixo”, “Microfundamento” e “Título”. |    |    
| Registro da tela: | ![image](https://user-images.githubusercontent.com/96087622/236625619-8361a81c-d85f-4f55-9607-88adbefc7595.png) | Resultado negativo - A aplicação não permitiu a postagem da indicação, mas não retornou nenhum erro ou aviso sobre os campos obrigatorios - Data do Teste: 06/05/2023 | Baixa |


| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-28 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: | ![Reagir com Emojis](img/ct28emojisnaoativos.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - O usuário não consegue reagir às perguntas com emojis. | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-29 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/3Y0pVvF.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possivel verificar a ativação dos emojis nas Respostas | Media | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-30 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: |![Interações](https://user-images.githubusercontent.com/114435981/236687776-74eb2daa-a0e8-4232-a2fd-0fe4b40a44c4.png)| Data do teste: 06/05/2023 - Os emojis estão sendo contabilizados corretamente, mas passará por nova validação| Média |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-31 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/EzPwijN.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possivel verificar a ativação dos emojis nos Comentários das Interações | Media | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-32 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: | ![image](https://user-images.githubusercontent.com/96087622/236626167-0ff8bc20-7530-4c99-acc1-ebc6e44f8375.png) | Data do Teste: 05/05/23 - Resultado Negativo - Foi possivel reagir a publicação, mas as unicas opções eram estrela e sorriso | Baixa |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-33 - RF-09 | Verificar se os emojis estão sendo ativados corretamente. |    |    |
| Registro da tela: | ![image](https://i.imgur.com/oRM1Bpo.png) | Data do Teste: 05/05/23 - Resultado Negativo - Não foi possivel verificar a ativação dos emojis nos Comentários das Indicações | Media | 

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-34 - RF-08 | Verificar se a aplicação está apresentando todas as Perguntas com as respectivas Respostas para todos os usuários, logados ou não. |    |    |
| Registro da tela: | ![Perguntas com respectivas respostas](img/ct34enviarresposta.jpg) | Data do Teste: 06/05/2023 - Resultado: NEGATIVO - O botão "Enviar" não está funcionando, logo não é possível enviar respostas para realizar o teste. | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-35 - RF-08 | Verificar se a aplicação está apresentando todas as interações com os respectivos comentários para todos os usuários, logados ou não. ||  |
| Registro da tela: |![Tela de Interações](https://user-images.githubusercontent.com/114435981/236688381-4dbd89c1-a14c-435d-8d75-17319a920356.png)|Data do teste: 06/05/2023 - As interações estão sendo apresentadas, no entanto os comentarios ainda não estão implementados| Grave|

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-36 - RF-08 | Verificar se a aplicação está apresentando todas as indicações com os respectivos comentários para todos os usuários, logados ou não. |    |    |
| Registro da tela: | ![image](https://user-images.githubusercontent.com/96087622/236626464-aef93303-b46c-48e4-a4f4-79b987197231.png) | Resultado Negativo - Não foram apresentadas todas as respostas respectivas a indicação - Data do Teste: 06/05/2023 | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-37 - RF-07 | Verificar se as interações do usuário estão sewndo apresentadas corretamente na página de Perfil do usuário. |  |  |
| Registro da tela: |![Tela Histórico - Com apresentação da Funcionalidade Histórico por Post](https://user-images.githubusercontent.com/114453508/236344419-f282cc48-f13f-474c-a6a9-8d836d1bc35a.png) |Data do Teste: 04/05/23 - Resultado Negativo - A tela Histórico não apresentou todos os históricos aguardados nas devidas abas. As Perguntas e Interações, vieram corretamente, porém, ao testar o input de uma Resposta ela não veio para o Histórico. Quanto a aba Favoritos ainda não veio nenhum resultado. AÇÃO DE CORREÇÃO: Realizar revisão do código da funcionalidade Post Resposta e implementar a funcionalidade de "Favoritar" | Grave |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-43 - RNF-02 - RNF-06 | Verificar se as telas estão sendo responsivas aos diversos tamanhos de tela. |    |    |
| Registro da tela: |![image](https://user-images.githubusercontent.com/114453508/236561619-4a6477e1-e225-4cca-a872-f4fdf662ee36.png) | Data do Teste: 05/05/23 - Resultado Negativo - A tela Histórico não apresentou uma responsividade satisfatória. AÇÃO DE CORREÇÃO: Realizar revisão do CSS com a aplicação do @Media para correção da superposição das telas em dimensões menores. | Médio |

| **ID** | **Descrição do teste** | **Descrição do resultado** | **Gravidade** |
|:---: |:---: |:---: |:---: |
| CT-44 - RNF-02 - RNF-06 | Verificar se o contraste dos elementos das telas estão com boa qualidade. |    |    |
| Registro da tela: |![image](https://user-images.githubusercontent.com/114453508/236567015-24cf3efc-453e-4309-948c-8e142ca7a0b8.png)| Data do Teste: 05/05/23 - Resultado Positivo - A Tela Editar Perfil apresentou uma qualidade satisfatória no contraste dos seus elementos. | - |

