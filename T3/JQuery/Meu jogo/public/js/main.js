var tempoInicial = $("#tempo-digitacao").text();
var campo = $(".campo-digitacao");

$(function(){
    atualizaTamanhoFrase();
    incializaContadores();
    inicializaCronometro();
    inicializaMarcadores();
    $("#botao-reiniciar").click(reiniciaJogo);
});

function atualizaTempoInicial(tempo){
    tempoInicial = tempo;
    $("#tempo-digitacao").text(tempo);
}

function atualizaTamanhoFrase (){
    var frase = $(".frase").text();
    var numPalavras = frase.split(" ").length;
    var tamanhoFrase = $("#tamanho-frase");
    tamanhoFrase.text(numPalavras);
}

function incializaContadores(){
    campo.on("input", function(){
        var conteudo = campo.val();

        var qtdPalavras = conteudo.split(/\S+/).length -1;
        $("#contador-palavras").text(qtdPalavras);

        var qtdCaracteres = conteudo.length;
        $("#contador-caracteres").text(qtdCaracteres);

    });
}

function inicializaCronometro(){
    campo.one("focus", function(){
        var conometroID = setInterval(function(){
        var tempoRestante = $("#tempo-digitacao").text();
        tempoRestante--;
        console.log(tempoRestante);
        $("#tempo-digitacao").text(tempoRestante);
        if(tempoRestante < 1){
            clearInterval(conometroID);
            finalizaJogo();
        }
        },1000);
    });
}

function finalizaJogo(){
    campo.attr("disabled",true);
    campo.toggleClass("campo-disativado");
    inserePlacar();
}

function reiniciaJogo(){
    campo.attr("disabled",false);
    campo.val("");
    $("#contador-palavras").text("0");
    $("#contador-caracteres").text("0");
    $("#tempo-digitacao").text(tempoInicial);
    inicializaCronometro();
    campo.toggleClass("campo-desativado");
    campo.removeClass("campo-correto");
    campo.removeClass("campo-errado");
}
function inicializaMarcadores(){
    campo.on("input",function(){
        var frase = $(".frase").text();
        var digitado = campo.val();
        var comparavel = frase.substr(0,digitado.length);
        console.log("Digitado:" + digitado);
        console.log("Frase C.:" + comparavel);
        if(digitado == comparavel){
            campo.addClass("campo-correto");
            campo.removeClass("campo-errado");
        }else{
            campo.addClass("campo-errado");
            campo.removeClass("campo-correto");
        }
    });
}