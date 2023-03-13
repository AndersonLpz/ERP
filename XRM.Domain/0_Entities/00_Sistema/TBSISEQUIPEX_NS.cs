using System;

namespace XRM.Domain._0_Entities._00_Sistema
{
    /*
     * tabela de cadastro da equipe
     */
    public class TBSISEQUIPEX
    {
        public int TBSISEQUIPEX_NS { get; set; }

        public string TBSISEQUIPEX_NM { get; set; }

        public string TBSISEQUIPEX_DS { get; set; }

        public DateTime TBSISEQUIPEX_DT_CAD { get; set; }

        public DateTime? TBSISEQUIPEX_DT_INA { get; set; }

        public int TBSISDEPARTA_NS { get; set; }

        public virtual TBSISDEPARTA TBSISDEPARTA { get; set; }
    }
}
