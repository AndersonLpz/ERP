using System;

namespace XRM.Domain._0_Entities._04_Cobranca
{
    /*
     * Tabela de cadastro da Divida
     */
    public class TBCOBDIVIDAX
    {
        public int TBCOBDIVIDAX_NS { get; set; }

        public string TBCOBDIVIDAX_NM { get; set; }

        public DateTime TBCOBDIVIDAX_DT_CAD { get; set; }

        public DateTime? TBCOBDIVIDAX_DT_INA { get; set; }

        #region TBCONTRATOXX

        public int TBCOBCONTRAT_NS { get; set; }

        public virtual TBCOBCONTRAT TBCOBCONTRAT { get; set; }

        #endregion TBCONTRATOXX

        public int TBCOBSTATUSX_NS { get; set; }

        public virtual TBCOBSTATUSX TBCOBSTATUSX { get; set; }
    }
}
