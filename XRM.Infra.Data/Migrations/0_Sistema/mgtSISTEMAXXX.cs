using System.Data.Entity.Migrations;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Infra.Data._0_Context;

namespace XRM.Infra.Data.Migrations._0_Sistema
{
    public class mgtSISTEMAXXX
    {
        public static void AddOrUpdate(XRMContext context)
        {
            context.TBSISTEMAXXX.AddOrUpdate(
                  new TBSISTEMAXXX { TBSISMODULOX_NS = 1, TBSISTEMAXXX_NM = "Consulta Modulo", TBSISTEMAXXX_DS = "Tela de consulda do modulo", TBSISTEMAXXX_VIEW = "CSSYSMODULOX", TBSISTEMAXXX_CONTROLLER = "ctlSYSMODULOX" }
                , new TBSISTEMAXXX { TBSISMODULOX_NS = 1, TBSISTEMAXXX_NM = "Detalhe Modulo", TBSISTEMAXXX_DS = "Tela de detalhe do modulo", TBSISTEMAXXX_VIEW = "DTSYSMODULOX", TBSISTEMAXXX_CONTROLLER = "ctlSYSMODULOX" }

             );

        }
    }
}
