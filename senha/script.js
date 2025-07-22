document.getElementById("formulario").addEventListener("submit", function(e){
    e.preventDefault(); //impede o envio tradicional do formulario

    const senha = document.getElementById("senha").value;

    if (senha === "123456") {
        document.getElementById("mensagem").textContent = "Senha correta!";
        document.getElementById("mensagem").style.color = "green";
    } else{
        document.getElementById("mensagem").textContent = "Senha incorreta.";
        document.getElementById("mensagem").style.color = "red";
    }
    console.log (textContent);
});
