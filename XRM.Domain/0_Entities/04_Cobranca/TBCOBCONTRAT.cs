using System;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Domain._0_Entities._04_Cobranca
{
    /*
     * Tabela de cadastro de Contrato.
     */
    public class TBCOBCONTRAT
    {
        public int TBCOBCONTRAT_NS { get; set; }

        public DateTime TBCOBCONTRAT_DT_CAD { get; set; }
        /*
         * Data de expiração do contrato
         * Quantos dias ele ira ficar na base pasa ser cobrado.
         */
        public DateTime? TBCOBCONTRAT_DT_INA { get; set; }

        public int TBCLIENTEXXX_NS { get; set; }

        public virtual TBCADCLIENTE TBCADCLIENTE { get; set; }

        public int TBCADCEDENTE_NS { get; set; }

        public virtual TBCADCEDENTE TBCADCEDENTE { get; set; }
        
        public int TBCOBSTATUSX_NS { get; set; }

        public virtual TBCOBSTATUSX TBCOBSTATUSX { get; set; }
    }
}
