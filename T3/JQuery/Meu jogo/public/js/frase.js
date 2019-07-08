$("#botao-frase").click(fraseAleatoria);

function fraseAleatoria(){
    $("#spinner").toggle();
    
    $.get("http://localhost:3000/frases", trocaFrase).fail(function(){
        $("#erro").toggle();
        setTimeout(function(){
            $("#erro").toggle();
        },3000);
    })
    .always(function(){
        $("#spinner").toggle();
    });
}

function trocaFrase(data){
    var frase = $(".frase");
    var numeroAleatorio = Math.floor(Math.random() * data.length);
    frase.text(data[numeroAleatorio].texto);
    atualizaTempoInicial();
    atualizaTamanhoTempo(data[numeroAleatorio].tempo);
}