$(document).ready(function () {

    var objSidebarMenu = document.getElementById('sidebarMenu');


    objSidebarMenu.addEventListener('click', function (e) {
        var lstrId = e.target.id.substring(1);
        var lintConfiguracao = lstrId.localeCompare("Configuracao");
        var lintAtendimento = lstrId.localeCompare("Atendimento");

        if (lintConfiguracao >= 0) {

            $("#aAtendimento").removeClass("active");
            $("#aAtendimento").addClass("active collapsed")
            $("#subMenuAtendimento").removeClass("show");

            $("#aFinanceiro").removeClass("active");
            $("#aFinanceiro").addClass("active collapsed")
            $("#subMenuFinanceiro").removeClass("show");

            $("#aCobranca").removeClass("active");
            $("#aCobranca").addClass("active collapsed")
            $("#subMenuCobranca").removeClass("show");

            $("#aRelatorio").removeClass("active");
            $("#aRelatorio").addClass("active collapsed")
            $("#subMenuRelatorio").removeClass("show");
        }

        if (lintAtendimento >= 0) {

            $("#aConfiguracao").removeClass("active");
            $("#aConfiguracao").addClass("active collapsed")
            $("#subMenuConfiguracao").removeClass("show");

            $("#aFinanceiro").removeClass("active");
            $("#aFinanceiro").addClass("active collapsed")
            $("#subMenuFinanceiro").removeClass("show");

            $("#aCobranca").removeClass("active");
            $("#aCobranca").addClass("active collapsed")
            $("#subMenuCobranca").removeClass("show");

            $("#aRelatorio").removeClass("active");
            $("#aRelatorio").addClass("active collapsed")
            $("#subMenuRelatorio").removeClass("show");
        }


    });

    /*objBody.addEventListener('click', function (e) {
        alert(e.target.id);
    });*/

    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    })

});