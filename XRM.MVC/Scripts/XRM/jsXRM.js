//#region Variaveis Sistema

var sobjTraducao = new Array();

//#endregion Variaveis Sistema


//#region Configuração

$.ajaxSetup({
    type: 'post',
    dataType: 'json',
    cache: false,
    error: function (XMLHttpRequest, errorThrown) {
        if (XMLHttpRequest.status == 403 || XMLHttpRequest.responseText.indexOf('<html>') >= 0) {
            Loading(true);
            location.href = gstrGlobalPath + 'Login/Login/Index';
        } else {
            if (window.Loading) {
                Loading(false);
            }
            if (window.msgExibir) {
                msgExibir(errorThrown + '\n\n' + $(XMLHttpRequest.responseText).filter('title').get(0).innerText);
            }
        }
    },
    beforeSend: function (xhr) {
        var lobjToken = $('input[name=__RequestVerificationToken]').val();
        xhr.setRequestHeader('__RequestVerificationToken', lobjToken);
        if (window.Loading) {
            Loading(true);
        }
    },
    complete: function () {
        if (window.Loading) {
            Loading(false);
        }
    }
});

//#endregion Configuração

//#region Menu Sistema

$(document).ready(function () {

    if ($('#sidebarMenu').length > 0) {
        $.ajax({
            url: gstrGlobalPath + 'Global/RetornarMenu_Gerenciador',
            success: function (data, textStatus, XMLHttpRequest) {
                if (data.Exception != null) {
                    msgExibir(data.Exception);
                } else {
                    $('#sidebarMenu').html(data.TBUPMENU);
                }
            }
        });
    }

});



//#endregion Menu Sistema
