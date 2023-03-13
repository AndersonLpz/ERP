$(document).ready(function () {

    function Salvar_SISEMPRESA() {

        debugger;
        var lstrUrl = '/SISEMPRESA/Create'

        var lstrTBSISEMPRESA_NM = $('#TBSISEMPRESA_NM').val();
        var lstrTBSISEMPRESA_NM_FANTASIA = $('#TBSISEMPRESA_NM_FANTASIA').val();
        var lstrTBSISEMPRESA_DS = $('#TBSISEMPRESA_DS').val();
        var ldecTBSISEMPRESA_CPF_CNPJ = $('#TBSISEMPRESA_CPF_CNPJ').val();

        var lobjToken = $('input[name="__RequestVerificationToken"]').val();
        var lobjTokenadr = $('form[action="' + lstrUrl + '"] input[name="__RequestVerificationToken"]').val();
        var lobjHeaders = {};
        var lobjHeaderadr = {};

        lobjHeaders['__RequestVerificationToken'] = lobjToken;
        lobjHeaderadr['__RequestVerificationToken'] = lobjTokenadr;

        $.ajax({
            url: lstrUrl
            , type: 'POST'
            , dataType: 'json'
            , headers: lobjHeaderadr
            , data: {
                TBSISEMPRESA_NM: lstrTBSISEMPRESA_NM
                , TBSISEMPRESA_NM_FANTASIA: lstrTBSISEMPRESA_NM_FANTASIA
                , TBSISEMPRESA_DS: lstrTBSISEMPRESA_DS
                , TBSISEMPRESA_CPF_CNPJ: ldecTBSISEMPRESA_CPF_CNPJ
            }
            , success: function (data) {
                debugger;
                if (data.TBSISEMPRESA_NS > 0) {

                }
            }

        })


    }
});