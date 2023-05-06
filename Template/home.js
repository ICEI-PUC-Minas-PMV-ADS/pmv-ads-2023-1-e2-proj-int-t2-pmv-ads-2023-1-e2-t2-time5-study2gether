const meuBotao = document.getElementById("meu-botao");

meuBotao.addEventListener("mouseover", function() {
  meuBotao.textContent = "Fazer nova indicação";
});

meuBotao.addEventListener("mouseout", function() {
  meuBotao.textContent = "+";
});


