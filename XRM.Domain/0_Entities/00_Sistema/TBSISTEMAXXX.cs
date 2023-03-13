using System;

namespace XRM.Domain._0_Entities._00_Sistema
{
    /*
     * Tabela de cadastro das telas do sistema
     */
    public class TBSISTEMAXXX
    {
        public int TBSISTEMAXXX_NS { get; set; }

        public string TBSISTEMAXXX_NM { get; set; }

        public string TBSISTEMAXXX_DS { get; set; }

        public DateTime TBSISTEMAXXX_DT_CAD { get; set; }

        public DateTime? TBSISTEMAXXX_DT_INA { get; set; }

        public string TBSISTEMAXXX_VIEW { get; set; }

        public string TBSISTEMAXXX_CONTROLLER { get; set; }

        public int TBSISMODULOX_NS { get; set; }

        public virtual TBSISMODULOX TBSISMODULOX { get; set; }
    }
}
