using System.Data.Entity.Migrations;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Infra.Data._0_Context;

namespace XRM.Infra.Data.Migrations._0_Sistema
{
    public class mgtSISMODULOX
    {
        public static void AddOrUpdate(XRMContext context)
        {
            context.TBSISMODULOX.AddOrUpdate(
                  new TBSISMODULOX { TBSISMODULOX_NM = "Sistema", TBSISMODULOX_DS = "Modulo Sistema" }
                , new TBSISMODULOX { TBSISMODULOX_NM = "Atendimento", TBSISMODULOX_DS = "Modulo Atendimento" }
                , new TBSISMODULOX { TBSISMODULOX_NM = "Financeiro", TBSISMODULOX_DS = "Modulo Financeiro" }
                , new TBSISMODULOX { TBSISMODULOX_NM = "Cobrança", TBSISMODULOX_DS = "Modulo Cobrança" }
                , new TBSISMODULOX { TBSISMODULOX_NM = "Discador", TBSISMODULOX_DS = "Modulo Discador" }
                , new TBSISMODULOX { TBSISMODULOX_NM = "Relatório", TBSISMODULOX_DS = "Modulo Relatório" }
             );

        }
    }
}
