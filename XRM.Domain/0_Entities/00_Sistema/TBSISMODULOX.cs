using System;
using System.Collections.Generic;

namespace XRM.Domain._0_Entities._00_Sistema
{
    /*
     * Tabela de cadastro do modulodo sistema
     */
    public class TBSISMODULOX
    {
        public int TBSISMODULOX_NS { get; set; }

        public string TBSISMODULOX_NM { get; set; }

        public string TBSISMODULOX_DS { get; set; }

        public DateTime TBSISMODULOX_DT_CAD { get; set; }

        public DateTime? TBSISMODULOX_DT_INA { get; set; }

        public virtual IEnumerable<TBSISTEMAXXX> TBSISTEMAXXX { get; set; }

        public virtual IEnumerable<TBSISUSPEMOD> TBSISUSPEMOD { get; set; }
    }
}
