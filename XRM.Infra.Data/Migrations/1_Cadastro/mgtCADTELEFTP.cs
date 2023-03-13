using System.Data.Entity.Migrations;
using XRM.Domain._0_Entities._01_Cadastro;
using XRM.Infra.Data._0_Context;

namespace XRM.Infra.Data.Migrations._1_Cadastro
{
    public class mgtCADTELEFTP
    {
        public static void AddOrUpdate(XRMContext context)
        {
            context.TBCADTELEFTP.AddOrUpdate(
                  new TBCADTELEFTP { TBCADTELEFTP_NM = "Outros", TBCADTELEFTP_DS = "Telefone sem classificação." }
                , new TBCADTELEFTP { TBCADTELEFTP_NM = "Residencial", TBCADTELEFTP_DS = "Telefone residencial." }
                , new TBCADTELEFTP { TBCADTELEFTP_NM = "Comercial", TBCADTELEFTP_DS = "Telefone comercial." }
                , new TBCADTELEFTP { TBCADTELEFTP_NM = "Celular", TBCADTELEFTP_DS = "Telefone celular." }
                , new TBCADTELEFTP { TBCADTELEFTP_NM = "Recado", TBCADTELEFTP_DS = "Telefone para recado." }
                , new TBCADTELEFTP { TBCADTELEFTP_NM = "Referencia", TBCADTELEFTP_DS = "Telefone de referencia." }
             );
        }
    }
}
