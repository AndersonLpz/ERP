using System;

namespace XRM.Domain._0_Entities._04_Cobranca
{
    /*
     * Tabela de cadastro do Detalhe
     */
    public class TBCOBDETALHE
    {
        public int TBCOBDETALHE_NS { get; set; }

        public string TBCOBDETALHE_NM { get; set; }

        public string TBCOBDETALHE_DS { get; set; }

        public DateTime TBCOBDETALHE_DT_CAD { get; set; }

        public DateTime? TBCOBDETALHE_DT_INA { get; set; }

        #region TBDETALHETPX

        public int TBCOBDETALTP_NS { get; set; }

        public virtual TBCOBDETALTP TBCOBDETALTP { get; set; }

        #endregion TBDETALHETPX

    }
}
